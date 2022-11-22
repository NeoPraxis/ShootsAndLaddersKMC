using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootsAndLaddersKMC
{
    internal class KMCPlayer

    { 

        private int currentPosition;

        public string playerName = null;

        public int CurrentPostion { get => currentPosition; }

        public string PlayerName { get => playerName; }


        public KMCPlayer(string newPlayerName)
        {
            playerName = newPlayerName;
            currentPosition = 0;
        }

        public void UpdatePosition(int updatedPosition)
        {
            currentPosition = updatedPosition;
        }

    }
}
