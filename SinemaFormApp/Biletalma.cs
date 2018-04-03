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
    public partial class Biletalma : Form
    {

        public string surname;
        public string name;
        public Biletalma()
        {
            InitializeComponent();


        }

        public void button1_Click(object sender, EventArgs e)
        {
            string ticket = "";
            name = textBox1.Text;
            name += "." + textBox2.Text;
            Form1.bilet.Add("BILETIN SAHIBI. - " + name);

            string[] bil = new string[1000];
            int i = 0;
            int j = 0;
            foreach (var item in Form1.bilet)
            {
                i++;
                
                ticket += item + "\n";
                bil[i] = item;


            }

           
            
               System.IO.File.WriteAllLines(@"C:\Users\P106\Desktop\bilet.txt", bil);


            MessageBox.Show(ticket);
            Form1.bilet.Clear();
           this.Hide();
            
            
        }
    }
}
