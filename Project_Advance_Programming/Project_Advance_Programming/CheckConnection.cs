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
    public partial class CheckConnection : Form
    {

        String connectionString = "Server=DESKTOP-4P5ADJ9\\SQLEXPRESS;Database=AdvanceProgramming;User Id=utbUser; Password=utbUser;";
        SqlConnection dbConnection;


        public CheckConnection()
        {
            InitializeComponent();
        }

        private void BConnect_Click(object sender, EventArgs e)
        {
            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();
            if (dbConnection != null && dbConnection.State == ConnectionState.Open) {
                MessageBox.Show("The connection work.");
            }
        }

        private void bDisconnect_Click(object sender, EventArgs e)
        {
            dbConnection.Close();
            if (dbConnection.State == ConnectionState.Closed) {
                MessageBox.Show("The conexion is close.");
            }
        }
    }
}
