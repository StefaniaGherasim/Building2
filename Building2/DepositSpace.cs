using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class DepositSpace : Room
    {
        int height;

        public int Height { get => height; set => height = value; }

        public DepositSpace( double lenght, double width, int height) : base(lenght, width)
        {
            this.Height = height;
        }

        public double Volume()
        {
            return Lenght * Width * Height;

        }

        public override void PrintRoom()
        {
            Console.WriteLine("\nThe area of the deposit space is {0} m2 and the storing volume is {1} m3 ", ComputingArea(), Volume());
        }
    }
}
