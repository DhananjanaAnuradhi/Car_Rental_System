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

namespace CourseWorkEx_1
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        // Create a connection with MS SQL Server
        SqlConnection con = new SqlConnection(@"Data Source=Anuu\SQLEXPRESS;Initial Catalog=CarRentalSystem;Integrated Security=True");

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            // Car Count
            string sqlCar = "SELECT COUNT(*) FROM CarTable";
            SqlCommand cmdCar = new SqlCommand(sqlCar, con);
            con.Open();
            int carCount = (int)cmdCar.ExecuteScalar();
            con.Close();
            CARSlbl.Text = carCount.ToString();

            // Customer Count
            string sqlCustomer = "SELECT COUNT(*) FROM CustomerTable";
            SqlCommand cmdCustomer = new SqlCommand(sqlCustomer, con);
            con.Open();
            int customerCount = (int)cmdCustomer.ExecuteScalar();
            con.Close();
            CUSTOMERSlbl.Text = customerCount.ToString();

            // User Count
            string sqlUser = "SELECT COUNT(*) FROM UserTable";
            SqlCommand cmdUser = new SqlCommand(sqlUser, con);
            con.Open();
            int userCount = (int)cmdUser.ExecuteScalar();
            con.Close();
            USERSlbl.Text = userCount.ToString();

        }

        private void CARSlbl_Click(object sender, EventArgs e)
        {

        }
    }
}
