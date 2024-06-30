# config.py
import numpy as np

# Parking spaces
SPACES = [
    {
        'poly': np.array([(199, 317), (379, 316), (321, 461), (64, 466)]),
        'plate_roi': np.array([(333, 319), (327, 464), (13, 467)]),
        'occupied': False,
        'ID': "1",
        'last_plate': None,
        'status_changed': False
    },
    {
        'poly': np.array([(414, 314), (590, 312), (626, 465), (366, 467)]),
        'plate_roi': np.array([(336, 324), (632, 321), (634, 477), (330, 469)]),
        'occupied': False,
        'ID': "2",
        'last_plate': None,
        'status_changed': False
    },
    {
        'poly': np.array([(625, 315), (820, 310), (965, 466), (674, 465)]),
        'plate_roi': np.array([(656, 311), (676, 467), (1011, 462), (1005, 294)]),
        'occupied': False,
        'ID': "3",
        'last_plate': None,
        'status_changed': False
    }
]

SERVER_ADDRESS = ('192.168.0.31', 55655)  # Server for receiving data

