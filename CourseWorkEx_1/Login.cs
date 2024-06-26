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
    public partial class Login : Form
    {

        private string initialUserId;
        private string initialUserName;
        private string initialPassword;
        

        public Login()
        {
            InitializeComponent();

            // Initialize the initial values of User ID and password
            initialUserId = txtUserID.Text;
            initialUserName = txtUsername.Text;
            initialPassword = txtPassword.Text;
        }

        // Create a connection with MS SQL Server
        SqlConnection con = new SqlConnection(@"Data Source=Anuu\SQLEXPRESS;Initial Catalog=CarRentalSystem;Integrated Security=True");
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {


            using (SqlConnection con = new SqlConnection(@"Data Source=Anuu\SQLEXPRESS;Initial Catalog=CarRentalSystem;Integrated Security=True"))
            {
                string sql = "SELECT COUNT(*) FROM UserTable WHERE UserId = @UserID AND UserName = @UserName AND Password = @Password";
                SqlCommand command = new SqlCommand(sql, con);
                command.Parameters.AddWithValue("@UserID", txtUserID.Text);
                command.Parameters.AddWithValue("@UserName", txtUsername.Text);
                command.Parameters.AddWithValue("@Password", txtPassword.Text);

                con.Open();
                int count = (int)command.ExecuteScalar();

                if (count == 1)
                {
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong UserName or Password");
                }
            }
        }
  
        private void lblClear_Click(object sender, EventArgs e)
        {
            txtUserID.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void btbReset_Click(object sender, EventArgs e)
        {
            // Reset the User ID and password textboxes to their initial values
           // txtUserID.Text = initialUserId;
            //txtPassword.Text = initialPassword;
        }


        private void cbPassword_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Set the PasswordChar property of the MaskedTextBox control
            txtPassword.PasswordChar = '*';
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
