using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OTCalculator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        
        private int getDayType()
        {
            string[] day = calander.SelectionStart.Date.Date.ToLongDateString().Split(',');
            int fullOT = 0;

            if (day[0] == "Saturday")
            {
                fullOT = 1;
            }
            else if (day[0] == "Sunday")
            {
                fullOT = 1;
            }
            else
            {
                fullOT = 0;
            }
            return fullOT;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            TimeSpan officeTime = new TimeSpan(9,0,0);
            TimeSpan dt = inTime.Value.Subtract(outTime.Value);
            TimeSpan t = dt.Subtract(officeTime);
            MessageBox.Show(t.ToString());
        }

        private void label18_Click(object sender, EventArgs e)
        {
            MessageBox.Show("© 2013 Sanath Samarasinghe ");
        }

               
    }
}
