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
        public static string selecteditem1;
        public static string selectedfilm;
        public static int qiymet1;
        public static int qiymet2;
        public static int qiymet3;
        public static int qiymet4;
        public static int evvelkiqiymet = 0;
        public seans()
        {

            InitializeComponent();
           this.Width = 500 + 17;
            this.Height = 500 + 40;
            if (selecteditem1=="VIPSALON")
            {
                VIP12();
            }
            else if (selecteditem1 == "SEVGILILERSALONU")
            {
                VIP15();
            }
            else if (selecteditem1== "ERGENSALONU")
            {
                VIP17();
            }
            else if (selecteditem1 == "NARMOBILESALONU")
            {
                VIP21();
            }

           


        }
        public  void VIP12()
        {
            
            for (int i = 0; i <= count; i++)
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

            for (int i = 0; i <= count+2; i++)
            {
                left += ((50/2) * i);

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
        public void VIP17()
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
                //count -= 2;
            }
        }
        //]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
        public void VIP21()
        {

            for (int i = 0; i <= count +2; i++)
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
                    btn.FlatStyle = FlatStyle.Popup;
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
        
        //[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[
        public void selectseat(Object sender, EventArgs e)
        {
           
            var btn = sender as Button;
            if (btn.BackColor == Color.Red)
            {
                ((Control)sender).BackColor = Color.Gray;
                
                seats.Add(btn);
                Movie.bilet.Add("OTURACAQ NOMRESI. - " + btn.Text);
              
            }
            else
            {
                ((Control)sender).BackColor = Color.Red;
               
                seats.Remove(btn);
                Movie.bilet.Remove("OTURACAQ NOMRESI. - " + btn.Text);


            }
            
        }

        public void button1_Click(object sender, EventArgs e)
        {
            //string bil = "";
            int biletqiy = 0;
            int qiymet = 0;
           
            var obj=new Biletalma();
            foreach (var item in seats)
            {
                item.Enabled = false;
                qiymet++;
            }
            
            if (selectedfilm== "STALININ BASI")
            {
                evvelkiqiymet *= qiymet1;
                biletqiy = qiymet1 * qiymet;
            }
            else if (selectedfilm== "OGLAN EVI")
            {
                evvelkiqiymet *= qiymet2;
                biletqiy = qiymet2 * qiymet;
            }
            else if (selectedfilm == "BIR XALANIN SIRRI")
            {
                evvelkiqiymet *= qiymet3;
                biletqiy = qiymet3 * qiymet;
            }
            else if (selectedfilm == "BEXT UZUYU 2")
            {
                evvelkiqiymet *= qiymet4;
                biletqiy = qiymet4 * qiymet;
            }
            biletqiy -= evvelkiqiymet;
            Movie.bilet.Add("BILETIN DEYERI. - "+biletqiy.ToString()+".AZN");
            evvelkiqiymet = qiymet;
            
            obj.Show();
        }
    }
}
