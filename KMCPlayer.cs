using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootsAndLaddersKMC
{
    internal class KMCPlayer

    { 
        // current position of ONE player
        private int currentPosition;
        
        // player name eg: Player 1
        public string playerName = null;

        // getter and setter for current position
        public int CurrentPostion { get => currentPosition; }
        
        // getter and setter for player name
        public string PlayerName { get => playerName; }

        // Player has name and position
        public KMCPlayer(string newPlayerName)
        {
            playerName = newPlayerName;
            currentPosition = 0;
        }

        // update current players position
        public void UpdatePosition(int updatedPosition)
        {
            currentPosition = updatedPosition;
        }

    }
}
