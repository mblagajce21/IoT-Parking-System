import cv2
import numpy as np

rectangles = []

def mark_rectangle(event, x, y, flags, param):
    global rectangles

    if event == cv2.EVENT_LBUTTONDOWN:
        rectangles.append((x, y))

    elif event == cv2.EVENT_LBUTTONUP:
        rectangles[-1] = (rectangles[-1], (x, y))
        cv2.rectangle(frame, rectangles[-1][0], rectangles[-1][1], (0, 255, 0), 2)
        cv2.imshow('Mark Parking Spaces', frame)

def capture_and_mark():
    global frame

    cap = cv2.VideoCapture(0)
    cv2.namedWindow('Mark Parking Spaces')
    cv2.setMouseCallback('Mark Parking Spaces', mark_rectangle)

    while True:
        _, frame = cap.read()

        for rect in rectangles:
            cv2.rectangle(frame, rect[0], rect[1], (0, 255, 0), 2)

        cv2.imshow('Mark Parking Spaces', frame)

        if cv2.waitKey(1) & 0xFF == ord('q'):
            break

    cap.release()
    cv2.destroyAllWindows()

capture_and_mark()
print("Marked rectangles:", rectangles)
