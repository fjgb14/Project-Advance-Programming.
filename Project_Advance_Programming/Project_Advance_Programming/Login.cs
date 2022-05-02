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
                sql = "Select Id,Name From Student where Email='" + tbUsername.Text + "' AND Password='" + Eramake.eCryptography.Encrypt(tbPassword.Text) + "'";
                command = new SqlCommand(sql, dbConnection);
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows == false) //Not is a Student, maybe is a professor.
                {
                    dataReader.Close();

                    sql = "Select Id,Name From Professor where Email='" + tbUsername.Text + "' AND Password='" + Eramake.eCryptography.Encrypt(tbPassword.Text) + "'";
                    command = new SqlCommand(sql, dbConnection);
                    dataReader = command.ExecuteReader();

                    if (dataReader.HasRows == false) //Either is a Professor.
                    {
                        MessageBox.Show("Invalid username or password");
                        dataReader.Close();
                        command.Dispose();
                        dbConnection.Close();
                    }
                    else //Professor
                    {
                        dataReader.Read();
                        int idProfessor = dataReader.GetInt32(0);
                        String name = dataReader.GetString(1);

                        MessageBox.Show("Welcome. " + name);
                        
                        MainProfessor mainProfessor = new MainProfessor(idProfessor,name);
                        mainProfessor.lWelcomeProfessor.Text = "Welcome " + name;
                        mainProfessor.Show();

                        dataReader.Close();
                        command.Dispose();
                        dbConnection.Close();

                        this.Hide();

                    }

                }
                else //Student
                {
                    dataReader.Read();
                    int idStudent = dataReader.GetInt32(0);
                    String name = dataReader.GetString(1);

                    MessageBox.Show("Welcome. " + name);


                    MainStudent mainStudent = new MainStudent(idStudent,name);
                    mainStudent.labelWelcomeStudent.Text = "Welcome " + name;
                    mainStudent.Show();

                    dataReader.Close();
                    command.Dispose();
                    dbConnection.Close();

                    this.Hide();


                }

            }
        }

        private void EncryptPassword(int id,String encrypPass)
        {
            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            sql = "UPDATE Student SET Password = '" + encrypPass + "' WHERE Id = '" + id + "' and email= '" + tbUsername.Text + "'";
            command = new SqlCommand(sql, dbConnection);
            command.ExecuteNonQuery();

            command.Dispose();
            dbConnection.Close();
        }
        private void llForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.Show();
            this.Hide();
        }
    }
}
