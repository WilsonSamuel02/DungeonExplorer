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
    internal class Player :Entity, IHealth 
    {

        private List<Item> _inventory;

        /// <summary>
        /// Empty player constructor.
        /// </summary>
        /// <remarks>
        /// This empty player constructor is the base of the player class, assigning temporary variables as place holders.
        /// </remarks>
        public Player(){
            Name = "Empty Name";
            Level = 1;
            XP = 0;
            Gold = 10;
            this._inventory = new List<Item>();
        }

        public Player(string name, string gender, string combatClass, string species, List<int> currentCoordinates)
        {
            Name = name;
            Gender = gender;
            Level = 1;
            XP = 0;
            Gold = 10;
            Class = combatClass;
            CurrentCoordinates = currentCoordinates;
            CombatClass.ClassSelection(combatClass);
            Species.SpeciesSelection(species);

            this._inventory = new List<Item>();
        }

        public List<Item> Inventory
        {
            get { return _inventory; }
            set { _inventory = value; }
        }

        public void TakeDamage(int damageAmount)
        {
            Health -= damageAmount;
        }

        public void Heal(int healAmount)
        {
            Health += healAmount;
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
                Console.WriteLine();
                Console.WriteLine($"Gold: {Gold}");

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
            Console.WriteLine($"HP: {Health}");
            Console.WriteLine($"Armour: {Armour}");
            Console.WriteLine($"Strength: {Strength}");
            Console.WriteLine($"Dexterity: {Dexterity}");
            Console.WriteLine($"Intelligence: {Intelligence}");
            Console.WriteLine($"Constitution: { Constitution}");
            Console.WriteLine($"Wisdom: {Wisdom}");
            Console.WriteLine($"Charisma: {Charisma}");
            Console.WriteLine();
            Console.WriteLine("---------------");
        }

        public void GetDescription()
        {
            Console.WriteLine();
            Console.WriteLine($"---- {Name} ----");
            Console.WriteLine();
            Console.WriteLine($"Level: {Level}");
            Console.WriteLine($"Class: {Class}");
            Console.WriteLine($"Gender: {Gender}");
            Console.WriteLine($"Species: {Specie}");
            Console.WriteLine($"Size: {Size}");
            Console.WriteLine($"Speed: {Speed}");
            Console.WriteLine();
            Console.WriteLine("----------------------");
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
        public List<Item> PickupItem(Item item){
            
            
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