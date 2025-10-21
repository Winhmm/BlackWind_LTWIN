using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace CodeGameFlapyBird
{
    public partial class Game : Form
    {
        
        private Bird myBird1 { get; set; }
        private ObstacleAndBonus P1 { get; set; }
        private Ground Ground_ { get; set; }

        private int score = 0;
        private int HighScore { get; set; } = 0;

        private string savePath = Path.Combine(Application.StartupPath, "Save.txt");
        private SoundPlayer HoverButton = new SoundPlayer("Sound\\ButtonHover.wav");

        private bool isJumping { get; set; } = false;
        private int jumpDuration { get; set; } = 0;

        private Random Rnd { get; set; } = new Random();
        public int Level { get; private set; } = 1;
        public int Speed { get; private set; } = 7;
        public Game(int LevelFromHome)
        {
            Level = LevelFromHome;

            InitializeComponent();
            this.DoubleBuffered = true;         

            myBird1 = new Bird(Bird1 , 3f , 0 , 9f);          
            P1 = new ObstacleAndBonus(Pt1, Pb1, Apple, FlyObstacle, this.Width, Level, Speed);             
            Ground_ = new Ground(Ground1 , Ground2 , 5 );
        }
        // Load
        private void Game_Load(object sender, System.EventArgs e)
        {
            timer1.Interval = 16;             
            if (!File.Exists(savePath))
            {
                File.WriteAllText(savePath, "BEST SCORE: 0");
            }

            if (Level == 1)
            {
                this.BackgroundImage = Properties.Resources.Level1BG;
                Pb1.Image = Properties.Resources.Level1PipeB;
                Pt1.Image = Properties.Resources.Level1PipeT;
                FlyObstacle.Image = Properties.Resources.Cloud;
                Ground1.Image = Properties.Resources.Level1Base;
                Ground2.Image = Properties.Resources.Level1Base;
                Best_score.ForeColor = Color.Red;
                Score.ForeColor = Color.Red;
            }
            else if (Level == 2)
            {
                this.BackgroundImage = Properties.Resources.Level2BG;
                Pb1.Image = Properties.Resources.Level2PipeB;
                Pt1.Image = Properties.Resources.Level2PipeT;
                FlyObstacle.Image = Properties.Resources.Cactus;
                Ground1.Image = Properties.Resources.Level2Base;
                Ground2.Image = Properties.Resources.Level2Base;
                Best_score.ForeColor = Color.White;
                Score.ForeColor = Color.White;
            }
            else if (Level == 3)
            {
                this.BackgroundImage = Properties.Resources.Level3BG;
                Pb1.Image = Properties.Resources.Level3PipeB;
                Pt1.Image = Properties.Resources.Level3PipeT;
                FlyObstacle.Image = Properties.Resources.Helicopter;
                Ground1.Image = Properties.Resources.Level3Base;
                Ground2.Image = Properties.Resources.Level3Base;
                Best_score.ForeColor = Color.LawnGreen;
                Score.ForeColor = Color.LawnGreen;
            }
            this.BackgroundImageLayout = ImageLayout.Stretch;

            // Lấy điểm từ trong txt
            string text = File.ReadAllText(savePath);
            Best_score.Text = text;

            string[] parts = text.Split(':');
            if (parts.Length == 2 && int.TryParse(parts[1].Trim(), out int value))
            {
                HighScore = value;
            }

        }
        

        // Thời gian
        private void timer1_Tick(object sender, System.EventArgs e)
        {
            Ground_.AutoMoveGround();           
            myBird1.Update(Ground1 , P1);
            P1.Update();          

            if (myBird1.Dead == true)
            {                
                timer1 .Stop();               
                GameOver.Visible = true;
                PlayAgain.Visible = true;
                Quit.Visible = true;
                Home.Visible = true;
                
                PlayAgain.Focus();      
            }

            P1.CheckScore(Bird1, ref score);          
            Score.Text = score.ToString();

            if (score < 10)
            {
                P1.IncreaseSpeed(7); // tốc độ ban đầu
            }
            else if (score < 20)
            {
                P1.IncreaseSpeed(10); // sau 10 điểm
            }
            else if (score < 30)
            {
                P1.IncreaseSpeed(13);
            }
            else if (score < 40)
            {
                P1.IncreaseSpeed(16);
            }
            else if (score < 50)
            {
                P1.IncreaseSpeed(19);
            }
            else
            {
                P1.IncreaseSpeed(21); // tối đa
            }

            // ghi điểm cao nhất
            if (HighScore < score)
            {
                HighScore = score;
                File.WriteAllText(savePath, $"BEST SCORE: {HighScore}");
                Best_score.Text = $"BEST SCORE: {HighScore}";
            }

            if (isJumping)
            {
                jumpDuration--;
                if (jumpDuration <= 0)
                {
                    isJumping = false;
                }
            }
            else
            {
                Bird1.Image = Properties.Resources.Down;
            }
        }
        
        
        // Thao tác để bay và bắt đầu
        private bool gameStarted { get; set; } = false;
        private void Game_KeyPress(object sender, KeyPressEventArgs e)
        {
            PressSpace.Visible = false;
            if (e.KeyChar == ' ' && !gameStarted)
            {
                gameStarted = true;
                timer1.Start();

            }
            if (e.KeyChar == ' ')
            {
                Bird1.Image = Properties.Resources.Up;
                myBird1.Jump();
                isJumping = true;
                jumpDuration = 12;
            }

            
        }    
        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
            if (myBird1.Dead)
            {
                PlayAgain.Focus();
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void PlayAgain_Click(object sender, System.EventArgs e)
        {
            
            Game newGame = new Game(Level);
            newGame.Show();
            this.Hide();
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
            Application.Exit();
        }

        private void Home_Click(object sender, System.EventArgs e)
        {
            Main Home = new Main();
            Home.Show();
            this.Hide();
        }

        private void PlayAgain_MouseHover(object sender, EventArgs e)
        {
            HoverButton.Play();
        }

        private void Home_MouseHover(object sender, EventArgs e)
        {
            HoverButton.Play();
        }

        private void Quit_MouseHover(object sender, EventArgs e)
        {
            HoverButton.Play();
        }

        
    }
}
