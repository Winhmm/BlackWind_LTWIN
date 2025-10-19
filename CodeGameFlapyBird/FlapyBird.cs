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
        
        private Bird myBird1;
        private Pipe P1;
        private Ground Ground_;

        private int score = 0;
        private int HighScore = 0;

        private string savePath = Path.Combine(Application.StartupPath, "Save.txt");

        private SoundPlayer Die = new SoundPlayer("Sound\\die2.wav");
        private SoundPlayer HoverButton = new SoundPlayer("Sound\\ButtonHover.wav");

        private bool isJumping = false;
        private int jumpDuration = 0;

        private Random Rnd = new Random();
        public int Level { get; private set; } = 1;
        public int Map { get; private set; } = 1;
        public Game(int LevelFromHome , int MapFromHome)
        {
            Level = LevelFromHome;
            Map = MapFromHome;

            InitializeComponent();
            this.DoubleBuffered = true;

            // Map
            if (Level == 4)
            {
                if(Map == 1)
                {
                    this.BackgroundImage = Properties.Resources.NightMare1;
                }
                if (Map == 2) 
                {
                    this.BackgroundImage = Properties.Resources.NightMare2;
                }
            }
            else
            {
                if (Map == 1)
                {
                    this.BackgroundImage = Properties.Resources.BackGround3;
                }
                if (Map == 2)
                {
                    this.BackgroundImage = Properties.Resources.Forest;
                }
            }
            this.BackgroundImageLayout = ImageLayout.Stretch;

            myBird1 = new Bird(Bird1 , 3f , 0 , 9f);

            int Speed = (Level == 4 ? 18 : 7);
            P1 = new Pipe(Pt1, Pb1, this.Width, Level , Speed);   
            
            Ground_ = new Ground(Ground1 , Ground2 , 5);
        }
        // Load
        private void Game_Load(object sender, System.EventArgs e)
        {
            timer1.Interval = 16;
                

            if (!File.Exists(savePath))
            {
                File.WriteAllText(savePath, "BEST SCORE: 0");
            }

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
        private bool gameStarted = false;
        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            PressSpace.Visible = false;
            if (e.KeyCode == Keys.Space && !gameStarted)
            {
                gameStarted = true;
                timer1.Enabled = true;

            }
            if (e.KeyCode == Keys.Space)
            {
                Bird1.Image = Properties.Resources.Up;
                myBird1.Jump();
                isJumping = true;
                jumpDuration = 12;
            }

            if (myBird1.Dead)
            {
                if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
                {
                    PlayAgain.Focus();
                }
                else if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
                {
                    Quit.Focus();
                }
                 

            }

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void PlayAgain_Click(object sender, System.EventArgs e)
        {
            
            Game newGame = new Game(Level, Map);
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
