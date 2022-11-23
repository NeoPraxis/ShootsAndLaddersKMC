/* ********************************************************************
 * Projct:      Chutes and Ladders
 * File:        KMCQueue.cs
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
 *                      - EDITED queue to accept players and not customers
 *    
 * *******************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootsAndLaddersKMC
{
    internal class KMCQueue : IEnumerable<String>
    {
        #region enum
        #endregion enum

        #region data
        #endregion data

        #region properties
        public KMCNode Front { get; set; }     // pointer to front of the queue
        public KMCNode Back { get; set; }      // pointer to back of the queue
        public int Count { get; private set; }  // number of the nodes in queue
        #endregion properties

        #region constructor

        /// <summary>
        /// This default constructor creates an empty queue
        /// </summary>
        public KMCQueue()
        {
            Front = null;
            Back = null;
            Count = 0;
        }
        #endregion constructor

        #region methods

        /// <summary>
        /// This method will remove the item at the the front of the queue.
        /// If the queue is empty this routine will return null.
        /// </summary>
        /// <returns></returns>
        public KMCPlayer Dequeue()
        {
            KMCPlayer item;

            if (IsEmpty())
            {
                item = null;
            }
            else
            {
                // queue is not empty, return first item
                item = Front.player;
                Front = Front.Next;
                Count--;
                // Count -= 1;
                // Count = Count - 1;
            }

            // return the data
            return item;
        }

        /// <summary>
        /// This routine will add a customer to the back of the queue
        /// with the passed customer identifier
        /// </summary>
        /// <param name="player"></param>
        public void Enqueue(KMCPlayer player)
        {
            // create a node with the new data
            KMCNode person = new KMCNode(player);

            if (IsEmpty())
            {
                // special case, update both pointers
                Front = person;
                Back = person;
            }
            else
            {
                // add new person to the end of the line, no cuts
                Back.Next = person;
                Back = Back.Next;
                person.Next = null;
            }

            // increment counter
            Count++;
        }

        /// <summary>
        /// This method returns true if the queue is empty
        /// </summary>
        /// <returns>True if the queue is empty, otherwise returns false</returns>
        public bool IsEmpty()
        {
            return Count == 0;
        }

        /// <summary>
        /// This method returns true if the queue is full
        /// </summary>
        /// <returns>True if the queue is full, otherwise returns false</returns>
        public bool IsFull()
        {
            // always return false, becuase we are using a link list
            return false;
        }

        #endregion methods

        #region IEnumerable
        /// <summary>
        /// This method allows for the traversal of the queue starting
        /// at front and ending at back, returning on item at a time
        /// to the calling method.
        /// </summary>
        /// <returns></returns>
        public IEnumerator<String> GetEnumerator()
        {
            // start at the front of the queue
            KMCNode current = Front;

            // traverse the queue
            while (current != null)
            {
                yield return current.ToString();
                current = current.Next;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion IEnumerable
    }
}
