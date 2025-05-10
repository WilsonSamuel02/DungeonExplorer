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
    }
}