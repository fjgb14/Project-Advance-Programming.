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
    public partial class DoAExam : Form
    {
        String connectionString = "Server=DESKTOP-4P5ADJ9\\SQLEXPRESS;Database=AdvanceProgramming;User Id=utbUser; Password=utbUser;";
        SqlConnection dbConnection;

        string sql;
        SqlCommand command;
        SqlDataAdapter adapter;

        int CodeExam;
        int idStudent;
        String name;
        String nameExam;

        public DoAExam(int id, string username)
        {
            InitializeComponent();
            this.idStudent = id;
            this.name = username;
        }

        private void bSTART_Click(object sender, EventArgs e)
        {
            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();
            CodeExam = int.Parse(tbCodeExam.Text);
            sql = "Select * from Exam where CodeExam ='" + CodeExam + "'";
            command = new SqlCommand(sql, dbConnection);
            SqlDataReader dataReader = command.ExecuteReader();
            Boolean exists = dataReader.HasRows;

            dataReader.Close();
            command.Dispose();
            

            if (!exists)
            {
                MessageBox.Show("Error.The exam doesn´t exist with this code.");

                dbConnection.Close();
            }
            else
            {
                sql = "Select * from Exam_Student where CodeExam ='" + CodeExam + "' and IdStudent ='" + idStudent + "'";
                command = new SqlCommand(sql, dbConnection);
                SqlDataReader dataReade = command.ExecuteReader();
                Boolean did = dataReade.HasRows;

                dataReade.Close();
                command.Dispose();

                if (did)
                {
                    MessageBox.Show("You have done this exam.");

                    dbConnection.Close();

                }
                else //Create a exam Student.
                {


                    sql = "Select NameExam From Exam where CodeExam =" + CodeExam;
                    command = new SqlCommand(sql, dbConnection);
                    dataReader = command.ExecuteReader();
                    if (dataReader.Read())
                    {
                        nameExam = dataReader.GetString(0);
                    }


                    dataReader.Close();
                    command.Dispose();
                    


                    sql = "insert into Exam_Student (CodeExam,IdStudent,Grade,NameExam,NameStudent) values ('" + CodeExam + "','" + idStudent + "','" + 0 + "','" + nameExam + "','" + name + "')";
                    command = new SqlCommand(sql, dbConnection);

                    adapter = new SqlDataAdapter();
                    adapter.InsertCommand = command;
                    adapter.InsertCommand.ExecuteNonQuery();

                    adapter.Dispose();
                    command.Dispose();
                    dbConnection.Close();


                    CreateAnswerStudent createAnswerStudent = new CreateAnswerStudent(idStudent, CodeExam, 1, 0);
                    this.Hide();
                    createAnswerStudent.ShowDialog();
                }


            }
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            MainStudent mainStudent = new MainStudent(idStudent,name);
            mainStudent.labelWelcomeStudent.Text = "Welcome " + name;
            mainStudent.Show();
            this.Hide();
        }
    }
}
