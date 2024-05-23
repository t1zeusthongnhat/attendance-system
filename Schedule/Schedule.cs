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

namespace AttendanceSystem.Schedule
{
    public partial class Slot : Form
    {

        SqlConnection conn;
        public Slot()
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

        private void Slot_Load(object sender, EventArgs e)
        {
            txtID.Visible = false;
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string query = "select * from Schedule";
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

        private void btnLoad_Click(object sender, EventArgs e)
        {
            txtName.ResetText();
            txtQuantity.ResetText();
            txtID.ResetText();
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
                MessageBox.Show("Enter Start_end, please", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            try
            {

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string query = "insert into Schedule(name,start_end) values (@name,@start_end) ";
                SqlCommand thucthi = new SqlCommand(query, conn);
                thucthi.Parameters.AddWithValue("@name", txtName.Text);


                thucthi.Parameters.AddWithValue("@start_end", txtQuantity.Text);

                thucthi.ExecuteNonQuery();
                txtID.ResetText();
                txtName.ResetText();
                txtQuantity.ResetText();

                MessageBox.Show("Add sucess!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Slot_Load(sender, e); //sau khi them xong load lai form



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

        private void dgvClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dgvClass.Rows[e.RowIndex];

                // Lấy dữ liệu từ hàng được chọn và điền vào các TextBox và DateTimePicker
                txtName.Text = row.Cells["name"].Value.ToString();
                txtQuantity.Text = row.Cells["St_end"].Value.ToString();
                txtID.Text = row.Cells["id"].Value.ToString();

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Please choose schedule you want update in datagridview!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {

                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    string query = "update Schedule set name = @class_name , start_end= @quantity where id =@id ";
                    SqlCommand thucthi = new SqlCommand(query, conn);
                    thucthi.Parameters.AddWithValue("@class_name", txtName.Text);
                    thucthi.Parameters.AddWithValue("@id", txtID.Text);

                    thucthi.Parameters.AddWithValue("@quantity", txtQuantity.Text);


                    thucthi.ExecuteNonQuery();
                    MessageBox.Show("Update sucess!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Slot_Load(sender, e);



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
    }
}
