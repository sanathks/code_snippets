using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NotifiTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nt.Show("Saved !");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nt.ShowErr("Error !");
        }
    }
}
