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
    public partial class Return : Form
    {
        private string initialReturnID;
        private string initialCarID;
        private string initialCustomerName;
        private string initialReturnDate;
        private string initialdtDelay;
        private string initialFine;

        public Return()
        {
            InitializeComponent();
            initialReturnID = txtID.Text;
            initialCarID = txtCar.Text;
            initialCustomerName = txtName.Text;
            initialReturnDate = dtReturnDate.Text;
            initialdtDelay = Delaytxt.Text;
            initialFine = txtFine.Text;
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Reset the User ID and password textboxes to their initial values
            txtID.Text = initialReturnID;
            txtCar.Text = initialCarID;
            txtName.Text = initialCustomerName;
            dtReturnDate.Text = initialReturnDate;
            Delaytxt.Text = initialdtDelay;
            txtFine.Text = initialFine;

        }

        // Create a connection with MS SQL Server
        SqlConnection con = new SqlConnection(@"Data Source=Anuu\SQLEXPRESS;Initial Catalog=CarRentalSystem;Integrated Security=True");

        private void DisplayData()
        {
            con.Open();
            string sql = " SELECT  * FROM RentalTable ";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            dtCarOnRent.DataSource = ds.Tables[0];
            con.Close();

        }

        private void DisplayReturnData()
        {
            con.Open();
            string sql = " SELECT  * FROM ReturnTable ";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            dgvCarsReturned.DataSource = ds.Tables[0];
            con.Close();

        }

        

        private void Return_Load(object sender, EventArgs e)
        {
            DisplayData();
            DisplayReturnData();
        }

        private void dtCarOnRent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dtCarOnRent.SelectedRows[0].Cells[0].Value.ToString();
            txtCar.Text = dtCarOnRent.SelectedRows[0].Cells[1].Value.ToString();
            txtName.Text = dtCarOnRent.SelectedRows[0].Cells[3].Value.ToString();
            dtReturnDate.Text = dtCarOnRent.SelectedRows[0].Cells[5].Value.ToString();
             

            // calculation

            DateTime d1 = dtReturnDate.Value.Date;
            DateTime d2 = DateTime.Now;
            TimeSpan T = d1 - d2;
            int no_of_days = Convert.ToInt32(T.TotalDays);
            if (no_of_days <= 0)
            {
                Delaytxt.Text  = "No Delay";
                txtFine.Text = " No Fine Added ";
            }
            else 
            {
                Delaytxt.Text = " " + no_of_days;
                txtFine.Text = " " + (no_of_days *500 );
            }


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtID.Text == " " || txtName.Text == " " || txtFine.Text == " "  || Delaytxt.Text == " ")
            {
                MessageBox.Show(" Missing Information ");
            }
            else
            {
                try
                {
                    con.Open();
                    string sql = "INSERT INTO ReturnTable VALUES (" + txtID.Text + ",'" + txtCar.Text + "','" + txtName.Text + "', '" + dtReturnDate.Text + "', '" + Delaytxt.Text + "','" + txtFine.Text + "')";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Car Returned Successfully  ");
                    con.Close();
                    //UpdateonRentals();
                    DisplayReturnData();
                    //DeleteOnReturn();


                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void dgvCarsReturned_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvCarsReturned.SelectedRows[0].Cells[0].Value.ToString();
            txtCar.Text = dgvCarsReturned.SelectedRows[0].Cells[1].Value.ToString();
            txtName.Text = dgvCarsReturned.SelectedRows[0].Cells[2].Value.ToString();
            dtReturnDate.Text = dgvCarsReturned.SelectedRows[0].Cells[3].Value.ToString();
            Delaytxt.Text = dgvCarsReturned.SelectedRows[0].Cells[4].Value.ToString();
            txtFine.Text = dgvCarsReturned.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text == " " || txtName.Text == " ")
            {
                MessageBox.Show(" Missing Information ");
            }
            else
            {
                try
                {
                    con.Open();
                    string sql = " DELETE FROM ReturnTable WHERE ID = " + txtID.Text + "; ";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Return Deleted Successfully ");
                    con.Close();
                    DisplayData();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
