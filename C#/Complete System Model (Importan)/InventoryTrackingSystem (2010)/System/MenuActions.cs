using System;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Forms;

namespace InventoryTrackingSystem
{
    class MenuActions
    {

        public void hide(frmMain frm)
        {
            frm.miscContainerPanel_show_hide();
        }

        public void mtrCompany(frmMain frm)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmCompanies))
                {
                    form.Activate();
                    return;
                }
            }
            frmCompanies frmCom = new frmCompanies();
            frmCom.MdiParent = frm;
            frmCom.Show();
        }

        public void mtrLocation(frmMain frm)
        {
           foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmLocations))
                {
                    form.Activate();
                    return;
                }
            }
           frmLocations frmLoc = new frmLocations();
           frmLoc.MdiParent = frm;
           frmLoc.Show();
        }



    }
}
