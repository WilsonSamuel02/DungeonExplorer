using System;
using System.Web;

namespace DungeonCrawler{

    internal abstract class Entity{

        //main entity class that all entities (players and enemies) inherit from

        public string Name { get; set; }
        public int Level { get; protected set; }
        public int Health { get; protected set; }
        public int MaxHealth { get; protected set; }
        public int Armour { get; protected set; }
        public int Strength {  get; protected set; }
        public int Dexterity { get; protected set; }
        public int Intelligence { get; protected set; }
        public int Constitution { get; protected set; }
        public int Wisdom { get; protected set; }
        public int Charisma { get; protected set; }
    }
}