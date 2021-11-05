using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Level3SD_BA_SZL
{
    class Card : PictureBox
    {
        public static int size = 80;
        public Card()
        {
            Height = size;
            Width = size;
            Load($"Pictures/background.png");
        }
    }
}
