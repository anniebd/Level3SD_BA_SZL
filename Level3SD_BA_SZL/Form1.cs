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

        public static int n = 20;
        public static int[] mixed_id = new int[n];
        int turned = 0;
        int count = 20;


        Card lastCard;

        public Form1()
        {
            InitializeComponent();

            int rows = 4;
            int columns = 5;

            Mix(n);

            int counter = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {

                    Card card = new Card(i, j, counter);
                    Controls.Add(card);

                    card.Click += Card_Click;

                    counter++;

                }
            }
        }

        private void Card_Click(object sender, EventArgs e)
        {
            Card thisCard = (Card)sender;
            if (turned >= 2)
            {
                turned = 0;

                foreach (Card card in Controls)
                {
                    card.Load("Pictures/background.png");
                }
                return;
            }

           
            if (lastCard != null)
                {
                    if (thisCard.id == lastCard.id && thisCard != lastCard)
                    {
                        thisCard.Visible = false;
                        lastCard.Visible = false;
                        count = count - 2;
                    }
                }
            lastCard = thisCard;
            
            turned++;
            if (count == 0) MessageBox.Show("Gratulálunk!");

             
        }


        void Mix(int n)
            {
                int pictureNumber = 1;
                for (int i = 0; i < n; i++)
                {
                    mixed_id[i] = pictureNumber;
                    if (i % 2 == 1)
                    {
                        pictureNumber++;
                    }
                }

                for (int i = 0; i < n; i++)
                {
                    int x1 = rnd.Next(n);
                    int x2 = rnd.Next(n);
                    int help = mixed_id[x1];
                    mixed_id[x1] = mixed_id[x2];
                    mixed_id[x2] = help;
                }
            }

    }
    }
