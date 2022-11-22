using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootsAndLaddersKMC
{
    internal class KMCNode
    {
        #region enum
        #endregion enum

        #region data
        #endregion data

        #region properties
        public KMCPlayer player { get; set; }      // customer identifier
        public KMCNode Next { get; set; }       // pointer to the next customer
        #endregion properties

        #region constructor
        /// <summary>
        /// This routine initializes a Customer Node using the Customer Identifier
        /// </summary>
        /// <param name="customerID"></param>
        public KMCNode(KMCPlayer tempPlayer)
        {
            player = tempPlayer;
            Next = null;
        }

        #endregion constructor

        #region methods
        /// <summary>
        /// This method outputs the node in a generic format
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("Current Player = {0}, Next Player = {1}", this.player.playerName,
                this.Next == null ? "end of queue" : this.Next.player.playerName);
        }
        #endregion methods
    }
}
