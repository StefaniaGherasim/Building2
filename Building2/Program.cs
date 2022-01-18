using System;

namespace Program
{
    class Program
    {
        public static void Main(String[] args)
        {

            Room depositSpace1 = new DepositSpace(2, 2, 3);
            Room depositSpace2 = new DepositSpace(3, 2, 3);

            Room kitchen1 = new Kitchen(10, 4, 4, 8, false, true);
            Room kitchen2 = new Kitchen(8, 4, 3, 6, true, true);

            Room workingSpace1 = new WorkingSpace(20, 10, 10, 22, true);
            Room workingSpace2 = new WorkingSpace(30, 15, 10, 35, true);
            Room workingSpace3 = new WorkingSpace(20, 20, 15, 70, false);

            Room meetingRoom1 = new MeetingRoom(10, 5, 5, 6, false);
            Room meetingRoom2 = new MeetingRoom(5, 5, 3, 6, true);
            Room meetingRoom3 = new MeetingRoom(30, 10, 4, 25, true);

            Room[] roomsFloor0 = { depositSpace1, depositSpace2, kitchen1, meetingRoom3};
            Room[] roomsFloor1 = { meetingRoom1, workingSpace2, kitchen2, meetingRoom3};
            Room[] roomsFloor2 = { meetingRoom2, workingSpace1, kitchen2, workingSpace3};
            Room[] roomsFloor3 = { depositSpace1, workingSpace2, kitchen2, meetingRoom3};
            Room[] roomsFloor4 = { workingSpace3, workingSpace1, kitchen1, meetingRoom1 };
            
            // This Room Floor is only for testing if the exception is throwing an error if maximum capacity is reached (300)
            Room[] roomsFloor5 = { workingSpace3, workingSpace3, kitchen1, workingSpace3};

            Floor floor0 = new Floor(roomsFloor0, false);
            Floor floor1 = new Floor(roomsFloor1, true);
            Floor floor2 = new Floor(roomsFloor2, true);
            Floor floor3 = new Floor(roomsFloor3, true);
            Floor floor4 = new Floor(roomsFloor4, false);

            Floor floor5 = new Floor(roomsFloor5, false);


            Floor[] building1 = { floor0, floor1, floor2, floor3, floor4 };

            Floor[] building2 = { floor0, floor1, floor2, floor3, floor5 };

            try
            {
                Building btBuilding = new Building(building1, true);
                Building.PrintBuilding(btBuilding);

                //Bank building is throwing an exception because the maximum capacity is > then 300

                //Building bankBuilding = new Building(building2, true);
                //Building.PrintBuilding(bankBuilding);
            }
            catch (BuildingException e)
            {
                Console.WriteLine(e.ToString());
            }



        }
    }
}
