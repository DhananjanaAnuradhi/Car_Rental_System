using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkEx_1
{
    public partial class Cars : Form
    {
        private string initialRegNo;
        private string initialBrand;
        private string initialModel;
        private string initialPrice;
        private string initialAvailability;


        DataSet ds;



        public Cars()
        {
            InitializeComponent();

            // Initialize the initial values of User ID and password
            initialRegNo = txtRegNo.Text;
            initialBrand = txtBrand.Text;
            initialModel = txtModel.Text;
            initialPrice = txtPrice.Text;
            initialAvailability = AvailableCMB.Text;




        }

        // Create a connection with MS SQL Server
        SqlConnection con = new SqlConnection(@"Data Source=Anuu\SQLEXPRESS;Initial Catalog=CarRentalSystem;Integrated Security=True");
        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Display Users in Datagrid View 

        private void DisplayData()
        {

            con.Open();
            string sql = " SELECT  * FROM CarTable ";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            datagridview_Car.DataSource = ds.Tables[0];
            con.Close();

        }




        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtRegNo.Text == " " || txtBrand.Text == " " || txtModel.Text == " " || txtPrice.Text == " ")
            {
                MessageBox.Show(" Missing Information ");
            }
            else
            {
                try
                {
                    con.Open();
                    string sql = "INSERT INTO CarTable VALUES (" + txtRegNo.Text + ",'" + txtBrand.Text + "','" + txtModel.Text + "','" + txtPrice.Text + "','" + AvailableCMB.SelectedItem.ToString() + "' )";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Car Successfully Added ");
                    con.Close();
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
            txtRegNo.Text = initialRegNo;
            txtBrand.Text = initialBrand;
            txtModel.Text = initialModel;
            txtPrice.Text = initialPrice;
            AvailableCMB.Text = initialAvailability;
        }

        private void FillAvailability()
        {
            con.Open();
            string sql = " SELECT Availability FROM CarTable ";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Availability", typeof(String));
            dt.Load(rdr);
            cmbSearch.ValueMember = "Availability";
            cmbSearch.DataSource = dt;
            con.Close();
        }

        private void Cars_Load(object sender, EventArgs e)
        {
            DisplayData();
            FillAvailability();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtRegNo.Text == " " || txtBrand.Text == " ")
            {
                MessageBox.Show(" Missing Information ");
            }
            else
            {
                try
                {
                    con.Open();
                    string sql = " DELETE FROM CarTable WHERE RegNo = " + txtRegNo.Text + "; ";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Car  Deleted Successfully ");
                    con.Close();
                    DisplayData();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void datagridview_Car_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRegNo.Text = datagridview_Car.SelectedRows[0].Cells[0].Value.ToString();
            txtBrand.Text = datagridview_Car.SelectedRows[0].Cells[1].Value.ToString();
            txtModel.Text = datagridview_Car.SelectedRows[0].Cells[2].Value.ToString();
            txtPrice.Text = datagridview_Car.SelectedRows[0].Cells[3].Value.ToString();
            AvailableCMB.SelectedItem = datagridview_Car.SelectedRows[0].Cells[4].Value.ToString();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtRegNo.Text == " " || txtBrand.Text == " " || txtModel.Text == " " || txtPrice.Text == " " )
            {
                MessageBox.Show(" Missing Information ");
            }
            else
            {
                try
                {
                    con.Open();
                    string sql = " UPDATE CarTable SET Brand = '" + txtBrand.Text + "' , Model= '" + txtModel.Text +"' , Price = '" + txtPrice.Text + "', Availability= '" + AvailableCMB.Text + "'  WHERE RegNo = " + txtRegNo.Text + ";";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Car  Updated Successfully ");
                    con.Close();
                    DisplayData();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void cmbSearch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string Car = " ";
            if(cmbSearch.SelectedItem.ToString() == " Available ")
            {
                Car = " yes ";
            }
            else
            {
                Car = " No ";
            }
            con.Open();
            string sql = " SELECT  * FROM CarTable WHERE Available =  '" + Car + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            datagridview_Car.DataSource = ds.Tables[0];
            con.Close();
        }

        
    }

}

