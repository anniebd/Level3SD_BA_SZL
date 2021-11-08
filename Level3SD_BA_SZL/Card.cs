using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Level3SD_BA_SZL
{
    class Card : PictureBox
    {
        int id;
        int column = 5;

        public static int size = 80;
        public Card()
        {
            Height = size;
            Width = size;
            Load($"Pictures/background.png");

            MouseClick += Card_MouseClick;
        }

        private void Card_MouseClick(object sender, MouseEventArgs e)
        {
            id = Top / size * column + Left / size;
            Load($"Pictures/p{Form1.mixed_id[id]}.png");
        }

    }
}
