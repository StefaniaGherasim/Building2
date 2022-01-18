using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class MeetingRoom : Room

    {
        int nrChairs;
        bool hasAirConditioner;

        public int NrChairs { get => nrChairs; set => nrChairs = value; }
        public bool HasAirConditioner { get => hasAirConditioner; set => hasAirConditioner = value; }

        public MeetingRoom(int capacity, double lenght, double width, int nrChairs, bool hasAirConditioner) : base(capacity, lenght, width)
        {
            this.HasAirConditioner = hasAirConditioner;
            this.NrChairs = nrChairs;
        }

        public override void PrintRoom()
        {

            Console.WriteLine("\nArea of the meeting room is {0} m2, has a capacity of {1} people and a number of {2} chairs", ComputingArea(), Capacity, NrChairs);
            if (HasAirConditioner)
            {
                Console.WriteLine("The meeting room has air conditioner. ");
            }

        }
    }
}
