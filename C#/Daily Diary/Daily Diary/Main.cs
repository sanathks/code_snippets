using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;


namespace Daily_Diary
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        Diary _diary = new Diary();
        #region  make this as moverble form
        const int WS_CLIPCHILDREN = 0X2000000;
        const int WS_MINIMINZEBOX = 0X20000;
        const int WS_MAXIMIZEBOX = 0X10000;
        const int WS_SYSMENU = 0X80000;
        const int CS_DBLCLKS = 0X8;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style = WS_CLIPCHILDREN | WS_MAXIMIZEBOX | WS_MINIMINZEBOX | WS_SYSMENU;
                cp.ClassStyle = CS_DBLCLKS;
                return cp;
            }
        }
        Point frmloc, curloc = new Point(0, 0);

        private void setPosition()
        {
            frmloc = this.Location;
            curloc = Cursor.Position;
        }




        private void move_Tick(object sender, EventArgs e)
        {
            int nxp = frmloc.X - curloc.X + Cursor.Position.X;
            int nyp = frmloc.Y - curloc.Y + Cursor.Position.Y;
            this.Location = new Point(nxp, nyp);
        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            move.Start();
            setPosition();
        }

        private void Main_MouseUp(object sender, MouseEventArgs e)
        {
            move.Stop();
            setPosition();
        }

        #endregion

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int x = 0;
            string st = "0";
            if (textBox2.Text == "")
            {
                nt.ShowErr("Error !");
                x++;
            }
            if(textBox3.Text==""){
                nt.ShowErr("Error !");
                x++;
            }
            if (checkBox1.Checked)
            {
                st = "1";
            }

            if (x == 0)
            {
                if (_diary.Save(dateTimePicker1.Value.ToShortDateString(), textBox1.Text, textBox2.Text, textBox3.Text, st) == 1)
                {
                    nt.Show("Saved !");
                    cls();
                }
                else
                {
                    nt.ShowErr("Try again !");
                }
                
            }
            else
            {

            }
        }

        public string getData(string code)
        {
            return _diary.GetToAutocomplete("data", "project", code);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (File.Exists("diary.db"))
            {
                Screen screen = Screen.PrimaryScreen;
                int S_width = screen.Bounds.Width - 331;
                this.Location = new Point(S_width, 0);
            }
            else
            {
                MessageBox.Show("File missed placed !", "");
                Application.Exit();
            }
          
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void cls()
        {
            dateTimePicker1.Value = DateTime.Now;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            checkBox1.Checked = false;
            pinTextBox1.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cls();
        }

        private void eraseDiaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pinTextBox1.Text != "1218")
            {
                nt.ShowErr("Err Pin!");
                pinTextBox1.Text = "";
            }
            else
            {
                pinTextBox1.Text = "";
                if (_diary.Delete() == 1)
                {
                    nt.Show("Cleared !");
                }
                else
                {
                    nt.ShowErr("Try again !");
                }
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pinTextBox1.Text != "1218")
            {
                nt.ShowErr("Err Pin!");
                pinTextBox1.Text = "";
            }
            else
            {
                pinTextBox1.Text = "";
                saveFile.ShowDialog();
                string path = saveFile.FileName+".xls";
                if (_diary.Export(path) == 1)
                {
                    nt.Show("Exported !");
                }
                else
                {
                    nt.ShowErr("Try again !");
                }
            }
        }

       
       

    }
}
