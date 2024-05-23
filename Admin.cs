using AttendanceSystem.Schedule;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;


namespace AttendanceSystem
{
    public partial class FormAdmin : Form
    {
        SqlConnection conn;
        public FormAdmin()
        {
            InitializeComponent();
            conn = new SqlConnection("server = Tira\\SQLEXPRESS; database = AttendanceSystem;  uid = sa; pwd = 300924");
        }
        private void DashBoard_Load(object sender, EventArgs e)
        {
            txtID.Visible = false;
            txtIDUser.Visible = false;
            txtIDAtt.Visible = false;
            GetClass();
            GetMajors();
            getRoles();
            GetClassIntoAttendance();
            getSchedule();
            GetMajorsIntoAttendance();
            GetSlot();
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string queryRe = "select a.id,a.student_name,c.class_name,m.major_name,s.start_end,a.birthday,a.gender, a.phone,a.address from Attendance a inner join Class c on c.id = a.class_id inner join Majors m on m.id = a.major_id inner join Schedule s on s.id = a.schedule_id";

                SqlCommand command = new SqlCommand(queryRe, conn);
                SqlDataReader read = command.ExecuteReader();
                DataTable data = new DataTable();
                data.Load(read);
                dgvStudent.DataSource = data;

                string queryMa = "select id,student_name,major_id,schedule_id,class_id,status,date from Attendance ";

                SqlCommand chay = new SqlCommand(queryMa, conn);
                SqlDataReader red = chay.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(red);
                dgvAttendance.DataSource = dataTable;

                string queryUser = "select * from Users";
                SqlCommand sqlCommand = new SqlCommand(queryUser, conn);
                SqlDataReader docdulieu = sqlCommand.ExecuteReader();
                DataTable bang = new DataTable();
                bang.Load(docdulieu);
                dgvUsers.DataSource = bang;





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



        private void button1_Click(object sender, EventArgs e)
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

        private void btnAdd_Click(object sender, EventArgs e)
        {



            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Enter Name, please", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(cboClass.Text))
            {
                MessageBox.Show("Choose Class, please", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            if (string.IsNullOrEmpty(dtPBirhtday.Text))
            {
                MessageBox.Show("Enter Birhthday, please", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            if (string.IsNullOrEmpty(cboGender.Text))
            {
                MessageBox.Show("Choose Gender, please", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }

            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("Enter Phone, please", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Enter Address, please", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            try
            {

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }



                string query = "insert into Attendance(student_name,class_id,major_id,schedule_id,birthday,gender,phone,address,role_id) values (@student_name,@class_id,@major_id,@schedule_id,@birthday,@gender,@phone,@address,@role_id)";
                SqlCommand thucthi = new SqlCommand(query, conn);
                thucthi.Parameters.AddWithValue("@student_name", txtName.Text);
                thucthi.Parameters.AddWithValue("@schedule_id", cboSlot.SelectedValue);
                thucthi.Parameters.AddWithValue("@class_id", cboClass.SelectedValue);
                thucthi.Parameters.AddWithValue("@major_id", cboMajors.SelectedValue);

                thucthi.Parameters.AddWithValue("@gender", cboGender.Text);

                thucthi.Parameters.AddWithValue("@phone", txtPhone.Text);
                thucthi.Parameters.AddWithValue("@birthday", dtPBirhtday.Value.ToString("yyyy/MM/dd"));
                //dinh dang ngay sinh
                thucthi.Parameters.AddWithValue("@address", txtAddress.Text);
                thucthi.Parameters.AddWithValue("@role_id", "2");



                thucthi.ExecuteNonQuery();
                MessageBox.Show("Add sucess!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DashBoard_Load(sender, e); //sau khi them xong load lai form
                load();


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

        public void GetClass()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                // Thực hiện truy vấn để lấy dữ liệu từ cơ sở dữ liệu
                string queryUser = "select * from Class";
                SqlCommand command = new SqlCommand(queryUser, conn);

                // Tạo DataTable để lưu dữ liệu từ SqlDataReader
                DataTable table = new DataTable();
                SqlDataReader reader = command.ExecuteReader();
                table.Load(reader);

                // Đặt DataTable làm nguồn dữ liệu cho ComboBox
                cboClass.DataSource = table;

                // Chỉ định cột cần hiển thị trong ComboBox
                cboClass.DisplayMember = "class_name";

                // Chỉ định giá trị cần trả về khi một mục được chọn
                cboClass.ValueMember = "id";


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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Please choose student you want update in datagridview!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {

                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }



                    string query = "update Attendance set student_name=@student_name,class_id=@class_id,major_id =@major_id,schedule_id =@schedule_id,birthday=@birthday,gender=@gender,phone=@phone,address=@address,role_id = @role_id where id =@id";
                    SqlCommand thucthi = new SqlCommand(query, conn);
                    thucthi.Parameters.AddWithValue("@student_name", txtName.Text);
                    thucthi.Parameters.AddWithValue("@id", txtID.Text);

                    thucthi.Parameters.AddWithValue("@schedule_id", cboSlot.SelectedValue);
                    thucthi.Parameters.AddWithValue("@class_id", cboClass.SelectedValue);
                    thucthi.Parameters.AddWithValue("@major_id", cboMajors.SelectedValue);
                    thucthi.Parameters.AddWithValue("@gender", cboGender.Text);

                    thucthi.Parameters.AddWithValue("@phone", txtPhone.Text);
                    thucthi.Parameters.AddWithValue("@birthday", dtPBirhtday.Value.ToString("yyyy/MM/dd"));
                    //dinh dang ngay sinh
                    thucthi.Parameters.AddWithValue("@address", txtAddress.Text);
                    thucthi.Parameters.AddWithValue("@role_id", "2");



                    thucthi.ExecuteNonQuery();
                    MessageBox.Show("Update sucess!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DashBoard_Load(sender, e); //sau khi them xong load lai form


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

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dgvStudent.Rows[e.RowIndex];

                // Lấy dữ liệu từ hàng được chọn và điền vào các TextBox và DateTimePicker
                txtName.Text = row.Cells["student_name"].Value.ToString();
                dtPBirhtday.Value = Convert.ToDateTime(row.Cells["birthday"].Value);

                if (row.Cells["class_id"].Value != null)
                {
                    cboClass.SelectedValue = row.Cells["class_id"].Value.ToString();
                }

                if (row.Cells["SLot"].Value != null)
                {
                    cboSlot.SelectedItem = row.Cells["SLot"].Value.ToString();
                }

                if (row.Cells["majorss"].Value != null)
                {
                    cboMajors.SelectedItem = row.Cells["majorss"].Value.ToString();
                }
                cboGender.Text = row.Cells["gender"].Value.ToString();
                txtAddress.Text = row.Cells["address"].Value.ToString();
                txtPhone.Text = row.Cells["phone"].Value.ToString();
                txtID.Text = row.Cells["id"].Value.ToString();


            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                if (txtID.Text == "")
                {
                    MessageBox.Show("Please Select the student you want to delete !", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                    DialogResult result = MessageBox.Show("Do you want delete ?", "Warning", buttons, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        string query = "delete from Attendance where id =@id";
                        SqlCommand thucthi = new SqlCommand(query, conn);

                        thucthi.Parameters.AddWithValue("@id", txtID.Text);



                        thucthi.ExecuteNonQuery();
                        DashBoard_Load(sender, e); //sau khi them xong load lai form
                    }


                }




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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dgvStudent.DataSource = HienDL(" select a.id, a.student_name, c.class_name, m.major_name, s.name,a.birthday, a.gender, a.phone, a.address from Attendance a inner join Class c on c.id = a.class_id inner join Majors m on m.id = a.major_id inner join Schedule s on s.id = a.schedule_id where student_name like '%" + txtSearchStudent.Text + "%' or phone like '%" + txtSearchStudent.Text + "%' or address like '%" + txtSearchStudent.Text + "%' or class_name like '%"+txtSearchStudent.Text+ "%' or major_name like '%"+txtSearchStudent.Text+"%' ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearchStudent_KeyDown(object sender, KeyEventArgs e)
        {
            btnSearch.PerformClick();
        }
        public void load()
        {
            txtName.ResetText();
            txtSearchStudent.ResetText();
            cboGender.ResetText();
            cboClass.ResetText();
            txtID.ResetText();
            dtPBirhtday.ResetText();
            txtPhone.ResetText();
        }
        public void GetMajors()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                // Thực hiện truy vấn để lấy dữ liệu từ cơ sở dữ liệu
                string queryUser = "select * from Majors";
                SqlCommand command = new SqlCommand(queryUser, conn);

                // Tạo DataTable để lưu dữ liệu từ SqlDataReader
                DataTable table = new DataTable();
                SqlDataReader reader = command.ExecuteReader();
                table.Load(reader);

                // Đặt DataTable làm nguồn dữ liệu cho ComboBox
                cboMajors.DataSource = table;

                // Chỉ định cột cần hiển thị trong ComboBox
                cboMajors.DisplayMember = "major_name";

                // Chỉ định giá trị cần trả về khi một mục được chọn
                cboMajors.ValueMember = "id";


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
        public void GetSlot()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                // Thực hiện truy vấn để lấy dữ liệu từ cơ sở dữ liệu
                string queryUser = "select * from Schedule";
                SqlCommand command = new SqlCommand(queryUser, conn);

                // Tạo DataTable để lưu dữ liệu từ SqlDataReader
                DataTable table = new DataTable();
                SqlDataReader reader = command.ExecuteReader();
                table.Load(reader);

                // Đặt DataTable làm nguồn dữ liệu cho ComboBox
                cboSlot.DataSource = table;

                // Chỉ định cột cần hiển thị trong ComboBox
                cboSlot.DisplayMember = "start_end";

                // Chỉ định giá trị cần trả về khi một mục được chọn
                cboSlot.ValueMember = "id";


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
        public void getRoles()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                // Thực hiện truy vấn để lấy dữ liệu từ cơ sở dữ liệu
                string queryUser = "select * from Roles";
                SqlCommand command = new SqlCommand(queryUser, conn);

                // Tạo DataTable để lưu dữ liệu từ SqlDataReader
                DataTable table = new DataTable();
                SqlDataReader reader = command.ExecuteReader();
                table.Load(reader);

                // Đặt DataTable làm nguồn dữ liệu cho ComboBox
                cboRole.DataSource = table;

                // Chỉ định cột cần hiển thị trong ComboBox
                cboRole.DisplayMember = "name";

                // Chỉ định giá trị cần trả về khi một mục được chọn
                cboRole.ValueMember = "id";


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
        private void btnAddUsers_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtNameUsers.Text))
            {
                MessageBox.Show("Enter Name, please", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(cboGenderUser.Text))
            {
                MessageBox.Show("Choose Gender, please", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            if (string.IsNullOrEmpty(txtEmailUsers.Text))
            {
                MessageBox.Show("Enter Email, please", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            if (string.IsNullOrEmpty(txtUserNameUser.Text))
            {
                MessageBox.Show("Enter Username, please", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }

            if (string.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("Enter Pass, please", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            if (string.IsNullOrEmpty(cboRole.Text))
            {
                MessageBox.Show("Choose Role, please", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            try
            {

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string query = "insert into Users (fullname,gender,email,username,password,role_id) values (@fullname,@gender,@email,@username,@password,@role_id) ";
                SqlCommand thucthi = new SqlCommand(query, conn);
                thucthi.Parameters.AddWithValue("@fullname", txtNameUsers.Text);

                thucthi.Parameters.AddWithValue("@role_id", cboRole.SelectedValue);
                thucthi.Parameters.AddWithValue("@password", txtPass.Text);

                thucthi.Parameters.AddWithValue("@username", txtUserNameUser.Text);

                thucthi.Parameters.AddWithValue("@email", txtEmailUsers.Text);
                thucthi.Parameters.AddWithValue("@gender", cboGenderUser.Text);

                thucthi.ExecuteNonQuery();
                MessageBox.Show("Add sucess!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadUser();
                DashBoard_Load(sender, e); //sau khi them xong load lai form
                load();


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

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dgvUsers.Rows[e.RowIndex];

                // Lấy dữ liệu từ hàng được chọn và điền vào các TextBox và DateTimePicker
                txtNameUsers.Text = row.Cells["fullname"].Value.ToString();
                txtPass.Text = row.Cells["password"].Value.ToString();
                cboRole.SelectedValue = row.Cells["role_id"].Value.ToString();
                cboGenderUser.Text = row.Cells["genderU"].Value.ToString();
                txtEmailUsers.Text = row.Cells["email"].Value.ToString();
                txtIDUser.Text = row.Cells["idusers"].Value.ToString();
                txtUserNameUser.Text = row.Cells["username"].Value.ToString();


            }
        }
        public void loadUser()
        {
            txtNameUsers.ResetText();
            txtUserNameUser.ResetText();
            cboRole.ResetText();
            cboGenderUser.ResetText();
            txtEmailUsers.ResetText();
            txtIDUser.ResetText();
            txtPass.ResetText();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIDUser.Text))
            {
                MessageBox.Show("Please choose admin you want update in datagridview!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {

                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    string query = "Update Users set fullname =@fullname,gender =@gender,email =@email,username =@username,password =@password,role_id =@role_id where id =@id ";
                    SqlCommand thucthi = new SqlCommand(query, conn);
                    thucthi.Parameters.AddWithValue("@fullname", txtNameUsers.Text);
                    thucthi.Parameters.AddWithValue("@id", txtIDUser.Text);

                    thucthi.Parameters.AddWithValue("@role_id", cboRole.SelectedValue);
                    thucthi.Parameters.AddWithValue("@password", txtPass.Text);

                    thucthi.Parameters.AddWithValue("@username", txtUserNameUser.Text);

                    thucthi.Parameters.AddWithValue("@email", txtEmailUsers.Text);
                    thucthi.Parameters.AddWithValue("@gender", cboGenderUser.Text);

                    thucthi.ExecuteNonQuery();
                    MessageBox.Show("Update sucess!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadUser();
                    DashBoard_Load(sender, e); //sau khi them xong load lai form
                    load();


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

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            try
            {

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                if (txtIDUser.Text == "")
                {
                    MessageBox.Show("Please Select the admin you want to delete !", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                    DialogResult result = MessageBox.Show("Do you want delete ?", "Warning", buttons, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        string query = "delete from Users where id =@id";
                        SqlCommand thucthi = new SqlCommand(query, conn);

                        thucthi.Parameters.AddWithValue("@id", txtIDUser.Text);



                        thucthi.ExecuteNonQuery();
                        loadUser();
                        DashBoard_Load(sender, e); //sau khi them xong load lai form
                    }
                    else
                    {
                        loadUser();

                    }

                }

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

        private void btnattendance_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIDAtt.Text))
            {
                MessageBox.Show("Please choose student you want attendance in datagridview!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {

                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }



                    string query = "update Attendance set student_name =@student_name,major_id =@major_id,schedule_id =@schedule_id,class_id =@class_id,status =@status,date =@date where id =@id";
                    SqlCommand thucthi = new SqlCommand(query, conn);
                    thucthi.Parameters.AddWithValue("@student_name", txtNameAtt.Text);
                    thucthi.Parameters.AddWithValue("@id", txtIDAtt.Text);

                    thucthi.Parameters.AddWithValue("@class_id", cboClassAtt.SelectedValue);
                    thucthi.Parameters.AddWithValue("@major_id", cboMajorAtt.SelectedValue);
                    thucthi.Parameters.AddWithValue("@schedule_id", cboScheduleAtt.SelectedValue);


                    thucthi.Parameters.AddWithValue("@status", cboStatusAttendance.Text);
                    thucthi.Parameters.AddWithValue("@date", dateTimeAttenance.Value.ToString("yyyy/MM/dd"));
                    //dinh dang ngay sinh




                    thucthi.ExecuteNonQuery();
                    MessageBox.Show("Attendance sucess!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DashBoard_Load(sender, e); //sau khi them xong load lai form


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
        public void GetClassIntoAttendance()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                // Thực hiện truy vấn để lấy dữ liệu từ cơ sở dữ liệu
                string queryUser = "select * from Class";
                SqlCommand command = new SqlCommand(queryUser, conn);

                // Tạo DataTable để lưu dữ liệu từ SqlDataReader
                DataTable table = new DataTable();
                SqlDataReader reader = command.ExecuteReader();
                table.Load(reader);

                // Đặt DataTable làm nguồn dữ liệu cho ComboBox
                cboClassAtt.DataSource = table;

                // Chỉ định cột cần hiển thị trong ComboBox
                cboClassAtt.DisplayMember = "class_name";

                // Chỉ định giá trị cần trả về khi một mục được chọn
                cboClassAtt.ValueMember = "id";


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
        public void GetMajorsIntoAttendance()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                // Thực hiện truy vấn để lấy dữ liệu từ cơ sở dữ liệu
                string queryUser = "select * from Majors";
                SqlCommand command = new SqlCommand(queryUser, conn);

                // Tạo DataTable để lưu dữ liệu từ SqlDataReader
                DataTable table = new DataTable();
                SqlDataReader reader = command.ExecuteReader();
                table.Load(reader);

                // Đặt DataTable làm nguồn dữ liệu cho ComboBox
                cboMajorAtt.DataSource = table;

                // Chỉ định cột cần hiển thị trong ComboBox
                cboMajorAtt.DisplayMember = "major_name";

                // Chỉ định giá trị cần trả về khi một mục được chọn
                cboMajorAtt.ValueMember = "id";


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
        public void getSchedule()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                // Thực hiện truy vấn để lấy dữ liệu từ cơ sở dữ liệu
                string queryUser = "select * from Schedule";
                SqlCommand command = new SqlCommand(queryUser, conn);

                // Tạo DataTable để lưu dữ liệu từ SqlDataReader
                DataTable table = new DataTable();
                SqlDataReader reader = command.ExecuteReader();
                table.Load(reader);

                // Đặt DataTable làm nguồn dữ liệu cho ComboBox
                cboScheduleAtt.DataSource = table;

                // Chỉ định cột cần hiển thị trong ComboBox
                cboScheduleAtt.DisplayMember = "start_end";

                // Chỉ định giá trị cần trả về khi một mục được chọn
                cboScheduleAtt.ValueMember = "id";


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

        private void dgvAttendance_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dgvAttendance.Rows[e.RowIndex];

                // Lấy dữ liệu từ hàng được chọn và điền vào các TextBox và DateTimePicker
                txtNameAtt.Text = row.Cells["student_namemm"].Value.ToString();
                txtIDAtt.Text = row.Cells["Idd"].Value.ToString();
                cboMajorAtt.SelectedValue = row.Cells["majorr"].Value.ToString();
                cboScheduleAtt.SelectedValue = row.Cells["scheduleee"].Value.ToString();
                cboClassAtt.SelectedValue = row.Cells["classs"].Value.ToString();
                cboStatusAttendance.Text = row.Cells["statuss"].Value.ToString();
                //dateTimeAttenance.Value = Convert.ToDateTime(row.Cells["date"].Value);



            }
        }

        private void dgvStudent_CellBorderStyleChanged(object sender, EventArgs e)
        {

        }

        private void dgvAttendance_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchAteen_Click(object sender, EventArgs e)
        {
            try
            {
                dgvAttendance.DataSource = HienDL("select id,student_name,major_id,schedule_id,class_id,status,date from Attendance where student_name like '%" + txtSearchAtten.Text + "%' or status like '%" + txtSearchAtten.Text + "%'");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearchAtten_KeyDown(object sender, KeyEventArgs e)
        {
            btnSearchAteen.PerformClick();
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && txtPhone.Text.Length < 10)
            {
                e.Handled = true;
            }
        }

        private void btnMajor_Click(object sender, EventArgs e)
        {
            this.Hide();
            Major major = new Major();
            major.ShowDialog();

        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clash clas = new Clash();
            clas.ShowDialog();

        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {

            this.Hide();
            Slot clas = new Slot();
            clas.ShowDialog();
        }


    }

}
