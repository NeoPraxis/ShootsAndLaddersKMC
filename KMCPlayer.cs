using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootsAndLaddersKMC
{
    internal class KMCPlayer

    {

        int[] gameBoard = new int[100] { 0, 38, 2, 3, 14, 5, 6, 7, 8, 31, 10,
                                        11, 12, 13, 14, 15, 6, 17, 18, 19, 20,
                                        21, 22, 23, 24, 25, 26, 27, 84, 29, 30,
                                        31, 32, 33, 34, 35, 44, 37, 38, 39, 40,
                                        41, 42, 43, 44, 45, 46, 26, 48, 11, 50,
                                        67, 52, 53, 54, 55, 53, 57, 58, 59, 60,
                                        61, 19, 63, 60, 65, 66, 67, 68, 69, 70,
                                        91, 72, 73, 74, 75, 76, 77, 78, 79, 100,
                                        82, 83, 84, 85, 86, 24, 88, 89, 90, 91,
                                        92, 73, 94, 75, 96, 97, 78, 99, 100};

        int playerPosition = 0;

        private int currentPosition = 0;

        private string playerName = null;

        private int diceResult = 0;

        private bool winner = false;

        public int CurrentPostion { get => currentPosition + 1; }
        public int DiceResult { get; private set; }

        //public string PlayerName { get => playerName; }

        public bool Winner { get; private set; }
            

        public void Roll()
        {
            Random random = new Random();
            diceResult = random.Next(1, 7);
        }

        public void UpdatePosition()
        {
            //if (playerPosition + diceResult  gameBoard())
            {

            }
        }




        //TODO need to keep track of player position
        public String player { get; set; }

        public KMCPlayer (string player)
        {
            this.player = player;

        }
    }
}
