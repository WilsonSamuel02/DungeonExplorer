using System;
using System.Collections.Generic;

namespace DungeonCrawler
{
    internal class Map
    {
        public StartRoom startRoom = new StartRoom();
        CoordinateSystem coordinateSystem = new CoordinateSystem();

        public List<int> GetStartCoordinates(int width, int length)
        {
            List<List<int>> totalCoordinates = new List<List<int>>();
            double coord = (width / 2) + 0.5;
            List<int> startCoordinates  = new List<int>{0, (int)coord};

            totalCoordinates = coordinateSystem.GetTotalCoordinates(width, length, 1);

            foreach (List<int> coordinates in totalCoordinates)
            {
                if (startCoordinates == coordinates) return startCoordinates;
                else Console.WriteLine("Coordinate System failed!");
            }

            return startCoordinates;
        }
    }
}