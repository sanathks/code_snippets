using System.Windows.Forms;

namespace InventoryTrackingSystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        Login login = new Login();
        private void button3_Click(object sender, System.EventArgs e)
        {
          //  if (login.checkLogin(txtUsername.Text, txtPassword.Text) == 1)
           // {
                Stat.setLogin();
                this.Close();
           // }

        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            txtPassword.Text = "";
            txtUsername.Text = "";
        }



    }
}
