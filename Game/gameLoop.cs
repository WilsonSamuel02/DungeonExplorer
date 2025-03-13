using DungeonCrawler;
using System;
using System.Media;

namespace DungeonExplorer
{
    internal class GameLoop
    {
        private int gameState;
        public void Start()
        {
            //controls the state of the game after certain events
            bool running = true;
            while (running)
            {
                switch (gameState)
                {
                    case 0:
                        gameState = Menu.StartMenu();
                        break;
                    case 1:
                        gameState = Game.Play();
                        break;
                    case 2:
                        Menu.WinMenu();
                        running = false;
                        break;
                    case 3:
                        gameState = Menu.GameOver();
                        running = false;
                        break;
                }
            }
        }
    }
}