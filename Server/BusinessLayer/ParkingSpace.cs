using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ParkingSpace
    {
        public int SpaceId { get; private set; }
        public bool Occupied { get; set; }
        public string LicensePlate { get; set; }
        public string ReservedForLicensePlate { get; set; }

        public ParkingSpace(int spaceId, string reservedForLicensePlate = null)
        {
            SpaceId = spaceId;
            ReservedForLicensePlate = reservedForLicensePlate;
            Occupied = false;
            LicensePlate = null;
        }
    }


}
