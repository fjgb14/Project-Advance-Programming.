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
    public partial class CreateAnswerStudent : Form
    {
        String connectionString = "Server=DESKTOP-4P5ADJ9\\SQLEXPRESS;Database=AdvanceProgramming;User Id=utbUser; Password=utbUser;";
        SqlConnection dbConnection;

        string sql;
        SqlCommand command;

        int studentId;
        int codeExam;
        int numberQuestion;
        int CorrectQuestions;
        int numberAnswerCorrect;
        String nameStudent;

        public CreateAnswerStudent(int idStudent, int codeExam, int numberQuestion, int CorrectQuestions)
        {
            InitializeComponent();

            this.studentId = idStudent;
            this.codeExam = codeExam;
            this.numberQuestion = numberQuestion;
            this.CorrectQuestions = CorrectQuestions;
            
            rb1.Checked = true;

            this.lQuestionN.Text = "Question " + numberQuestion;

            showAnswerQuestion();

            if (numberQuestion == 5)
            {
                bNextQuestion.Visible = false;
                bFinish.Visible = true;
            }
            else
            {
                bNextQuestion.Visible = true;
                bFinish.Visible = false;
            }
        }

        private void showAnswerQuestion()
        {
            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            sql = "Select NameQuestion,Answer_1,Answer_2,Answer_3,Answer_4,NumberAnswerCorrect from Question where NumberQuestion =" + numberQuestion + " and CodeExam =" + codeExam;
            command = new SqlCommand(sql, dbConnection);
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                String nameQuestion = dataReader.GetString(0);
                String Answer_1 = dataReader.GetString(1);
                String Answer_2 = dataReader.GetString(2);
                String Answer_3 = dataReader.GetString(3);
                String Answer_4 = dataReader.GetString(4);
                numberAnswerCorrect = dataReader.GetInt32(5);

                labelNameQuestion.Text = nameQuestion;
                labelAnswer1.Text = Answer_1;
                labelAnswer2.Text = Answer_2;
                labelAnswer3.Text = Answer_3;
                labelAnswer4.Text = Answer_4;
            }
            dataReader.Close();
            command.Dispose();
            dbConnection.Close();
        }

        private void bNextQuestion_Click(object sender, EventArgs e)
        {
                if (numberAnswerCorrect == 1 && rb1.Checked == true)
                {
                    CorrectQuestions = CorrectQuestions + 1;
                }
                else if (numberAnswerCorrect == 2 && rb2.Checked == true)
                {
                    CorrectQuestions = CorrectQuestions + 1;
                }
                else if (numberAnswerCorrect == 3 && rb3.Checked == true)
                {
                    CorrectQuestions = CorrectQuestions + 1;
                }
                else if(numberAnswerCorrect == 4 && rb4.Checked == true)
                {
                    CorrectQuestions = CorrectQuestions + 1;
                }


                CreateAnswerStudent createAnswerStudent = new CreateAnswerStudent(studentId, codeExam, numberQuestion + 1, CorrectQuestions);
                this.Hide();
                createAnswerStudent.ShowDialog();
        }

        private void bFinish_Click(object sender, EventArgs e)
        {


                if (numberAnswerCorrect == 1 && rb1.Checked == true)
                {
                    CorrectQuestions = CorrectQuestions + 1;
                }
                else if (numberAnswerCorrect == 2 && rb2.Checked == true)
                {
                    CorrectQuestions = CorrectQuestions + 1;
                }
                else if (numberAnswerCorrect == 3 && rb3.Checked == true)
                {
                    CorrectQuestions = CorrectQuestions + 1;
                }
                else if (numberAnswerCorrect == 4 && rb4.Checked == true)
                {
                    CorrectQuestions = CorrectQuestions + 1;
                }

                dbConnection = new SqlConnection(connectionString);
                dbConnection.Open();

                sql = "Select Name From Student where Id =" + studentId;
                command = new SqlCommand(sql, dbConnection);
                SqlDataReader dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    nameStudent = dataReader.GetString(0);
                }


                dataReader.Close();
                command.Dispose();
                dbConnection.Close();

                updateMark(studentId, codeExam);

                MainStudent mainStudent = new MainStudent(studentId, nameStudent);
                MessageBox.Show("Successfully completed test.");
                MessageBox.Show("Your mark is:" + (CorrectQuestions * 2));
                this.Hide();
                mainStudent.ShowDialog();
            
        }

        private void updateMark(int studentId, int codeExam)
        {
            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            sql = "UPDATE Exam_Student SET Grade = '" + (CorrectQuestions * 2) + "' WHERE IdStudent = '" + studentId + "' and CodeExam= '" + codeExam + "'";
            command = new SqlCommand(sql, dbConnection);
            command.ExecuteNonQuery();

            command.Dispose();
            dbConnection.Close();
        }
    }
}
