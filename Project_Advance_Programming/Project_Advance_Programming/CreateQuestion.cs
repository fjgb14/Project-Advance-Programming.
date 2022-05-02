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
    public partial class CreateQuestion : Form
    {
        String connectionString = "Server=DESKTOP-4P5ADJ9\\SQLEXPRESS;Database=AdvanceProgramming;User Id=utbUser; Password=utbUser;";
        SqlConnection dbConnection;

        string sql;
        SqlCommand command;
        SqlDataAdapter adapter;
        SqlDataReader dataReader;

        int CodeExam;
        int numberQuestion;
        int idProfessor;

        public CreateQuestion(int codeExam, int numberQuestion, int idProfessor)
        {
            InitializeComponent();
            this.CodeExam = codeExam;
            this.numberQuestion = numberQuestion;
            this.idProfessor = idProfessor;

            this.lQuestionN.Text = "Question " + numberQuestion;
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

        private void QuestionCreate()
        {
            if (tbAnswer1.Text == null || tbAnswer1.Text == "" || tbAnswer2.Text == null || tbAnswer2.Text == "" || tbAnswer3.Text == null || tbAnswer3.Text == "" || tbAnswer4.Text == null || tbAnswer4.Text == "" || tbNameQuestion.Text == null || tbNameQuestion.Text == "" || tbNumberAnswerCorrect.Text == null || tbNumberAnswerCorrect.Text == "")
            {
                MessageBox.Show("Please enter the correct data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                dbConnection = new SqlConnection(connectionString);
                dbConnection.Open();
                sql = "insert into Question (NumberQuestion,NameQuestion,Answer_1,Answer_2,Answer_3,Answer_4,NumberAnswerCorrect,CodeExam) values ('" + numberQuestion + "','" + tbNameQuestion.Text + "','" + tbAnswer1.Text + "','" + tbAnswer2.Text + "','" + tbAnswer3.Text + "','" + tbAnswer4.Text + "','" + int.Parse(tbNumberAnswerCorrect.Text) + "','" + CodeExam + "')";
                command = new SqlCommand(sql, dbConnection);

                adapter = new SqlDataAdapter();
                adapter.InsertCommand = command;
                adapter.InsertCommand.ExecuteNonQuery();
                numberQuestion = numberQuestion + 1;

                adapter.Dispose();
                command.Dispose();
                dbConnection.Close();
            }
        }

        private String searchName(int idProfesor) {
            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();
            sql = "Select Name From Professor where Id=" + idProfesor;
            command = new SqlCommand(sql, dbConnection);
            dataReader = command.ExecuteReader();
            dataReader.Read();
            String name = dataReader.GetString(0);

            dataReader.Close();
            command.Dispose();
            dbConnection.Close();

            return name;
            
        
        }

        private void bNextQuestion_Click(object sender, EventArgs e)
        {
            QuestionCreate();
            CreateQuestion createQuestion = new CreateQuestion(CodeExam, numberQuestion, idProfessor);
            this.Hide();
            createQuestion.ShowDialog();
        }

        private void bFinish_Click(object sender, EventArgs e)
        {
            QuestionCreate();
            MainProfessor mainProfessor = new MainProfessor(idProfessor,searchName(idProfessor));
            MessageBox.Show("Exam successfully created.");
            this.Hide();
            mainProfessor.ShowDialog();
        }
    }
}
