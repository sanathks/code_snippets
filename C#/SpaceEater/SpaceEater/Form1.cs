using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpaceEater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            opn.ShowDialog();
        }

        private void opn_FileOk(object sender, CancelEventArgs e)
        {
            label1.Text = opn.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void add()
        {
            for (int x = 0; x < 100; x++)
            {

            }
        }
    }
}
