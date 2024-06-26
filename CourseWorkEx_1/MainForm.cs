using CourseWorkEx_1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkEx_1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cars car = new Cars();
            car.Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customers customers = new Customers();
            customers.Show();
        }

        private void btnRental_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rentals rental = new Rentals();
            rental.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Users users = new Users();
            users.Show();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Return @return = new Return();  
            @return.Show();

        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashBoard dashboard = new DashBoard();
            dashboard.Show();
        }


        private void Logout()
        {

           
            Login loginForm = new Login();
            loginForm.Show();

            // Close the current form
            this.Close();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
