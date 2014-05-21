using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicMenu
{
    public partial class frmMain : Form
    {
        MenuStrip menuXml = new MenuStrip();
        public frmMain()
        {
            InitializeComponent();
            menuXml.Renderer = new ToolStripProfessionalRenderer(new CustomProfessionalColors());
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            menuSetup menu = new menuSetup();
            menu.InitializeMenuXmlDirect(this, menuXml);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menuSetup menu = new menuSetup();
            //menu.InitialazeMenu(this);
            //menu.InitializeMenuXml(this);
            menu.InitializeMenuXmlDirect(this, menuXml);
        }
    }

}
