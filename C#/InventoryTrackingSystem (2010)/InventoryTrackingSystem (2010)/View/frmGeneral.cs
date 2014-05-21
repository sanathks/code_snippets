using System.Windows.Forms;
using System;

namespace InventoryTrackingSystem
{
    public partial class frmGeneral : Form
    {
        public frmGeneral()
        {
            InitializeComponent();
        }

        #region System
        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
        #endregion

        GeneralItemGRN _generalItemsGRN = new GeneralItemGRN();
        private bool isEdit = false;

        private void frmGeneral_Load(object sender, System.EventArgs e)
        {
            refreshTable();
            setTranceCode();
        }

        #region ItemSummuryTable

        private void refreshTable()
        {
            dgvCurrentItrmList.Rows.Clear();

            var table = _generalItemsGRN.TableFill();
            foreach (var data in table)
            {
                string[] row = { data["item_cat"], data["cat_name"], data["current_qty"], data["value"] };
                dgvCurrentItrmList.Rows.Add(row);
            }

        }
        #endregion

        #region Basic Functions
        private void btnAddCat_Click(object sender, System.EventArgs e)
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
            frmLoc.MdiParent = this.ParentForm;
            Stat.selected = 0;
            frmLoc.Show();
        }

        private void setTranceCode()
        {
            txtTransCode.Text = _generalItemsGRN.getCurrentCode();
        }
        //Autocomplete ItemCat
        public string getItemCode(string code)
        {
            return _generalItemsGRN.GetItemCat(code);
        }
        //Autocomplete Location
        public string getLocation(string code)
        {
            //Log.write(code);
            return _generalItemsGRN.GetLocation(code);
        }

        #endregion

        #region Save
        private void btnSave_Click(object sender, System.EventArgs e)
        {
            TransFields _tranData = new TransFields();
            string errMag = "";

            _tranData.Date = dtDate.Value.ToString("yyyy-MM-dd");
            if ((_tranData.TransCode = Data.Feed(txtTransCode.Text, true)) == null)
            {
                errMag = "Invalide Trancs Code !\n";
            }
            _tranData.RefNo = Data.Feed(txtRefNo.Text, false);

            if ((_tranData.ItemCategory = Data.Feed(txtItemCat.Text, true)) == null)
            {
                errMag += "Insert Item Category !\n";
            }

            if ((_tranData.Qty = Data.Feed(txtQty.Text, true)) == null)
            {
                errMag += "Insert Item Qty !\n";
            }

            _tranData.Price = Data.Feed(txtUnitPr.Text, false);

            _tranData.Location = Data.Feed(txtLocation.Text, false);

            _tranData.Remark = Data.Feed(txtRemark.Text, false);

            if (errMag != "")
            {
                ntGenGRN.ShowErr("Error !");
                MessageBox.Show(errMag);
            }else
                {
                    if (isEdit)
                    {
                        if (_generalItemsGRN.Update(_tranData) > 0)
                        {
                            clr();
                            ntGenGRN.Show("Saved !");
                        }
                        else
                        {
                            ntGenGRN.ShowErr("Try again !");
                        }
                    }
                    else
                    {
                        if (_generalItemsGRN.Save(_tranData) > 0)
                        {
                            clr();
                            ntGenGRN.Show("Saved !");
                        }
                        else
                        {
                            ntGenGRN.ShowErr("Try again !");
                        }
                    }
                }

        }

        #endregion

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            clr();
        }

        private void clr()
        {
            dtDate.Text = "";
            txtRefNo.Text = "";
            txtItemCat.Text = "";
            txtQty.Text = "";
            txtUnitPr.Text = "";
            txtLocation.Text = "";
            txtRemark.Text = "";
            btnDelete.Enabled = false;
            txtTransCode.Enabled = true;
            isEdit = false;
            refreshTable();
            setTranceCode();
        }
     
        private void txtTranseCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var result = _generalItemsGRN.getDataByCode(txtTransCode.Text);
                if (result != null)
                {
                    string res = MessageBox.Show("Do you want load this recode ?", "Load existing recode !", MessageBoxButtons.YesNo).ToString();
                    if (res == "Yes")
                    {
                        txtTransCode.Enabled = false;
                        dtDate.Value = Convert.ToDateTime(result.Date);
                        txtRefNo.Text = result.RefNo;
                        txtItemCat.Text = result.ItemCategory;
                        txtQty.Text = result.Qty;
                        txtUnitPr.Text = result.Price;
                        txtLocation.Text = result.Location;
                        txtRemark.Text = result.Remark;
                        isEdit = true;
                        btnDelete.Enabled = true;
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            string res = MessageBox.Show("Do you want to delete this recode ?", "Delete existing recode ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString();
            if (res == "Yes")
            {
                if (_generalItemsGRN.Delete(txtTransCode.Text) > 0)
                {
                    ntGenGRN.Show("Deleted !");
                    clr();
                }
                else
                {
                    ntGenGRN.ShowErr("Try Again !");
                }
            }            
        }

        
    }
}
