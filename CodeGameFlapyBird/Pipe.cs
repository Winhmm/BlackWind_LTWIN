using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.IO;
using System.Threading;

namespace CodeGameFlapyBird
{
    // Lớp ống
    internal class Pipe
    {
        public PictureBox PipeTop { get; private set; }
        public PictureBox PipeBottom { get; private set; }
        private int Speed { get; set; } = 7;
        public bool Passed { get; private set; } = false;
        private int FormWidth;
        private int Level = 0;
        private Random rnd = new Random();
        private SoundPlayer Ting = new SoundPlayer("Sound\\TingSound.wav");
        public Pipe(PictureBox top, PictureBox bottom, int formWidth, int level , int SpeedGame)
        {
            PipeTop = top;
            PipeBottom = bottom;
            FormWidth = formWidth;
            Level = level;
            Speed = SpeedGame;
        }
        // Di chuyển ống nước
        public void Update()
        {
            PipeTop.Left -= Speed;
            PipeBottom.Left -= Speed;

            if (PipeTop.Right < 0)
            {
                Reset();
            }
        }

        private void Reset()
        {
            Passed = false;
            // Chuyển ống ngược qua bên phải màng hình
            int startX = FormWidth;
            
            int A = rnd.Next(0,6);

            int[][] B =
            {
                new int[] { 200,  -380 },
                new int[] { 225,  -350 },
                new int[] { 250,  -330 },
                new int[] { 280,  -300 },
                new int[] { 310,  -250 },
                new int[] { 350,  -220 },
                new int[] { 430,  -150 },
                new int[] { 460,  -100 }
            };

            int C = 0;

            switch (Level)
            {
                case 1:
                    C = 20; 
                    break;
                case 2:
                    C = 0;
                    break;
                case 3:
                    C = -15;
                    break;
                case 4:
                    C = -30;                  
                        break;
                default:
                    break;
            }

            PipeBottom.Location = new Point (startX, B[A][0] + C);
            PipeTop.Location = new Point(startX, B[A][1] - C);

        }
        public void CheckScore(PictureBox bird, ref int score)
        {
            if (Passed == false && bird.Left >= PipeTop.Right)
            {
                Ting.Play();
                score++;
                Passed = true;                             
            }
        }
    }
}
