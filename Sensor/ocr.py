# ocr_utils.py
import cv2
import pytesseract

def ocr(plate):
    gray = cv2.cvtColor(plate, cv2.COLOR_BGR2GRAY)
    
    _, thresh = cv2.threshold(gray, 0, 255, cv2.THRESH_BINARY + cv2.THRESH_OTSU)
    
    config = '--psm 8 -c tessedit_char_whitelist=ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-'
    
    text = pytesseract.image_to_string(thresh, lang="eng")
    text = ''.join(e for e in text if e.isalnum() or e == '-')
    if text:
        return text
    
    return None

