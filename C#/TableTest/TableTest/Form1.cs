using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TableTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] row0 = { txtCode.Text, txtName.Text, txtDesc.Text};
            string[] row1 = { "FF", "OK", "FFF" };
            dataTable.Rows.Add(row0);
        }
    }
}
