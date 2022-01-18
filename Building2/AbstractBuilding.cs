using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public abstract class AbstractBuilding : IBuilding
    {

        public virtual double ComputingArea()
        {
            return 0;
        }

        public virtual int GetNumberOfFloors()
        {
            return 0;
        }

        public virtual int GetTotalNumberOfRooms()
        {
            return 0;
        }

        public virtual int TotalCapacity()
        {
            return 0;
        }
    }
}
