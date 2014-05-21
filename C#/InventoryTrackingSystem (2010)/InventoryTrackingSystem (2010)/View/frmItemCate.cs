using System.Windows.Forms;

namespace InventoryTrackingSystem
{
    public partial class frmItemCate : Form
    {
       
        public frmItemCate()
        {
            InitializeComponent();
        }

        #region System
        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
       
        #endregion

        ItemCategories _ItemCategory = new ItemCategories();
        private bool isEdit = false;

        //Autocomplete Data Mehod

        public string exCategory(string cat)
        {
            string stock="";
            if (cmbStock.SelectedIndex != -1)
            {
                switch (cmbStock.SelectedIndex)
                {
                    case 0:
                        stock = Stock.GE.ToString();
                        break;
                    case 1:
                        stock = Stock.FA.ToString();
                        break;
                    case 2:
                        stock = Stock.EC.ToString();
                        break;
                }
            }

          return _ItemCategory.Get(cat,stock);
        }

        //FORM SAVE 
        private void btnSave_Click(object sender, System.EventArgs e)
        {
            StockFields _categoryData = new StockFields();
            string errorMessage = "";
          

            if (cmbStock.SelectedIndex == -1)
            {
                errorMessage += "Select Stock ! \n";
            }
            else
            {
                switch (cmbStock.SelectedIndex)
                {
                    case 0:
                        _categoryData.Stock = Stock.GE.ToString();
                           break;
                    case 1:
                        _categoryData.Stock = Stock.FA.ToString();
                            break;
                    case 2:
                        _categoryData.Stock = Stock.EC.ToString();
                            break;
                }
            }

            if ((_categoryData.Code = Data.Feed(txtCatCode.Text, true)) == null)
            {
                errorMessage += "Insert Category Code ! \n";
            }
            if ((_categoryData.Name = Data.Feed(txtCatName.Text, true)) == null)
            {
                errorMessage += "Insert Category Name ! \n";
            }

            _categoryData.Description = Data.Feed(txtCatDesc.Text, false);

            if (errorMessage != "")
            {
                ntGenaralCategory.ShowErr("Error !");
                MessageBox.Show(errorMessage);
            }
            else
            {
                if (isEdit)
                {
                    if (_ItemCategory.Update(_categoryData) > 0)
                    {
                        ntGenaralCategory.Show("Saved !");
                        clr();
                    }
                }
                else
                {

                    if (_ItemCategory.Save(_categoryData) > 0)
                    {
                        ntGenaralCategory.Show("Saved !");
                        clr();
                    }
                }
            }
            
        }

        
        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            clr();
        }

        public void loadExData(string code)
        {
            var result = _ItemCategory.checkExData(code);
            if (result != null)
            {
                string res = MessageBox.Show("Do you want load this recode ?", "Load existing recode !", MessageBoxButtons.YesNo).ToString();
                if (res == "Yes")
                {
                    txtCatCode.Enabled = false;
                    txtCatCode.Text = result.Code;
                    txtCatName.Text = result.Name;
                    txtCatDesc.Text = result.Description;
                    switch (result.Stock)
                    {
                        case "GE":
                            cmbStock.SelectedIndex = 0;
                            break;
                        case "FA":
                            cmbStock.SelectedIndex = 1;
                            break;
                        case "EC":
                            cmbStock.SelectedIndex = 2;
                            break;
                    }
                    isEdit = true;
                    btnDelete.Enabled = true;
                }
            }
        }

      //FORM Clear 
        private void clr()
        {
            txtCatCode.Text = "";
            txtCatCode.Enabled = true;
            txtCatName.Text = "";
            txtCatDesc.Text = "";
            if (Stat.selected == 10)
            {
                cmbStock.SelectedIndex = -1;
            }
            txtCatCode.Focus();
            isEdit = false;
            btnDelete.Enabled = false;
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            string res = MessageBox.Show("Do you want to delete this recode ?", "Delete existing recode !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString();
            if (res == "Yes")
            {
                if (_ItemCategory.Delete(txtCatCode.Text) > 0)
                {
                    ntGenaralCategory.Show("Deleted !");
                    clr();
                }
            }
            
        }

        private void frmItemCate_Load(object sender, System.EventArgs e)
        {
            switch (Stat.selected)
            {
                case 10:
                   
                    break;
                case 0:
                    cmbStock.SelectedIndex = 0;
                 
                    break;
                case 1:
                    cmbStock.SelectedIndex = 1;
                    
                    break;
                case 2:
                    cmbStock.SelectedIndex =2;
                   
                    break;

            }
        }

        private void frmItemCate_FormClosed(object sender, FormClosedEventArgs e)
        {
            Stat.selected = 10;
        }


    }
}
