using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeGameFlapyBird
{
    public partial class Main : Form
    {
        private int selectedLevel;

        private string savePath = Path.Combine(Application.StartupPath, "Save.txt");
        private SoundPlayer HoverButton = new SoundPlayer("Sound\\ButtonHover.wav");
        public Main()
        {
            InitializeComponent();           

            Level.Items.Add("Level 1 (Beach)");
            Level.Items.Add("Level 2 (Desert)");
            Level.Items.Add("Level 3 (City)");
          
            Level.SelectedIndex = 0;

            if (!File.Exists(savePath))
            {
                File.WriteAllText(savePath, "BEST SCORE: 0");
            }

            string text = File.ReadAllText(savePath);
            BestScore.Text = text;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedLevel = Level.SelectedIndex + 1;
            if (selectedLevel == 1)
            {
                this.BackgroundImage = Properties.Resources.Level1BG;
                Pipe.Image = Properties.Resources.Level1PipeB;
                Base.Image = Properties.Resources.Level1Base;
                BestScore.ForeColor = Color.Red;
                Level_.ForeColor = Color.Red;
            }
            else if (selectedLevel == 2)
            {
                this.BackgroundImage = Properties.Resources.Level2BG;
                Pipe.Image = Properties.Resources.Level2PipeB;
                Base.Image = Properties.Resources.Level2Base;
                BestScore.ForeColor = Color.White;
                Level_.ForeColor = Color.White;
            }
            else if (selectedLevel == 3)
            {
                this.BackgroundImage = Properties.Resources.Level3BG;
                Pipe.Image = Properties.Resources.Level3PipeB;
                Base.Image = Properties.Resources.Level3Base;
                BestScore.ForeColor = Color.LawnGreen;
                Level_.ForeColor = Color.LawnGreen;
            }
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        
        private void BackGroundHome_Click(object sender, EventArgs e)
        {
            Level_.Focus();
        }

        private void QuickHome_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void StartGame_Click(object sender, EventArgs e)
        {
            File.WriteAllText(savePath, "BEST SCORE: 0");
            int level = Level.SelectedIndex + 1;
            Game Gem = new Game(level);
            Gem.Show();
            this.Hide();
        }
        private void ContinueGame_Click(object sender, EventArgs e)
        {
            int level = Level.SelectedIndex + 1;
            Game Gem = new Game(level);           
            Gem.Show();
            this.Hide();
        }

        private void FormHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void StartGame_MouseHover(object sender, EventArgs e)
        {
            HoverButton.Play();

        }

        private void ContinueGame_MouseHover(object sender, EventArgs e)
        {
            HoverButton.Play();
        }

        private void QuickHome_MouseHover(object sender, EventArgs e)
        {
            HoverButton.Play();
        }
    }
}
