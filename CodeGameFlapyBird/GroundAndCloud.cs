using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeGameFlapyBird
{
    internal class Ground
    {
        // Xử lí mặt đất duy chuyển
        private PictureBox Ground1 { get; set; }
        private PictureBox Ground2 { get; set; }
        private int groundSpeed { get; set; } = 0;

        public Ground(PictureBox ground1, PictureBox ground2, int groundSpeed)
        {
            Ground1 = ground1;
            Ground2 = ground2;
            this.groundSpeed = groundSpeed;
        }

        public void AutoMoveGround()
        {

            Ground1.Left -= groundSpeed;
            Ground2.Left -= groundSpeed;
            if (Ground1.Right <= 0)
            {
                Ground1.Left = Ground2.Right;
            }
            if (Ground2.Right <= 0)
            {
                Ground2.Left = Ground1.Right;
            }
        }
    }
}
