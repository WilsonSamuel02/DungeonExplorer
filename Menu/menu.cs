using System;

namespace DungeonCrawler{

    public class Menu{

        public static int StartMenu(){
            //main menu class that displays settings
            
            int gameState;
            string menuSelection = "N/A";

            while (true){
                Console.WriteLine();
                Console.WriteLine("####################");
                Console.WriteLine();
                Console.WriteLine("     Start Game");
                Console.WriteLine();
                Console.WriteLine("        Quit");
                Console.WriteLine();
                Console.WriteLine("####################");
                Console.WriteLine();

                Console.WriteLine("Where would you like to go?");
                menuSelection = Console.ReadLine();

                if (menuSelection.Length > 0){
                    if (menuSelection.ToLower() == "start game"){
                    gameState = (int)States.PLAY_GAME;
                    break;
                    }
                    else if (menuSelection.ToLower() == "quit"){
                        Environment.Exit(0);
                    }
                    else{
                        Console.WriteLine("That is not an option!");
                        Console.WriteLine("Please try again!");
                    }
                }
                
            }

            return gameState;
        }

        public static void WinMenu(){
            Console.WriteLine();
            Console.WriteLine("####################");
            Console.WriteLine();
            Console.WriteLine("  Congratulations!");
            Console.WriteLine();
            Console.WriteLine("You have completed the game!");
            Console.WriteLine();
            Console.WriteLine("####################");
        }

        public static int GameOver(){
            int gameState;

            while (true){
                Console.WriteLine();
                Console.WriteLine("####################");
                Console.WriteLine();
                Console.WriteLine("     Game Over!");
                Console.WriteLine();
                Console.WriteLine("####################");
                Console.WriteLine();

                Console.WriteLine("Would you like to try again? (y/n)");
                string userInput = Console.ReadLine();

                if (userInput.Length > 0){
                    if (userInput.ToLower() == "y"){
                    gameState = (int)States.START_MENU;
                    break;
                    }
                    else if (userInput.ToLower() == "n"){
                        gameState = (int)States.EXIT_MENU;
                        break;
                    }
                    else{
                        Console.WriteLine();
                        Console.WriteLine("That is not an option!");
                        Console.WriteLine("Please try again!");
                    }
                }
                
            }

            return gameState;
        }

        public static void ExitMenu(){
            Console.WriteLine();
            Console.WriteLine("####################");
            Console.WriteLine();
            Console.WriteLine("Thank you for playing!");
            Console.WriteLine();
            Console.WriteLine("####################");
        }
    }
}