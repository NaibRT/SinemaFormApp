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
    public partial class seans : Form
    {
        public List<Button> seats = new List<Button>();
        public string name;
        public int ID;
        public Button btn;
        public int count = 10;
        public int seatnum = 0;
        public int left = 0;
        public int top = 0;
        public seans()
        {

            InitializeComponent();

          
            
            
           
          


            this.Width = 500 + 17;
            this.Height = 500 + 40;



        }
    public  void VIP12()
        {
            
            for (int i = 0; i <= count+2; i++)
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
                    btn.FlatAppearance.BorderColor = Color.White;
                    btn.BackColor = Color.Red;
                    
                    Controls.Add(btn);
                    left += 50;
                }
                top += 50;
                left = 0;
                count -= 2;
            }
        }
        //]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
        public void VIP15()
        {

            for (int i = 0; i <= count + 2; i++)
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
                    btn.FlatAppearance.BorderColor = Color.White;
                    btn.BackColor = Color.Yellow;

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
            //List<string> seats = new List<string>();
            var btn = sender as Button;
            if (btn.BackColor == Color.Red)
            {
                ((Control)sender).BackColor = Color.Gray;
                
                seats.Add(btn);
                comboBox1.Items.Clear();
                foreach (var item in seats)
                {
                    comboBox1.Items.Add(item.Text);
                }
            }
            else
            {
                ((Control)sender).BackColor = Color.Red;
               
                seats.Remove(btn);
                comboBox1.Items.Clear();
                foreach (var item in seats)
                {
                    comboBox1.Items.Add(item.Text);
                }

            }
            
        }

        public void button1_Click(object sender, EventArgs e)
        {
            var obj=new Biletalma();
            foreach (var item in seats)
            {
                item.Enabled = false;
            }

            obj.Show();
        }
    }
}
