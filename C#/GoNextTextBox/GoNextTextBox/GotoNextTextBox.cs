using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace gnclib
{
    [ToolboxBitmap(typeof(TextBox))]
    public partial class GotoNextTextBox : UserControl
    {
        public GotoNextTextBox()
        {
            InitializeComponent();
        }
        private bool gotoNextController = true;
      
        private void toolBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && this.gotoNextController==true)
            {
              Parent.SelectNextControl(this, true, false, true, true);
            }
        }

        [Browsable(true)]
        public override string Text
        {
            set
            {
                toolBox.Text = value;
            }
            get
            {
                return toolBox.Text;
            }
        }

        private CharacterCasing charactercasing = CharacterCasing.Normal;

        [Browsable(true)]
        public CharacterCasing CharacterCasing
        {

            get { return this.charactercasing; }

            set { this.charactercasing = value; }
        }

        
        [Browsable(true)]
        public bool Multiline
        {
            set
            {
                toolBox.Multiline = value;
            }
            get
            {
                return toolBox.Multiline;
            }
        }

        [Browsable(true)]
        public char PasswordChar 
        { 
            get{ return toolBox.PasswordChar;}
            set{ toolBox.PasswordChar=value;}
        
        }

        [Browsable(true)]
        public bool GotoNextController
        {
            set { this.gotoNextController = value; }
            get { return this.gotoNextController; }
        }
        
    }
}
