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

        public void mtrEmployee(frmMain frm)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmEmployee))
                {
                    form.Activate();
                    return;
                }
            }
            Form frmLoc = new frmEmployee();
            frmLoc.MdiParent = frm;
            frmLoc.Show();
        }

        public void mtrGenItemCat(frmMain frm)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmGenItemCate))
                {
                    form.Activate();
                    return;
                }
            }
            Form frmLoc = new frmGenItemCate();
            frmLoc.MdiParent = frm;
            frmLoc.Show();
        }

        public void mtrElecItemCat(frmMain frm)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmElecItemCate))
                {
                    form.Activate();
                    return;
                }
            }
            Form frmLoc = new frmElecItemCate();
            frmLoc.MdiParent = frm;
            frmLoc.Show();
        }

        public void mtrFAItemCat(frmMain frm)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmFAItemCate))
                {
                    form.Activate();
                    return;
                }
            }
            Form frmLoc = new frmFAItemCate();
            frmLoc.MdiParent = frm;
            frmLoc.Show();
        }

        public void trnGenItem(frmMain frm)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmGeneral))
                {
                    form.Activate();
                    return;
                }
            }
            Form frmLoc = new frmGeneral();
            frmLoc.MdiParent = frm;
            frmLoc.Show();
        }

        public void trnFAItem(frmMain frm)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmFixtAsset))
                {
                    form.Activate();
                    return;
                }
            }
            Form frmLoc = new frmFixtAsset();
            frmLoc.MdiParent = frm;
            frmLoc.Show();
        }

        public void trnElecItem(frmMain frm)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmElecDivice))
                {
                    form.Activate();
                    return;
                }
            }
            Form frmLoc = new frmElecDivice();
            frmLoc.MdiParent = frm;
            frmLoc.Show();
        }

        public void trnGTNFA(frmMain frm)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmGTNFA))
                {
                    form.Activate();
                    return;
                }
            }
            Form frmLoc = new frmGTNFA();
            frmLoc.MdiParent = frm;
            frmLoc.Show();
        }

        public void trnGTNGen(frmMain frm)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmGTNGen))
                {
                    form.Activate();
                    return;
                }
            }
            Form frmLoc = new frmGTNGen();
            frmLoc.MdiParent = frm;
            frmLoc.Show();
        }

        public void trnGDN(frmMain frm)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmGDN))
                {
                    form.Activate();
                    return;
                }
            }
            Form frmLoc = new frmGDN();
            frmLoc.MdiParent = frm;
            frmLoc.Show();
        }

        public void sysSerReg(frmMain frm)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(DatabaseRegister))
                {
                    form.Activate();
                    return;
                }
            }
            Form frmLoc = new DatabaseRegister();
            frmLoc.MdiParent = frm;
            frmLoc.Show();
        }

       
    }
}
