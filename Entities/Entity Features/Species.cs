using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class Species : Entity
    {
        public static void SpeciesSelection(string speciesName)
        {
            switch (speciesName.ToLower())
            {
                case "dwarf":
                    Dwarf.SetDescription();
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

    internal enum DragonSpecies
    {
        //Dragon Wyrmling - Adult Dragon - Ancient Dragon - Greatwyrm
        //Medium - Large - Huge - Gargantuan
        //Level 5 - Level 10 - Level 15 - Level 20
        //Found in treasure rooms

        BRASS,
        BRONZE,
        COPPER,
        CRYSTAL,
        DEEP,
        EMERALD,
        GOLD,
        LUNAR,
        MOONSTONE,
        SAPPHIRE,
        SILVER,
        SOLAR,
        TIME,
        TOPAZ,
        AMETHYST,
        VOID
    }

    internal enum MonsterSpecies
    {
        ANCIENT_CONSTRUCT,
        ANDROID,
        ZOMBIE,
        ASSASSIN_BUG,
        ASSASSIN_VINE,
        AUTOGNOME,
        BANSHEE,
        OGRE,
        STALKER,
        MUMMY,
        GHOST,
        DARKLING,
        DOPPELGANGER,
        DROWNED_ASSASSIN,
        DRYAD,
        SKELETON,
        SPHINX,
        TROLL,
        GARGOYLE,
        VAMPIRE,
        GIANT,
        GHOUL,
        GOBLIN,
        SENTINEL,
        GORGON,
        JUGGERNAUT,
        HOBGOBLIN,
        KOBOLD,
        IMP,
        INCUBUS,
        MERFOLK,
        SIREN,
        MIMIC,
        REVENANT,
        SPECTER,
        STONECLOAK,
        SUCCUBUS
    }

    internal enum BossSpecies
    {
        ARCLIGHT_PHOENIX,   //CR 28
        BAHAMUT,            //CR 30
        TIAMAT,             //CR 30
        BAPHOMET,           //CR 22
        BASILISK,           //CR 6
        CHIMERA,            //CR 8
        COLOSSUS,           //CR 14
        VAMPIRE,            //CR 20
        ELDRICH_LICH,       //CR 18
        GOBLIN_CHIEFTON,    //CR 2
        HYDRA,              //CR 10
        JABBERWOCK,         //CR 26
        MANTICORE,          //CR 16
        ONI,                //CR 12
        ORC_WAR_CHIEF       //CR 4
    }
}
