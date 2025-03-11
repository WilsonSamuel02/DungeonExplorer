using System;
using System.Media;

namespace DungeonExplorer
{
    internal class GameLoop
    {
        public void Start()
        {
            //controls the state of the game after certain events
            bool running = false;
            while (playing)
            {
                if (gameState == (int)States.START_MENU){
                    gameState = Menu.StartMenu();
                }
                else if (gameState == (int)States.PLAY_GAME){
                    gameState = Game.Play();
                }
                else if (gameState == (int)States.WIN_MENU){
                    Menu.WinMenu();
                    running = false;
                }
                else if (gameState == (int)States.GAME_OVER){
                    gameState = Menu.GameOver();
                }
                else if (gameState == (int)States.EXIT_MENU){
                    Menu.ExitMenu();
                    running = false;
                }
                else{
                    Console.WriteLine("Bye bye!");
                    Console.WriteLine("Press any key...");
                    Console.Read();
                    running = false;
                }
            }
        }
    }
}