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
    internal class Player : Entity, IHealth 
    {

        private List<Item> _inventory;

        public Player() { }

        public Player(string name, string gender, string combatClass, string species) : base(name, gender, combatClass, species)
        {
            Name = name;
            Gender = gender;
            Class = combatClass;
            Specie = species;
            ClassSelection(combatClass);
            SpeciesSelection(species);

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
                Console.ReadLine();
            }
            else{
                Console.WriteLine();
                Console.WriteLine("---- Inventory ----");
                Console.WriteLine();
                Console.WriteLine($"Gold: {Gold}");
                Console.WriteLine();

                foreach(var item in _inventory){
                    Console.WriteLine($"- {item.Name}");
                }
                Console.WriteLine("-------------------");
                Console.ReadLine();
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
            Console.ReadLine();
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
            Console.ReadLine();
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

        private void ClassSelection(string combatClass)
        {
            switch (combatClass.ToLower())
            {
                case "artificer":
                    Health = 10;
                    MaxHealth = 10;
                    Armour = 11;
                    Strength = 14;
                    Dexterity = 13;
                    Intelligence = 15;
                    Constitution = 10;
                    Wisdom = 12;
                    Charisma = 8;
                    break;
                case "barbarian":
                    Health = 12;
                    MaxHealth = 12;
                    Armour = 10;
                    Strength = 15;
                    Dexterity = 10;
                    Intelligence = 12;
                    Constitution = 14;
                    Wisdom = 8;
                    Charisma = 13;
                    break;
                case "bard":
                    Health = 11;
                    MaxHealth = 11;
                    Armour = 12;
                    Strength = 8;
                    Dexterity = 14;
                    Intelligence = 13;
                    Constitution = 12;
                    Wisdom = 10;
                    Charisma = 15;
                    break;
                case "cleric":
                    Health = 10;
                    MaxHealth = 10;
                    Armour = 11;
                    Strength = 8;
                    Dexterity = 12;
                    Intelligence = 13;
                    Constitution = 10;
                    Wisdom = 15;
                    Charisma = 14;
                    break;
                case "druid":
                    Health = 10;
                    MaxHealth = 10;
                    Armour = 11;
                    Strength = 12;
                    Dexterity = 13;
                    Intelligence = 14;
                    Constitution = 10;
                    Wisdom = 15;
                    Charisma = 8;
                    break;
                case "fighter":
                    Health = 12;
                    MaxHealth = 12;
                    Armour = 12;
                    Strength = 13;
                    Dexterity = 15;
                    Intelligence = 12;
                    Constitution = 14;
                    Wisdom = 10;
                    Charisma = 8;
                    break;
                case "monk":
                    Health = 10;
                    MaxHealth = 10;
                    Armour = 12;
                    Strength = 13;
                    Dexterity = 15;
                    Intelligence = 12;
                    Constitution = 10;
                    Wisdom = 14;
                    Charisma = 8;
                    break;
                case "paladin":
                    Health = 11;
                    MaxHealth = 11;
                    Armour = 12;
                    Strength = 15;
                    Dexterity = 14;
                    Intelligence = 8;
                    Constitution = 12;
                    Wisdom = 10;
                    Charisma = 13;
                    break;
                case "ranger":
                    Health = 11;
                    MaxHealth = 11;
                    Armour = 12;
                    Strength = 13;
                    Dexterity = 15;
                    Intelligence = 8;
                    Constitution = 12;
                    Wisdom = 14;
                    Charisma = 10;
                    break;
                case "rogue":
                    Health = 11;
                    MaxHealth = 11;
                    Armour = 12;
                    Strength = 10;
                    Dexterity = 15;
                    Intelligence = 14;
                    Constitution = 12;
                    Wisdom = 8;
                    Charisma = 13;
                    break;
                case "sorcerer":
                    Health = 12;
                    MaxHealth = 12;
                    Armour = 9;
                    Strength = 10;
                    Dexterity = 8;
                    Intelligence = 12;
                    Constitution = 14;
                    Wisdom = 13;
                    Charisma = 15;
                    break;
                case "warlock":
                    Health = 11;
                    MaxHealth = 11;
                    Armour = 11;
                    Strength = 8;
                    Dexterity = 13;
                    Intelligence = 10;
                    Constitution = 12;
                    Wisdom = 14;
                    Charisma = 15;
                    break;
                case "wizard":
                    Health = 9;
                    MaxHealth = 9;
                    Armour = 11;
                    Strength = 10;
                    Dexterity = 12;
                    Intelligence = 15;
                    Constitution = 8;
                    Wisdom = 14;
                    Charisma = 13;
                    break;
            }
        }

        private void SpeciesSelection(string species)
        {
            switch (species.ToLower())
            {
                case "dwarf":
                    Specie = "Dwarf";
                    Size = "Medium";
                    Speed = 30;
                    break;
                case "elf":
                    Specie = "Elf";
                    Size = "medium";
                    Speed = 30;
                    break;
                case "halfling":
                    Specie = "Halfling";
                    Size = "small";
                    Speed = 30;
                    break;
                case "human":
                    Specie = "Human";
                    Size = "medium";
                    Speed = 30;
                    break;
                case "dragonborn":
                    Specie = "Dragonborn";
                    Size = "medium";
                    Speed = 30;
                    break;
                case "gnome":
                    Specie = "Gnome";
                    Size = "small";
                    Speed = 25;
                    break;
                case "goliath":
                    Specie = "Goliath";
                    Size = "medium";
                    Speed = 30;
                    break;
                case "orc":
                    Specie = "Orc";
                    Size = "medium";
                    Speed = 30;
                    break;
                case "tiefling":
                    Specie = "Tiefling";
                    Size = "medium";
                    Speed = 30;
                    break;
                case "changeling":
                    Specie = "Changeling";
                    Size = "small";
                    Speed = 30;
                    break;
                case "shifter":
                    Specie = "Shifter";
                    Size = "medium";
                    Speed = 30;
                    break;
                case "warforged":
                    Specie = "Warforged";
                    Size = "medium";
                    Speed = 30;
                    break;
            }
        }
    }
}