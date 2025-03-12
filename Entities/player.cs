using System;
using System.Collections.Generic;

namespace DungeonCrawler
{

    public class Player : Entity {

        //main player class

        private List<string> _inventory = new List<string>();

        public Player(){
            Name = "Empty Name";
            this._inventory = new List<string>();
            Health = 10;
            MaxHealth = 10;
        }

        public Player(string name, List<string> inventory, int health = 10, int maxHealth = 10){
            Name = name;
            this._inventory = inventory;
            Health = health;
            MaxHealth = maxHealth;
        }

        public List<string> Inventory{
            get { return _inventory; }
            set { _inventory = value; }
        }

        public void AccessInventory(){
            //allows the player to see what their inventory haas

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