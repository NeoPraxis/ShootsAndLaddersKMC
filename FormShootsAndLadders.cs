/* ********************************************************************
 * Projct:      Chutes and Ladders
 * File:        FormChutesAndLadders.cs
 * 
 * Language:    C#
 * 
 * Desription:  This program will play a simple LOGICAL version of chutes and ladders (NO FANCY UI)
 *              
 * College:     Husson University
 * Course:      IT 325
 * 
 * Edit History:
 * Ver   Who Date       Notes
 * ----- --- ---------- -----------------------------------------------
 * 0.1   KMC 11/20/2022 - initial writing
 *                      - created properties
 *                      - wrote default constructor
 * 0.2   KMC 11/21/2022 - added array
 *                      - added add player logic
 *                      - added turn logic
 *                      - added dice logic
 *                      - added button turn logic
 *                      - added button play game logic
 *                      - CHANGED local player, to using player class instead
 * *******************************************************************/
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
        int[] gameBoard = new int[101] { 0, 38, 2, 3, 14, 5, 6, 7, 8, 31, 10,
                                        11, 12, 13, 14, 15, 6, 17, 18, 19, 20,
                                        21, 22, 23, 24, 25, 26, 27, 84, 29, 30,
                                        31, 32, 33, 34, 35, 44, 37, 38, 39, 40,
                                        41, 42, 43, 44, 45, 46, 26, 48, 11, 50,
                                        67, 52, 53, 54, 55, 53, 57, 58, 59, 60,
                                        61, 19, 63, 60, 65, 66, 67, 68, 69, 70,
                                        91, 72, 73, 74, 75, 76, 77, 78, 79, 100,
                                        81, 82, 83, 84, 85, 86, 24, 88, 89, 90,
                                        91, 92, 73, 94, 75, 96, 97, 78, 99, 100};

        // create a turn queue for the users/players
        KMCQueue userTurnQueue = new KMCQueue();


        // TODO I could not figure out how to do the win condition correctly ***
/*
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
        }*/

        #endregion data

        #region contructor
        public FormShootsAndLadders()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method rolls dice and returns the value of the dice
        /// </summary>
        /// <returns></returns>
        private int RollDice()
        {
            Random rnd = new Random();
            int rollResult = rnd.Next(1, 7);
            return rollResult;
        }
        #endregion constructor

        #region properties
        #endregion properties

        #region events
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

        /// <summary>
        /// This method adds players to the player turn queue
        /// </summary>
        public void AddPlayers()
        {

            // initialize number of users
            string[] users = new string[6] {"Player 6", "Player 1", "Player 2",
                                            "Player 3", "Player 4", "Player 5", };

            //int[] userDieData = new int[100];

            int userCount;
            //KMCQueue playerTurn = new KMCQueue();

            // total count of the users entered by the playerName


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
                    string playerName = users[index];
                    KMCPlayer player = new KMCPlayer(playerName);
                    
                    userTurnQueue.Enqueue(player);
                    listBoxPlayerTurnData.Items.Add(playerName);
                }
            }
        }
        /// <summary>
        /// This method displays the queue
        /// </summary>
        /// <param name="theTurnQueue"></param>
        /// <param name="theListBox"></param>
        private void DisplayQueue(KMCQueue theTurnQueue, ListBox theListBox)
        {
            // clear the queue
            theListBox.Items.Clear();

            // display the content of the queue
            
            theListBox.Items.Add(theTurnQueue.First());

            // display stats
            theListBox.Items.Add(String.Empty);
        }

        /// <summary>
        /// This method plays a SINGLE turn
        /// </summary>
        public void PlayTurn()
        {
            int dieResult;
            
            // create a player to be used in the queue
            KMCPlayer tempPlayer = userTurnQueue.Dequeue();
          
            // have a more accurate 
            dieResult = RollDice();
            
            // If the die result, is less than the board length, add (THIS HELPS SO YOU HAVE TO WIN WITH EXACT DIE ROLL)
            if (tempPlayer.CurrentPostion + dieResult < gameBoard.Length)
            {
                // Update players position 
                if (gameBoard[tempPlayer.CurrentPostion + dieResult] == 0)
                {
                    tempPlayer.UpdatePosition(tempPlayer.CurrentPostion + dieResult);
                    
                }
                else
                {
                    tempPlayer.UpdatePosition(gameBoard[dieResult + tempPlayer.CurrentPostion]);
                    
                }
                // display new results
                DisplayQueue(userTurnQueue, listBoxPlayerTurnData);
            }

            // Enqueue the next player
            userTurnQueue.Enqueue(tempPlayer);

            // Display the stats for the roll
            listBoxPlayerTurnData.Items.Add(tempPlayer.PlayerName.ToString() + " rolled a " + dieResult.ToString() + "," + " and is now at position: " + tempPlayer.CurrentPostion);

            // Win check for current player
            if (tempPlayer.CurrentPostion == 100)
            {
                MessageBox.Show(tempPlayer.PlayerName.ToString() + " Won the game!");
            }
        }
        #endregion methods

    }
}
