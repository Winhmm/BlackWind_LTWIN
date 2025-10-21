using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace CodeGameFlapyBird
{
    // Lớp chim
    internal class Bird
    {
        private PictureBox Bird_;
        private float Gravity {get; set;}
        private float FallSpeed { get; set; }
        private float MaxFallSpeed { get; set; }
        private int GrowCount { get; set; } = 0;
        // Khởi tạo trường hợp riêng cho âm thanh
        private WindowsMediaPlayer whoos { get; set; }
        private WindowsMediaPlayer EatApple { get; set; }
        public Bird(PictureBox pictureBox , float G , float F , float M)
        {
            Bird_ = pictureBox;
            Gravity = G;
            FallSpeed = F;
            MaxFallSpeed = M;

            //
            whoos = new WindowsMediaPlayer();
            whoos.URL = "Sound\\FlapyWhoos.wav";          
            whoos.settings.volume = 100;
            whoos.controls.stop();
            //
            EatApple = new WindowsMediaPlayer();
            EatApple.URL = "Sound\\ScoreSound.wav";
            EatApple.settings.volume = 100;
            EatApple.controls.stop();

        }
        private void Grow()
        {
            GrowCount++;

            Bird_.Width += 15;
            Bird_.Height += 15;

            Gravity += 2;

            // Bird_.Top -= 2;
            // Bird_.Left -= 2;

            if (Bird_.Width > 100) Bird_.Width = 100;
            if (Bird_.Height > 100) Bird_.Height = 100;
        }
        public bool Dead { get; private set; } = false; // Kiểm tra nằm đất
        public void Update(PictureBox Ground_t , ObstacleAndBonus T)
        {
            FallSpeed += Gravity;            
            // Chặn đất
            if (FallSpeed > MaxFallSpeed)
            {
                FallSpeed = MaxFallSpeed;
            }
            // Chặn trên
            if (Bird_.Top < 0)
            {
                Bird_.Top = 0;
                FallSpeed = 0;
            }
            Bird_.Top += (int)FallSpeed;

            int a = Ground_t.Top;
            if (Bird_.Top + Bird_.Height > a )
            {
                Bird_.Top = a - Bird_.Height;
                FallSpeed = 0;
                Dead = true;
            }
            if (Bird_.Bounds.IntersectsWith(T.PipeTop.Bounds) || Bird_.Bounds.IntersectsWith(T.PipeBottom.Bounds))
            {
                Dead = true; 
            }
            if (Bird_.Bounds.IntersectsWith(T.Point.Bounds) && T.Point.Visible)
            {              
                EatApple.controls.stop();
                EatApple.controls.play();
                T.Point.Visible = false;
                Grow();
            }
            if (T.FlyObstacle != null && T.FlyObstacle.Visible && Bird_.Bounds.IntersectsWith(T.FlyObstacle.Bounds))
            {
                Dead = true;
            }
        }
        // Bay lên
        public void Jump()
        {
            whoos.controls.stop();
            whoos.controls.play();
            FallSpeed =- 20f;           
        }
    }
}
