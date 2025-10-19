using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace CodeGameFlapyBird
{
    // Lớp chim
    internal class Bird
    {
        public PictureBox Bird_;
        public float Gravity {get; set;}
        public float FallSpeed { get; set; }
        public float MaxFallSpeed { get; set; }
        private SoundPlayer Whoos = new SoundPlayer("Sound\\FlappyWhoos.wav");
        public Bird(PictureBox pictureBox , float G , float F , float M)
        {
            Bird_ = pictureBox;
            Gravity = G;
            FallSpeed = F;
            MaxFallSpeed = M;
        }
        public bool Dead { get; private set; } = false; // Kiểm tra nằm đất
        public void Update(PictureBox Ground_t , Pipe T)
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
        }
        // Bay lên
        public void Jump()
        {
            // Whoos.Play();
            FallSpeed =- 20f;
        }
    }
}
