using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    interface IBuilding
    {
        public double ComputingArea();

        public int GetNumberOfFloors();

        public int GetTotalNumberOfRooms();

        public int TotalCapacity();

    }
}