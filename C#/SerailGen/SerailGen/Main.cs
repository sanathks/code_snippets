using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SerailGen
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        string pin = "";
        private int ranNumber(int x,int y)
        {
            Random random = new Random();
            return random.Next(x, y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setSec1();
            setSec2();
            setSec3();
            setSec4();
        }

        #region SEC1
        private void setSec1()
        {
            A: 
            int x = ranNumber(1000,9995);
            if (matchSec1(x) == 0)
            {
                goto A;
            }
            else
            {
                txtSec1.Text = x.ToString();
            }
            
            
        }

       
        private int matchSec1(int x)
        {
            int res = (x + 4) % 3;

            if (res == 0)
            {
                return x;
            }
            else
            {

                return 0;
            }
        }
        #endregion

        #region SEC2

        private void setSec2()
        {
            txtSec2.Text = setSec2A() + setSec2B();
        }

        #region SEC2A
        private string setSec2A()
        {
            string sec2A = "";
            sec2A = getChar(ranNumber(0, 8));
            sec2A += getChar(ranNumber(4, 10));
            return sec2A;

        }

        private string getChar(int x)
        {
            string charter = "";

            switch (x)
            {
                case 0:
                    charter = "Q";
                    break;
                case 1:
                    charter = "4";
                    break;
                case 2:
                    charter = "M";
                    break;
                case 3:
                    charter = "Y";
                    break;
                case 4:
                    charter = "X";
                    break;
                case 5:
                    charter = "9";
                    break;
                case 6:
                    charter = "D";
                    break;
                case 7:
                    charter = "T";
                    break;
                case 8:
                    charter = "P";
                    break;
                case 9:
                    charter = "Z";
                    break;
            }
            return charter;
        }
        #endregion 

        #region SEC2B
        private string setSec2B()
        {
        A:
            int x = ranNumber(10, 99);
            if (matchSec2B(x) == 0)
            {
                goto A;
            }
            else
            {
                return x.ToString();
            }
        }

        private int matchSec2B(int x)
        {
            int res = ((x - 2) * 4) % 6;
            if (res == 0)
            {
                return x;
            }
            else
            {
                return 0;
            }
        }
        #endregion

        #endregion

        #region SEC3
        private void setSec3()
        {
        A:
            int x = ranNumber(1000, 9995);
            if (matchSec3(x) == 0)
            {
                goto A;
            }
            else
            {
                txtSec3.Text = x.ToString();
            }


        }


        private int matchSec3(int x)
        {
            int res = (x + 3) % 5 ;

            if (res == 0)
            {
                return x;
            }
            else
            {

                return 0;
            }
        }
        #endregion

        #region SEC4

        private void setSec4()
        {
            txtSec4.Text = matchSec4();
        }

        
        private string matchSec4()
        {
            string sec4 = "";
            sec4= getChar2(ranNumber(0, 8));
            sec4 += getChar2(ranNumber(2, 5));
            sec4 += getChar2(ranNumber(3, 7));
            sec4 += getChar2(ranNumber(6, 10));
            return sec4;

        }

        private string getChar2(int x)
        {
            string charter = "";

            switch (x)
            {
                case 0:
                    charter = "7";
                    break;
                case 1:
                    charter = "E";
                    break;
                case 2:
                    charter = "R";
                    break;
                case 3:
                    charter = "H";
                    break;
                case 4:
                    charter = "J";
                    break;
                case 5:
                    charter = "2";
                    break;
                case 6:
                    charter = "V";
                    break;
                case 7:
                    charter = "A";
                    break;
                case 8:
                    charter = "W";
                    break;
                case 9:
                    charter = "K";
                    break;
            }
            return charter;
        }
       
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtSec1.Text + "-" + txtSec2.Text + "-" + txtSec3.Text + "-" + txtSec4.Text);
            MessageBox.Show("Serial Code Copied to Clipbord ! ");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pin == DateTime.Now.ToString("MMdd"))
            {
                pinchk.Stop();
                unlock();
            }
        }

        private void unlock()
        {
            button1.Enabled = true;
            button2.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pin += "1";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pin += "2";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pin += "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pin += "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pin += "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pin += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pin += "7";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pin += "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            pin += "9";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            pin += "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            pin = "";
        }


  
        private void txtSec1_KeyPress(object sender, KeyPressEventArgs e)
        {
            pin += e.KeyChar;
            //MessageBox.Show(e.KeyChar.ToString());
        }

        
    }
}
