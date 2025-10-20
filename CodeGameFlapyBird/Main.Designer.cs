namespace CodeGameFlapyBird
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Ver = new System.Windows.Forms.Label();
            this.StartGame = new System.Windows.Forms.Button();
            this.ContinueGame = new System.Windows.Forms.Button();
            this.BestScore = new System.Windows.Forms.Label();
            this.Level = new System.Windows.Forms.ComboBox();
            this.Level_ = new System.Windows.Forms.Label();
            this.QuickHome = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Ver
            // 
            this.Ver.AutoSize = true;
            this.Ver.BackColor = System.Drawing.Color.Transparent;
            this.Ver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ver.Location = new System.Drawing.Point(468, 9);
            this.Ver.Name = "Ver";
            this.Ver.Size = new System.Drawing.Size(135, 22);
            this.Ver.TabIndex = 14;
            this.Ver.Text = "Version: 0.1.5";
            // 
            // StartGame
            // 
            this.StartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartGame.Location = new System.Drawing.Point(24, 300);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(261, 54);
            this.StartGame.TabIndex = 15;
            this.StartGame.Text = "Start New Game";
            this.StartGame.UseVisualStyleBackColor = true;
            this.StartGame.Click += new System.EventHandler(this.StartGame_Click);
            this.StartGame.MouseHover += new System.EventHandler(this.StartGame_MouseHover);
            // 
            // ContinueGame
            // 
            this.ContinueGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContinueGame.Location = new System.Drawing.Point(24, 384);
            this.ContinueGame.Name = "ContinueGame";
            this.ContinueGame.Size = new System.Drawing.Size(261, 54);
            this.ContinueGame.TabIndex = 16;
            this.ContinueGame.Text = "Continue Game";
            this.ContinueGame.UseVisualStyleBackColor = true;
            this.ContinueGame.Click += new System.EventHandler(this.ContinueGame_Click);
            this.ContinueGame.MouseHover += new System.EventHandler(this.ContinueGame_MouseHover);
            // 
            // BestScore
            // 
            this.BestScore.AutoSize = true;
            this.BestScore.BackColor = System.Drawing.Color.Transparent;
            this.BestScore.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BestScore.ForeColor = System.Drawing.Color.Red;
            this.BestScore.Location = new System.Drawing.Point(18, 246);
            this.BestScore.Name = "BestScore";
            this.BestScore.Size = new System.Drawing.Size(215, 33);
            this.BestScore.TabIndex = 17;
            this.BestScore.Text = "BEST SCORE: ";
            // 
            // Level
            // 
            this.Level.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Level.FormattingEnabled = true;
            this.Level.Location = new System.Drawing.Point(334, 321);
            this.Level.Name = "Level";
            this.Level.Size = new System.Drawing.Size(256, 33);
            this.Level.TabIndex = 19;
            this.Level.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Level_
            // 
            this.Level_.AutoSize = true;
            this.Level_.BackColor = System.Drawing.Color.Transparent;
            this.Level_.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Level_.ForeColor = System.Drawing.Color.Red;
            this.Level_.Location = new System.Drawing.Point(326, 282);
            this.Level_.Name = "Level_";
            this.Level_.Size = new System.Drawing.Size(64, 25);
            this.Level_.TabIndex = 20;
            this.Level_.Text = "Level";
            // 
            // QuickHome
            // 
            this.QuickHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuickHome.Location = new System.Drawing.Point(24, 477);
            this.QuickHome.Name = "QuickHome";
            this.QuickHome.Size = new System.Drawing.Size(261, 54);
            this.QuickHome.TabIndex = 21;
            this.QuickHome.Text = "Quit Game";
            this.QuickHome.UseVisualStyleBackColor = true;
            this.QuickHome.Click += new System.EventHandler(this.QuickHome_Click);
            this.QuickHome.MouseHover += new System.EventHandler(this.QuickHome_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CodeGameFlapyBird.Properties.Resources.HomeImg;
            this.pictureBox1.Location = new System.Drawing.Point(-138, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(599, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::CodeGameFlapyBird.Properties.Resources.DarkWind1;
            this.pictureBox2.Location = new System.Drawing.Point(261, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 91);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CodeGameFlapyBird.Properties.Resources.BackGround4;
            this.ClientSize = new System.Drawing.Size(626, 635);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.QuickHome);
            this.Controls.Add(this.Level_);
            this.Controls.Add(this.Level);
            this.Controls.Add(this.BestScore);
            this.Controls.Add(this.ContinueGame);
            this.Controls.Add(this.StartGame);
            this.Controls.Add(this.Ver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOME";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormHome_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Ver;
        private System.Windows.Forms.Button StartGame;
        private System.Windows.Forms.Button ContinueGame;
        private System.Windows.Forms.Label BestScore;
        private System.Windows.Forms.ComboBox Level;
        private System.Windows.Forms.Label Level_;
        private System.Windows.Forms.Button QuickHome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}