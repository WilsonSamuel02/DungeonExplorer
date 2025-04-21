using System;
using System.Media;

namespace DungeonCrawler
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
                        break;
                    case 3:
                        gameState = Menu.GameOver();
                        break;
                    case 4:
                        Menu.ExitMenu();
                        break;
                }
            }
        }
    }
}