using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class Kitchen : Room
    {
        int nrChairs;
        bool hasMinibar,hasSink;

        public int NrChairs { get => nrChairs; set => nrChairs = value; }
        public bool HasMinibar { get => hasMinibar; set => hasMinibar = value; }
        public bool HasSink { get => hasSink; set => hasSink = value; }
       
        public Kitchen(int capacity, double lenght, double width, int nrChairs, bool hasMinibar, bool hasSink) : base(capacity, lenght, width)
        {
            this.NrChairs = nrChairs;
            this.HasMinibar = hasMinibar;
            this.HasSink = hasSink;
        }

        public override void PrintRoom()
        {

            Console.WriteLine("\nArea of the kitchen is {0} m2, has a capacity of {1} people and {2} number of chairs", ComputingArea(), Capacity, NrChairs);
            if (HasMinibar)
            {
                Console.WriteLine("This kitchen has minibar");
            }
            if (HasSink)
            {
                Console.WriteLine("This kitchen has a sink");
            }
        }
    }
}
