namespace CodeGameFlapyBird
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.Score = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Best_score = new System.Windows.Forms.Label();
            this.PlayAgain = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.Ground2 = new System.Windows.Forms.PictureBox();
            this.Ground1 = new System.Windows.Forms.PictureBox();
            this.Pb1 = new System.Windows.Forms.PictureBox();
            this.PressSpace = new System.Windows.Forms.PictureBox();
            this.GameOver = new System.Windows.Forms.PictureBox();
            this.Pt1 = new System.Windows.Forms.PictureBox();
            this.Bird1 = new System.Windows.Forms.PictureBox();
            this.Home = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Ground2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PressSpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameOver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird1)).BeginInit();
            this.SuspendLayout();
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.BackColor = System.Drawing.Color.Transparent;
            this.Score.Font = new System.Drawing.Font("Stencil", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.ForeColor = System.Drawing.Color.Red;
            this.Score.Location = new System.Drawing.Point(12, 36);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(86, 95);
            this.Score.TabIndex = 2;
            this.Score.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Best_score
            // 
            this.Best_score.AutoSize = true;
            this.Best_score.BackColor = System.Drawing.Color.Transparent;
            this.Best_score.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Best_score.ForeColor = System.Drawing.Color.Red;
            this.Best_score.Location = new System.Drawing.Point(12, 9);
            this.Best_score.Name = "Best_score";
            this.Best_score.Size = new System.Drawing.Size(169, 27);
            this.Best_score.TabIndex = 6;
            this.Best_score.Text = "BEST SCORE: 0";
            // 
            // PlayAgain
            // 
            this.PlayAgain.BackColor = System.Drawing.Color.White;
            this.PlayAgain.FlatAppearance.BorderSize = 0;
            this.PlayAgain.Font = new System.Drawing.Font("Tahoma", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayAgain.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PlayAgain.Location = new System.Drawing.Point(190, 350);
            this.PlayAgain.Name = "PlayAgain";
            this.PlayAgain.Size = new System.Drawing.Size(250, 57);
            this.PlayAgain.TabIndex = 10;
            this.PlayAgain.Text = "Play Again";
            this.PlayAgain.UseVisualStyleBackColor = false;
            this.PlayAgain.Visible = false;
            this.PlayAgain.Click += new System.EventHandler(this.PlayAgain_Click);
            this.PlayAgain.MouseHover += new System.EventHandler(this.PlayAgain_MouseHover);
            // 
            // Quit
            // 
            this.Quit.BackColor = System.Drawing.Color.White;
            this.Quit.FlatAppearance.BorderSize = 0;
            this.Quit.Font = new System.Drawing.Font("Tahoma", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Quit.Location = new System.Drawing.Point(190, 538);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(250, 57);
            this.Quit.TabIndex = 11;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = false;
            this.Quit.Visible = false;
            this.Quit.Click += new System.EventHandler(this.button1_Click);
            this.Quit.MouseHover += new System.EventHandler(this.Quit_MouseHover);
            // 
            // Ground2
            // 
            this.Ground2.Image = ((System.Drawing.Image)(resources.GetObject("Ground2.Image")));
            this.Ground2.Location = new System.Drawing.Point(493, 570);
            this.Ground2.Name = "Ground2";
            this.Ground2.Size = new System.Drawing.Size(777, 112);
            this.Ground2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground2.TabIndex = 7;
            this.Ground2.TabStop = false;
            // 
            // Ground1
            // 
            this.Ground1.Image = ((System.Drawing.Image)(resources.GetObject("Ground1.Image")));
            this.Ground1.Location = new System.Drawing.Point(-200, 570);
            this.Ground1.Name = "Ground1";
            this.Ground1.Size = new System.Drawing.Size(781, 111);
            this.Ground1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground1.TabIndex = 3;
            this.Ground1.TabStop = false;
            // 
            // Pb1
            // 
            this.Pb1.BackColor = System.Drawing.Color.Transparent;
            this.Pb1.Image = ((System.Drawing.Image)(resources.GetObject("Pb1.Image")));
            this.Pb1.Location = new System.Drawing.Point(458, 446);
            this.Pb1.Name = "Pb1";
            this.Pb1.Size = new System.Drawing.Size(70, 500);
            this.Pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb1.TabIndex = 5;
            this.Pb1.TabStop = false;
            // 
            // PressSpace
            // 
            this.PressSpace.BackColor = System.Drawing.Color.Transparent;
            this.PressSpace.Image = global::CodeGameFlapyBird.Properties.Resources.PressSpace2;
            this.PressSpace.Location = new System.Drawing.Point(72, 312);
            this.PressSpace.Name = "PressSpace";
            this.PressSpace.Size = new System.Drawing.Size(425, 55);
            this.PressSpace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PressSpace.TabIndex = 8;
            this.PressSpace.TabStop = false;
            // 
            // GameOver
            // 
            this.GameOver.BackColor = System.Drawing.Color.Transparent;
            this.GameOver.Image = global::CodeGameFlapyBird.Properties.Resources.Game_over2;
            this.GameOver.Location = new System.Drawing.Point(72, 170);
            this.GameOver.Name = "GameOver";
            this.GameOver.Size = new System.Drawing.Size(493, 134);
            this.GameOver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GameOver.TabIndex = 9;
            this.GameOver.TabStop = false;
            this.GameOver.Visible = false;
            // 
            // Pt1
            // 
            this.Pt1.BackColor = System.Drawing.Color.Transparent;
            this.Pt1.Image = ((System.Drawing.Image)(resources.GetObject("Pt1.Image")));
            this.Pt1.Location = new System.Drawing.Point(468, -324);
            this.Pt1.Name = "Pt1";
            this.Pt1.Size = new System.Drawing.Size(70, 500);
            this.Pt1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pt1.TabIndex = 4;
            this.Pt1.TabStop = false;
            // 
            // Bird1
            // 
            this.Bird1.BackColor = System.Drawing.Color.Transparent;
            this.Bird1.Image = global::CodeGameFlapyBird.Properties.Resources.Horizontal;
            this.Bird1.Location = new System.Drawing.Point(81, 255);
            this.Bird1.Name = "Bird1";
            this.Bird1.Size = new System.Drawing.Size(65, 49);
            this.Bird1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Bird1.TabIndex = 1;
            this.Bird1.TabStop = false;
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.White;
            this.Home.FlatAppearance.BorderSize = 0;
            this.Home.Font = new System.Drawing.Font("Tahoma", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Home.Location = new System.Drawing.Point(190, 446);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(250, 57);
            this.Home.TabIndex = 13;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Visible = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            this.Home.MouseHover += new System.EventHandler(this.Home_MouseHover);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::CodeGameFlapyBird.Properties.Resources.BackGround4;
            this.ClientSize = new System.Drawing.Size(626, 635);
            this.Controls.Add(this.GameOver);
            this.Controls.Add(this.Bird1);
            this.Controls.Add(this.Best_score);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.PlayAgain);
            this.Controls.Add(this.Ground2);
            this.Controls.Add(this.Ground1);
            this.Controls.Add(this.Pb1);
            this.Controls.Add(this.PressSpace);
            this.Controls.Add(this.Pt1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flapy Bird";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game_FormClosing);
            this.Load += new System.EventHandler(this.Game_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Game_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Game_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Ground2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PressSpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameOver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Bird1;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.PictureBox Ground1;
        private System.Windows.Forms.PictureBox Pt1;
        private System.Windows.Forms.PictureBox Pb1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Best_score;
        private System.Windows.Forms.PictureBox Ground2;
        private System.Windows.Forms.PictureBox PressSpace;
        private System.Windows.Forms.PictureBox GameOver;
        private System.Windows.Forms.Button PlayAgain;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Button Home;
    }
}

