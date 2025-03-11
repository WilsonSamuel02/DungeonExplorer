using System;
using System.Text;

namespace DungeonCrawler
{

    public class Player : Entity {
        private List<string> _inventory = new List<string>();

        public Player(){
            Name = "Empty Name";
            this._inventory = [];
            Health = 10;
            MaxHealth = 10;
        }

        public Player(string name, List<string> inventory, int health = 10, int maxHealth = 10){
            Name = name;
            this._inventory = inventory;
            Health = health;
            maxHealth = maxHealth;
        }

        public List<string> Inventory{
            get { return _inventory; }
            set { _inventory = value; }
        }

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
            Console.WriteLine("---- Stats ----");
            Console.WriteLine();
            Console.WriteLine($"HP: {_health}");
            Console.WriteLine();
            Console.WriteLine("---------------");
        }

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