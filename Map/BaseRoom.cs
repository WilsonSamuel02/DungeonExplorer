using System;
using System.Collections.Generic;

namespace DungeonCrawler
{
    internal class BaseRoom
    {
        protected Random ranInt = new Random();

        public string RoomType { get; protected set; }
        public int EnemiesAmount { get; protected set; }
        public List<string> Exits { get; set; }
        public int Width { get; protected set; }
        public int Length { get; protected set; }
        public int Height { get; protected set; }
        public string LightLevel { get; protected set; }
        public string WallMaterial { get; protected set; }
        public string FloorMaterial { get; protected set; }

        public BaseRoom()
        {
            RoomType = "Base Room";
            EnemiesAmount = 0;
        }

        public virtual void GetDescription()
        {
            Console.WriteLine("You enter a bland room.");
            Console.WriteLine("Must be the base room");
        }

        protected int RandomNumber(Random ranInt)
        { 

            int ran = ranInt.Next(3, 15);

            if (ran % 2 == 1) return ran;
            else RandomNumber(ranInt);

            return ran;
        }

        protected string RandomLight()
        {
            string[] lightLevels = { "bright", "dim", "dark" };

            Random ranInt = new Random();

            int ranLight = ranInt.Next(0, lightLevels.Length);

            return lightLevels[ranLight];
        }

        protected string RandomMaterial()
        {
            string[] material = { "wood", "cobble", "granite", "bricks" };

            Random ranInt = new Random();

            int ranMaterial = ranInt.Next(0, material.Length);

            return material[ranMaterial];
        }

        protected List<string> RandomExits(List<string> exitDirections)
        {
            Random random = new Random();
            int exits = random.Next(1, 3);

            List<string> directions = new List<string>() { "Left", "Right", "Down" };
            List<string> dupeDirections = new List<string>();

            if (exits == 1)
            {
                int randomExits = random.Next(1, 18);
                if (randomExits <= 5) exitDirections.Add("Right");
                else if (randomExits <= 10 && randomExits > 5) exitDirections.Add("Left");
                else exitDirections.Add("Down");
            }
            else if (exits == 2)
            {
                int index = 0;


                while (index < 2)
                {
                    int randomExits = random.Next(1, 18);

                    foreach (string direction in directions)
                    {
                        if (randomExits <= 5 && direction == "Right")
                        {
                            exitDirections.Add("Right");
                            directions.Remove("Right");
                            index++;
                        }
                        else if (randomExits <= 10 && randomExits > 5 && direction == "Left")
                        {
                            exitDirections.Add("Left");
                            directions.Remove("Left");
                            index++;
                        }
                        else if (randomExits <= 18 && randomExits > 10 && direction == "Down")
                        {
                            exitDirections.Add("Down");
                            directions.Remove("Down");
                            index++;
                        }
                    }

                }
            }
            else
            {
                exitDirections.Add("Right");
                exitDirections.Add("Left");
                exitDirections.Add("Down");
            }

            return exitDirections;
        }
    }
}