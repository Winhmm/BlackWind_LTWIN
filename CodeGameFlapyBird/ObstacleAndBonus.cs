using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskBand;

namespace CodeGameFlapyBird
{
    // Lớp ống
    internal class ObstacleAndBonus
    {
        public PictureBox PipeTop { get; private set; }
        public PictureBox PipeBottom { get; private set; }
        public PictureBox Point { get; private set; }
        private int Speed { get; set; } = 0;
        private bool Passed { get; set; } = false;
        private int FormWidth { get; set; }
        private int Level { get; set; } = 0;
        private bool AppleTaken { get; set; } = false;

        public PictureBox FlyObstacle { get; set; }  
        private int flySpeedY { get; set; } = 3;      
        private bool flyDown { get; set; } = true;    

        private WindowsMediaPlayer Ting { get; set; }
        private Random rnd { get; set; } = new Random();
        public ObstacleAndBonus(PictureBox top, PictureBox bottom, PictureBox point, PictureBox FlyObstacle_ , int formWidth, int level , int SpeedGame)
        {
            PipeTop = top;
            PipeBottom = bottom;
            Point = point;
            FlyObstacle = FlyObstacle_ ;
            FormWidth = formWidth;
            Level = level;
            Speed = SpeedGame;

            Ting = new WindowsMediaPlayer();
            Ting.URL = "Sound\\TingSound.wav";
            Ting.settings.volume = 100;
        }
        
        // cập nhật tốc độ
        public void IncreaseSpeed(int newSpeed)
        {
            Speed = newSpeed;
        }

        // Di chuyển ống nước
        public void Update()
        {
            PipeTop.Left -= Speed;
            PipeBottom.Left -= Speed;

            Point.Left -= Speed;
            
            if (Point.Right < 0)
            {
                Reset();
            }

            if (FlyObstacle != null && FlyObstacle.Visible)
            {
                
                FlyObstacle.Left -= Speed;
                
                if (flyDown) FlyObstacle.Top += flySpeedY;
                else FlyObstacle.Top -= flySpeedY;
                
                if (FlyObstacle.Top <= 20) flyDown = true;
                if (FlyObstacle.Bottom >= 400) flyDown = false;
              
                if (FlyObstacle.Right < 0)
                    Reset2();
            }

        }

        private void Reset2()
        {
            int startX = FormWidth + 200;          
            int startY = rnd.Next(100, 500);       
            FlyObstacle.Location = new Point(startX, startY);
            FlyObstacle.Visible = true;
        }

        private void Reset()
        {
            AppleTaken = false;
            Passed = false;
            // Chuyển ống ngược qua bên phải màng hình
            int startX = FormWidth;
            int startApple = startX + 290;
                  
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

            int A = rnd.Next(0, B.Length);
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
                    C = -16;
                    break;
                default:
                    C = 20;
                    break;
            }
            Point.Visible = true;
            PipeBottom.Location = new Point (startX, B[A][0] + C);
            PipeTop.Location = new Point(startX, B[A][1] - C);
            Point.Location = new Point(startApple, rnd.Next(10,400));
        }
        public void CheckScore(PictureBox bird, ref int score)
        {
            if (Passed == false && bird.Left >= PipeTop.Right)
            {
                Ting.controls.stop();
                Ting.controls.play();
                score++;
                Passed = true;              
            }
            if (!AppleTaken && Point.Visible == false)
            {
                score += 2;           
                AppleTaken = true;
            }
        }
    }

}
