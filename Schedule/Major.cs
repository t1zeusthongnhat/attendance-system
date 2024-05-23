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
    public partial class Major : Form
    {
        SqlConnection conn;
        public Major()
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

        private void Major_Load(object sender, EventArgs e)
        {

            txtID.Visible = false;
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string query = "select * from Majors";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            dataGridView1.DataSource = dt;

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Lấy dữ liệu từ hàng được chọn và điền vào các TextBox và DateTimePicker
                txtName.Text = row.Cells["major_name"].Value.ToString();
                txtTeacher.Text = row.Cells["teacher_name"].Value.ToString();
                txtID.Text = row.Cells["id"].Value.ToString();
                txtDes.Text = row.Cells["description"].Value.ToString();
                cboStatus.Text = row.Cells["status"].Value.ToString();


            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Enter Name, please", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            if (string.IsNullOrEmpty(txtTeacher.Text))
            {
                MessageBox.Show("Enter Teacher, please", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            if (string.IsNullOrEmpty(cboStatus.Text))
            {
                MessageBox.Show("Choose status, please", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            if (string.IsNullOrEmpty(txtDes.Text))
            {
                MessageBox.Show("Enter Description, please", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            try
            {

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string query = "insert into Majors (major_name,teacher_name,description,status) values (@major_name,@teacher_name,@description,@status) ";
                SqlCommand thucthi = new SqlCommand(query, conn);
                thucthi.Parameters.AddWithValue("@major_name", txtName.Text);


                thucthi.Parameters.AddWithValue("@teacher_name", txtTeacher.Text);

                thucthi.Parameters.AddWithValue("@status", cboStatus.Text);


                thucthi.Parameters.AddWithValue("@description", txtDes.Text);

                thucthi.ExecuteNonQuery();
                load();
                MessageBox.Show("Add sucess!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Major_Load(sender, e); //sau khi them xong load lai form



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
            txtTeacher.ResetText();
            txtDes.ResetText();
            cboStatus.ResetText();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            load();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Please choose major you want update in datagridview!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {

                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    string query = "update Majors set major_name = @major_name,teacher_name =@teacher_name ,description =@description , status =@status where id = @id";
                    SqlCommand thucthi = new SqlCommand(query, conn);
                    thucthi.Parameters.AddWithValue("@major_name", txtName.Text);
                    thucthi.Parameters.AddWithValue("@id", txtID.Text);
                    thucthi.Parameters.AddWithValue("@status", cboStatus.Text);
                    thucthi.Parameters.AddWithValue("@teacher_name", txtTeacher.Text);
                    thucthi.Parameters.AddWithValue("@description", txtDes.Text);


                    thucthi.ExecuteNonQuery();
                  
                    MessageBox.Show("Update sucess!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load();
                    Major_Load(sender, e);

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
