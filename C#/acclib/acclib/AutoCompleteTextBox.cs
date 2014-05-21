using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace acclib
{
    [ToolboxBitmap(typeof(TextBox))]
    public partial class AutoCompleteTextBox : UserControl
    {
     
        private ListBox acfb = new ListBox();
        private Boolean gotoNextController = false;
        private string method="";
        private string callBackMethod = "";
        public AutoCompleteTextBox()
        {
            InitializeComponent();
            
           
        }

        private void AutoCompleteTextBox_Load(object sender, EventArgs e)
        {
            Parent.Controls.Add(acfb);
            acfb.Hide();
        }
      
        private void autoCompleteBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z' || e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                drawAutoCompleteFillBox(autoCompleteBox.Text);
            }
        }

        private void drawAutoCompleteFillBox(string text)
        {
            acfb.Items.Clear();
            acfb.Items.AddRange(source(text));
            int width = this.Width;
            int itemCount = acfb.Items.Count;
            int height = itemCount * 14;
            height = (height >= 200) ? 200 : height;
            height = (itemCount == 3) ? 50 : height;
            height = (itemCount == 2) ? 30 : height;
            height = (itemCount == 1) ? 20 : height; 
            acfb.Width = width;
            acfb.Height = height;
            int x = this.Location.X;
            int txt_y = this.Location.Y;
            int y = txt_y + this.Height;
            acfb.Location = new Point(x, y);
            acfb.SelectedIndex = 0;
            acfb.KeyDown += new KeyEventHandler(acfb_KeyDown);
            acfb.DoubleClick += new EventHandler(acfb_DoubleClick);
            acfb.KeyPress += new KeyPressEventHandler(acfb_KeyPress);
            if (acfb.Items.Count >= 1 && acfb.Items[0].ToString() != "00")
            {
                acfb.Show();
                acfb.BringToFront();
            }
            else
            {
                acfb.Hide();
            }
            
            
            
        }

        private string[] source(string key)
        {
            try
            {
                string[] items=null;
                Type t = Parent.GetType();
                MethodInfo me = t.GetMethod(this.method);
                string res = me.Invoke(Parent, new object[] { key }).ToString();
                //{ "ABCC,BCC,AAA,BCC,AAA" };
       
                items = res.Split(',');
              
               if(items.Length>0 && items[0]!="")
                  return items;
               else
                   return new string[] { "00" };
            }
            catch (Exception)
            {
                
                return new string[]{"00"};
            }
        }

        private void acfb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                 autoCompleteBox.Text = acfb.SelectedItem.ToString();
                 acfb.Hide();

                if (callBackMethod != "")
                {
                    callback();
                }

                if (gotoNextController)
                {
                    focusToNext(sender);
                }
                else
                {
                    autoCompleteBox.SelectAll();
                }
            }
        }

        private void acfb_DoubleClick(object sender, EventArgs e)
        {
            
                autoCompleteBox.Text = acfb.SelectedItem.ToString();
                acfb.Hide();

                if (callBackMethod != "")
                {
                    callback();
                }

                if (gotoNextController)
                {
                    focusToNext(sender);
                }
                else
                {
                    autoCompleteBox.SelectAll();
                }
         }

        private void acfb_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z || e.KeyCode >= Keys.D1 && e.KeyCode <= Keys.D9)
            //if(e.KeyCode!=Keys.Down && e.KeyCode!=Keys.Up)
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z' || e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                autoCompleteBox.AppendText(e.KeyChar.ToString());
                autoCompleteBox.Focus();

            }
            // MessageBox.Show(e.KeyData.ToString());
        }


        private void focusToNext(object cnt)
        {
            //TextBox currentCnt = (TextBox)cnt;
            Parent.SelectNextControl(this, true, true, true, false);
        }

        private void autoCompleteBox_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.Enter)
            {

                if (acfb.Items.Count > 0 && acfb.Items[0].ToString() != "00")
                {
                    autoCompleteBox.Text = acfb.SelectedItem.ToString();
                    acfb.Hide();
                    if (callBackMethod != "")
                    {
                        callback();
                    }
                }
                if (gotoNextController)
                {
                    focusToNext(sender);
                }
                else
                {
                    autoCompleteBox.SelectAll();
                }
            }
            else if (e.KeyCode == Keys.Back)
            {
                acfb.Items.Clear();
                acfb.Hide();
            }
            else if (e.KeyCode == Keys.Down)
            {
               
                    acfb.Focus();
                    int currentSelectedIndex = acfb.SelectedIndex;
                    int nextIndex = (currentSelectedIndex == (acfb.Items.Count - 1)) ? 0 : currentSelectedIndex + 1;
                    acfb.SelectedIndex = nextIndex;
               
            }
            else if (e.KeyCode == Keys.Up)
            {
                
                    acfb.Focus();
                    int currentSelectedIndex = acfb.SelectedIndex;
                    int nextIndex = (currentSelectedIndex == 0) ? (acfb.Items.Count - 1) : currentSelectedIndex - 1;
                    acfb.SelectedIndex = nextIndex;
               

            }
        }

        private void autoCompleteBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (autoCompleteBox.Text == "")
            {
                acfb.Items.Clear();
                acfb.Hide();
            }
            else if (e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z || e.KeyCode >= Keys.NumPad1 && e.KeyCode <= Keys.NumPad9)
            {
                drawAutoCompleteFillBox(autoCompleteBox.Text);
            }
        }
        private void adfHiden(object obj, EventArgs e)
        {
            acfb.Items.Clear();
            acfb.Hide();
        }
        private void callback()
        {
            acfb.Items.Clear();
            acfb.Hide();
            if (callBackMethod != "")
            {
                Type t = Parent.GetType();
                MethodInfo me = t.GetMethod(this.callBackMethod);
                    me.Invoke(Parent, new object[] { autoCompleteBox.Text });
            }
        }

        [Browsable(true)]
        public override string Text
        {
            get
            {
                return autoCompleteBox.Text;
            }

            set
            {
                autoCompleteBox.Text = value;
            }
        }

        [Browsable(true)]
        public bool GotoNextController
        {
            set { this.gotoNextController = value; }
            get { return this.gotoNextController; }
        }

        [Browsable(true)]
        public string CallBackMethod
        {
            set { this.callBackMethod = value; }
            get { return this.callBackMethod; }
        }

        [Browsable(true)]
        public string DataSourceMethod
        {
            set { this.method = value; }
            get { return this.method; }
        }

       [Browsable(true)]
        public  CharacterCasing CharacterCasing
        {
           get { return autoCompleteBox.CharacterCasing; }
           set { autoCompleteBox.CharacterCasing = value; }
        }

       
        
    }
}
