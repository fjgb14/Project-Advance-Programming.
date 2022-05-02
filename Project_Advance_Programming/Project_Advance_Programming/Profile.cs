using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Advance_Programming
{
    public partial class Profile : Form
    {
        String connectionString = "Server=DESKTOP-4P5ADJ9\\SQLEXPRESS;Database=AdvanceProgramming;User Id=utbUser; Password=utbUser;";
        SqlConnection dbConnection;

        string sql;
        SqlCommand command;
        SqlDataReader dataReader;

        Boolean Professor;
        int idUser;
        String user = "";
        String checkEmail = "";

        public Profile(int Id)
        {
            InitializeComponent();
            this.idUser = Id;

            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();
            if (dbConnection != null && dbConnection.State == ConnectionState.Open)
            {
                sql = "Select * From Student where Id= " + idUser + ";";
                command = new SqlCommand(sql, dbConnection);
                dataReader = command.ExecuteReader();

                if (dataReader.HasRows == false) //Not is a Student,is a professor.
                {
                    dataReader.Close();

                    sql = "Select * From Professor where Id= " + idUser + ";";
                    command = new SqlCommand(sql, dbConnection);
                    dataReader = command.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        dataReader.Read();
                        tbUsername.Text = dataReader.GetString(1);
                        tbPassword.Text = Eramake.eCryptography.Decrypt(dataReader.GetString(2));
                        tbEmail.Text = dataReader.GetString(3);
                        checkEmail = tbEmail.Text;
                        user = "Professor";
                        Professor = true;
                        dataReader.Close();
                    }

                }
                else //Student
                {
                    dataReader.Read();
                    tbUsername.Text = dataReader.GetString(1);
                    tbPassword.Text = Eramake.eCryptography.Decrypt(dataReader.GetString(2));
                    tbEmail.Text = dataReader.GetString(3);
                    checkEmail = tbEmail.Text;
                    user = "Student";
                    Professor = false;
                    dataReader.Close();

                }

            }
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            if (Professor == true)
            {
                MainProfessor mainProfessor = new MainProfessor(idUser, tbUsername.Text);
                mainProfessor.lWelcomeProfessor.Text = "Welcome " + tbUsername.Text;
                mainProfessor.Show();

                command.Dispose();
                dbConnection.Close();
                this.Hide();
            }
            else {
                MainStudent mainStudent = new MainStudent(idUser, tbUsername.Text);
                mainStudent.labelWelcomeStudent.Text = "Welcome " + tbUsername.Text;
                mainStudent.Show();

                command.Dispose();
                dbConnection.Close();
                this.Hide();
            }
        }

        private void bChangeEmail_Click(object sender, EventArgs e)
        {
            if (!new EmailAddressAttribute().IsValid(tbEmail.Text))
            {
                MessageBox.Show("Please, write a correct Email.");
            } else if (tbEmail.Text == checkEmail) {}
            else {
                DialogResult res = DialogResult.OK;
                do {
                    Random r = new Random();
                    int verifiedCode = r.Next(100000, 1000000);

                    var mailService = new SystemSupportMail();
                    int number = mailService.sendMail(
                        subject: "SYSTEM: Confirmation mail change.",
                        body: "You have requested a change of email address, please enter the code we have sent you below to complete the verification.\n" +
                        "Your verification code is: " + verifiedCode + " .\n",
                        recipientMail: new List<String> { tbEmail.Text }
                    );

                    if (number != 0)
                    {
                        try
                        {

                            int result = Convert.ToInt32(Interaction.InputBox("Enter the code:", "Verification"));
                            if (result == verifiedCode)
                            {
                                sql = "Update " + user + " set Email = '" + tbEmail.Text + "' where Id =" + idUser + ";";
                                command = new SqlCommand(sql, dbConnection);

                                SqlDataAdapter adapter = new SqlDataAdapter();
                                adapter.UpdateCommand = command;
                                adapter.UpdateCommand.ExecuteNonQuery();
                                command.Dispose();
                                dbConnection.Close();

                                MessageBox.Show("Email has been changed successfully.");

                            }
                            else {
                                MessageBox.Show("The verification code is invalid.");
                                res = MessageBox.Show("Do you want to forward the mail?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Invalid characters.");
                            res = MessageBox.Show("Do you want to forward the mail?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        res = MessageBox.Show("Do you want to forward the mail?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    }
                } while (res == DialogResult.Yes);

                Profile p = new Profile(idUser);
                p.Show();
                this.Hide();
            }
        }

        private void bChangePassword_Click(object sender, EventArgs e)
        {
            if (tbNewPassword.Text == "" || tbNewPassword.Text == "" || tbNewPassword.Text != tbNewPassword.Text)
            {
                MessageBox.Show("Please enter a correct password.");

            }
            else
            {
                sql = "Update " + user + " set Password = '" + Eramake.eCryptography.Encrypt(tbNewPassword.Text) + "'  where Id =" + idUser + ";";
                command = new SqlCommand(sql, dbConnection);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.UpdateCommand = command;
                adapter.UpdateCommand.ExecuteNonQuery();
                command.Dispose();
                MessageBox.Show("Password has been changed successfully.");
                Profile profile = new Profile(idUser);
                profile.Show();
                this.Hide();
            }
        }

    }
}
