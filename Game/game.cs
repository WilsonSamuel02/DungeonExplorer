using System;

namespace DungeonCrawler{

    public class Game {
        //main game class
        //It is split from game logic as it provides a more organised game logic
        //In the future the text will be in a different class so that it is much cleaner and would be easier to add more methods and easier to implement
        
        public static int Play(){

            int gameState;

            Player player = new Player();
            StartRoom startRoom = new StartRoom();

            Console.WriteLine("Blah blah blah, story here, later.");

            while (true)
            {
                Console.WriteLine("What would you like to name your warrior?");
                string playerName = Console.ReadLine();

                if (playerName.Length > 0)
                {
                    player.Name = playerName;
                    break;
                }
                else
                {
                    Console.WriteLine("Please input a name before going forward!");
                }
            }

            while (true){

                Console.WriteLine($"Welcome to Kendryl {player.Name}!");
                Console.WriteLine("Blah blah blah, more story here!");
                Console.WriteLine("Blah blah blah, you're in a dungeon now");
                Console.WriteLine();

                Console.WriteLine("To select an option please type the words only in quotation marks (i.e. '')");
                Console.WriteLine();
                Console.WriteLine("What would you like to do?");
                Console.WriteLine();
                Console.WriteLine("- 'Observe' the room");
                Console.WriteLine("- Access 'Inventory'");
                Console.WriteLine("- Check 'Stats'");
                Console.WriteLine("- 'Leave'");
                Console.WriteLine();
                string userInput = Console.ReadLine();

                if (userInput.Length > 0){
                    if (userInput.ToLower() == "observe"){
                        startRoom.GetDescription();
                        break;
                    }
                    else if (userInput.ToLower() == "inventory"){
                        player.AccessInventory();
                    }
                    else if (userInput.ToLower() == "stats"){
                        player.AccessStats();
                    }
                    else if (userInput.ToLower() == "leave"){
                        Console.WriteLine("You decided to leave and live another day!");
                        Environment.Exit(0);
                    }
                    else{
                        Console.WriteLine("That is not an option!");
                        Console.WriteLine("Please try again!");
                    }
                }
                else{
                    Console.WriteLine("That is not an option!");
                    Console.WriteLine("Please try again!");
                }
                
            }

            while (true){
                Console.WriteLine("What would you like to do?");
                Console.WriteLine();
                Console.WriteLine("- 'Investigate' glimmer");
                Console.WriteLine("- Go to 'next room'");
                Console.WriteLine("- Access 'Inventory'");
                Console.WriteLine("- Check 'Stats'");
                Console.WriteLine("- 'Leave'");
                string userInput = Console.ReadLine();

                if (userInput.Length > 0){
                    if (userInput.ToLower() == "investigate"){
                    break;
                    }
                    else if (userInput.ToLower() == "next room"){
                        Console.WriteLine("You decide to open the creaky heavy door.");
                        gameState = (int)States.WIN_MENU;

                        return gameState;
                    }
                    else if (userInput.ToLower() == "inventory"){
                        player.AccessInventory();
                    }
                    else if (userInput.ToLower() == "stats"){
                        player.AccessStats();
                    }
                    else if (userInput.ToLower() == "leave"){
                        Console.WriteLine("You decided to leave and live another day!");
                        gameState = (int)States.EXIT_MENU;

                        return gameState;
                    }
                    else{
                        Console.WriteLine("That is not an option!");
                        Console.WriteLine("Please try again!");
                    }
                }
                else{
                    Console.WriteLine("That is not an option!");
                    Console.WriteLine("Please try again!");
                }
                
            }

            Console.WriteLine("You slowly creep towards the glimmer.");
            Console.WriteLine("Leaning on the corner of the room you see a silver sword.");
            Console.WriteLine("It seems old and slightly rusted at the hilt, but the blade seems intact somehow");
            Console.WriteLine();

            while(true){
                Console.WriteLine("What would you like to do?");
                Console.WriteLine();
                Console.WriteLine("- 'Pick up' the sword");
                Console.WriteLine("- 'Leave' the sword behind");
                string userInput = Console.ReadLine();

                if (userInput.Length > 0){
                    if (userInput.ToLower() == "pick up"){
                        player.PickupItem("Damaged Silver Sword");
                        Console.WriteLine("You pick up the Damaged Silver Sword and add it to you inventory");
                        Console.WriteLine();
                        break;
                    }
                    else if (userInput.ToLower() == "leave"){
                        break;
                    }
                    else{
                        Console.WriteLine("That is not an option!");
                        Console.WriteLine("Please try again!");
                    }
                }
                else{
                    Console.WriteLine("That is not an option!");
                    Console.WriteLine("Please try again!");
                }
            }

            while (true){
                Console.WriteLine("What would you like to do?");
                Console.WriteLine();
                Console.WriteLine("- Go to the 'next room'");
                Console.WriteLine("- Access 'Inventory'");
                Console.WriteLine("- Check 'Stats'");
                Console.WriteLine("- 'Leave'");
                string userInput = Console.ReadLine();

                if (userInput.Length > 0){
                    if (userInput.ToLower() == "next room"){
                        Console.WriteLine("You decide to open the creaky heavy door.");
                        gameState = (int)States.WIN_MENU;

                        return gameState;
                    }
                    else if (userInput.ToLower() == "inventory"){
                        player.AccessInventory();
                    }
                    else if (userInput.ToLower() == "stats"){
                        player.AccessStats();
                    }
                    else if (userInput.ToLower() == "leave"){
                        Console.WriteLine("You decided to leave and live another day!");
                        gameState = (int)States.EXIT_MENU;

                        return gameState;
                    }
                    else{
                        Console.WriteLine("That is not an option!");
                        Console.WriteLine("Please try again!");
                    }
                }
                else{
                    Console.WriteLine("That is not an option!");
                    Console.WriteLine("Please try again!");
                }
            }
        }
    }
}