using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace CallMethodByName
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            meth cmbn = new meth();

            // Get the desired method by name: DisplayName
            MethodInfo methodInfo =
               typeof(meth).GetMethod(txtMethodName.Text);

            // Use the instance to call the method without arguments
           methodInfo.Invoke(cmbn, null);
        }

       
    }
}
