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
            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();
            sql = "SELECT Password,Email FROM Student WHERE Email = '" + tbEmail.Text + "';";
            command = new SqlCommand(sql, dbConnection);
            dataReader = command.ExecuteReader();

            if (dataReader.HasRows == false) //Not is a Student, maybe is a professor.
            {
                dataReader.Close();
                sql = "Select Password,Email From Professor where Email='" + tbEmail.Text + "';";
                command = new SqlCommand(sql, dbConnection);
                dataReader = command.ExecuteReader();

                if (dataReader.HasRows == false) //Either is a Professor.
                {
                    MessageBox.Show("Invalid email.");
                    dataReader.Close();
                    command.Dispose();
                    dbConnection.Close();
                }
                else //Professor
                {
                    dataReader.Read();
                    String password = Eramake.eCryptography.Decrypt(dataReader.GetString(0));
                    String email = dataReader.GetString(1);

                    var mailService = new SystemSupportMail();
                    int number = mailService.sendMail(
                        subject: "SYSTEM: Password recovery request.",
                        body: "Hello, you have requested to recover your password.\nYour current password is: " + password +
                        " .\nHowever, we strongly recommend that you change it when you log in.",
                        recipientMail: new List<String> { email }
                        );
                    if (number != 0) { 
                        MessageBox.Show("The email have been sent successfully.");
                    }
                    dataReader.Close();
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
                String password = Eramake.eCryptography.Decrypt(dataReader.GetString(0));
                String email = dataReader.GetString(1);

                var mailService = new SystemSupportMail();
                int number = mailService.sendMail(
                    subject: "SYSTEM: Password recovery request.",
                    body: "Hello, you have requested to recover your password.\nYour current password is: " + password +
                    " .\nHowever, we strongly recommend that you change it when you log in.",
                    recipientMail: new List<String> { email }
                    );
                if (number != 0)
                {
                    MessageBox.Show("The email have been sent successfully.");
                }

                dataReader.Close();
                command.Dispose();
                dbConnection.Close();

                Login login = new Login();
                login.Show();
                this.Hide();


            }
        }
    }
}
