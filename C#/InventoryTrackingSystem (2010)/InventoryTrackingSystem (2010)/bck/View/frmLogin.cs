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
                this.Hide();
           // }
            
           
        }



    }
}
