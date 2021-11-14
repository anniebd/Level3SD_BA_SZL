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
        public int id = 0;
        public int pictureId = 0;
        int interval = 2000;

        Timer timer = new Timer();

        public static int size = 80;
        public Card(int row, int coloumn, int cardId)
        {
            id = Form1.mixed_id[cardId];

            Height = size;
            Width = size;

            Top = row * (size + 3);
            Left = coloumn * (size + 3);

            Down();

            MouseClick += Card_MouseClick;
            timer.Interval = interval;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Down();
            timer.Stop();
        }

        private void Card_MouseClick(object sender, MouseEventArgs e)
        {
            Up();
        }

        public void Up()
        {
            Load($"Pictures/p{id}.png");
            timer.Start();
        }

        public void Down()
        {
            Load($"Pictures/background.png");
        }

    }
}
