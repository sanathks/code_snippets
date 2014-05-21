using System;
using System.Windows.Forms;
using System.Xml;
using System.Drawing;

namespace InventoryTrackingSystem
{
    class MenuSetup
    {
        Form FRM;
        
        public void InitializeMenu(Form frm, MenuStrip menuXml)
        {
            XmlDocument doc = new XmlDocument();
                try 
	                {	        
		
                            doc.Load("core/mioitsx.serconfig");
                            XmlNodeList mItems = doc.SelectNodes("//menu");
                            foreach (XmlNode item in mItems) //Main Menu
                            {
                                if (item.HasChildNodes)
                                {
                                    ToolStripMenuItem nMenu = new ToolStripMenuItem();
                                    nMenu.Name = item.Attributes["name"].Value;
                                    nMenu.Text = item.Attributes["text"].Value.ToUpper();
                                     foreach(XmlNode sItem in item) //Sub Menu
                                     {
                                         ToolStripMenuItem sMenu = new ToolStripMenuItem();
                                         sMenu.Name = sItem.Attributes["name"].Value;
                                         sMenu.Text = sItem.Attributes["text"].Value;
                                         sMenu.BackColor = System.Drawing.Color.LightSteelBlue;
                                         if (sItem.Attributes["icon"].Value=="true")
                                         {
                                             sMenu.Image = new System.Drawing.Bitmap(@"res\" + sItem.Attributes["iconName"].Value);
                                         }
                                         if (sItem.HasChildNodes)
                                         {
                                             foreach (XmlNode ssItem in sItem) //Super Sub Menu
                                             {
                                                 ToolStripMenuItem ssMenu = new ToolStripMenuItem();
                                                 ssMenu.Name = ssItem.Attributes["name"].Value;
                                                 ssMenu.Text = ssItem.Attributes["text"].Value;
                                                 ssMenu.BackColor = System.Drawing.Color.LightSteelBlue;
                                                 if (ssItem.Attributes["icon"].Value == "true")
                                                 {
                                                     ssMenu.Image = new System.Drawing.Bitmap(@"res\" + ssItem.Attributes["iconName"].Value);
                                                 }
                                                 ssMenu.Tag = ssItem.Attributes["click"].Value;
                                                 ssMenu.Click += new EventHandler(this.menu_click);
                                                 sMenu.DropDownItems.Add(ssMenu);
                                             }
                                     

                                         }else
                                         {
                                             sMenu.Tag = sItem.Attributes["click"].Value;
                                             sMenu.Click += new EventHandler(this.menu_click);
                                         }

                                         //if (sItem.Attributes["separator"].Value == "true")
                                         //{
                                         //    ToolStripSeparator sep = new ToolStripSeparator();
                                         //    sep.Name = sItem.Attributes["name"].Value;
                                         //    sep.Size =new Size(149, 6);
                                         //    nMenu.DropDownItems.AddRange(new ToolStripItem[] { sMenu , sep});
                                         //}
                                         //else
                                         //{
                                             nMenu.DropDownItems.Add(sMenu);
                                         //}

                                     }
                                    menuXml.Items.Add(nMenu);
                                }
                                else
                                {
                                    ToolStripMenuItem nMenu = new ToolStripMenuItem();
                                    nMenu.Name = item.Attributes["name"].Value;
                                    nMenu.Text = item.Attributes["text"].Value.ToUpper();
                                    nMenu.Tag = item.Attributes["click"].Value;
                                    nMenu.Click += new EventHandler(this.menu_click);
                                    menuXml.Items.Add(nMenu);
                                }
	                

                        }
                }
                catch (Exception)
                {

                    throw;
                }
         frm.Controls.Add(menuXml);
         this.FRM = frm;
        }

        public void menu_click(object sender, EventArgs e)
        {
            try
            {
                String method = ((ToolStripMenuItem)sender).Tag.ToString();

                System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();

                MenuActions act = new MenuActions();

                System.Reflection.MethodInfo methodInfo = typeof(MenuActions).GetMethod(method);

                methodInfo.Invoke(act, new object[] { FRM });
            }
            catch (Exception)
            {
                
                throw;
            }

        }
    }
}
