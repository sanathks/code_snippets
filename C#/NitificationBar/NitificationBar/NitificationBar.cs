using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace NitificationBar
{
    public partial class NitificationBar : UserControl
    {
        int time = 0;
        public NitificationBar()
        {
            InitializeComponent();
        }

        public void ShowErr(string msg)
        {
            On();
            this.ntLable.Text = msg;
            this.ntContainer.BackColor = Color.LightPink;
        }

        public void Show(string msg)
        {
            On();
            this.ntLable.Text = msg;
            this.ntContainer.BackColor = Color.LightSkyBlue;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (time >= 5)
            {
                Off();
                time = 0;
            }
            time += 1;
        }

        private void On()
        {
            timer.Start();
            this.ntLable.Text = "";
            this.ntContainer.BackColor = Color.Transparent;
            this.ntLable.Show();
            this.ntContainer.Show();
        }

        private void Off()
        {
            timer.Stop();
            this.ntLable.Text = "";
            this.ntContainer.BackColor = Color.Transparent;
            this.ntLable.Hide();
            this.ntContainer.Hide();
        }

        private void NitificationBar_Load(object sender, EventArgs e)
        {
            Off();
        }

      
    }
}
