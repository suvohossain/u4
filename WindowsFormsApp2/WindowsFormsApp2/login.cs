using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            {
                string Username = "U123";
                string password = "Password123";
                if (txtUsername.Text == Username && txtPassword.Text == password)
                {
                    MessageBox.Show("Login successful");
                    Form1 frm1 = new Form1();
                    frm1.Show();
                }
                else MessageBox.Show("Please enter valid email and password");
            }
        }
    }
}
