using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AttendanceSystem.Schedule
{
    public partial class Clash : Form
    {
        SqlConnection conn;
        public Clash()
        {
            InitializeComponent();
            conn = new SqlConnection("server = Tira\\SQLEXPRESS; database = AttendanceSystem;  uid = sa; pwd = 300924");
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            using (FormAdmin form2 = new FormAdmin())
                form2.ShowDialog();
            Show();
        }

        private void Class_Load(object sender, EventArgs e)
        {
            txtID.Visible = false;
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string query = "select * from Class";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            dgvClass.DataSource = dt;

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Enter Name, please", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            if (string.IsNullOrEmpty(txtQuantity.Text))
            {
                MessageBox.Show("Enter Quantity, please", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            try
            {

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string query = "insert into Class(class_name,quantity) values (@class_name,@quantity) ";
                SqlCommand thucthi = new SqlCommand(query, conn);
                thucthi.Parameters.AddWithValue("@class_name", txtName.Text);


                thucthi.Parameters.AddWithValue("@quantity", txtQuantity.Text);

                thucthi.ExecuteNonQuery();
                load();
                MessageBox.Show("Add sucess!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Class_Load(sender, e); //sau khi them xong load lai form



                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        public void load()
        {
            txtName.ResetText();
            txtQuantity.ResetText();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Please choose class you want update in datagridview!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {

                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    string query = "update class set class_name = @class_name , quantity= @quantity where id =@id ";
                    SqlCommand thucthi = new SqlCommand(query, conn);
                    thucthi.Parameters.AddWithValue("@class_name", txtName.Text);
                    thucthi.Parameters.AddWithValue("@id", txtID.Text);

                    thucthi.Parameters.AddWithValue("@quantity", txtQuantity.Text);


                    thucthi.ExecuteNonQuery();
                    MessageBox.Show("Update sucess!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load();
                    Class_Load(sender, e);



                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void dgvClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            load();
        }

        private void dgvClass_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dgvClass.Rows[e.RowIndex];

                // Lấy dữ liệu từ hàng được chọn và điền vào các TextBox và DateTimePicker
                txtName.Text = row.Cells["class_name"].Value.ToString();
                txtQuantity.Text = row.Cells["quantity"].Value.ToString();
                txtID.Text = row.Cells["id"].Value.ToString();

            }
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            Hide();
            using (FormAdmin form2 = new FormAdmin())
                form2.ShowDialog();
            Show();
        }
    }
}
