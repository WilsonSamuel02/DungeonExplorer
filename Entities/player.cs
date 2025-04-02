using DungeonExplorer.Entities.CombatClasses;
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
    internal class Player : CombatClass, IHealth {

        private List<string> _inventory;
        private List<> _traits;

        /// <summary>
        /// Empty player constructor.
        /// </summary>
        /// <remarks>
        /// This empty player constructor is the base of the player class, assigning temporary variables as place holders.
        /// </remarks>
        public Player(){
            Name = "Empty Name";
            this._inventory = new List<string>();
        }

        public Player(string name, string combatClass)
        {
            Name = name;
            ClassSelection(combatClass);

            this._inventory = new List<string>();
        }

        public List<string> Inventory
        {
            get { return _inventory; }
            set { _inventory = value; }
        }

        public void TakeDamage(int damageAmount)
        {
            base.Health -= damageAmount;
        }

        public void Heal(int healAmount)
        {
            base.Health += healAmount;
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

                Console.WriteLine();
                Console.WriteLine("Inventory is Empty");
            }
            else{
                Console.WriteLine();
                Console.WriteLine("---- Inventory ----");

                for (int i = 0; i < _inventory.Count; i++){
                    Console.WriteLine($"- {_inventory[i]}");
                }
                Console.WriteLine("-------------------");
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

            Console.WriteLine();
            Console.WriteLine("---- Stats ----");
            Console.WriteLine();
            Console.WriteLine($"HP: {base.Health}");
            Console.WriteLine($"MP: {base.Mana}");
            Console.WriteLine($"Armour: {base.Armour}");
            Console.WriteLine($"Strength: {base.Strength}");
            Console.WriteLine($"Dexterity: {base.Dexterity}");
            Console.WriteLine($"Intelligence: {base.Intelligence}");
            Console.WriteLine($"Constitution: { Constitution}");
            Console.WriteLine($"Wisdom: {base.Wisdom}");
            Console.WriteLine($"Charisma: {base.Charisma}");
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