using System;
using System.Collections.Generic;

namespace DungeonCrawler{

    internal abstract class Entity{

        //main entity class that all entities (players and enemies) inherit from

        public static string Name { get; set; }
        public static List<int> CurrentCoordinates { get; protected set; }
        public static int Level { get; protected set; }
        public static int XP { get; protected set; }
        public static int Gold { get; protected set; }
        public static string Specie { get; protected set; }
        public static string Class { get; protected set; }
        public static string Size { get; protected set;}
        public static int Speed { get; protected set; }
        public static int Health { get; protected set; }
        public static int MaxHealth { get; protected set; }
        public static int Armour { get; protected set; }
        public static List<string> Resistance { get; protected set; }
        public static int Strength {  get; protected set; }
        public static int Dexterity { get; protected set; }
        public static int Intelligence { get; protected set; }
        public static int Constitution { get; protected set; }
        public static int Wisdom { get; protected set; }
        public static int Charisma { get; protected set; }
    }
}