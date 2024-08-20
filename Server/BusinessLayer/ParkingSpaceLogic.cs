using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ParkingSpaceLogic
    {
        private int totalNumberOfSpaces = 3;
        private int numberOfTakenSpaces = 0;
        public string getAvailabilityOfGarage (bool isNewSpaceTaken)
        {
            if (isNewSpaceTaken)
            {
                numberOfTakenSpaces++;
            }
            else
                numberOfTakenSpaces--;
            return numberOfTakenSpaces + "/" + totalNumberOfSpaces;
        }
    }
}
