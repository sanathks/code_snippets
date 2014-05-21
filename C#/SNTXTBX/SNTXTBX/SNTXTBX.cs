using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SNTXTBX
{
    public partial class SNTXTBX : UserControl
    {
        bool gotoNextController = true;

        public SNTXTBX()
        {
            InitializeComponent();
        }

        private void SeriamNoBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Match match = Regex.Match(SeriamNoBox.Text, @"\b[A-Z]{1,5}/[A-Z]{1,5}/[0-9]{4}\b");

                if (match.Success)
                {
                    gotoNext();
                }
                else
                {
                    if (SeriamNoBox.Text == "")
                    {
                        gotoNext();
                    }
                    else
                    {
                        SeriamNoBox.AppendText(@"/");
                    }
                   
                }
            }
        }

        private void gotoNext()
        {
            Parent.SelectNextControl(this, true, true, true, false);
        }

        [Browsable(true)]
        public override string Text
        {
            get
            {
                return SeriamNoBox.Text;
            }

            set
            {
                SeriamNoBox.Text = value;
            }
        }

        [Browsable(true)]
        public bool GotoNextController
        {
            set { this.gotoNextController = value; }
            get { return this.gotoNextController; }
        }

    }
}
