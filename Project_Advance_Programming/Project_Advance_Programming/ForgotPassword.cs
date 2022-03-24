using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Advance_Programming
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
            lNewPassword.Hide();
            lRepeatPassword.Hide();
            bSaveChanges.Hide();
            tbNewPassword.Hide();
            tbRepeatPassword.Hide();
        }

        private void bChangePassword_Click(object sender, EventArgs e)
        {
            lNewPassword.Show();
            lRepeatPassword.Show();
            bSaveChanges.Show();
            tbNewPassword.Show();
            tbRepeatPassword.Show();
            bChangePassword.Hide();

        }

        private void bBack_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
