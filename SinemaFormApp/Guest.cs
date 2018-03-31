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
    public partial class Guest : Form
    {
        public string name1= "1.Sevgililer Salonu";
        public string name2="2.VIP Salon";
        public string name3= "3.Ergen Slonu";
        public string name4 = "4.NarMobile Salonu";
        public Guest()
        {
            InitializeComponent();
            var salon = new Guest();
            var SevgililerSalonu = new Movie();
            var VIPSalon = new Movie();
            var ErgenSlonu = new Movie();
            var NarMobileSalonu = new Movie();

            comboBox1.Items.Add(salon.name1+""+ salon.name2 + "" + salon.name3 + "" + salon.name4);
            comboBox2.Items.Add(salon.name1 + "" + salon.name2 + "" + salon.name3 + "" + salon.name4);
            comboBox3.Items.Add(salon.name1 + "" + salon.name2 + "" + salon.name3 + "" + salon.name4);
            comboBox4.Items.Add(salon.name1 + "" + salon.name2 + "" + salon.name3 + "" + salon.name4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var obj = new Movie();
            obj.Show();

            // SevgililerSalonu.Show();
        }
    }
}
