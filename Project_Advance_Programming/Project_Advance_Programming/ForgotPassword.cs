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
    public partial class ForgotPassword : Form
    {
        String connectionString = "Server=DESKTOP-4P5ADJ9\\SQLEXPRESS;Database=AdvanceProgramming;User Id=utbUser; Password=utbUser;";
        SqlConnection dbConnection;

        string sql;
        SqlCommand command;
        SqlDataReader dataReader;
        String user = "";

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
            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();
            if (dbConnection != null && dbConnection.State == ConnectionState.Open)
            {
                sql = "Select Id From Student where Name ='" + tbUserName.Text + "' AND SecretCode ='" + tbSecretCode.Text + "'";
                command = new SqlCommand(sql, dbConnection);
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows == false) //Not is a Student, maybe is a professor.
                {
                    dataReader.Close();

                    sql = "Select Id From Professor where Name ='" + tbUserName.Text + "' AND SecretCode ='" + tbSecretCode.Text + "'";
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

                        MessageBox.Show("Welcome. " + tbUserName.Text);

                        user = "Professor";

                        command.Dispose();


                        lNewPassword.Show();
                        lRepeatPassword.Show();
                        bSaveChanges.Show();
                        tbNewPassword.Show();
                        tbRepeatPassword.Show();
                        bChangePassword.Hide();

                    }

                }
                else
                {
                    dataReader.Close();
                    int idStudent = Convert.ToInt32(command.ExecuteScalar());

                    MessageBox.Show("Welcome. " + tbUserName.Text);

                    user = "Student";

                    dataReader.Close();
                    command.Dispose();


                    lNewPassword.Show();
                    lRepeatPassword.Show();
                    bSaveChanges.Show();
                    tbNewPassword.Show();
                    tbRepeatPassword.Show();
                    tbNewPassword.UseSystemPasswordChar = true;
                    bChangePassword.Hide();


                }
            }

        }

        private void bBack_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void bSaveChanges_Click(object sender, EventArgs e)
        {
            if (tbNewPassword.Text == "" || tbRepeatPassword.Text == "" || tbNewPassword.Text != tbRepeatPassword.Text) {
                MessageBox.Show("Please enter a correct password.");

            }
            else
            {
                sql = "Update "+ user + " set Password = '" + tbNewPassword.Text + "' where Name ='" + tbUserName.Text + "' AND SecretCode ='" + tbSecretCode.Text + "'";
                command = new SqlCommand(sql, dbConnection);
                
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.UpdateCommand = command;
                adapter.UpdateCommand.ExecuteNonQuery();
                command.Dispose();

            }
        }
    }
}
