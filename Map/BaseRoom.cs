using System;
using System.Collections.Generic;

namespace DungeonCrawler
{
    internal class BaseRoom
    {
        public string RoomType { get; protected set; }
        public int EnemiesAmount { get; protected set; }

        public BaseRoom()
        {
            RoomType = "Base Room";
            EnemiesAmount = 0;
        }
    }
}