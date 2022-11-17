using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private void buttonPlayTurn_Click(object sender, EventArgs e)
        {
            Game();
        }
    }
}
