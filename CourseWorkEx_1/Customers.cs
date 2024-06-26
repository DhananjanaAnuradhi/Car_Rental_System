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
    public partial class Customers : Form
    {
        private string initialID;
        private string initialName;
        private string initialAddress;
        private string initialTelephone;


        DataSet ds;



        public Customers()
        {
            InitializeComponent();

            // Initialize the initial values of User ID and password
            initialID = txtID.Text;
            initialName = txtName.Text;
            initialAddress = txtAddress.Text;
            initialTelephone = txtPhone.Text;

            var ds = new DataSet();


        }

        // Create a connection with MS SQL Server
        SqlConnection con = new SqlConnection(@"Data Source=Anuu\SQLEXPRESS;Initial Catalog=CarRentalSystem;Integrated Security=True");

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
            txtID.Text = initialID;
            txtName.Text = initialName;
            txtAddress.Text = initialAddress;
            txtPhone.Text = initialTelephone;
        }

        private void dgvCustomerList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvCustomerList.SelectedRows[0].Cells[0].Value.ToString();
            txtName.Text = dgvCustomerList.SelectedRows[0].Cells[1].Value.ToString();
            txtAddress.Text = dgvCustomerList.SelectedRows[0].Cells[2].Value.ToString();
            txtPhone.Text = dgvCustomerList.SelectedRows[0].Cells[3].Value.ToString();

        }

        // Display Users in Datagrid View 

        private void DisplayData()
        {
            con.Open();
            string sql = " SELECT  * FROM  CustomerTable ";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            dgvCustomerList.DataSource = ds.Tables[0];
            con.Close();

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtID.Text == " " || txtName.Text == " " || txtAddress.Text == " " || txtPhone.Text == " ")
            {
                MessageBox.Show(" Missing Information ");
            }
            else
            {
                try
                {
                    con.Open();
                    string sql = "INSERT INTO CustomerTable VALUES (" + txtID.Text + ",'" + txtName.Text + "','" + txtAddress.Text + "' ,'" + txtPhone.Text + "')";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Successfully Added ");
                    con.Close();
                    DisplayData();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            DisplayData();
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
                    string sql = " DELETE FROM CustomerTable WHERE ID = " + txtID.Text + "; ";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Customer Deleted Successfully ");
                    con.Close();
                    DisplayData();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtID.Text == " " || txtName.Text == " " || txtAddress.Text == " ")
            {
                MessageBox.Show(" Missing Information ");
            }
            else
            {
                try
                {
                    con.Open();
                    string sql = " UPDATE CustomerTable SET Name = '" + txtName.Text + "' ,Address = '" + txtAddress.Text +"' , Telephone = '" + txtPhone.Text +  "' WHERE ID = " + txtID.Text + ";";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Customer  Updated Successfully ");
                    con.Close();
                    DisplayData();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }
    }
}
