using System;
using System.Collections.Generic;

namespace DungeonCrawler
{
    internal class CoordinateSystem
    {
        public int GetArea(int width, int height, int length)
        {
            return length * width * height;
        }

        public List<List<int>> GetTotalCoordinates(int width, int length, int tileSize)
        {
            List<int> zAxis = new List<int>();
            List<int> xAxis = new List<int>();
            List<List<int>> coordinates = new List<List<int>>();

            int room2DSize = width * length;

            for (int i = 0; i < room2DSize; i++)
            {
                zAxis.Add(-((i / length) - length / 2) * room2DSize);
                xAxis.Add(((i % width) - width / 2) * room2DSize);
            }

            if (width < length)
            {
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < length; j++)
                    {
                        coordinates.Add(new List<int>{xAxis[i], zAxis[j]});
                        return coordinates;
                    }
                }
            }
            else
            {
                for (int i = 0; i < length; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        coordinates.Add(new List<int>{xAxis[j], zAxis[i]});
                        return coordinates;
                    }
                }
            }

            return coordinates;
        }
    }
}