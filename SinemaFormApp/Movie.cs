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
       
      

        public Movie()
        {
            InitializeComponent();
            //seans VIPSALON = new seans();
            //seans SEVGILILERSALONU = new seans();
            //seans ERGENSALONU = new seans();
            //seans NARMOBILESALONU = new seans();

            List<string> salon = new List<string>()
            {
             "1.VIPSALON",
             "2.SEVGILILERSALONU",
             "3.ERGENSALONU",
             "4.NARMOBILESALONU",
            };
            List<string> time = new List<string>() { "12:00", "15:00", "19:00", "21:00", "23:00" };

            foreach (var item in salon)
            {
                comboBox1.Items.Add(item);
                comboBox2.Items.Add(item);
                comboBox3.Items.Add(item);
                comboBox4.Items.Add(item);
            }
            foreach (var item in time)
            {
                comboBox5.Items.Add(item);
                comboBox6.Items.Add(item);
                comboBox7.Items.Add(item);
                comboBox8.Items.Add(item);
            }




        }
       
        
            public string name;
            public int ID;
            
       

        public void button1_Click(object sender, EventArgs e)
        {
            var obj = new seans();
            obj.Show();

        }

       
    }
}
