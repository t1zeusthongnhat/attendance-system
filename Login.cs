using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceSystem

{
    public partial class Login : Form
    {
        SqlConnection conn;
       
        public Login()
        {
            InitializeComponent();
            conn = new SqlConnection("server = Tira\\SQLEXPRESS; database = AttendanceSystem;  uid = sa; pwd = 300924");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPass.Text == "" || txtUser.Text == "")
            {
                MessageBox.Show("User Name or Password is empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                conn.Open();
                string username = txtUser.Text;
                string password = txtPass.Text;
                string query = "select * from Users where username= @username and password = @password";
                SqlCommand cmd = new SqlCommand(query, conn);
                //gan du lieu tu cac text box
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int role = int.Parse(reader["role_id"].ToString());
                    if (role == 1)
                    {
                        MessageBox.Show("Login success!", username, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        FormAdmin formDashBoard = new FormAdmin();
                        formDashBoard.ShowDialog();
                        this.Dispose();
                    }
                    if (role == 2)
                    {
                        MessageBox.Show("Login success!", username, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        FormStudent user = new FormStudent();
                        user.ShowDialog();
                        this.Dispose();
                    }

                }
                else
                {
                    MessageBox.Show("Account Invalid ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                conn.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            string message = "Are you sure close program?";
            string title = "Warning!!!";
            MessageBoxButtons button = MessageBoxButtons.OKCancel;
            MessageBoxIcon icon = MessageBoxIcon.Information;
            DialogResult result = MessageBox.Show(message, title, button, icon);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '*';
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void lbRegister_Click(object sender, EventArgs e)
        {
            SigUP sigUP = new SigUP();
            sigUP.Show();
            this.Hide();

        }
    }
}