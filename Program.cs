using DungeonExplorer;
using System;

namespace DungeonCrawler
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GameLoop gameLoop = new GameLoop();
            try
            {
                gameLoop.Start();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }
    }
}
