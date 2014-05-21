using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SER_DataBridge;
using MySql.Data.MySqlClient;

namespace Database_Lib
{
    public partial class Demo : Form
    {
        
        public Demo()
        {
            InitializeComponent();
        }

        private void Demo_Load(object sender, EventArgs e)
        {
            if (MySQL_Bridge.open())
                MessageBox.Show("Open"); 
            else
                MessageBox.Show("Error");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MySQL_Bridge.insert())
            {
                MessageBox.Show("Inserted");
            }
            else
            {
                MessageBox.Show("Error");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
