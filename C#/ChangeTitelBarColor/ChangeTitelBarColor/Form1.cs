using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace ChangeTitelBarColor
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }


        int sec = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.MistyRose;
            this.StartPosition = FormStartPosition.CenterScreen;


        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            Match match1 = Regex.Match(textBox1.Text, @"\b[A-Z]{1,5}\b");
            Match match2 = Regex.Match(textBox1.Text, @"\b[A-Z]{1,5}/[A-Z]{1,5}\b");
            Match match3 = Regex.Match(textBox1.Text, @"\b[A-Z]{1,5}/[A-Z]{1,5}/[0-9]{3}\b");

            
            if (e.KeyCode == Keys.Enter)
            {
                if (match3.Success && match2.Success && match1.Success)
                {

                }
                else
                {
                    if (match2.Success && match1.Success)
                    {
                        textBox1.AppendText(@"/");
                    }
                    else if (match1.Success)
                    {
                        textBox1.AppendText(@"/");
                    }

                }
            }

        }
    }
}
