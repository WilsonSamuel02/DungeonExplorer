using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal enum Species
    {
        DWARF,
        ELF,
        HALFLING,
        HUMAN,
        DRAGONBORN,
        GNOME,
        GOLIATH,
        ORC,
        TIEFLING,
        CHANGELING,
        SHIFTER,
        WARFORGED
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
