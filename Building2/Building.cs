using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class Building : AbstractBuilding
    {

        const int MAX_CAPACITY = 300;
        bool hasElevator;
        private readonly Floor[] floors;

        public bool HasElevator { get => hasElevator; set => hasElevator = value; }

        public Building(Floor[] floors, bool hasElevator)
        {
            this.floors = floors;
            this.HasElevator = hasElevator;

            if (this.TotalCapacity() > MAX_CAPACITY)
            {
                throw new BuildingException("The maximum capcity of the building is 300. ");
            }
        }

        public override double ComputingArea()
        {
            double area = 0;

            foreach (Floor floor in floors)
            {
                area += floor.ComputingArea();
            }

            return area;
        }

        public override int GetNumberOfFloors()
        {
            return this.floors.Length;
        }

        public override int GetTotalNumberOfRooms()
        {
            int totalNumberOfRooms = 0;
            foreach (Floor floor in floors)
            {
                totalNumberOfRooms += floor.GetTotalNumberOfRooms();
            }

            return totalNumberOfRooms;
        }

        public override int TotalCapacity()
        {
            int capacity = 0;
            foreach (Floor floor in floors)
            {
                capacity += floor.TotalCapacity();
            }
            return capacity;

        }
        public static void PrintBuilding(Building building)

        {

            if (building.HasElevator)
            {
                Console.WriteLine("The building has elevator");
            }
            Console.WriteLine("\nThe building has a number of {0} floors, {1} rooms. Has a area of {2} m2 and a capacity of {3} people ", building.GetNumberOfFloors(), building.GetTotalNumberOfRooms(), building.ComputingArea(), building.TotalCapacity());

            for (int i = 0; i < building.floors.Length; i++)
            {
                Console.Write("\n Floor number " + i + ": ");
                building.floors[i].PrintFloor();
            }

        }

    }
}