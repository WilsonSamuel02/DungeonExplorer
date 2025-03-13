using System;
using System.Collections.Generic;

namespace DungeonCrawler
{

    /// <summary>
    /// Main player class.
    /// </summary>
    /// <remarks>
    /// This player class inherits from the Entity class, setting the players name and other variables as needed.
    /// It is also house to certain player specific methods, such as "AccessInventory", "AccessStats", etc.
    /// </remarks>
    public class Player : Entity {

        public List<string> Inventory { get; set; }

        /// <summary>
        /// Empty player constructor.
        /// </summary>
        /// <remarks>
        /// This empty player constructor is the base of the player class, assigning temporary variables as place holders.
        /// </remarks>
        public Player(){
            Name = "Empty Name";
            this._inventory = new List<string>();
            Health = 10;
            MaxHealth = 10;
        }

        /// <summary>
        /// Player constructor with modifiable parameters.
        /// </summary>
        /// <remarks>
        /// This is a modifiable player constructor, which, in the future, will be used to add certain elements manually.
        /// This same constructor will be used in the enemy class for randomising their inventory and allowing them to level up over the course of the game.
        /// </remarks>
        /// <param name="name">Player name that is assigned at the start of the game.</param>
        /// <param name="inventory">Temporary empty list being used as a player inventory.</param>
        /// <param name="health">Player's current health.</param>
        /// <param name="maxHealth">Maximum health the player can reach.</param>
        public Player(string name, List<string> inventory, int health = 10, int maxHealth = 10){
            Name = name;
            this._inventory = inventory;
            Health = health;
            MaxHealth = maxHealth;
        }

        /// <summary>
        /// Allows the player to access inventory
        /// </summary>
        /// <remarks>
        /// Adds a simple string considered as an "item" that the player can check whenever.
        /// It first checks if the list is empty.
        /// If not then each element in the list is looped over and displayed for the player.
        /// In the future, this method will expand to allow each item to be characterised differently for better control of their functions.
        /// </remarks>
        public void AccessInventory(){

            if (_inventory.Count <= 0){
                Console.WriteLine("Inventory is Empty");
                Console.WriteLine();
            }
            else{
                Console.WriteLine("---- Inventory ----");

                for (int i = 0; i < _inventory.Count; i++){
                    Console.WriteLine($"- {_inventory[i]}");
                }
                Console.WriteLine("-------------------");
                Console.WriteLine();
            }
        }

        public void AccessStats(){

            //allows the player to check their health, and in the future their mana, attack and defense stats

            Console.WriteLine("---- Stats ----");
            Console.WriteLine();
            Console.WriteLine($"HP: {Health}");
            Console.WriteLine();
            Console.WriteLine("---------------");
        }

        public List<string> PickupItem(string item){
            //allows the player to add items to the list, will be later changed for better implementation
            
            if (_inventory.Count < 5){
                _inventory.Add(item);
            }
            else{
                Console.WriteLine("Inventory is full");
            }
            return _inventory;
        }
    }
}