using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ParkingSpaceLogic
    {

        private static ParkingSpaceLogic _instance;
        private List<ParkingSpace> parkingSpaces;

        private ParkingSpaceLogic()
        {
            parkingSpaces = new List<ParkingSpace>
            {
            new ParkingSpace(1, "ABC123"),
            new ParkingSpace(2),
            new ParkingSpace(3)
            };
        }

        public static ParkingSpaceLogic Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ParkingSpaceLogic();
                }
                return _instance;
            }
        }
        public ParkingSpace GetParkingSpace(int spaceId)
        {
            return parkingSpaces.FirstOrDefault(space => space.SpaceId == spaceId);
        }

        public void UpdateParkingSpace(int spaceId, bool occupied, string licensePlate)
        {
            var space = GetParkingSpace(spaceId);
            if (space != null)
            {
                space.Occupied = occupied;
                space.LicensePlate = licensePlate;
            }
        }

        public ParkingSpace FindParkingSpaceByLicensePlate(string licensePlate)
        {
            return parkingSpaces.FirstOrDefault(space => space.Occupied && space.LicensePlate == licensePlate);
        }

        public int GetTotalAvailability()
        {
            return parkingSpaces.Count(space => !space.Occupied);
        }

        public IEnumerable<ParkingSpace> GetAllParkingSpaces()
        {
            return parkingSpaces;
        }

        public int GetTotalSpaces()
        {
            return parkingSpaces.Count;
        }

    }
}
