using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RestoreDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = @"RESTORE DATABASE TimeAttendance
                        FROM  DISK = 'E:\Projects\C#\BMTInterface\BMTInterface\bin\Release\TimeAttendance.bak'";
                
            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Integrated Security=True;");
            SqlCommand cmd = new SqlCommand(a);
            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
