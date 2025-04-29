using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class MapGenerator
    {
        public static void GenerateFloors(int floors)
        {
            /*
             * Main map generator class
             * Objectives of class:
             *      - Create a 2D array of characters to represent each room:
             *          - B: Beginning Room/Start Room
             *          - S: Safe Room
             *          - M: Merchant room
             *          - T: Treasure Room
             *          - C: Boss Room/Challenge Room
             *          - N: Normal Room
             *          - E: End Room, which has a ladder which takes you to the next floor
             *          - V: Void, where there isn't a room, just empty space.
             *      - First row must generate a start room(B), along with how many exits and where they are located
             *      - After that the rooms have to be connected to other rooms, while also checking if the spaces are free
             *      - Each room other than S, E, and N have different probabilities of appearing and certain characteristics
             * How:
             *      - Randomly select a number for the start room to be positioned
             *      - Determine how many exits there will be while checking if the areas are part of the array i.e. {B, V, V, V}, start room can only generate rooms to the right or down
             *      - If exit is down then move to next row and generate a normal room(N) below it, keep doing this until the last row is reached, where E will be generated
             *      - If there are exits without rooms then generate rooms from the room generation pool (M, T, N, S) according to designated probability
             *      - Make sure to keep track of floors as every 5 floors E is replaced with M for the boss.
             *      - Predetermined area for floors: 5x5
             */

            List<List<string>> floor = new List<List<string>>(5)
            {
                new List<string>(5) { "V", "V", "V", "V", "V" },
                new List<string>(5) { "V", "V", "N", "V", "V" },
                new List<string>(5) { "V", "V", "V", "V", "V" },
                new List<string>(5) { "V", "V", "V", "V", "V" },
                new List<string>(5) { "V", "V", "V", "V", "V" }
            };

            Random random = new Random();
            int startFloor = random.Next(0, 12);

            floor[0] = FloorStart(floor[0], startFloor);
            floor = AdjacentRooms(floor);

            //Testing
            Console.WriteLine($"{floor[0][0]} {floor[0][1]} {floor[0][2]} {floor[0][3]} {floor[0][4]}");
            Console.WriteLine($"{floor[1][0]} {floor[1][1]} {floor[1][2]} {floor[1][3]} {floor[1][4]}");
            Console.WriteLine($"{floor[2][0]} {floor[2][1]} {floor[2][2]} {floor[2][3]} {floor[2][4]}");
            Console.WriteLine($"{floor[3][0]} {floor[3][1]} {floor[3][2]} {floor[3][3]} {floor[3][4]}");
            Console.WriteLine($"{floor[4][0]} {floor[4][1]} {floor[4][2]} {floor[4][3]} {floor[4][4]}");
        }

        protected static List<string> FloorStart(List<string> startRow, int startFloor)
        {

            Console.WriteLine($"Start Floor Number: {startFloor / 3}");

            startRow[startFloor / 3] = "B";

            return startRow;
        }

        protected static List<List<string>> AdjacentRooms(List<List<string>> floor)
        {
            /*
             * Generates adjacent rooms in a row
             * Objectives:
             *      - Checks where the first room is located on the row 
             *      - If the room is anything but N then it skips to the next room, until a normal, safe or start room is found
             *      - If a start, safe or normal room is found then it checks for exit directions
             *      - If only one exit then normal room is generated and given exit directions to
             *          - Checks where there are any spaces
             *          - Adds a corresponding room
             *          - Repeats until exit is down
             *      - If there are 2 exits but not down
             *          - 50/50 on whether left or right is normal or from room generation pool
             *      - If the room has a down and other directions generate room from room pool, until none of the rooms have exits except down
             *      - Return the row and input next one
             */

            List<string> exitDirections = new List<string>();
            bool generatedFloors = false;

            List<List<string>> GenerateRooms(int roomIndex, int floorIndex)
            {
                foreach (string direction in exitDirections)
                {
                    if (roomIndex == 0 && direction == "Right")
                    {
                        floor[floorIndex][roomIndex + 1] = "N";
                    }
                    else if (roomIndex == 4 && direction == "Left")
                    {
                        floor[floorIndex][roomIndex - 1] = "N";
                    }
                    else
                    {
                        if (exitDirections.Count > 1 && !exitDirections.Contains("Down"))
                        {
                            Random random = new Random();
                            int roomPercent = random.Next(1, 10);

                            if (roomPercent <= 5)
                            {
                                floor[floorIndex][roomIndex + 1] = RoomGenerationPool();
                                floor[floorIndex][roomIndex - 1] = "N";
                            }
                            else
                            {
                                floor[floorIndex][roomIndex - 1] = RoomGenerationPool();
                                floor[floorIndex][roomIndex + 1] = "N";
                            }
                        }
                        else if (exitDirections.Count > 1 && exitDirections.Contains("Down"))
                        {
                            if (direction == "Left")
                            {
                                floor[floorIndex][roomIndex - 1] = RoomGenerationPool();
                            }
                            else
                            {
                                floor[floorIndex][roomIndex + 1] = RoomGenerationPool();
                            }
                        }
                    }

                    if (direction == "Down" && floorIndex <= 3)
                    {
                        floorIndex++;
                        floor[floorIndex][roomIndex] = "N";
                        Console.WriteLine($"Floor Index: {floorIndex}");
                    }
                    else if (roomIndex <= floor.Count)
                    {
                        floorIndex++;
                        floor[floorIndex - 1][roomIndex] = "E";
                        generatedFloors = true;
                    }
                }

                foreach (string direction in exitDirections)
                {
                    Console.WriteLine($"Exits: {direction}");
                }

                return floor;
            }

            while (!generatedFloors)
            {
                foreach (List<string> rows in floor)
                {
                    int floorIndex = floor.IndexOf(rows);

                    for (int i = 0; i < rows.Count; i++)
                    {
                        int roomIndex = i;

                        if (rows[i] == "B" || rows[i] == "S" || rows[i] == "N")
                        {
                            if (roomIndex == 0 && rows[roomIndex + 1] == "V")
                            {
                                exitDirections = ExitDirections(floor[floorIndex]);
                                GenerateRooms(roomIndex, floorIndex);
                                Console.WriteLine($"Room Index: {roomIndex}");
                            }
                            else if (roomIndex == 4 && floor[floorIndex][roomIndex - 1] == "V")
                            {
                                exitDirections = ExitDirections(floor[floorIndex]);
                                GenerateRooms(roomIndex, floorIndex);
                                Console.WriteLine($"Room Index: {roomIndex}");
                            }
                            else if (roomIndex > 0 && roomIndex < 4 && floor[floorIndex][roomIndex - 1] == "V" || floor[floorIndex][roomIndex + 1] == "V")
                            {
                                exitDirections = ExitDirections(floor[floorIndex]);
                                GenerateRooms(roomIndex, floorIndex);
                                Console.WriteLine($"Room Index: {roomIndex}");
                            }
                        }
                    }
                    
                }
            }

            return floor;
        }

        private static string RoomGenerationPool()
        {
            string room = "V";
            int roomInt;

            Random random = new Random();
            roomInt = random.Next(0, 100);

            if (roomInt <= 70)
            {
                room = "N";
                return room;
            }
            else if (roomInt <= 85 && roomInt > 70)
            {
                room = "M";
                return room;
            }
            else if (roomInt <= 95 && roomInt > 85)
            {
                room = "S";
                return room;
            }
            else if(roomInt <= 100 && roomInt > 95)
            {
                room = "T";
                return room;
            }

            return room;
        }

        protected static List<string> ExitDirections(List<string> row)
        {
            int exits;
            int randomExits;
            Random random = new Random();
            List<string> exitDirections = new List<string>();

            for (int i = 0; i < row.Count; i++)
            {
                if (row[i] != "V" && i == 0)
                {
                    exits = random.Next(1, 2);
                    Console.WriteLine($"Number of exits: {exits}, Index: {i}");

                    if (exits == 1)
                    {
                        randomExits = random.Next(1, 12);
                        if (randomExits <= 5) exitDirections.Add("Right");
                        else exitDirections.Add("Down");
                        break;
                    }
                    else if (exits == 2)
                    {
                        exitDirections.Add("Right");
                        exitDirections.Add("Down");
                        break;
                    }
                }
                else if (row[i] != "V" && 1 == 4)
                {
                    exits = random.Next(1, 2);
                    Console.WriteLine($"Number of exits: {exits}, Index: {i}");

                    if (exits == 1)
                    {
                        randomExits = random.Next(1, 12);
                        if (randomExits <= 5) exitDirections.Add("Left");
                        else exitDirections.Add("Down");
                        break;
                    }
                    else
                    {
                        exitDirections.Add("Left");
                        exitDirections.Add("Down");
                        break;
                    }
                }
                else if (row[i] != "V")
                {
                    exits = random.Next(1, 3);
                    Console.WriteLine($"Number of exits: {exits}, Index: {i}");

                    List<string> directions = new List<string>() { "Left", "Right", "Down" };
                    List<string> dupeDirections = new List<string>();

                    if (exits == 1)
                    {
                        randomExits = random.Next(1, 18);
                        if (randomExits <= 5) exitDirections.Add("Right");
                        else if (randomExits <= 10 && randomExits > 5) exitDirections.Add("Left");
                        else exitDirections.Add("Down");
                        break;
                    }
                    else if (exits == 2)
                    {
                        int index = 0;


                        while (index < 2)
                        {
                            randomExits = random.Next(1, 18);

                            foreach (string direction in directions)
                            {
                                if (randomExits <= 5 && direction == "Right")
                                {
                                    exitDirections.Add("Right");
                                    directions.Remove("Right");
                                    index++;
                                    break;
                                }
                                else if (randomExits <= 10 && randomExits > 5 && direction == "Left")
                                {
                                    exitDirections.Add("Left");
                                    directions.Remove("Left");
                                    index++;
                                    break;
                                }
                                else if (randomExits <= 18 && randomExits > 10 && direction == "Down")
                                {
                                    exitDirections.Add("Down");
                                    directions.Remove("Down");
                                    index++;
                                    break;
                                }
                            }

                        }
                    }
                    else
                    {
                        exitDirections.Add("Right");
                        exitDirections.Add("Left");
                        exitDirections.Add("Down");
                        break;
                    }
                }
            }

            return exitDirections;
        }
    }
}
