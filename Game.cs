using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShootsAndLaddersKMC
{
    internal class Game
    {
        private int DieRoll = 0;
        private const int MIN_ALLOWED_PLAYERS = 2;
        private const int MAX_ALLOWED_PLAYERS = 6;

        KMCQueue turnQueue = new KMCQueue();        // queue of waiting players
        Random random = new Random();                  // creates a Random Number Generator



        // create 6 players
        KMCPlayer player1;
        KMCPlayer player2;
        KMCPlayer player3;
        KMCPlayer player4;
        KMCPlayer player5;
        KMCPlayer player6;

        private bool PlayerWinCheck
        {
            get { return PlayerWinCheck; }
        }

        private void PlaySingleTurn()
        {
            KMCPlayer currentPlayer = new KMCPlayer;

            // dequeue the player
            if (turnQueue.IsEmpty())
            {
                MessageBox.Show("Queue is empty.");

            }
            else
            {
                currentPlayer = turnQueue.Dequeue();
                MessageBox.Show(String.Format(" Removing Customer ID = {0}", currentPlayer));
                DisplayQueue(turnQueue, listBoxPlayerTurnData);
            }
        }

        private int RollDie()
        {
            return random.Next(1, 7); ;
        }


    }
}
