﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        

       

        private void button2_Click(object sender, EventArgs e)
        {
            var obj = new Movie();
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
