using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class LoginForm : Form
    {
        private AccountDataBase adb = AccountDataBase.get();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void tbUName_Enter(object sender, EventArgs e)
        {
            if (tbUName.Text == "Username")
            {
                tbUName.Text = "";
                tbUName.ForeColor = Color.Black;
            }
        }

        private void tbUName_Leave(object sender, EventArgs e)
        {
            if (tbUName.Text == "")
            {
                tbUName.Text = "Username";
                tbUName.ForeColor = Color.Gray;
            }
        }

        private void tbPWord_Enter(object sender, EventArgs e)
        {
            if (tbPWord.Text == "Password")
            {
                tbPWord.UseSystemPasswordChar = true;
                tbPWord.Text = "";
                tbPWord.ForeColor = Color.Black;
            }
        }

        private void tbPWord_Leave(object sender, EventArgs e)
        {
            if (tbPWord.Text == "")
            {
                tbPWord.UseSystemPasswordChar = false;
                tbPWord.Text = "Password";
                tbPWord.ForeColor = Color.Gray;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = tbUName.Text;
            String password = tbPWord.Text;

            Account acc = adb.login(username, password);

            if (acc == null)
            {
                MessageBox.Show("Login fail!", "Error");
            }
            else
            {
                MessageBox.Show("Login successful!");
            }
        }
    }
}
