using System;
using System.Collections.Generic;

namespace DungeonCrawler{

    public class Game {
        //main game class
        //It is split from game logic as it provides a more organised game logic
        //In the future the text will be in a different class so that it is much cleaner and would be easier to add more methods and easier to implement


        public static int Play()
        {
            int gameState = 4;

            Player player = CharacterCreation.CharacterCreator();

            player = Story.Intro(player);
            Story.Town();

            return gameState;
        }

        
    }
}