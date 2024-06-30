# main.py
import asyncio
import cv2
import numpy as np
import picamera
import picamera.array
from config import SPACES
from processing import is_space_occupied, extraction
from ocr import ocr
from networking import send_parking_status_update

async def process_parking_space(image, space):
    occupied = is_space_occupied(image, space)
    
    
    if occupied and not space['occupied']:
        space['status_changed'] = True
        await asyncio.sleep(5)
        global camera
        with picamera.array.PiRGBArray(camera) as stream:
            camera.capture(stream, 'bgr', use_video_port=True)
            currentImage = stream.array
            
            x, y, w, h = cv2.boundingRect(space['plate_roi'])
            plate_roi = currentImage[y:y+h, x:x+w]
            
            plate = extraction(currentImage, plate_roi)
            if plate is not None:
                text = ocr(plate)
                if text:
                    space['last_plate'] = text
                    print(f"Parking Space {space['ID']} License Plate: {text}")
                    send_parking_status_update(space['ID'], occupied, space['last_plate'])

    elif not occupied and space['occupied']:
        space['last_plate'] = None
        space['status_changed'] = False
        send_parking_status_update(space['ID'], occupied, None)

    space['occupied'] = occupied

    color = (0, 0, 255) if occupied else (0, 255, 0)
    cv2.polylines(image, [space['poly']], True, color, 2)
    cv2.putText(image, 'Zauzeto' if occupied else 'Slobodno', tuple(space['poly'][0]), cv2.FONT_HERSHEY_SIMPLEX, 0.5, color, 2)
    
    if occupied and space['last_plate']:
        cv2.putText(image, space['last_plate'], (space['poly'][0][0], space['poly'][0][1] - 10), cv2.FONT_HERSHEY_SIMPLEX, 0.5, color, 2)

async def main():
    global camera
    with picamera.PiCamera() as camera:
        camera.vflip = True
        camera.hflip = True
        with picamera.array.PiRGBArray(camera) as stream:
            while True:
                camera.capture(stream, 'bgr', use_video_port=True)
                image = stream.array

                tasks = [process_parking_space(image, space) for space in SPACES]
                await asyncio.gather(*tasks)

                cv2.imshow('Parking Lot', image)

                stream.truncate(0)

                if cv2.waitKey(1) & 0xFF == ord('q'):
                    break

    cv2.destroyAllWindows()

if __name__ == "__main__":
    asyncio.run(main())

