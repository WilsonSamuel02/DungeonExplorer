using Dungeoncrawler;
using System;

namespace DungeonCrawler
{
    internal class Story
    {
        public static Player Intro(Player player)
        {
            while(true)
            {
                Console.WriteLine($"Welcome to Kendryl Adventurer {player.Name}");
                Console.WriteLine();
                Console.WriteLine("Let us help you get set up here at the Adventurer's Guild!");
                Console.WriteLine($"You are a {player.Gender} {player.Specie}.");
                Console.WriteLine($"You have decided to apply for dungeon raids as a {player.Class}");
                Console.WriteLine("Is everything I just mentioned correct?");
                string userInput = Console.ReadLine();
            
                if (userInput.ToLower() == "y" || userInput.ToLower() == "yes")
                {
                    break;
                }
                else if (userInput.ToLower() == "n" || userInput.ToLower() == "no")
                {
                    Console.Clear();
                    player = CharacterCreation.CharacterCreator();
                }   
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Sorry, that isn't a valid answer to my question.");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Thank you for confirming your details!");
            Console.WriteLine($"As you are just starting with us you will be level {player.Level}.");

            while(true)
            {
                Console.WriteLine("Are you aware of how leveling work?");
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "n" || userInput.ToLower() == "no")
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("Levels are how we assess how strong an adventurer is.");
                    Console.WriteLine("Each adventurer is given a kill tracker, that automatically tracks how many creatures they have defeated.");
                    Console.WriteLine("Each creature has a different amount of experience.");
                    Console.WriteLine("The higher level we deem a creature to be, the more experience the adventurer gets.");
                    Console.WriteLine("The more experience the adventurer accumulates, the higher level they will be.");
                    Console.WriteLine("However leveling up isn't the only way to get stronger.");
                    Console.WriteLine("You must also need to train your different skills.");
                    break;
                }
                else if (userInput.ToLower() == "y" || userInput.ToLower() == "yes")
                {
                    break;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Sorry, that's not what I asked.");
                }
            }

            while(true)
            {
                Console.WriteLine();
                Console.WriteLine("Are you aware of how training your skills works?");
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "n" || userInput.ToLower() == "no")
                {
                    Console.Clear();
                    Console.WriteLine("When an adventurer levels up, we provide professional training in a skill that they desire.");
                    Console.WriteLine("Of course our training will correspond with their current level and current skill level, as training them to mastery would take far too long from the beginning.");
                    Console.WriteLine("We can train adventurers in the following skills:");
                    Console.WriteLine("- Strength: ");
                    Console.WriteLine("- Dexterity: ");
                    Console.WriteLine("- Intelligence: ");
                    Console.WriteLine("- Constitution: ");
                    Console.WriteLine("- Wisdom: ");
                    Console.WriteLine("- Charisma: ");
                    break;
                }
                else if (userInput.ToLower() == "y" || userInput.ToLower() == "yes")
                {
                    break;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Sorry, that's not what I asked.");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Now that we have completed your orientation, we can get you set up to start on your adventure.");
            Console.WriteLine("To help new adventurers to get started we offer a free care package, that includes some money, food and a simple weapon");
            
            while(true)
            {
                Console.WriteLine("Is that something we can interest you in?");
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "n" || userInput.ToLower() == "no")
                {
                    Console.Clear();
                    break;
                }
                else if (userInput.ToLower() == "y" || userInput.ToLower() == "yes")
                {
                    Console.WriteLine();
                    Console.WriteLine("--Recieved 20x Gold, 5x Cobs, 1x Club--");
                    player.Gold += 20;

                    //Add food and club to player's inventory here

                    player.Inventory.Add(new Club());

                    break;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Sorry, that's not what I asked.");
                }
            }

            Console.WriteLine("As you are now part of the adventurer's guild we also offer a room for 5 gold per night in our local tavern.");

            while(true)
            {
                Console.WriteLine("Is that something you'll be interested in?");
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "n" || userInput.ToLower() == "no")
                {
                    Console.Clear();
                    break;
                }
                else if (userInput.ToLower() == "y" || userInput.ToLower() == "yes")
                {
                    Console.WriteLine();
                    Console.WriteLine("--Recieved 1x Room Key--");

                    //Add tavern key to player inventory.

                    break;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Sorry, that's not what I asked.");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Your orientation to the Adventurers Guild has now concluded.");

            while(true)
            {
                Console.WriteLine("Is there anything you'll like to ask?");
                Console.WriteLine();
                Console.WriteLine("------------------------------");
                Console.WriteLine();
                Console.WriteLine("-- To select certain options type the word(s) surrounded by '' . --");
                Console.WriteLine("-- I.e. 'gold'. --");
                Console.WriteLine();
                Console.WriteLine("- How do I get more 'gold'?");
                Console.WriteLine("- How do I get more 'food'?");
                Console.WriteLine("- How do I get 'potions'?");
                Console.WriteLine("- How do I get 'spell' books?");
                Console.WriteLine("- How do I get better 'weapons'?");
                Console.WriteLine("- How do I get 'armor'?");
                Console.WriteLine();
                Console.WriteLine("- 'Leave'");
                Console.WriteLine();
                Console.WriteLine("------------------------------");
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "gold")
                {
                    Console.Clear();
                    Console.WriteLine("You can make more gold by selling creature parts, items, gems, spare weapons, or spare armor.");
                }
                else if (userInput.ToLower() == "weapons")
                {
                    Console.Clear();
                    Console.WriteLine("We have a local weaponsmith that can make weapons for you.");
                    Console.WriteLine("If you bring the materials and gold, the blacksmith can make you specialised weapons.");
                    Console.WriteLine("You can also buy what the blacksmith currently has in stock, however they can be more expensive.");
                }
                else if (userInput.ToLower() == "food")
                {
                    Console.Clear();
                    Console.WriteLine("We have a local merchant that can sell you food.");
                    Console.WriteLine("You can also find other random assortments such as potions, spell books, or creature parts.");
                }
                else if (userInput.ToLower() == "potions")
                {
                    Console.Clear();
                    Console.WriteLine("We have a local mage that can sell you potions .");
                    Console.WriteLine("They can also sell you spell books, or potential places where you could find certain spell books.");
                }
                else if (userInput.ToLower() == "spell")
                {
                    Console.Clear();
                    Console.WriteLine("We have a local mage that can sell you spell books or potential places where you could find certain spell books.");
                    Console.WriteLine("They can also sell you potions.");
                }
                else if  (userInput.ToLower() == "armor")
                {
                    Console.Clear();
                    Console.WriteLine("We have a local armorer that can make armor for you.");
                    Console.WriteLine("If you bring the materials and gold, the armorer can make you specialised armor.");
                    Console.WriteLine("You can also buy what the armorer currently has in stock, however they can be more expensive.");
                }
                else if (userInput.ToLower() == "leave")
                {
                    Console.Clear();
                    Console.WriteLine("Thank you for joining the Adventurers Guild.");
                    Console.WriteLine("We hope to see you often.");
                    Console.WriteLine("Good Luck!");
                    Console.WriteLine();
                    Console.WriteLine("-- Press any key --");
                    Console.ReadLine();

                    break;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Sorry, that's not what I asked.");
                }
            }

            return player;
        }
    
        public static void Town(Player player)
        {
            Console.WriteLine("You step outside into the town.");
            Console.WriteLine("It is bustling with people and merchants from all around the world.");
            Console.WriteLine();

            while(true)
            {
                Console.WriteLine("Where would you like to go?");
                Console.WriteLine();
                Console.WriteLine("------------------------------");
                Console.WriteLine();
                Console.WriteLine("- 'Merchant'");
                Console.WriteLine("- 'Armorer'");
                Console.WriteLine("- 'Weaponsmith'");
                Console.WriteLine("- 'Inn'");
                Console.WriteLine("- Visit the 'mage'");
                Console.WriteLine("- 'Dungeon'");
                Console.WriteLine();
                Console.WriteLine("------------------------------");
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "merchant")
                {
                    Merchant Xzadia = new Merchant(player.Floor);
                    Xzadia.Shop(player);
                }
                else if (userInput.ToLower() == "armorer")
                {
                    Console.WriteLine("The armorer is not in at the moment!");
                    Console.WriteLine("Please come again later!");
                }
                else if (userInput.ToLower() == "weaponsmith")
                {
                    Console.WriteLine("The weaponsmith is not in at the moment!");
                    Console.WriteLine("Please come again later!");
                }
                else if (userInput.ToLower() == "inn")
                {
                    Console.WriteLine("The inn is currently closed!");
                    Console.WriteLine("Please come again later!");
                }
                else if (userInput.ToLower() == "mage")
                {
                    Console.WriteLine("The mage seems to be on a quest!");
                    Console.WriteLine("Please come again later!");
                }
                else if (userInput.ToLower() == "dungeon")
                {
                    Dungeon.DungeonGenerator();
                }
            }
        }
    }
}