using DungeonCrawler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeoncrawler
{
    internal class Dungeon
    {
        public Dungeon() { }

        public static void DungeonGenerator(Player player)
        {
            List<BaseRoom> rooms = new List<BaseRoom>()
            {
                new BeginningRoom(),
                new MerchantRoom(),
                new  NormalRoom(),
                new SafeRoom(),
            };

        }

        private static void RoomMenu(Player player, BaseRoom room)
        {
            while (true){

                Console.WriteLine("-- You have entered the dungeon -- ");
                Console.WriteLine();

                Console.WriteLine("-- What would you like to do? --");
                Console.WriteLine();
                Console.WriteLine("- 'Observe' the room");
                Console.WriteLine("- Get own 'description'");
                Console.WriteLine("- Access 'Inventory'");
                Console.WriteLine("- Check 'Stats'");
                Console.WriteLine("- 'Leave'");
                Console.WriteLine();
                string userInput = Console.ReadLine();

                if (userInput.Length > 0){
                    if (userInput.ToLower() == "observe")
                    {
                        room.GetDescription();
                        break;
                    }
                    else if (userInput.ToLower() == "description")
                    {
                        player.GetDescription();
                    }
                    else if (userInput.ToLower() == "inventory")
                    {
                        player.AccessInventory();
                    }
                    else if (userInput.ToLower() == "stats")
                    {
                        player.AccessStats();
                    }
                    else if (userInput.ToLower() == "leave")
                    {
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

            if (room.EnemiesAmount == 0)
            {
                while (true){
                    Console.WriteLine("-- What would you like to do? --");
                    Console.WriteLine();
                    Console.WriteLine("- Go to 'next room'");
                    Console.WriteLine("- Get own 'description'");
                    Console.WriteLine("- Access 'Inventory'");
                    Console.WriteLine("- Check 'Stats'");
                    Console.WriteLine("- 'Leave'");
                    string userInput = Console.ReadLine();

                    if (userInput.Length > 0){
                        if (userInput.ToLower() == "next room"){
                            Console.WriteLine("You decide to open the creaky heavy door.");
                            break;
                        }
                        else if (userInput.ToLower() == "description")
                        {   
                            player.GetDescription();
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
            else
            {
                while(true)
                {
                    Console.WriteLine("-- What would you like to do? --");
                    Console.WriteLine();
                    Console.WriteLine("- 'Attack' enemies")
                    Console.WriteLine("- Go to 'next room'");
                    Console.WriteLine("- Get own 'description'");
                    Console.WriteLine("- Access 'Inventory'");
                    Console.WriteLine("- Check 'Stats'");
                    Console.WriteLine("- 'Leave'");
                    string userInput = Console.ReadLine();

                    if (userInput.Length > 0)
                    {
                        if (userInput.ToLower() == "attack")
                        {
                           List<Enemy> enemies = new List<Enemy>();
                           enemies = SpawnEnemies(room.EnemiesAmount);

                           foreach (Enemy enemy in enemies)
                           {
                                Console.WriteLine($"- Level {enemy.Level} {enemy}");
                           } 

                           Console.WriteLine("-- Which would you like to do? --")
                           Console.WriteLine();
                           Console.WriteLine("- 'Attack'");
                           Console.WriteLine("- 'Defend'");
                           Console.WriteLine("- 'Heal'");
                           Console.WriteLine("- 'Run'");
                           string userInput = Console.ReadLine();

                           if (userInput.ToLower() == "attack")
                           {

                           }
                           else if (userInput.ToLower() == "defend")
                           {

                           }
                           else if
                        }
                        if (userInput.ToLower() == "next room")
                        {
                            Console.WriteLine("You decide to open the creaky heavy door.");
                            break;
                        }
                        else if (userInput.ToLower() == "description")
                        {   
                            player.GetDescription();
                        }
                        else if (userInput.ToLower() == "inventory")
                        {
                            player.AccessInventory();
                        }
                        else if (userInput.ToLower() == "stats")
                        {
                            player.AccessStats();
                        }
                        else if (userInput.ToLower() == "leave")
                        {
                            Console.WriteLine("You decided to leave and live another day!");
                            gameState = (int)States.EXIT_MENU;

                            return gameState;
                        }
                        else
                        {
                            Console.WriteLine("That is not an option!");
                            Console.WriteLine("Please try again!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("That is not an option!");
                        Console.WriteLine("Please try again!");
                    }
                }
            }
        }

        private static List<Enemy> SpawnEnemies(int enemiesAmount)
        {
            List<Enemy> enemies = new List<Enemy>();
            Random random = new Random();

            for (int i = 0; i < enemiesAmount; i++)
            {
                int enemyPercent = random.Next(1, 15);

                if (enemyPercent <= 5)
                {
                    enemies.Add(new Goblin());
                }
                else if (enemyPercent <= 10 && enemyPercent > 5)
                {
                    enemies.Add(new GoblinArcher());
                }
                else if (enemyPercent <= 15 && enemyPercent > 10)
                {
                    enemies.Add(new GoblinMage());
                }
            }
        }
    }
}
