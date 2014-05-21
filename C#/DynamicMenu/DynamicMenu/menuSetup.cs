using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DynamicMenu
{
    class menuSetup
    {
        Form frm;
        public void InitialazeMenu(Form frm)
        {
            MenuStrip menu = new MenuStrip();
            ToolStripMenuItem m = new ToolStripMenuItem();
            m.Text = "Hello";
            for (int x = 0; x < 10; x++)
            {
                ToolStripMenuItem mn = new ToolStripMenuItem();
                mn.Text = "All " + x;
                mn.Click += new EventHandler(this.frm_show);
                m.DropDownItems.Add(mn);
            }
            menu.Items.AddRange(new ToolStripMenuItem[] { m });
            frm.Controls.Add(menu);
        }

        public void frm_show(object sender, EventArgs e)
        {
            Form frmN = new Form();
            frmN.Text = "OK";
            frmN.Show();
        }

        public void InitializeMenuXml(Form  frm)
        {
            menuConfig menu = new menuConfig();
            List<menus> m= menu.getMenuItems();

            MenuStrip menuXml = new MenuStrip();
            foreach (menus mm in m)
            {
                ToolStripMenuItem nMenu = new ToolStripMenuItem();
                nMenu.Name = mm.name;
                nMenu.Text = mm.text;
                menuXml.Items.Add(nMenu);
            }

            frm.Controls.Add(menuXml);
        }

        public void InitializeMenuXmlDirect(Form frm, MenuStrip menuXml)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("menuItems.serconfig");
            XmlNodeList mItems = doc.SelectNodes("//mmenu");
            foreach (XmlNode item in mItems)
            {
                if (item.HasChildNodes)
                {
                    ToolStripMenuItem nMenu = new ToolStripMenuItem();
                    nMenu.Name = item.Attributes["name"].Value;
                    nMenu.Text = item.Attributes["text"].Value;
                     foreach(XmlNode sItem in item)
                     {
                         ToolStripMenuItem sMenu = new ToolStripMenuItem();
                         sMenu.Name = sItem.Attributes["name"].Value;
                         sMenu.Text = sItem.Attributes["text"].Value;
                         sMenu.BackColor = System.Drawing.Color.LightSteelBlue;
                         sMenu.Tag = sItem.Attributes["text"].Value;
                         sMenu.Click += new EventHandler(this.menu_click);
                         nMenu.DropDownItems.Add(sMenu);
                     }
                    menuXml.Items.Add(nMenu);
                }
                else
                {
                    ToolStripMenuItem nMenu = new ToolStripMenuItem();
                    nMenu.Name = item.Attributes["name"].Value;
                    nMenu.Text = item.Attributes["text"].Value;
                    menuXml.Items.Add(nMenu);
                }

            }
         frm.Controls.Add(menuXml);
         this.frm = frm;
        }

        public void menu_click(object sender, EventArgs e)
        {
            Form frmN = new Form();
            frmN.Text = "OK";
            frmN.MdiParent = frm;
            frmN.BackColor = System.Drawing.Color.LightSteelBlue;
            frmN.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            frmN.Show();
        }
    }
}
