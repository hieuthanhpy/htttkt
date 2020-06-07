using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTTTKT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void password_Click(object sender, EventArgs e)
        {

        }

        private void inputUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (txt_Username.ToString() == "" || txt_Password.ToString() == "")
            {
                MessageBox.Show("Please provide Username and Password");
                return;
            }
        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
