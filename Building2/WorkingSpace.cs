using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class WorkingSpace : Room
    {
        int nrOfLaptops;
        bool hasWifi;

        public WorkingSpace(int capacity, double lenght, double width, int nrOfLaptops, bool hasWifi) : base(capacity, lenght, width)
        {
            this.NrOfLaptops = nrOfLaptops;
            this.HasWifi = hasWifi;
        }

        public int NrOfLaptops { get => nrOfLaptops; set => nrOfLaptops = value; }
        public bool HasWifi { get => hasWifi; set => hasWifi = value; }

        public override void PrintRoom()
        {

            Console.WriteLine("\nThe area of the working space is {0} m2, has a capacity of {1} people and {2} laptops", ComputingArea(), Capacity, NrOfLaptops);
            if (HasWifi)
            {
                Console.WriteLine("The working space has wifi");
            }
        }
    }
}
