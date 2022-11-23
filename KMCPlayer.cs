/* ********************************************************************
 * Projct:      Chutes and Ladders
 * File:        KMCPlayer.cs
 * 
 * Language:    C#
 * 
 * Desription:  This program will play a simple version of chutes and ladders
 *              
 * College:     Husson University
 * Course:      IT 325
 * 
 * Edit History:
 * Ver   Who Date       Notes
 * ----- --- ---------- -----------------------------------------------
 * 0.1   KMC 11/20/2022 - initial writing
 *                      - created properties
 *                      - wrote default constructors
 * 0.2   KMC 11/21/2022 - refactored whole class to be used
 *                      - added all player logic for a player of the game
 *                        player position, etc...
 *    
 * *******************************************************************/
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
