using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class Species : Entity
    {
        public void SpeciesSelection(string speciesName)
        {
            switch (speciesName.ToLower())
            {
                case "dwarf":
                    base.Species = "Dwarf";
                    base.Size = "medium";
                    base.Speed = 30;
                    break;
                case "elf":
                    base.Species = "Elf";
                    base.Size = "medium";
                    base.Speed = 30;
                    break;
                case "halfling":
                    base.Species = "Halfling";
                    base.Size = "small";
                    base.Speed = 30;
                    break;
                case "human":
                    base.Species = "Human";
                    base.Size = "medium";
                    base.Speed = 30;
                    break;
                case "dragonborn":
                    base.Species = "Dragonborn";
                    base.Size = "medium";
                    base.Speed = 30;
                    break;
                case "gnome":
                    base.Species = "Gnome";
                    base.Size = "small";
                    base.Speed = 25;
                    break;
                case "goliath":
                    base.Species = "Goliath";
                    base.Size = "medium";
                    base.Speed = 30;
                    break;
                case "orc":
                    base.Species = "Orc";
                    base.Size = "medium";
                    base.Speed = 30;
                    break;
                case "tiefling":
                    base.Species = "Tiefling";
                    base.Size = "medium";
                    base.Speed = 30;
                    break;
                case "changeling":
                    base.Species = "Changeling";
                    base.Size = "small";
                    base.Speed = 30;
                    break;
                case "shifter":
                    base.Species = "Shifter";
                    base.Size = "medium";
                    base.Speed = 30;
                    break;
                case "warforged":
                    base.Species = "Warforged";
                    base.Size = "medium";
                    base.Speed = 30;
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
