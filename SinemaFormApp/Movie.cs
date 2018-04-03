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
         


            List <string> salon = new List<string>()
            {
             "VIPSALON",
             "SEVGILILERSALONU",
             "ERGENSALONU",
             "NARMOBILESALONU",
            };
            List<string> time = new List<string>() { "12:00", "15:00", "19:00", "21:00", "23:00" };
            comboBox1.SelectionChangeCommitted += new EventHandler(comboselect);
            comboBox2.SelectionChangeCommitted += new EventHandler(comboselect);
            comboBox3.SelectionChangeCommitted += new EventHandler(comboselect);
            comboBox4.SelectionChangeCommitted += new EventHandler(comboselect);
            comboBox5.SelectionChangeCommitted += new EventHandler(comboselect2);
            comboBox6.SelectionChangeCommitted += new EventHandler(comboselect2);
            comboBox7.SelectionChangeCommitted += new EventHandler(comboselect2);
            comboBox8.SelectionChangeCommitted += new EventHandler(comboselect2);
            comboBox9.SelectionChangeCommitted += new EventHandler(comboselect3);

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
            
            film film1 = new film();
            film film2 = new film();
            film film3 = new film();
            film film4 = new film();


            film1.name = "STALININ BASI";
            film1.prise = 10;
            film2.name = "OGLAN EVI";
            film2.prise = 12;
            film3.name = "BIR XALANIN SIRRI";
            film3.prise = 11;
            film4.name = "BEXT UZUYU 2";
            film4.prise = 13;
            label1.Text = film1.name;
            label2.Text = film2.name;
            label3.Text = film3.name;
            label4.Text = film4.name;
            label5.Text = film1.prise.ToString() +".AZN";
            label6.Text = film2.prise.ToString() + ".AZN";
            label7.Text = film3.prise.ToString() + ".AZN";
            label8.Text = film4.prise.ToString() + ".AZN";
            seans.qiymet1 = film1.prise;
            seans.qiymet2 = film2.prise;
            seans.qiymet3 = film3.prise;
            seans.qiymet4 = film4.prise;
            List<film> filimler = new List<film>(){ film1,film2,film3,film4};
            foreach (var item in filimler)
            {
                comboBox9.Items.Add(item.name);
            }


        }

        public void comboselect(object obj, EventArgs e)
        {
            var box = obj as ComboBox;
            seans.selecteditem1 = box.SelectedItem.ToString();
            Form1.bilet.Add("ZALIN ADI. - "+box.SelectedItem.ToString());

        }
        public void comboselect2(object obj, EventArgs e)
        {
            var box = obj as ComboBox;
            Form1.bilet.Add("FILMIN SEANSI. - "+box.SelectedItem.ToString());

        }
        public void comboselect3(object obj, EventArgs e)
        {
            var box = obj as ComboBox;
            seans.selectedfilm = box.SelectedItem.ToString();
            Form1.bilet.Add("FILMIN ADI. - "+box.SelectedItem.ToString());

        }





        public void button1_Click(object sender, EventArgs e)
        {
         
            var obj = new seans();
            obj.Show();

        }

       
    }
    public  class film
    {
        public string name;
        public  int prise;
    }
}
