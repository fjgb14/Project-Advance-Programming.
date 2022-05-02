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
    public partial class CreateAExam : Form
    {
        String connectionString = "Server=DESKTOP-4P5ADJ9\\SQLEXPRESS;Database=AdvanceProgramming;User Id=utbUser; Password=utbUser;";
        SqlConnection dbConnection;

        string sql;
        SqlCommand command;
        SqlDataAdapter adapter;

        
        int codeExam;
        int idProfessor;
        String name;

        public CreateAExam(int id, string username)
        {
            InitializeComponent();
            this.idProfessor = id;
            this.name = username;
            this.tbCodeExam.Text = "";
            this.tbNameExam.Text = "";
        }

        private void bEXIT_Click(object sender, EventArgs e)
        {
            MainProfessor mainProfessor = new MainProfessor(idProfessor, name);
            mainProfessor.lWelcomeProfessor.Text = "Welcome " + name;
            mainProfessor.Show();
            this.Hide();
        }

        private void bNext_Click(object sender, EventArgs e)
        {
            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            sql = "Select * from Exam where CodeExam =" + int.Parse(tbCodeExam.Text);
            command = new SqlCommand(sql, dbConnection);
            SqlDataReader dataReader = command.ExecuteReader();
            Boolean exists = dataReader.HasRows;

            dataReader.Close();
            command.Dispose();

            if (exists)
            {
                MessageBox.Show("Error.This code already exists");
                dbConnection.Close();
            }
            else
            {

                codeExam = int.Parse(tbCodeExam.Text);
                sql = "insert into Exam values ('" + codeExam + "','" + tbNameExam.Text + "','" + idProfessor + "')";
                command = new SqlCommand(sql, dbConnection);

                adapter = new SqlDataAdapter();
                adapter.InsertCommand = command;
                adapter.InsertCommand.ExecuteNonQuery();

                adapter.Dispose();
                command.Dispose();
                dbConnection.Close();
                CreateQuestion createQuestion = new CreateQuestion(codeExam, 1, idProfessor);
                this.Hide();
                createQuestion.ShowDialog();
            }
        }
    }
}
