using System;

namespace DungeonCrawler
{
    internal class Map
    {
        private List<List<string>> = 
        StartRoom startRoom = new StartRoom();

        public List<int> GetStartCoordinates(int width, int length)
        {
            List<List<int>> totalCoordinates = new List<List<int>>();
            List<int> startCoordinates  = new List<int>{0, (width / 2) + 0.5};

            totalCoordinates = CoordinateSystem.GetTotalCoordinates(width, length, 1);

            foreach (List<int> coordinates in totalCoordinates)
            {
                if (startCoordinates == coordinates) return startCoordinates;
                else Console.WriteLine("Coordinate System failed!")
            }
        }
    }
}