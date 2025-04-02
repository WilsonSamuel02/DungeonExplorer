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
            base.Name = name;

            switch (name.ToLower())
            {
                case "arclight phoenix":
                    base.Level = 28;
                    base.Health = 432;
                    base.MaxHealth = 432;
                    base.Armour = 18;
                    base.Strength = 15;
                    base.Dexterity = 22;
                    base.Constitution = 26;
                    base.Intelligence = 5;
                    base.Wisdom = 12;
                    base.Charisma = 7;
                    break;
                case "bahamut":
                    base.Level = 30;
                    base.Health = 585;
                    base.MaxHealth = 585;
                    base.Armour = 23;
                    base.Strength = 30;
                    base.Dexterity = 18;
                    base.Constitution = 29;
                    base.Intelligence = 25;
                    base.Wisdom = 28;
                    base.Charisma = 30;
                    break;
                case "tiamat":
                    base.Level = 30;
                    base.Health = 615;
                    base.MaxHealth = 615;
                    base.Armour = 25;
                    base.Strength = 30;
                    base.Dexterity = 10;
                    base.Constitution = 30;
                    base.Intelligence = 26;
                    base.Wisdom = 26;
                    base.Charisma = 28;
                    break;
                case "baphomet":
                    base.Level = 22;
                    base.Health = 292;
                    base.MaxHealth = 292;
                    base.Armour = 22;
                    base.Strength = 30;
                    base.Dexterity = 14;
                    base.Constitution = 26;
                    base.Intelligence = 18;
                    base.Wisdom = 24;
                    base.Charisma = 16;
                    break;
                case "basilisk":
                    base.Level = 6;
                    base.Health = 52;
                    base.MaxHealth = 52;
                    base.Armour = 15;
                    base.Strength = 16;
                    base.Dexterity = 8;
                    base.Constitution = 16;
                    base.Intelligence = 2;
                    base.Wisdom = 8;
                    base.Charisma = 7;
                    break;
                case "chimera":
                    base.Level = 8;
                    base.Health = 135;
                    base.MaxHealth = 135;
                    base.Armour = 15;
                    base.Strength = 19;
                    base.Dexterity = 11;
                    base.Constitution = 20;
                    base.Intelligence = 3;
                    base.Wisdom = 14;
                    base.Charisma = 10;
                    break;
                case "colossus":
                    base.Level = 14;
                    base.Health = 184;
                    base.MaxHealth = 184;
                    base.Armour = 22;
                    base.Strength = 23;
                    base.Dexterity = 8;
                    base.Constitution = 25;
                    base.Intelligence = 3;
                    base.Wisdom = 11;
                    base.Charisma = 1;
                    break;
                case "vampire lord":
                    base.Level = 20;
                    base.Health = 245;
                    base.MaxHealth = 245;
                    base.Armour = 19;
                    base.Strength = 18;
                    base.Dexterity = 20;
                    base.Constitution = 21;
                    base.Intelligence = 18;
                    base.Wisdom = 18;
                    base.Charisma = 20;
                    break;
                case "eldrich lich":
                    base.Level = 18;
                    base.Health = 190;
                    base.MaxHealth = 190;
                    base.Armour = 18;
                    base.Strength = 11;
                    base.Dexterity = 18;
                    base.Constitution = 17;
                    base.Intelligence = 19;
                    base.Wisdom = 14;
                    base.Charisma = 12;
                    break;
                case "goblin chiefton":
                    base.Level = 2;
                    base.Health = 25;
                    base.MaxHealth = 25;
                    base.Armour = 17;
                    base.Strength = 10;
                    base.Dexterity = 15;
                    base.Constitution = 11;
                    base.Intelligence = 10;
                    base.Wisdom = 8;
                    base.Charisma = 10;
                    break;
                case "hydra":
                    base.Level = 10;
                    base.Health = 199;
                    base.MaxHealth = 199;
                    base.Armour = 16;
                    base.Strength = 20;
                    base.Dexterity = 12;
                    base.Constitution = 21;
                    base.Intelligence = 2;
                    base.Wisdom = 10;
                    base.Charisma = 7;
                    break;
                case "jabberwock":
                    base.Level = 26;
                    base.Health = 291;
                    base.MaxHealth = 291;
                    base.Armour = 19;
                    base.Strength = 20;
                    base.Dexterity = 12;
                    base.Constitution = 27;
                    base.Intelligence = 4;
                    base.Wisdom = 7;
                    base.Charisma = 11;
                    break;
                case "manticore":
                    base.Level = 16;
                    base.Health = 183;
                    base.MaxHealth = 183;
                    base.Armour = 19;
                    base.Strength = 17;
                    base.Dexterity = 16;
                    base.Constitution = 23;
                    base.Intelligence = 7;
                    base.Wisdom = 12;
                    base.Charisma = 8;
                    break;
                case "oni":
                    base.Level = 12;
                    base.Health = 157;
                    base.MaxHealth = 157;
                    base.Armour = 18;
                    base.Strength = 19;
                    base.Dexterity = 11;
                    base.Constitution = 17;
                    base.Intelligence = 14;
                    base.Wisdom = 12;
                    base.Charisma = 15;
                    break;
                case "orc war chief":
                    base.Level = 4;
                    base.Health = 93;
                    base.MaxHealth = 93;
                    base.Armour = 16;
                    base.Strength = 18;
                    base.Dexterity = 12;
                    base.Constitution = 18;
                    base.Intelligence = 11;
                    base.Wisdom = 11;
                    base.Charisma = 16;
                    break;
            }
        }
    }
}
