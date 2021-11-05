using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Level3SD_BA_SZL
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();

        public int n;
        public int row;
        public int column;
        
        public Form1()
        {
            InitializeComponent();

            n = 20;
            Mix(n);

            row = 4;
            column = 5;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    
                    Card card = new Card();

                    card.Top = i * (Card.size + 3);
                    card.Left = j * (Card.size + 3);

                    Controls.Add(card);

                }
            }

        }

        void Mix(int n)
        {
            int[] list = new int[n];
            for (int i = 0; i < n; i+=2)
            {
                list[i] = i / 2 + 1;
                list[i + 1] = i / 2 + 1;
            }
            for (int i = 0; i < n; i++)
            {
                int x1 = rnd.Next(n);
                int x2 = rnd.Next(n);
                int help = list[x1];
                list[x1] = list[x2];
                list[x2] = help;
            }
        }



    }
}
