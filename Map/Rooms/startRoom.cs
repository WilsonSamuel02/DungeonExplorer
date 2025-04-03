using System;

namespace DungeonCrawler{
    public class StartRoom{

        //temporary main room code
        //The random elements make it easier to create multiple rooms
        //In the future room presets would be implemented along with random elements

        Random ranInt = new Random();

        public int Width { get; private set; }
        public int Length { get; private set; }
        public int Height { get; private set; }
        private string _lightLevel;
        private string _wallMaterial;
        private string _floorMaterial;

        public StartRoom(){
            this.Width = RandomNumber(ranInt);
            this.Length = RandomNumber(ranInt);
            this.Height = RandomNumber(ranInt);
            this._lightLevel = RandomLight();
            this._wallMaterial = RandomMaterial();
            this._floorMaterial = RandomMaterial();
        }

        public void GetDescription(){
            Console.WriteLine($"You enter a {_lightLevel} room. It seems to be {Width} wide, {Length} long, and {Height} tall.");
            Console.WriteLine($"The floor seems to be made of {_floorMaterial}, and the walls seem to be made of {_wallMaterial}");
            Console.WriteLine("In the far corner of the room, where it is least lit, you catch a small glimmer of something.");
            Console.WriteLine("Right in front you also notice a sturdy wooden door.");
            Console.WriteLine();
        }

        private static int RandomNumber(Random ranInt){

            int ran = ranInt.Next(3, 15);

            if (ran % 2 == 1) return ran;
            else RandomNumber(ranInt);

            return ran;
        }

        private static string RandomLight(){
            string[] lightLevels = {"bright", "dim", "dark"};

            Random ranInt = new Random();

            int ranLight = ranInt.Next(0, lightLevels.Length);

            return lightLevels[ranLight];
        }

        private static string RandomMaterial(){
            string[] material = {"wood", "cobble", "granite", "bricks"};

            Random ranInt = new Random();

            int ranMaterial = ranInt.Next(0, material.Length);

            return material[ranMaterial];
        }
    }
}