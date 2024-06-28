import cv2
import numpy as np
import picamera
import picamera.array

# Define parking spaces (replace with your coordinates)
spaces = [
    {'poly': np.array([(418, 323), (593, 320), (662, 473), (399, 479)]), 'occupied': False},
    {'poly': np.array([(187, 316), (386, 318), (355, 479), (47, 491)]), 'occupied': False},
    {'poly': np.array([(624, 318), (799, 314), (966, 468), (705, 475)]), 'occupied': False}
]

def is_space_occupied(image, space):

    poly = space['poly']
    gray = cv2.cvtColor(image, cv2.COLOR_BGR2GRAY)
    mask = np.zeros_like(gray)
    cv2.fillPoly(mask, [poly], 255)
    masked_roi = cv2.bitwise_and(gray, gray, mask=mask)
    blurred = cv2.GaussianBlur(masked_roi, (5, 5), 0)
    thresh = cv2.adaptiveThreshold(blurred, 255, cv2.ADAPTIVE_THRESH_GAUSSIAN_C, cv2.THRESH_BINARY_INV, 11, 2)
    contours, _ = cv2.findContours(thresh, cv2.RETR_EXTERNAL, cv2.CHAIN_APPROX_SIMPLE)
    
    for contour in contours:
        x, y, w, h = cv2.boundingRect(contour)
        center = (x + w // 2, y + h // 2)
        
        if cv2.pointPolygonTest(poly, center, False) >= 0:
            contour_area = cv2.contourArea(contour)
            if contour_area > 100 and contour_area < 5000:  # Sensitivity
                return True
    
    return False


with picamera.PiCamera() as camera:
    camera.vflip = True
    with picamera.array.PiRGBArray(camera) as stream:
        while True:
            camera.capture(stream, 'bgr', use_video_port=True)
            image = stream.array

            for space in spaces:
                occupied = is_space_occupied(image, space)
                space['occupied'] = occupied

                color = (0, 0, 255) if occupied else (0, 255, 0)
                cv2.polylines(image, [space['poly']], True, color, 2)
                cv2.putText(image, 'Zauzeto' if occupied else 'Slobodno', tuple(space['poly'][0]), cv2.FONT_HERSHEY_SIMPLEX, 0.5, color, 2)

            cv2.imshow('Parking Lot', image)
            stream.truncate(0)

            if cv2.waitKey(1) & 0xFF == ord('q'):
                break

cv2.destroyAllWindows()


