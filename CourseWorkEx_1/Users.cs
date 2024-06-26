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
    public partial class Users : Form
    {
        private string initialUserID;
        private string initialUserName;
        private string initialPassword;
       

        DataSet ds;
        public Users()
        {
            InitializeComponent();

            // Initialize the initial values of User ID and password
            initialUserID = txtUserID.Text;
            initialUserName = txtUserName.Text;
            initialPassword = txtPassword.Text;


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
            string sql = " SELECT  * FROM UserTable ";
            SqlDataAdapter adapter = new SqlDataAdapter(sql,con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            dgvUsersList.DataSource = ds.Tables[0];
            con.Close();
            
        }

        private void Users_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtUserID.Text == " " || txtUserName.Text == " " || txtPassword.Text == " ")
            {
                MessageBox.Show(" Missing Information ");
            }
            else
            {
                try
                {
                    con.Open();
                    string sql = "INSERT INTO UserTable VALUES (" + txtUserID.Text + ",'" + txtUserName.Text + "','" + txtPassword.Text + "')";
                    SqlCommand  cmd = new SqlCommand(sql,con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Successfully Added ");
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
            // Reset the User ID and password textboxes to their initial values
            txtUserID.Text = initialUserID;
            txtUserName.Text = initialUserName;
            txtPassword.Text = initialPassword;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtUserID.Text == " " || txtUserName.Text == " ") 
            {
                MessageBox.Show(" Missing Information ");
            }
            else
            {
                try
                {
                    con.Open();
                    string sql = " DELETE FROM UserTable WHERE UserID = " + txtUserID.Text + "; ";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" User  Deleted Successfully ");
                    con.Close();
                    DisplayData();
                }
                catch(Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void dgvUsersList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUserID.Text = dgvUsersList.SelectedRows[0].Cells[0].Value.ToString();
            txtUserName.Text = dgvUsersList.SelectedRows[0].Cells[1].Value.ToString();
            txtPassword.Text = dgvUsersList.SelectedRows[0].Cells[2].Value.ToString();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserID.Text) || string.IsNullOrWhiteSpace(txtUserName.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string sql = "UPDATE UserTable SET UserName = @UserName, Password = @Password WHERE UserID = @UserID";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@UserID", txtUserID.Text);
                    cmd.Parameters.AddWithValue("@UserName", txtUserName.Text);
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Updated Successfully");
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
    }
}
