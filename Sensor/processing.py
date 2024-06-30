# processing.py
import cv2
import numpy as np

def extraction(image, roi, crop_percent=0.05):
    gray = cv2.cvtColor(roi, cv2.COLOR_BGR2GRAY)
    blurred = cv2.GaussianBlur(gray, (5, 5), 0)
    edged = cv2.Canny(blurred, 50, 200)
    contours, _ = cv2.findContours(edged, cv2.RETR_TREE, cv2.CHAIN_APPROX_SIMPLE)
    contours = sorted(contours, key=cv2.contourArea, reverse=True)[:10]
    screenCnt = None

    for c in contours:
        peri = cv2.arcLength(c, True)
        approx = cv2.approxPolyDP(c, 0.02 * peri, True)

        if len(approx) == 4:
            screenCnt = approx
            break
    
    if screenCnt is None:
        return None
    
    rect = cv2.boundingRect(screenCnt)
    px, py, pw, ph = rect
    plate = roi[py:py + ph, px:px + pw]
    
    plate_h, plate_w, _ = plate.shape
    crop_width = int(plate_w * crop_percent)
    plate_cropped = plate[:, crop_width:plate_w - crop_width]

    return plate_cropped

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
            if contour_area > 0 and contour_area < 5000:  
                return True
    
    return False
