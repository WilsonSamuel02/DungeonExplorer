using System;
using System.Collections.Generic;

namespace DungeonCrawler
{
    internal class CharacterCreation
    {
        public static Player CharacterCreator()
        {
            string playerName;
            string gender;
            string species;
            string combatClass;

            List<string> _species = new List<string>
            {
                "dwarf",
                "elf",
                "halfling",
                "human",
                "dragonborn",
                "gnome",
                "goliath",
                "orc",
                "tiefling",
                "changeling",
                "shifter",
                "warforged"
            };

            List<string> _combatClass = new List<string>
            {
                "artificer",
                "barbarian",
                "bard",
                "cleric",
                "druid",
                "fighter",
                "monk",
                "paladin",
                "ranger",
                "rogue",
                "sorcerer",
                "warlock",
                "wizard",
            };

            while (true)
            {
                Console.Clear();
                Console.WriteLine("What would you like to name your warrior?");
                playerName = Console.ReadLine();

                if (playerName.Length > 0)
                {
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.WriteLine("Please input a name before going forward!");
                }
            }

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("What gender would you like your warrior to be?");
                Console.WriteLine();
                Console.WriteLine("- Male");
                Console.WriteLine("- Female");
                Console.WriteLine("- Non-Binary");
                gender = Console.ReadLine();

                if (gender.Length > 0)
                {
                    if (gender.ToLower() == "male" ||  gender.ToLower() == "female" || gender.ToLower() == "non-binary")
                    {
                        Console.Clear();
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Please select a valid option before going forward!");
                }
            }

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("What species would you like your warrior to be?");
                Console.WriteLine("- Dwarf");
                Console.WriteLine("- Elf");
                Console.WriteLine("- Halfling");
                Console.WriteLine("- Human");
                Console.WriteLine("- Dragonborn");
                Console.WriteLine("- Gnome");
                Console.WriteLine("- Goliath");
                Console.WriteLine("- Orc");
                Console.WriteLine("- Tiefling");
                Console.WriteLine("- Changeling");
                Console.WriteLine("- Shifter");
                Console.WriteLine("- Warforged");
                species = Console.ReadLine();

                if (species.Length > 0)
                {
                    for (int i = 0; i < _species.Count; i++)
                    {
                        if (species.ToLower() == _species[i])
                        {
                            Console.Clear();
                            break;
                        }
                        else if (species.ToLower() != _species[i] && i >= _species.Count)
                        {
                            Console.WriteLine();
                            Console.WriteLine("That is not a valid species!");
                            Console.WriteLine("Please try again!");
                        }
                    }

                    break;
                }
                else
                {
                    Console.WriteLine("Please select a class before going forward!");
                }
            }

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("What class would you like your warrior to be?");
                Console.WriteLine("- Artificer");
                Console.WriteLine("- Barbarian");
                Console.WriteLine("- Bard");
                Console.WriteLine("- Cleric");
                Console.WriteLine("- Druid");
                Console.WriteLine("- Fighter");
                Console.WriteLine("- Monk");
                Console.WriteLine("- Paladin");
                Console.WriteLine("- Ranger");
                Console.WriteLine("- Rogue");
                Console.WriteLine("- Sorcerer");
                Console.WriteLine("- Warlock");
                Console.WriteLine("- Wizard");
                combatClass = Console.ReadLine();

                if(combatClass.Length > 0)
                {
                    for (int i = 0; i < _combatClass.Count; i++)
                    {
                        if (combatClass.ToLower() == _combatClass[i])
                        {
                            Console.Clear();
                            break;
                        }
                        else if (combatClass.ToLower() != _combatClass[i] && i >= _combatClass.Count)
                        {
                            Console.WriteLine();
                            Console.WriteLine("That is not a valid species!");
                            Console.WriteLine("Please try again!");
                        }
                    }

                    break;
                }
                else
                {
                    Console.WriteLine("Please select a class before going forward!");
                }
            }

            Player player = new Player(playerName, gender, combatClass, species);

            return player;
        }
    }
}