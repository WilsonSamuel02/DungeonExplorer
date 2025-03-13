using DungeonExplorer.Entities;
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
    internal class Player : CombatClass {

        private List<string> _inventory;
        private int[] classStats = new int[9];

        /// <summary>
        /// Empty player constructor.
        /// </summary>
        /// <remarks>
        /// This empty player constructor is the base of the player class, assigning temporary variables as place holders.
        /// </remarks>
        public Player(){
            Name = "Empty Name";
            this._inventory = new List<string>();
            CombatClassId = "No class";
            CombatClassSelection(CombatClassId);
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
        public Player(string name, List<string> inventory, int health = 10, int maxHealth = 10, int attack = 5, int defense = 5, int mana = 20){
            Name = name;
            this._inventory = inventory;
            Health = health;
            MaxHealth = maxHealth;
            Attack = attack; 
            Defense = defense;
            Mana = mana;
        }

        public List<string> Inventory
        {
            get { return _inventory; }
            set { _inventory = value; }
        }

        /// <summary>
        /// Method to allow the player to access inventory
        /// </summary>
        /// <remarks>
        /// Allows the player to check the items that are in their inventory at any given time.
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

        /// <summary>
        /// Method to allow the player to access their stats
        /// </summary>
        /// <remarks>
        /// Simply prints out the value of certain stats for the player to easily see.
        /// In the future these stats would be adjusted to incorporate item stats and player leveling up.
        /// </remarks>
        public void AccessStats(){

            Console.WriteLine("---- Stats ----");
            Console.WriteLine();
            Console.WriteLine($"HP: {Health}");
            Console.WriteLine($"MP: {Mana}");
            Console.WriteLine($"Attack: {Attack}");
            Console.WriteLine($"Magic Attack: {MagicAttack}");
            Console.WriteLine($"Defense: {Defense}");
            Console.WriteLine($"Magic Defense: {MagicDefense}");
            Console.WriteLine($"Dexterity: {Dexterity}");
            Console.WriteLine();
            Console.WriteLine("---------------");
        }

        /// <summary>
        /// Adds an "item" to the player's inventory.
        /// </summary>
        /// <remarks>
        /// It allows items to be added to the player's inventory.
        /// In the future the items wouldn't be strings and they would have characteristics of their own that influence the player's stats.
        /// </remarks>
        /// <param name="item"> Item that the player is picking up.</param>
        /// <returns>
        /// Inventory list.
        /// </returns>
        public List<string> PickupItem(string item){
            
            
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