using DungeonExplorer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GameLoop gameLoop = new GameLoop();
            gameLoop.Start();
        }
    }
}
