namespace TicTacToe
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gameBoardImg = new System.Windows.Forms.PictureBox();
            this.newGameButton = new System.Windows.Forms.Button();
            this.oPlayer = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.oWins = new System.Windows.Forms.Label();
            this.oTurn = new System.Windows.Forms.Label();
            this.xWins = new System.Windows.Forms.Label();
            this.xTurn = new System.Windows.Forms.Label();
            this.box1 = new System.Windows.Forms.PictureBox();
            this.box4 = new System.Windows.Forms.PictureBox();
            this.box5 = new System.Windows.Forms.PictureBox();
            this.box7 = new System.Windows.Forms.PictureBox();
            this.box8 = new System.Windows.Forms.PictureBox();
            this.box2 = new System.Windows.Forms.PictureBox();
            this.box6 = new System.Windows.Forms.PictureBox();
            this.box9 = new System.Windows.Forms.PictureBox();
            this.box3 = new System.Windows.Forms.PictureBox();
            this.winnerLabel = new System.Windows.Forms.Label();
            this.resetWinButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gameBoardImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box3)).BeginInit();
            this.SuspendLayout();
            // 
            // gameBoardImg
            // 
            this.gameBoardImg.Image = ((System.Drawing.Image)(resources.GetObject("gameBoardImg.Image")));
            this.gameBoardImg.Location = new System.Drawing.Point(219, 29);
            this.gameBoardImg.Name = "gameBoardImg";
            this.gameBoardImg.Size = new System.Drawing.Size(406, 406);
            this.gameBoardImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gameBoardImg.TabIndex = 0;
            this.gameBoardImg.TabStop = false;
            // 
            // newGameButton
            // 
            this.newGameButton.Location = new System.Drawing.Point(146, 478);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(184, 80);
            this.newGameButton.TabIndex = 1;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // oPlayer
            // 
            this.oPlayer.Image = ((System.Drawing.Image)(resources.GetObject("oPlayer.Image")));
            this.oPlayer.Location = new System.Drawing.Point(12, 41);
            this.oPlayer.Name = "oPlayer";
            this.oPlayer.Size = new System.Drawing.Size(168, 174);
            this.oPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.oPlayer.TabIndex = 2;
            this.oPlayer.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(672, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(168, 174);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // oWins
            // 
            this.oWins.AutoSize = true;
            this.oWins.Location = new System.Drawing.Point(9, 275);
            this.oWins.Name = "oWins";
            this.oWins.Size = new System.Drawing.Size(55, 17);
            this.oWins.TabIndex = 4;
            this.oWins.Text = "Wins: 0";
            // 
            // oTurn
            // 
            this.oTurn.AutoSize = true;
            this.oTurn.Location = new System.Drawing.Point(12, 318);
            this.oTurn.Name = "oTurn";
            this.oTurn.Size = new System.Drawing.Size(70, 17);
            this.oTurn.TabIndex = 5;
            this.oTurn.Text = "Your turn!";
            // 
            // xWins
            // 
            this.xWins.AutoSize = true;
            this.xWins.Location = new System.Drawing.Point(672, 275);
            this.xWins.Name = "xWins";
            this.xWins.Size = new System.Drawing.Size(55, 17);
            this.xWins.TabIndex = 6;
            this.xWins.Text = "Wins: 0";
            // 
            // xTurn
            // 
            this.xTurn.AutoSize = true;
            this.xTurn.Location = new System.Drawing.Point(672, 318);
            this.xTurn.Name = "xTurn";
            this.xTurn.Size = new System.Drawing.Size(70, 17);
            this.xTurn.TabIndex = 7;
            this.xTurn.Text = "Your turn!";
            this.xTurn.Visible = false;
            // 
            // box1
            // 
            this.box1.ImageLocation = "";
            this.box1.Location = new System.Drawing.Point(234, 41);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(96, 95);
            this.box1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box1.TabIndex = 8;
            this.box1.TabStop = false;
            this.box1.Click += new System.EventHandler(this.box1_Click);
            // 
            // box4
            // 
            this.box4.Location = new System.Drawing.Point(234, 188);
            this.box4.Name = "box4";
            this.box4.Size = new System.Drawing.Size(96, 95);
            this.box4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box4.TabIndex = 9;
            this.box4.TabStop = false;
            this.box4.Click += new System.EventHandler(this.box4_Click);
            // 
            // box5
            // 
            this.box5.Location = new System.Drawing.Point(374, 188);
            this.box5.Name = "box5";
            this.box5.Size = new System.Drawing.Size(96, 95);
            this.box5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box5.TabIndex = 10;
            this.box5.TabStop = false;
            this.box5.Click += new System.EventHandler(this.box5_Click);
            // 
            // box7
            // 
            this.box7.Location = new System.Drawing.Point(234, 318);
            this.box7.Name = "box7";
            this.box7.Size = new System.Drawing.Size(96, 95);
            this.box7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box7.TabIndex = 11;
            this.box7.TabStop = false;
            this.box7.Click += new System.EventHandler(this.box7_Click);
            // 
            // box8
            // 
            this.box8.Location = new System.Drawing.Point(374, 318);
            this.box8.Name = "box8";
            this.box8.Size = new System.Drawing.Size(96, 95);
            this.box8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box8.TabIndex = 12;
            this.box8.TabStop = false;
            this.box8.Click += new System.EventHandler(this.box8_Click);
            // 
            // box2
            // 
            this.box2.Location = new System.Drawing.Point(374, 41);
            this.box2.Name = "box2";
            this.box2.Size = new System.Drawing.Size(96, 95);
            this.box2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box2.TabIndex = 13;
            this.box2.TabStop = false;
            this.box2.Click += new System.EventHandler(this.box2_Click);
            // 
            // box6
            // 
            this.box6.Location = new System.Drawing.Point(511, 188);
            this.box6.Name = "box6";
            this.box6.Size = new System.Drawing.Size(96, 95);
            this.box6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box6.TabIndex = 14;
            this.box6.TabStop = false;
            this.box6.Click += new System.EventHandler(this.box6_Click);
            // 
            // box9
            // 
            this.box9.Location = new System.Drawing.Point(511, 318);
            this.box9.Name = "box9";
            this.box9.Size = new System.Drawing.Size(96, 95);
            this.box9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box9.TabIndex = 15;
            this.box9.TabStop = false;
            this.box9.Click += new System.EventHandler(this.box9_Click);
            // 
            // box3
            // 
            this.box3.Location = new System.Drawing.Point(511, 41);
            this.box3.Name = "box3";
            this.box3.Size = new System.Drawing.Size(96, 95);
            this.box3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box3.TabIndex = 16;
            this.box3.TabStop = false;
            this.box3.Click += new System.EventHandler(this.box3_Click);
            // 
            // winnerLabel
            // 
            this.winnerLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.winnerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winnerLabel.Location = new System.Drawing.Point(0, 0);
            this.winnerLabel.Name = "winnerLabel";
            this.winnerLabel.Size = new System.Drawing.Size(852, 113);
            this.winnerLabel.TabIndex = 17;
            this.winnerLabel.Text = "place";
            this.winnerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.winnerLabel.Visible = false;
            // 
            // resetWinButton
            // 
            this.resetWinButton.Location = new System.Drawing.Point(511, 478);
            this.resetWinButton.Name = "resetWinButton";
            this.resetWinButton.Size = new System.Drawing.Size(184, 80);
            this.resetWinButton.TabIndex = 18;
            this.resetWinButton.Text = "Reset Win Counter";
            this.resetWinButton.UseVisualStyleBackColor = true;
            this.resetWinButton.Click += new System.EventHandler(this.resetWinButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 594);
            this.Controls.Add(this.resetWinButton);
            this.Controls.Add(this.winnerLabel);
            this.Controls.Add(this.box3);
            this.Controls.Add(this.box9);
            this.Controls.Add(this.box6);
            this.Controls.Add(this.box2);
            this.Controls.Add(this.box8);
            this.Controls.Add(this.box7);
            this.Controls.Add(this.box5);
            this.Controls.Add(this.box4);
            this.Controls.Add(this.box1);
            this.Controls.Add(this.xTurn);
            this.Controls.Add(this.xWins);
            this.Controls.Add(this.oTurn);
            this.Controls.Add(this.oWins);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.oPlayer);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.gameBoardImg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gameBoardImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox gameBoardImg;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.PictureBox oPlayer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label oWins;
        private System.Windows.Forms.Label oTurn;
        private System.Windows.Forms.Label xWins;
        private System.Windows.Forms.Label xTurn;
        private System.Windows.Forms.PictureBox box1;
        private System.Windows.Forms.PictureBox box4;
        private System.Windows.Forms.PictureBox box5;
        private System.Windows.Forms.PictureBox box7;
        private System.Windows.Forms.PictureBox box8;
        private System.Windows.Forms.PictureBox box2;
        private System.Windows.Forms.PictureBox box6;
        private System.Windows.Forms.PictureBox box9;
        private System.Windows.Forms.PictureBox box3;
        private System.Windows.Forms.Label winnerLabel;
        private System.Windows.Forms.Button resetWinButton;
    }
}

