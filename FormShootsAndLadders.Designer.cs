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
            this.labelPlayerData = new System.Windows.Forms.Label();
            this.buttonPlayNewGame = new System.Windows.Forms.Button();
            this.buttonPlayTurn = new System.Windows.Forms.Button();
            this.textBoxNumberOfUsers = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxPlayerTurnData
            // 
            this.listBoxPlayerTurnData.FormattingEnabled = true;
            this.listBoxPlayerTurnData.Location = new System.Drawing.Point(15, 46);
            this.listBoxPlayerTurnData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxPlayerTurnData.Name = "listBoxPlayerTurnData";
            this.listBoxPlayerTurnData.Size = new System.Drawing.Size(316, 303);
            this.listBoxPlayerTurnData.TabIndex = 0;
            // 
            // labelPlayerData
            // 
            this.labelPlayerData.AutoSize = true;
            this.labelPlayerData.Location = new System.Drawing.Point(12, 20);
            this.labelPlayerData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPlayerData.Name = "labelPlayerData";
            this.labelPlayerData.Size = new System.Drawing.Size(87, 13);
            this.labelPlayerData.TabIndex = 2;
            this.labelPlayerData.Text = "Player Turn Data";
            // 
            // buttonPlayNewGame
            // 
            this.buttonPlayNewGame.Location = new System.Drawing.Point(15, 353);
            this.buttonPlayNewGame.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPlayNewGame.Name = "buttonPlayNewGame";
            this.buttonPlayNewGame.Size = new System.Drawing.Size(111, 46);
            this.buttonPlayNewGame.TabIndex = 3;
            this.buttonPlayNewGame.Text = "Play New Game";
            this.buttonPlayNewGame.UseVisualStyleBackColor = true;
            this.buttonPlayNewGame.Click += new System.EventHandler(this.buttonPlayNewGame_Click);
            // 
            // buttonPlayTurn
            // 
            this.buttonPlayTurn.Location = new System.Drawing.Point(220, 353);
            this.buttonPlayTurn.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPlayTurn.Name = "buttonPlayTurn";
            this.buttonPlayTurn.Size = new System.Drawing.Size(111, 46);
            this.buttonPlayTurn.TabIndex = 1;
            this.buttonPlayTurn.Text = "Play Turn";
            this.buttonPlayTurn.UseVisualStyleBackColor = true;
            this.buttonPlayTurn.Click += new System.EventHandler(this.buttonPlayTurn_Click);
            // 
            // textBoxNumberOfUsers
            // 
            this.textBoxNumberOfUsers.Location = new System.Drawing.Point(370, 63);
            this.textBoxNumberOfUsers.Name = "textBoxNumberOfUsers";
            this.textBoxNumberOfUsers.Size = new System.Drawing.Size(93, 20);
            this.textBoxNumberOfUsers.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(367, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Number of Players:";
            // 
            // FormShootsAndLadders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 468);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNumberOfUsers);
            this.Controls.Add(this.buttonPlayNewGame);
            this.Controls.Add(this.labelPlayerData);
            this.Controls.Add(this.buttonPlayTurn);
            this.Controls.Add(this.listBoxPlayerTurnData);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormShootsAndLadders";
            this.Text = "Shoots and Ladders";
            this.Load += new System.EventHandler(this.FormShootsAndLadders_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPlayerTurnData;
        private System.Windows.Forms.Label labelPlayerData;
        private System.Windows.Forms.Button buttonPlayNewGame;
        private System.Windows.Forms.Button buttonPlayTurn;
        private System.Windows.Forms.TextBox textBoxNumberOfUsers;
        private System.Windows.Forms.Label label1;
    }
}

