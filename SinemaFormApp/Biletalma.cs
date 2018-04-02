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
            Movie.bilet.Add("BILETIN SAHIBI. - " + name);

            string[] bil = new string[10];
            int i = 0;
            int j = 0;
            foreach (var item in Movie.bilet)
            {
                i++;
                bil[i] = item;
                ticket += item + "\n";

             }


            System.IO.File.WriteAllLines(@"C:\Users\Naib\Desktop\bilet.txt", bil);
            MessageBox.Show(ticket);
            Movie.bilet.Clear();
           this.Hide();
            
            
        }
    }
}
