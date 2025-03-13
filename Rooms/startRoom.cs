using System;

namespace DungeonCrawler{
    public class StartRoom{

        //temporary main room code
        //The random elements make it easier to create multiple rooms
        //In the future room presets would be implemented along with random elements

        private int _width;
        private int _length;
        private int _height;
        private string _lightLevel;
        private string _wallMaterial;
        private string _floorMaterial;

        public StartRoom(){
            this._width = RandomNumber();
            this._length = RandomNumber();
            this._height = RandomNumber();
            this._lightLevel = RandomLight();
            this._wallMaterial = RandomMaterial();
            this._floorMaterial = RandomMaterial();
        }

        public void GetDescription(){
            Console.WriteLine($"You enter a {_lightLevel} room. It seems to be {_width} wide, {_length} long, and {_height} tall.");
            Console.WriteLine($"The floor seems to be made of {_floorMaterial}, and the walls seem to be made of {_wallMaterial}");
            Console.WriteLine("In the far corner of the room, where it is least lit, you catch a small glimmer of something.");
            Console.WriteLine("Right in front you also notice a sturdy wooden door.");
            Console.WriteLine();
        }

        private static int RandomNumber(){
            Random ranInt = new Random();

            int ran = ranInt.Next(2, 6);

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

        public int Width{
            get { return _width; }
            set { _width = value; }
        }
        public int Length{
            get { return _length; }
            set { _length = value; }
        }
        public int Height{
            get { return _height; }
            set { _height = value; }
        }
        public string LightLevel{
            get { return _lightLevel; }
            set { _lightLevel = value; }
        }
        public string WallMaterial{
            get { return _wallMaterial; }
            set { _wallMaterial = value; }
        }
        public string FloorMaterial{
            get { return _floorMaterial; }
            set { _floorMaterial = value; }
        }

    }
}