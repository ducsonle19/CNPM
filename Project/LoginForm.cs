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
                tbPWord.Text = "";
                tbPWord.ForeColor = Color.Black;
            }
        }

        private void tbPWord_Leave(object sender, EventArgs e)
        {
            if (tbPWord.Text == "")
            {
                tbPWord.Text = "Password";
                tbPWord.ForeColor = Color.Gray;
            }
        }
    }
}
