using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using MySql.Data.MySqlClient;

namespace CrystalReportTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;User Id=root;password=123;database=hec_its;Persist Security Info=True");
            string query = "SELECT `trans_code` AS `DataColumn1`,`item_cat` AS `DataColumn2`,`current_user` AS `DataColumn3` FROM its_stock_trans";
            MySqlDataAdapter adepter = new MySqlDataAdapter(query, con);
            DataSet1 Ds = new DataSet1();

            adepter.Fill(Ds, "DataTable1");
                    
            CrystalReport1 cryRpt = new CrystalReport1();

            MessageBox.Show(Ds.GetXml());
            cryRpt.SetDataSource(Ds);

            rpt.ReportSource = cryRpt;

        }
    }
}
