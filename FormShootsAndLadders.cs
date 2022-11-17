using System;
using System.Windows.Forms;

namespace ShootsAndLaddersKMC
{
    public partial class FormShootsAndLadders : Form
    {
        public FormShootsAndLadders()
        {
            InitializeComponent();

        }
        /// <summary>
        /// This routine should play a turn for a SINGLE player
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 


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

        private int RollDie()
        {
            return random.Next(1, 7); ;
        }
        private void PlaySingleTurn()
        {
            String player;

            KMCPlayer currentPlayer = new KMCPlayer(player);

            // dequeue the player
            if (turnQueue.IsEmpty())
            {
                MessageBox.Show("Queue is empty.");

            }
            else
            {
                player = turnQueue.Dequeue();
                MessageBox.Show(String.Format(" Removing Customer ID = {0}", player));
                DisplayQueue(turnQueue, listBoxPlayerTurnData);
            }
        }



        private void DisplayQueue(KMCQueue theQueue, ListBox theListBox)
        {
            // clear the queue
            theListBox.Items.Clear();

            // display header
            theListBox.Items.Add("Front of the Queue");

            // display the content of the queue
            foreach (String player in theQueue)
            {
                theListBox.Items.Add(player);
            }

            // display footer
            theListBox.Items.Add("Back of the Queue");

            // display stats
            theListBox.Items.Add(String.Empty);
            theListBox.Items.Add(String.Format("Count = {0}", theQueue.Count));
        }
        private void buttonPlayTurn_Click(object sender, EventArgs e)
        {
            PlaySingleTurn();

        }
    }
}

