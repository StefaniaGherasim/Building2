using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class Room : AbstractBuilding
    {
        int capacity;
        double lenght, width;
        
        public int Capacity { get => capacity; set => capacity = value; }
        public double Lenght { get => lenght; set => lenght = value; }
        public double Width { get => width; set => width = value; }

        public Room(int capacity, double lenght, double width )
        {
            Capacity = capacity;
            Lenght = lenght;
            Width = width;
        }
        public Room(double lenght, double width)
        {
            Lenght = lenght;
            Width = width;
        }

        public override double ComputingArea()
        {
            return Lenght * Width;
        }

        public virtual void PrintRoom()
        {
            Console.WriteLine("Area for this room is {0} and it has a capacity of {1}.", ComputingArea(), Capacity);
        }

    }
}