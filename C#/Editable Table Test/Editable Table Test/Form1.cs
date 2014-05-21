using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Editable_Table_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kryptonDataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button bt = new Button();
            bt.Text = "OK";
            grd.Rows.Add(txtCode.Text, txtName.Text, txtQty.Text, bt);
            grd.Rows.Add();
        }

        private void grd_RowDividerDoubleClick(object sender, DataGridViewRowDividerDoubleClickEventArgs e)
        {
            
        }

        private void grd_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("OK");
        }

       


      
    }
}
