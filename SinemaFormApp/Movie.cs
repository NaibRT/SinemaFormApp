using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaFormApp
{
    public partial class Movie : Form
    {
        public Button btn;
        public int count = 10;
        public int seatnum = 0;
        public int left = 0;
        public int top = 0;
        public Movie()
        {

            InitializeComponent();
            this.Width = 500 + 17;
            this.Height = 500 + 40;

            for (int i = 0; i < count; i++)
            {
                left += (50 * i);

                for (int j = 0; j < count; j++)
                {
                    seatnum++;
                    btn = new Button();
                    btn.Click += new EventHandler(selectseat);

                    btn.Top = top;
                    btn.Left = left;
                    btn.Width = 50;
                    btn.Height = 50;
                    btn.Text = seatnum.ToString();
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 3;
                    btn.BackColor = Color.Red;
                    Controls.Add(btn);
                    left += 50;
                }
                top += 50;
                left = 0;
                count -= 2;
            }

        }
    



        //[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[
        public void selectseat(Object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn.BackColor == Color.Red)
            {
                ((Control)sender).BackColor = Color.Gray;
            }
            else
            {
                ((Control)sender).BackColor = Color.Red;
            }
        }
    }
}
