using System;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace SER_System_Templete1
{
    public partial class Splashscreen : Form
    {
        public Splashscreen()
        {
            InitializeComponent();
            // proCom.
        }

        private void Splashscreen_Load(object sender, EventArgs e)
        {
            splash();
            allFilesExist.Enabled = true;
        }
        XmlNodeList comItems;
        float comCount = 0;
        float checkedCom = 1;
        int a = 0;
        private void splash()
        {
            int y = 0;
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("config/comitems.sys");
                comItems = doc.SelectNodes("//com");
                comCount = comItems.Count;
            }
            catch (Exception)
            {

                MessageBox.Show("Inventory Tracking System \n Error ! 0x0001comitems is missing.");
                Application.Exit();
            }
        }

        private void allFilesExist_Tick(object sender, EventArgs e)
        {
            if (a != comCount)
            {

                if (File.Exists(comItems[a].Attributes["path"].Value))
                {
                    checkedCom++;
                    float ans = checkedCom / comCount;
                    float na = ans * 100;
                    int val = (int)na;
                    if (val > 100)
                        val = 100;
                    proCom.Value = val;
                    if (val <= 98)
                    {
                        comName.Text = comItems[a].Attributes["name"].Value;
                    }
                    else
                    {
                        lbAction.Text = "Done";
                        comName.Text = "";
                    }
                    if ((comCount + 1) == checkedCom)
                    {
                        allFilesExist.Enabled = false;
                        frmMain frmMain = new frmMain();
                        frmMain.Show();
                        this.Hide();

                    }
                    a++;
                }
                else
                {
                    allFilesExist.Enabled = false;
                    MessageBox.Show("Inventory Tracking System \n Error ! 0x0001" + comItems[a].Attributes["name"].Value + "is missing.");
                    Application.Exit();
                }
            }
            else
            {
                allFilesExist.Enabled = false;
            }
        }




    }
}
