using System;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Forms;

namespace InventoryTrackingSystem
{
    class MenuActions
    {

        public void items(frmMain frm)
        {
            frmItem ifrm = new frmItem();
            ifrm.MdiParent = frm;
            ifrm.Show();
        }

        public void hide(frmMain frm)
        {
            frm.miscContainerPanel_show_hide();
        }

    }
}
