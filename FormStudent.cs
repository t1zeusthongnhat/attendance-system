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

namespace AttendanceSystem
{
    public partial class FormStudent : Form
    {
        SqlConnection conn;
        public FormStudent()
        {
            InitializeComponent();
            conn = new SqlConnection("server = Tira\\SQLEXPRESS; database = AttendanceSystem;  uid = sa; pwd = 300924");
        }


        private void FormStudent_Load(object sender, EventArgs e)
        {
            conn.Open();
            string query = "select a.id, a.student_name,m.major_name,s.name,c.class_name,a.status,a.date from Attendance a inner join Majors m on a.major_id = m.id inner join Class c on c.id = a.class_id inner join Schedule s on s.id = a.schedule_id";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            dgvAttendance.DataSource = dt;
            conn.Close();
        }
        public DataTable HienDL(string sql)
        {
            conn.Open();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reaer = cmd.ExecuteReader();
            dt.Load(reaer);
            conn.Close();
            return dt;
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            string message = "Are you sure exit program?";
            string title = "Warning!!!";
            MessageBoxButtons button = MessageBoxButtons.OKCancel;
            MessageBoxIcon icon = MessageBoxIcon.Information;
            DialogResult result = MessageBox.Show(message, title, button, icon);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void txt_KeyDown(object sender, KeyEventArgs e)
        {
            btnSearch.PerformClick();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dgvAttendance.DataSource = HienDL("select a.id, a.student_name,m.major_name,s.name,c.class_name,a.status,a.date from Attendance a inner join Majors m on a.major_id = m.id inner join Class c on c.id = a.class_id inner join Schedule s on s.id = a.schedule_id where student_name like '%" + txtSearch.Text + "%' or class_name like '%" + txtSearch.Text + "%'");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
