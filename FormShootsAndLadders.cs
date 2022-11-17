using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace ShootsAndLaddersKMC
{
    public partial class FormShootsAndLadders : Form
    {

        #region data
        // this is an array of all the spaces and what their values are if you land
        // on a certain space
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


        //int numberOfUsers = 0;

        KMCQueue userTurnQueue = new KMCQueue();

        private int playerPosition = 0;

        public int PlayerPosition { get => playerPosition + 1; }

        public bool winner()
        {
            if (playerPosition != 100)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        #endregion data

        #region contructor
        public FormShootsAndLadders()
        {
            InitializeComponent();
        }

        private int RollDice()
        {
            Random rnd = new Random();
            Thread.Sleep(30);
            int rollResult = rnd.Next(1, 7);
            return rollResult;
        }
        #endregion constructor

        #region properties
        #endregion properties

        #region events


        private void FormShootsAndLadders_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// This button starts a new game upon click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPlayNewGame_Click(object sender, EventArgs e)
        {
            AddPlayers();
        }

        /// <summary>
        /// This button plays a single turn upon click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPlayTurn_Click(object sender, EventArgs e)
        {
            PlayTurn();
        }
        #endregion events

        #region methods

        public void AddPlayers()
        {

            // initialize number of users
            string[] users = new string[6] {"p1", "p2", "p3",
                                            "p4", "p5", "p6", };

            //int[] userDieData = new int[100];

            int userCount;
            //KMCQueue playerTurn = new KMCQueue();

            // total count of the users entered by the user


            // convert the info to int to be used
            userCount = Convert.ToInt32(textBoxNumberOfUsers.Text);

            // error checking for values entered greater than 6
            if (userCount > 6)
            {
                MessageBox.Show("Users must not exceed 6");
            }

            // error checking for values entered less than 2
            else if (userCount < 2)
            {
                MessageBox.Show("Users must not be less than 2");
            }

            // if values are valid, enter for look to enqueue players into game
            else
            {
                for (int index = 0; index < userCount; index++)
                {

                    string user = users[index];
                    userTurnQueue.Enqueue(user);
                    listBoxPlayerTurnData.Items.Add(user);
                }
            }
        }
        private void DisplayQueue(KMCQueue theTurnQueue, ListBox theListBox)
        {
            // clear the queue
            theListBox.Items.Clear();

            // display header
            //theListBox.Items.Add("Is Up Next: ");

            // display the content of the queue
            //foreach (String player in theTurnQueue)
            //{
            theListBox.Items.Add(theTurnQueue.First());
            //}

            // display footer
            //theListBox.Items.Add("Back of the Queue");

            // display stats
            theListBox.Items.Add(String.Empty);
            //theListBox.Items.Add(String.Format("Count = {0}", theTurnQueue.Count));
        }

        public void PlayTurn()
        {
            int dieResult;
            string tempPlayer;

            dieResult = RollDice();



            if (playerPosition + dieResult < gameBoard.Length)
            {


                if (gameBoard[playerPosition + dieResult] == 0)
                {
                    playerPosition = playerPosition+ dieResult;
                    DisplayQueue(userTurnQueue, listBoxPlayerTurnData);
                }
                else
                {
                    playerPosition = gameBoard[dieResult + playerPosition];
                    DisplayQueue(userTurnQueue, listBoxPlayerTurnData);
                }
            }

            tempPlayer = userTurnQueue.Dequeue();
            userTurnQueue.Enqueue(tempPlayer);
            listBoxPlayerTurnData.Items.Add(playerPosition).ToString();

            if (playerPosition == gameBoard.Length)
            {
                MessageBox.Show("winner");
            }
            //playerPosition = playerPosition += dieResult;
            //playerPosition = gameBoard[playerPosition];

            


            // queue through players until win


        }

        #endregion methods



    }
}
