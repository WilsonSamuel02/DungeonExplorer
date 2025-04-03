using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class Bosses : Enemy
    {
        public Bosses(string name)
        {
            Name = name;

            switch (name.ToLower())
            {
                //Floor 5 boss
                case "goblin chiefton":
                    Level = 2;
                    XP = 450;
                    Health = 25;
                    MaxHealth = 25;
                    Armour = 17;
                    Strength = 10;
                    Dexterity = 15;
                    Constitution = 11;
                    Intelligence = 10;
                    Wisdom = 8;
                    Charisma = 10;
                    break;
                //Floor 10 boss
                case "orc war chief":
                    Level = 4;
                    XP = 1100;
                    Health = 93;
                    MaxHealth = 93;
                    Armour = 16;
                    Strength = 18;
                    Dexterity = 12;
                    Constitution = 18;
                    Intelligence = 11;
                    Wisdom = 11;
                    Charisma = 16;
                    break;
                //Floor 15 boss
                case "basilisk":
                    Level = 6;
                    XP = 2300;
                    Health = 52;
                    MaxHealth = 52;
                    Armour = 15;
                    Strength = 16;
                    Dexterity = 8;
                    Constitution = 16;
                    Intelligence = 2;
                    Wisdom = 8;
                    Charisma = 7;
                    break;
                //Floor 20 boss
                case "chimera":
                    Level = 8;
                    XP = 3900;
                    Health = 135;
                    MaxHealth = 135;
                    Armour = 15;
                    Strength = 19;
                    Dexterity = 11;
                    Constitution = 20;
                    Intelligence = 3;
                    Wisdom = 14;
                    Charisma = 10;
                    break;
                //Floor 25 boss
                case "hydra":
                    Level = 10;
                    XP = 5900;
                    Health = 199;
                    MaxHealth = 199;
                    Armour = 16;
                    Strength = 20;
                    Dexterity = 12;
                    Constitution = 21;
                    Intelligence = 2;
                    Wisdom = 10;
                    Charisma = 7;
                    break;
                //Floor 30 boss
                case "oni":
                    Level = 8400;
                    XP = 700;
                    Health = 157;
                    MaxHealth = 157;
                    Armour = 18;
                    Strength = 19;
                    Dexterity = 11;
                    Constitution = 17;
                    Intelligence = 14;
                    Wisdom = 12;
                    Charisma = 15;
                    break;
                //Floor 35 boss
                case "colossus":
                    Level = 14;
                    XP = 11500;
                    Health = 184;
                    MaxHealth = 184;
                    Armour = 22;
                    Strength = 23;
                    Dexterity = 8;
                    Constitution = 25;
                    Intelligence = 3;
                    Wisdom = 11;
                    Charisma = 1;
                    break;
                //Floor 40 boss
                case "manticore":
                    Level = 16;
                    XP = 15000;
                    Health = 183;
                    MaxHealth = 183;
                    Armour = 19;
                    Strength = 17;
                    Dexterity = 16;
                    Constitution = 23;
                    Intelligence = 7;
                    Wisdom = 12;
                    Charisma = 8;
                    break;
                //Floor 45 boss
                case "eldrich lich":
                    Level = 18;
                    XP = 20000;
                    Health = 190;
                    MaxHealth = 190;
                    Armour = 18;
                    Strength = 11;
                    Dexterity = 18;
                    Constitution = 17;
                    Intelligence = 19;
                    Wisdom = 14;
                    Charisma = 12;
                    break;
                //Floor 50 boss
                case "vampire lord":
                    Level = 20;
                    XP = 25000;
                    Health = 245;
                    MaxHealth = 245;
                    Armour = 19;
                    Strength = 18;
                    Dexterity = 20;
                    Constitution = 21;
                    Intelligence = 18;
                    Wisdom = 18;
                    Charisma = 20;
                    break;
                //Floor 55 boss
                case "baphomet":
                    Level = 22;
                    XP = 41000;
                    Health = 292;
                    MaxHealth = 292;
                    Armour = 22;
                    Strength = 30;
                    Dexterity = 14;
                    Constitution = 26;
                    Intelligence = 18;
                    Wisdom = 24;
                    Charisma = 16;
                    break;
                //Floor 60 boss
                case "jabberwock":
                    Level = 26;
                    XP = 90000;
                    Health = 291;
                    MaxHealth = 291;
                    Armour = 19;
                    Strength = 20;
                    Dexterity = 12;
                    Constitution = 27;
                    Intelligence = 4;
                    Wisdom = 7;
                    Charisma = 11;
                    break;
                //Floor 65 boss
                case "arclight phoenix":
                    Level = 28;
                    XP = 120000;
                    Health = 432;
                    MaxHealth = 432;
                    Armour = 18;
                    Strength = 15;
                    Dexterity = 22;
                    Constitution = 26;
                    Intelligence = 5;
                    Wisdom = 12;
                    Charisma = 7;
                    break;
                //Floor 70 boss
                case "bahamut":
                    Level = 30;
                    XP = 155000;
                    Health = 585;
                    MaxHealth = 585;
                    Armour = 23;
                    Strength = 30;
                    Dexterity = 18;
                    Constitution = 29;
                    Intelligence = 25;
                    Wisdom = 28;
                    Charisma = 30;
                    break;
                //Floor 75 boss
                case "tiamat":
                    Level = 30;
                    XP = 155000;
                    Health = 615;
                    MaxHealth = 615;
                    Armour = 25;
                    Strength = 30;
                    Dexterity = 10;
                    Constitution = 30;
                    Intelligence = 26;
                    Wisdom = 26;
                    Charisma = 28;
                    break;
            }
        }
    }
}
