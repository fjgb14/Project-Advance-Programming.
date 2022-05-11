using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Advance_Programming
{
    public partial class TemporalPassword : Form
    {
        String connectionString = "Server=DESKTOP-4P5ADJ9\\SQLEXPRESS;Database=AdvanceProgramming;User Id=utbUser; Password=utbUser;";
        SqlConnection dbConnection;

        string sql;
        SqlCommand command;

        int Id;
        string Name;
        string User;
        string Password;

        public TemporalPassword(int id, string name, string user,string password)
        {
            InitializeComponent();
            this.Id = id;
            this.Name = name;
            this.User = user;
            this.Password = password;
        }

        private void bChangePassword_Click(object sender, EventArgs e)
        {
            if (tbNewPassword.Text == "" || tbPassword.Text == "" || !tbPassword.Text.Equals(Password))
            {
                MessageBox.Show("Please enter a correct password.");

            }
            else
            {
                sql = "Update " + User + " set Password = '" + Eramake.eCryptography.Encrypt(tbNewPassword.Text) + "', PasswordChanged = 'y' where Id =" + Id + ";";

                dbConnection = new SqlConnection(connectionString);
                dbConnection.Open();
                command = new SqlCommand(sql, dbConnection);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.UpdateCommand = command;
                adapter.UpdateCommand.ExecuteNonQuery();
                command.Dispose();
                MessageBox.Show("Password has been changed successfully.");
                Profile profile = new Profile(Id);
                profile.Show();
                this.Hide();
            }
        }
    }
}
