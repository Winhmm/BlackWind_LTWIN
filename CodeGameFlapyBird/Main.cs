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
        private int selectedStyle;

        private string savePath = Path.Combine(Application.StartupPath, "Save.txt");
        private SoundPlayer HoverButton = new SoundPlayer("Sound\\ButtonHover.wav");
        public Main()
        {
            InitializeComponent();           

            Level.Items.Add("Easy");
            Level.Items.Add("Medium");
            Level.Items.Add("Hard");
            Level.Items.Add("Nightmare");

            Style.Items.Add("Map 1");
            Style.Items.Add("Map 2");

            Style.SelectedIndex = 0;
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

            if(selectedLevel == 4)
            {
                if(selectedStyle == 1)
                {
                    this.BackgroundImage = Properties.Resources.NightMare1;
                }
                if (selectedStyle == 2) 
                {
                    this.BackgroundImage = Properties.Resources.NightMare2;
                }
            }
            else
            {
                if (selectedStyle == 1)
                {
                    this.BackgroundImage = Properties.Resources.BackGround3;
                }
                if (selectedStyle == 2)
                {
                    this.BackgroundImage = Properties.Resources.Forest;
                }
            }
        }
        private void Style_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedStyle = Style.SelectedIndex + 1;
            if (selectedStyle == 1)
            {
                if (selectedLevel == 4)
                {
                    this.BackgroundImage = Properties.Resources.NightMare1;
                }
                else
                {
                    this.BackgroundImage = Properties.Resources.BackGround3;
                }
            }
            else
            {

                if (selectedLevel == 4)
                {
                    this.BackgroundImage = Properties.Resources.NightMare2;
                }
                else
                {
                    this.BackgroundImage = Properties.Resources.Forest;
                }
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
            int Map = Style.SelectedIndex + 1;
            Game Gem = new Game(level, Map);
            Gem.Show();
            this.Hide();
        }
        private void ContinueGame_Click(object sender, EventArgs e)
        {
            int level = Level.SelectedIndex + 1;
            int Map = Style.SelectedIndex + 1;
            Game Gem = new Game(level,Map);           
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
