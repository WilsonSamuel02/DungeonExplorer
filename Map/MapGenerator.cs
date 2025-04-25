using System;
using System.Collections.Generic;
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
             *          - M: Boss Room/Monster Room
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

            List<List<string>> floor = new List<List<string>>(5);
            List<string> exitDirections = new List<string>();

            Random random = new Random();
            int startFloor = random.Next(0, 12);

            floor = FloorStart(floor, startFloor);
            exitDirections = ExitDirections(startFloor);

            //Testing
            foreach (List<string> list in floor)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    Console.WriteLine(list[j]);
                }
            }

            foreach (string direction in exitDirections)
            {
                Console.WriteLine($"Exits: {direction}");
            }
        }

        protected static List<List<string>> FloorStart(List<List<string>> floor, int startFloor)
        {
            List<string> row1 = new List<string>(5) { "V", "V", "V", "V", "V" };

            Console.WriteLine($"Start Floor Number: {startFloor / 3}");

            row1[startFloor / 3] = "B";
            floor.Add(row1);

            return floor;
        }

        protected static List<string> ExitDirections(int startFloor)
        {
            int exits;
            int randomExits;
            Random random = new Random();
            List<string> exitDirections = new List<string>();

            if (startFloor == 0)
            {
                exits = random.Next(1, 2);
                Console.WriteLine($"Number of exits: {exits}");

                if (exits == 1) 
                {
                    randomExits = random.Next(1, 12);
                    if (randomExits <= 5) exitDirections.Add("Right");
                    else exitDirections.Add("Down");
                }
                else if (exits == 2) 
                {
                    exitDirections.Add("Right");
                    exitDirections.Add("Down");
                }
                return exitDirections;

            }
            else if (startFloor == 4)
            {
                exits = random.Next(1, 2);
                Console.WriteLine($"Number of exits: {exits}");

                if (exits == 1)
                {
                    randomExits = random.Next(1, 12);
                    if (randomExits <= 5) exitDirections.Add("Left");
                    else exitDirections.Add("Down");
                }
                else
                {
                    exitDirections.Add("Left");
                    exitDirections.Add("Down");
                }
                return exitDirections;

            }
            else
            {
                exits = random.Next(1, 3);
                Console.WriteLine($"Number of exits: {exits}");

                List<string> directions = new List<string>() { "Left", "Right", "Down" };

                if(exits == 1)
                {
                    randomExits = random.Next(1, 18);
                    if (randomExits <= 5) exitDirections.Add("Right");
                    else if (randomExits <= 10 && randomExits > 5) exitDirections.Add("Left");
                    else exitDirections.Add("Down");
                }
                else if (exits == 2)
                {
                    int index = 0;
                    randomExits = random.Next(1, 18);


                    while (index < 2)
                    {
                        if (randomExits <= 5 && directions.Any(str => str.Contains("Right")))
                        {
                            exitDirections.Add("Right");
                            directions.Remove("Right");
                            index++;
                        }
                        else if (randomExits <= 10 && randomExits > 5 && directions.Any(str => str.Contains("Left")))
                        {
                            exitDirections.Add("Left");
                            directions.Remove("Left");
                            index++;
                        }
                        else if (randomExits <= 10 && directions.Any(str => str.Contains("Down")))
                        {
                            exitDirections.Add("Down");
                            directions.Remove("Down");
                            index++;
                        }
                    }
                    return exitDirections;
                }
                else 
                {
                    exitDirections.Add("Right");
                    exitDirections.Add("Left");
                    exitDirections.Add("Down");
                    return exitDirections;
                }
                return exitDirections;
            }
        }
    }
}
