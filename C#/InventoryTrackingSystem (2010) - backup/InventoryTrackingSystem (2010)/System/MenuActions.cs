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
        public void show(frmMain frm)
        {
            frm.miscContainerPanel_show();
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

        public void mtrCategories(frmMain frm)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmItemCate))
                {
                    form.Activate();
                    return;
                }
            }
            Form frmLoc = new frmItemCate();
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
        public void rptShrtNm(frmMain frm)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmReportShrNM))
                {
                    form.Activate();
                    return;
                }
            }
            Form frmLoc = new frmReportShrNM();
            frmLoc.MdiParent = frm;
            frmLoc.Show();
        }
        public void rptGTN(frmMain frm)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmReportGTN))
                {
                    form.Activate();
                    return;
                }
            }
            Form frmLoc = new frmReportGTN();
            frmLoc.MdiParent = frm;
            frmLoc.Show();
        }

        public void rptGDN(frmMain frm)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmReportGDN))
                {
                    form.Activate();
                    return;
                }
            }
            Form frmLoc = new frmReportGDN();
            frmLoc.MdiParent = frm;
            frmLoc.Show();
        }

        public void sysBackup(frmMain frm)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Backup))
                {
                    form.Activate();
                    return;
                }
            }
            Form frmLoc = new Backup();
            frmLoc.MdiParent = frm;
            frmLoc.Show();
        }

        public void sysRestore(frmMain frm)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Restore))
                {
                    form.Activate();
                    return;
                }
            }
            Form frmLoc = new Restore();
            frmLoc.MdiParent = frm;
            frmLoc.Show();
        }

        public void sysAddUser(frmMain frm)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(AddUser))
                {
                    form.Activate();
                    return;
                }
            }
            Form frmLoc = new AddUser();
            frmLoc.MdiParent = frm;
            frmLoc.Show();
        }

        public void sysEditUser(frmMain frm)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(EditUser))
                {
                    form.Activate();
                    return;
                }
            }
            Form frmLoc = new EditUser();
            frmLoc.MdiParent = frm;
            frmLoc.Show();
        }
    }
}
