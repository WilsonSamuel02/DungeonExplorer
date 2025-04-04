using DungeonCrawler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer.Menu.Selections
{
    internal class BossSetters : Enemy
    {
        public BossSetters(string name)
        {
            Name = name;

            switch (name.ToLower())
            {
                //Floor 5 boss
                case "goblin chiefton":
                    GoblinChiefton.SetAbilityScore();
                    break;
                //Floor 10 boss
                case "orc war chief":
                    OrcWarChief.SetAbilityScore();
                    break;
                //Floor 15 boss
                case "basilisk":
                    Basilisk.SetAbilityScore();
                    break;
                //Floor 20 boss
                case "chimera":
                    Chimera.SetAbilityScore();
                    break;
                //Floor 25 boss
                case "hydra":
                    Hydra.SetAbilityScore();
                    break;
                //Floor 30 boss
                case "oni":
                    Oni.SetAbilityScore();
                    break;
                //Floor 35 boss
                case "colossus":
                    Colossus.SetAbilityScore();
                    break;
                //Floor 40 boss
                case "manticore":
                    Manticore.SetAbilityScore();
                    break;
                //Floor 45 boss
                case "eldrich lich":
                    EldrichLich.SetAbilityScore();
                    break;
                //Floor 50 boss
                case "vampire lord":
                    VampireLord.SetAbilityScore();
                    break;
                //Floor 55 boss
                case "baphomet":
                    Baphomet.SetAbilityScore();
                    break;
                //Floor 60 boss
                case "jabberwock":
                    Jabberwock.SetAbilityScore();
                    break;
                //Floor 65 boss
                case "arclight phoenix":
                    ArclightPhoenix.SetAbilityScore();
                    break;
                //Floor 70 boss
                case "bahamut":
                    Bahamut.SetAbilityScore();
                    break;
                //Floor 75 boss
                case "tiamat":
                    Tiamat.SetAbilityScore();
                    break;
            }
        }
    }
}
