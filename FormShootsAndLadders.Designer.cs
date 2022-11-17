namespace ShootsAndLaddersKMC
{
    partial class FormShootsAndLadders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxPlayerTurnData = new System.Windows.Forms.ListBox();
            this.buttonPlayTurn = new System.Windows.Forms.Button();
            this.labelPlayerData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxPlayerTurnData
            // 
            this.listBoxPlayerTurnData.FormattingEnabled = true;
            this.listBoxPlayerTurnData.ItemHeight = 25;
            this.listBoxPlayerTurnData.Location = new System.Drawing.Point(30, 88);
            this.listBoxPlayerTurnData.Name = "listBoxPlayerTurnData";
            this.listBoxPlayerTurnData.Size = new System.Drawing.Size(629, 754);
            this.listBoxPlayerTurnData.TabIndex = 0;
            // 
            // buttonPlayTurn
            // 
            this.buttonPlayTurn.Location = new System.Drawing.Point(741, 753);
            this.buttonPlayTurn.Name = "buttonPlayTurn";
            this.buttonPlayTurn.Size = new System.Drawing.Size(222, 89);
            this.buttonPlayTurn.TabIndex = 1;
            this.buttonPlayTurn.Text = "Play Turn";
            this.buttonPlayTurn.UseVisualStyleBackColor = true;
            this.buttonPlayTurn.Click += new System.EventHandler(this.buttonPlayTurn_Click);
            // 
            // labelPlayerData
            // 
            this.labelPlayerData.AutoSize = true;
            this.labelPlayerData.Location = new System.Drawing.Point(25, 39);
            this.labelPlayerData.Name = "labelPlayerData";
            this.labelPlayerData.Size = new System.Drawing.Size(348, 50);
            this.labelPlayerData.TabIndex = 2;
            this.labelPlayerData.Text = "Player Turn Data";
            // 
            // FormShootsAndLadders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 900);
            this.Controls.Add(this.labelPlayerData);
            this.Controls.Add(this.buttonPlayTurn);
            this.Controls.Add(this.listBoxPlayerTurnData);
            this.Name = "FormShootsAndLadders";
            this.Text = "Shoots and Ladders";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPlayerTurnData;
        private System.Windows.Forms.Button buttonPlayTurn;
        private System.Windows.Forms.Label labelPlayerData;
    }
}

