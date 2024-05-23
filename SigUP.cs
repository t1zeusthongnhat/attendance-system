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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace AttendanceSystem
{
    public partial class SigUP : Form
    {
        SqlConnection conn;
        
        public SigUP()
        {
            InitializeComponent();
            conn = new SqlConnection("server = Tira\\SQLEXPRESS; database = AttendanceSystem;  uid = sa; pwd = 300924");
        }

        private void SigUP_Load(object sender, EventArgs e)
        {

        }

        private void btnSigup_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFullName.Text))
            {
                MessageBox.Show("Enter Name, please", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            if (string.IsNullOrEmpty(cboGender.Text))
            {
                MessageBox.Show("Choose gender, please", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Enter Email, please", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Enter Username, please", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Enter Password, please", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // check user da ton tai
            int error = 0;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string query = "select * from Users where username = @username";

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmdCheck = new SqlCommand(query, conn);
            cmdCheck.Parameters.Add("@username", SqlDbType.VarChar);
            cmdCheck.Parameters["@username"].Value = username;
            SqlDataReader reader = cmdCheck.ExecuteReader();
            if (reader.Read())
            {
                error++;
                MessageBox.Show("This user name is exsisting, please choose another");
            }

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            // dang ki tai khoan
            if (error == 0)
            {
                string insert = "insert into Users (fullname,gender,email,username,password,role_id) values (@fullname,@gender,@email,@username,@password,@role_id)";
                conn.Open();
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.Parameters.AddWithValue("@fullname", txtFullName.Text);
                cmd.Parameters.AddWithValue("@gender", cboGender.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);

                cmd.Parameters.Add("@username", SqlDbType.VarChar);
                cmd.Parameters["@username"].Value = username;
                cmd.Parameters.Add("@password", SqlDbType.VarChar);
                cmd.Parameters["@password"].Value = password;

                cmd.Parameters.Add("@role_id", SqlDbType.BigInt);
                cmd.Parameters["@role_id"].Value = 2;
                cmd.ExecuteNonQuery();
                MessageBox.Show(this, "Registerd succsessfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);

            }
        }


        private void btnSigin_Click(object sender, EventArgs e)
        {

            Login home = new Login();
            home.Show();
            this.Hide();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }
    }
}
