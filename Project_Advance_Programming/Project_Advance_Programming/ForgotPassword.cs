using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Project_Advance_Programming
{
    public partial class ForgotPassword : Form
    {
        String connectionString = "Server=DESKTOP-4P5ADJ9\\SQLEXPRESS;Database=AdvanceProgramming;User Id=utbUser; Password=utbUser;";
        SqlConnection dbConnection;

        string sql;
        SqlCommand command;
        SqlDataReader dataReader;

        String randomPassword = "";

        public ForgotPassword()
        {
            InitializeComponent();
        }



        private void bBack_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void bAccept_Click(object sender, EventArgs e)
        {

            using (var crypto = new RNGCryptoServiceProvider())
            {
                var byte_size = ((10 + 7) / 3);
                var bytesarray = new byte[byte_size];
                crypto.GetBytes(bytesarray);
                randomPassword = Convert.ToBase64String(bytesarray);
            }
            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();
            sql = "SELECT Id FROM Student WHERE Email = '" + tbEmail.Text + "';";
            command = new SqlCommand(sql, dbConnection);
            dataReader = command.ExecuteReader();

            if (dataReader.HasRows == false) //Not is a Student, maybe is a professor.
            {
                dataReader.Close();
                sql = "Select Id From Professor where Email='" + tbEmail.Text + "';";
                command = new SqlCommand(sql, dbConnection);
                dataReader = command.ExecuteReader();

                if (dataReader.HasRows == false) //Either is a Professor.
                {
                    MessageBox.Show("This email not is registered.");
                    dataReader.Close();
                    command.Dispose();
                    dbConnection.Close();
                }
                else //Professor
                {
                    dataReader.Read();
                    int id = dataReader.GetInt32(0);
                    dataReader.Close();
                    command.Dispose();

                    sql = "UPDATE Professor SET Password = '" + Eramake.eCryptography.Encrypt(randomPassword) + "', PasswordChanged = 'n' WHERE Id = '" + id + "'";
                    command = new SqlCommand(sql, dbConnection);
                    command.ExecuteNonQuery();

                    var mailService = new SystemSupportMail();
                    int number = mailService.sendMail(
                        subject: "SYSTEM: Password recovery request.",
                        body: "Hello, you have requested to recover your password.\nYour temporal password is: " + randomPassword +
                        " .\nHowever, we strongly recommend that you change it when you log in.",
                        recipientMail: new List<String> { tbEmail.Text }
                        );
                    if (number != 0) { 
                        MessageBox.Show("The email have been sent successfully.");
                    }
                    
                    command.Dispose();
                    dbConnection.Close();
                    Login login = new Login();
                    login.Show();
                    this.Hide();

                }
            }
            else //Student
            {
                dataReader.Read();
                int id = dataReader.GetInt32(0);
                dataReader.Close();
                command.Dispose();

                sql = "UPDATE Student SET Password = '" + Eramake.eCryptography.Encrypt(randomPassword) + "', PasswordChanged = 'n' WHERE Id = '" + id + "'";
                command = new SqlCommand(sql, dbConnection);
                command.ExecuteNonQuery();

                var mailService = new SystemSupportMail();
                int number = mailService.sendMail(
                    subject: "SYSTEM: Password recovery request.",
                    body: "Hello, you have requested to recover your password.\nYour temporal password is: " + randomPassword +
                    " .\nHowever, We strongly recommend that you change it when you log in.",
                    recipientMail: new List<String> { tbEmail.Text }
                    );
                if (number != 0)
                {
                    MessageBox.Show("The email have been sent successfully.");
                }

                
                command.Dispose();
                dbConnection.Close();

                Login login = new Login();
                login.Show();
                this.Hide();


            }
        }
    }
}
