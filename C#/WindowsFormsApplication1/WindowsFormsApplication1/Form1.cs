using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string strFullPath = @"C:\Users\Ronny\Desktop\Sources\Danny\kawas\trunk\csharp\ImportME\XukMe\bin\Debug\DannyGoXuk.DTDs.xhtml-math-svg-flat.dtd";
            string strDirName;
            int intLocation;

            intLocation = strFullPath.LastIndexOf("\\");

            strDirName = strFullPath.Substring(0, intLocation);

            textBox1.Text = strDirName;
        }
    }
}
