using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class Floor : AbstractBuilding
    {

        private readonly Room[] rooms;
        bool hasBalcony;

        public bool HasBalcony { get => hasBalcony; set => hasBalcony = value; }

        public Floor(Room[] rooms, bool hasBalcony)
        {
            this.rooms = rooms;
            this.HasBalcony = hasBalcony;
        }

        public override double ComputingArea()
        {
            double area = 0;

            foreach (Room room in rooms)
            {
                area += room.ComputingArea();
            }

            return area;
        }

        public override int TotalCapacity()
        {
            int capacity = 0;
            foreach (Room room in rooms)
            {
                capacity += room.Capacity;
            }
            return capacity;
        }

        public override int GetTotalNumberOfRooms()
        {
            return rooms.Length;
        }

        public void PrintFloor()
        {
            Console.WriteLine("This floor has a number of {0} rooms, has a area of {1} m2 and a capacity for {2} people", GetTotalNumberOfRooms(), ComputingArea(), TotalCapacity());
            if (HasBalcony)
            {
                Console.WriteLine("The floor has a balcony.");

            }
            Console.WriteLine("\nThe floor has the nex rooms: ");
            foreach (Room room in rooms)
            {
                room.PrintRoom();
            }

        }


    }
}
