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
    public partial class Login : Form
    {
        String connectionString = "Server=DESKTOP-4P5ADJ9\\SQLEXPRESS;Database=AdvanceProgramming;User Id=utbUser; Password=utbUser;";
        SqlConnection dbConnection;

        string sql;
        SqlCommand command;
        SqlDataReader dataReader;

        public Login()
        {
            InitializeComponent();
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();
            if (dbConnection != null && dbConnection.State == ConnectionState.Open)
            {
                sql = "Select Id From Student where Name='" + tbUsername.Text + "' AND Password='" + tbPassword.Text + "'";
                command = new SqlCommand(sql, dbConnection);
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows == false) //Not is a Student, maybe is a professor.
                {
                    dataReader.Close();

                    sql = "Select Id From Professor where Name='" + tbUsername.Text + "' AND Password='" + tbPassword.Text + "'";
                    command = new SqlCommand(sql, dbConnection);
                    dataReader = command.ExecuteReader();

                    if (dataReader.HasRows == false) //Either is a Professor.
                    {
                        MessageBox.Show("Invalid username or password");
                        dataReader.Close();
                        command.Dispose();
                        dbConnection.Close();
                    }
                    else
                    {
                        dataReader.Close();
                        int idProfessor = Convert.ToInt32(command.ExecuteScalar());

                        MessageBox.Show("Welcome. " + tbUsername.Text);

                        command.Dispose();
                        dbConnection.Close();



                    }

                }
            }
        }
        
        private void llForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.Show();
            this.Close();
        }
    }
}
