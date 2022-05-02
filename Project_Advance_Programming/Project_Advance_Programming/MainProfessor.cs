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
    public partial class MainProfessor : Form
    {
        String connectionString = "Server=DESKTOP-4P5ADJ9\\SQLEXPRESS;Database=AdvanceProgramming;User Id=utbUser; Password=utbUser;";
        SqlConnection dbConnection;

        string sql;
        SqlCommand command;
        SqlDataReader dataReader;

        int id;
        String username;
        public MainProfessor(int idProfessor, string name)
        {
            InitializeComponent();
            this.id = idProfessor;
            this.username = name;
            LoadStudents();

        }

        private void BProfile_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(id);
            profile.Show();
            this.Hide();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void linklCreateAExam_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateAExam createAExam = new CreateAExam(id, username);
            createAExam.Show();
            this.Hide();
        }
        private void LoadStudents()
        {

            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            sql = "Select NameStudent,NameExam,Grade from Exam_Student where CodeExam in (Select CodeExam from Exam where IdProfessor='" + id + "')";
            command = new SqlCommand(sql, dbConnection);
            dataReader = command.ExecuteReader();

            if (dataReader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dataReader);
                dgvEXAM_STUDENT.DataSource = dt;
            }
            else
            {
                dgvEXAM_STUDENT.DataSource = null;
                MessageBox.Show("Work but there are not yet.");
            }

            dataReader.Close();
            command.Dispose();
            dbConnection.Close();

        }
    }
}
