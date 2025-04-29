using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class BeginningRoom : BaseRoom
    {
        public BeginningRoom() : base()
        {
            RoomType = "Beginning Room";
            EnemiesAmount = 0;
            Width = RandomNumber(ranInt);
            Height = RandomNumber(ranInt);
            Length = RandomNumber(ranInt);
            LightLevel = RandomLight();
            WallMaterial = RandomMaterial();
            FloorMaterial = RandomMaterial();
        }

        public override void GetDescription()
        {
            Console.WriteLine($"-- You enter a {LightLevel} room. It seems to be {Width} wide, {Length} long, and {Height} high. --");
            Console.WriteLine($"-- This must be the {RoomType} room. --");
            Console.WriteLine($"-- The floor seems to be made of {FloorMaterial}, and the walls seem to be made of {WallMaterial}. --");
            Console.WriteLine($"-- There seems to be {EnemiesAmount} enemies around. --");
        }
    }
}
