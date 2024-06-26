using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CourseWorkEx_1
{
    public partial class Rentals : Form
    {
        private string initialRentId;
        private string initialCarReg;
        private string initialCustomerID;
        private string initialCustomerName;
        private string initialdtRentalDate;
        private string initialdtReturnedDate;
        private string initialRentalFee;

        public Rentals()
        {
            InitializeComponent();

            // Initialize the initial values of User ID and password
            initialRentId = txtID.Text;
            initialCarReg = cmbCarReg.Text;
            initialCustomerID = cmbCustomerID.Text;
            initialCustomerName = txtName.Text;
            initialdtRentalDate = dtRentalDate.Text;
            initialdtReturnedDate = dtReturnedDate.Text;
            initialRentalFee = txtRentFee.Text;
        }

        // Create a connection with MS SQL Server
        SqlConnection con = new SqlConnection(@"Data Source=Anuu\SQLEXPRESS;Initial Catalog=CarRentalSystem;Integrated Security=True");

        private void FillCarReg()
        {
            con.Open();
            string sql = "SELECT RegNo FROM CarTable WHERE Availability = 'yes'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("RegNo", typeof(String));
            dt.Load(rdr);
            cmbCarReg.ValueMember = "RegNo";
            cmbCarReg.DataSource = dt;
            con.Close();
        }

        private void FillCustomerID()
        {
            con.Open();
            string sql = "SELECT ID FROM CustomerTable";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(String));
            dt.Load(rdr);
            cmbCustomerID.ValueMember = "ID";
            cmbCustomerID.DataSource = dt;
            con.Close();
        }

        private void FetchCustomerName()
        {
            con.Open();
            string sql = "SELECT * FROM CustomerTable WHERE ID = @CustomerID";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@CustomerID", cmbCustomerID.SelectedValue.ToString());
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtName.Text = dr["CustomerName"].ToString();
            }
            con.Close();
        }

        private void DisplayData()
        {
            con.Open();
            string sql = "SELECT * FROM RentalTable";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            dgvRental.DataSource = ds.Tables[0];
            con.Close();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UpdateonRentals()
        {
            con.Open();
            string sql = "UPDATE CarTable SET Availability = 'No' WHERE RegNo = @RegNo";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@RegNo", cmbCarReg.SelectedValue.ToString());
            cmd.ExecuteNonQuery();
            MessageBox.Show("Car Updated Successfully");
            con.Close();
        }

        private void UpdateonRentDelete()
        {
            con.Open();
            string sql = "UPDATE CarTable SET Availability = 'Yes' WHERE RegNo = @RegNo";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@RegNo", cmbCarReg.SelectedValue.ToString());
            cmd.ExecuteNonQuery();
            MessageBox.Show("Car Updated Successfully");
            con.Close();
        }

        private void Rentals_Load(object sender, EventArgs e)
        {
            FillCarReg();
            FillCustomerID();
            DisplayData();
        }

        private void cmbCustomerID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FetchCustomerName();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text) || string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtRentFee.Text))
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string sql = "INSERT INTO RentalTable (ID, CarReg, CustomerID, Name, RentalDate, ReturnedDate, RentalFee) VALUES (@RentID, @CarReg, @CustomerID, @CustomerName, @RentalDate, @ReturnedDate, @RentalFee)";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@RentID", txtID.Text);
                    cmd.Parameters.AddWithValue("@CarReg", cmbCarReg.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@CustomerID", cmbCustomerID.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@CustomerName", txtName.Text);
                    cmd.Parameters.AddWithValue("@RentalDate", dtRentalDate.Text);
                    cmd.Parameters.AddWithValue("@ReturnedDate", dtReturnedDate.Text);
                    cmd.Parameters.AddWithValue("@RentalFee", txtRentFee.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Successfully Rented");
                    con.Close();
                    UpdateonRentals();
                    DisplayData();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Reset the User ID and password textboxes to their initial values
            txtID.Text = initialRentId;
            cmbCarReg.Text = initialCarReg;
            cmbCustomerID.Text = initialCustomerID;
            txtName.Text = initialCustomerName;
            dtRentalDate.Text = initialdtRentalDate;
            dtReturnedDate.Text = initialdtReturnedDate;
            txtRentFee.Text = initialRentalFee;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text) || string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string sql = "UPDATE RentalTable SET Name = @CustomerName, RentalDate = @RentalDate, ReturnedDate = @ReturnedDate WHERE ID = @RentID";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@RentID", txtID.Text);
                    cmd.Parameters.AddWithValue("@CustomerName", txtName.Text);
                    cmd.Parameters.AddWithValue("@RentalDate", dtRentalDate.Text);
                    cmd.Parameters.AddWithValue("@ReturnedDate", dtReturnedDate.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("System Updated Successfully");
                    con.Close();
                    DisplayData();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text) || string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string sql = "DELETE FROM RentalTable WHERE ID = @RentID";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@RentID", txtID.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Rental Deleted Successfully");
                    con.Close();
                    DisplayData();
                    UpdateonRentDelete();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void dgvRental_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvRental.SelectedRows[0].Cells[0].Value.ToString();
            cmbCarReg.SelectedValue = dgvRental.SelectedRows[0].Cells[1].Value.ToString();
            cmbCustomerID.SelectedValue = dgvRental.SelectedRows[0].Cells[2].Value.ToString();
            txtName.Text = dgvRental.SelectedRows[0].Cells[3].Value.ToString();
            dtRentalDate.Text = dgvRental.SelectedRows[0].Cells[4].Value.ToString();
            dtReturnedDate.Text = dgvRental.SelectedRows[0].Cells[5].Value.ToString();
            txtRentFee.Text = dgvRental.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
