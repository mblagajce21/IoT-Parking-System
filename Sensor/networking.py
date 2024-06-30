# networking.py
import socket
import cv2
import numpy as np
from config import SERVER_ADDRESS

def send_parking_status_update(space_id, occupied, license_plate):
    
    message = f"{space_id};{occupied};{license_plate if license_plate else 'None'}<EOF>"
    
    try:
        with socket.socket(socket.AF_INET, socket.SOCK_STREAM) as sock:
            sock.connect(SERVER_ADDRESS)
            sock.sendall(message.encode())
    except Exception as e:
        print(f"Error sending data: {e}")

