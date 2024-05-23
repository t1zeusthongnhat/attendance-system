namespace AttendanceSystem
{
    partial class FormAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            tabControl = new TabControl();
            tabPageHome = new TabPage();
            label8 = new Label();
            label7 = new Label();
            tabPageStudent = new TabPage();
            Information = new GroupBox();
            cboSlot = new ComboBox();
            cboMajors = new ComboBox();
            cboGender = new ComboBox();
            cboClass = new ComboBox();
            dtPBirhtday = new DateTimePicker();
            txtPhone = new TextBox();
            textBox3 = new TextBox();
            txtID = new TextBox();
            txtAddress = new TextBox();
            txtName = new TextBox();
            label22 = new Label();
            label6 = new Label();
            label21 = new Label();
            label3 = new Label();
            label5 = new Label();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            txtSearchStudent = new TextBox();
            btnSearch = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            dgvStudent = new DataGridView();
            tabPageMajorClassSchedule = new TabPage();
            btnSchedule = new Button();
            btnClass = new Button();
            btnMajor = new Button();
            tabPageAttendance = new TabPage();
            groupBox1 = new GroupBox();
            dateTimeAttenance = new DateTimePicker();
            cboStatusAttendance = new ComboBox();
            cboScheduleAtt = new ComboBox();
            cboClassAtt = new ComboBox();
            cboMajorAtt = new ComboBox();
            txtIDAtt = new TextBox();
            txtNameAtt = new TextBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label10 = new Label();
            label11 = new Label();
            label9 = new Label();
            txtSearchAtten = new TextBox();
            dgvAttendance = new DataGridView();
            Idd = new DataGridViewTextBoxColumn();
            student_namemm = new DataGridViewTextBoxColumn();
            majorr = new DataGridViewTextBoxColumn();
            scheduleee = new DataGridViewTextBoxColumn();
            classs = new DataGridViewTextBoxColumn();
            statuss = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            btnSearchAteen = new Button();
            btnattendance = new Button();
            tabPageUsers = new TabPage();
            cboRole = new ComboBox();
            cboGenderUser = new ComboBox();
            txtPass = new TextBox();
            txtUserNameUser = new TextBox();
            txtEmailUsers = new TextBox();
            txtIDUser = new TextBox();
            txtNameUsers = new TextBox();
            btnDeleteUser = new Button();
            btnUpdateUser = new Button();
            btnAddUsers = new Button();
            label20 = new Label();
            label17 = new Label();
            label19 = new Label();
            label16 = new Label();
            label18 = new Label();
            label15 = new Label();
            dgvUsers = new DataGridView();
            idusers = new DataGridViewTextBoxColumn();
            fullname = new DataGridViewTextBoxColumn();
            genderU = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            username = new DataGridViewTextBoxColumn();
            password = new DataGridViewTextBoxColumn();
            role_id = new DataGridViewTextBoxColumn();
            tabPageExit = new TabPage();
            button1 = new Button();
            imageList1 = new ImageList(components);
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            student_namee = new DataGridViewTextBoxColumn();
            major_id = new DataGridViewTextBoxColumn();
            schedule_id = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            id = new DataGridViewTextBoxColumn();
            student_name = new DataGridViewTextBoxColumn();
            class_id = new DataGridViewTextBoxColumn();
            majorss = new DataGridViewTextBoxColumn();
            SLot = new DataGridViewTextBoxColumn();
            birthday = new DataGridViewTextBoxColumn();
            gender = new DataGridViewTextBoxColumn();
            phone = new DataGridViewTextBoxColumn();
            address = new DataGridViewTextBoxColumn();
            tabControl.SuspendLayout();
            tabPageHome.SuspendLayout();
            tabPageStudent.SuspendLayout();
            Information.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudent).BeginInit();
            tabPageMajorClassSchedule.SuspendLayout();
            tabPageAttendance.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).BeginInit();
            tabPageUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            tabPageExit.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPageHome);
            tabControl.Controls.Add(tabPageStudent);
            tabControl.Controls.Add(tabPageMajorClassSchedule);
            tabControl.Controls.Add(tabPageAttendance);
            tabControl.Controls.Add(tabPageUsers);
            tabControl.Controls.Add(tabPageExit);
            tabControl.Dock = DockStyle.Fill;
            tabControl.ImageList = imageList1;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(859, 561);
            tabControl.TabIndex = 0;
            // 
            // tabPageHome
            // 
            tabPageHome.BackgroundImage = (Image)resources.GetObject("tabPageHome.BackgroundImage");
            tabPageHome.BackgroundImageLayout = ImageLayout.Stretch;
            tabPageHome.Controls.Add(label8);
            tabPageHome.Controls.Add(label7);
            tabPageHome.ImageIndex = 9;
            tabPageHome.Location = new Point(4, 31);
            tabPageHome.Name = "tabPageHome";
            tabPageHome.Padding = new Padding(3);
            tabPageHome.Size = new Size(851, 526);
            tabPageHome.TabIndex = 0;
            tabPageHome.Text = "Home";
            tabPageHome.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(39, 32, 105);
            label8.Location = new Point(113, 169);
            label8.Name = "label8";
            label8.Size = new Size(238, 60);
            label8.TabIndex = 0;
            label8.Text = "WELCOME";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(39, 32, 105);
            label7.Location = new Point(8, 101);
            label7.Name = "label7";
            label7.Size = new Size(444, 54);
            label7.TabIndex = 0;
            label7.Text = "ATTENDANCE SYSTEM";
            // 
            // tabPageStudent
            // 
            tabPageStudent.BackColor = Color.FromArgb(53, 45, 125);
            tabPageStudent.Controls.Add(Information);
            tabPageStudent.Controls.Add(txtSearchStudent);
            tabPageStudent.Controls.Add(btnSearch);
            tabPageStudent.Controls.Add(btnDelete);
            tabPageStudent.Controls.Add(btnUpdate);
            tabPageStudent.Controls.Add(btnAdd);
            tabPageStudent.Controls.Add(dgvStudent);
            tabPageStudent.ImageIndex = 1;
            tabPageStudent.Location = new Point(4, 31);
            tabPageStudent.Name = "tabPageStudent";
            tabPageStudent.Padding = new Padding(3);
            tabPageStudent.Size = new Size(851, 526);
            tabPageStudent.TabIndex = 1;
            tabPageStudent.Text = "Student Manager";
            // 
            // Information
            // 
            Information.Controls.Add(cboSlot);
            Information.Controls.Add(cboMajors);
            Information.Controls.Add(cboGender);
            Information.Controls.Add(cboClass);
            Information.Controls.Add(dtPBirhtday);
            Information.Controls.Add(txtPhone);
            Information.Controls.Add(textBox3);
            Information.Controls.Add(txtID);
            Information.Controls.Add(txtAddress);
            Information.Controls.Add(txtName);
            Information.Controls.Add(label22);
            Information.Controls.Add(label6);
            Information.Controls.Add(label21);
            Information.Controls.Add(label3);
            Information.Controls.Add(label5);
            Information.Controls.Add(label2);
            Information.Controls.Add(label4);
            Information.Controls.Add(label1);
            Information.ForeColor = Color.FromArgb(239, 250, 252);
            Information.Location = new Point(8, 65);
            Information.Name = "Information";
            Information.Size = new Size(838, 221);
            Information.TabIndex = 3;
            Information.TabStop = false;
            Information.Text = "Information";
            // 
            // cboSlot
            // 
            cboSlot.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSlot.FormattingEnabled = true;
            cboSlot.Location = new Point(569, 163);
            cboSlot.Name = "cboSlot";
            cboSlot.Size = new Size(151, 28);
            cboSlot.TabIndex = 5;
            // 
            // cboMajors
            // 
            cboMajors.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMajors.FormattingEnabled = true;
            cboMajors.Location = new Point(133, 118);
            cboMajors.Name = "cboMajors";
            cboMajors.Size = new Size(219, 28);
            cboMajors.TabIndex = 4;
            // 
            // cboGender
            // 
            cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGender.FormattingEnabled = true;
            cboGender.Items.AddRange(new object[] { "Male", "Female" });
            cboGender.Location = new Point(569, 20);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(136, 28);
            cboGender.TabIndex = 3;
            // 
            // cboClass
            // 
            cboClass.DropDownStyle = ComboBoxStyle.DropDownList;
            cboClass.FormattingEnabled = true;
            cboClass.Location = new Point(133, 71);
            cboClass.Name = "cboClass";
            cboClass.Size = new Size(144, 28);
            cboClass.TabIndex = 3;
            // 
            // dtPBirhtday
            // 
            dtPBirhtday.Format = DateTimePickerFormat.Custom;
            dtPBirhtday.Location = new Point(133, 166);
            dtPBirhtday.Name = "dtPBirhtday";
            dtPBirhtday.Size = new Size(192, 27);
            dtPBirhtday.TabIndex = 2;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(569, 69);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(178, 27);
            txtPhone.TabIndex = 1;
            txtPhone.KeyPress += txtPhone_KeyPress;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(569, 65);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(178, 27);
            textBox3.TabIndex = 1;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(780, 188);
            txtID.Name = "txtID";
            txtID.Size = new Size(52, 27);
            txtID.TabIndex = 1;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(569, 121);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(178, 27);
            txtAddress.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(133, 25);
            txtName.Name = "txtName";
            txtName.Size = new Size(192, 27);
            txtName.TabIndex = 1;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(447, 166);
            label22.Name = "label22";
            label22.Size = new Size(35, 20);
            label22.TabIndex = 0;
            label22.Text = "Slot";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(447, 124);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 0;
            label6.Text = "Address";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(41, 121);
            label21.Name = "label21";
            label21.Size = new Size(48, 20);
            label21.TabIndex = 0;
            label21.Text = "Major";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 169);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 0;
            label3.Text = "Birthday";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(447, 72);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 0;
            label5.Text = "Phone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 74);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 0;
            label2.Text = "Class";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(447, 31);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 0;
            label4.Text = "Gender";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 28);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // txtSearchStudent
            // 
            txtSearchStudent.Location = new Point(540, 19);
            txtSearchStudent.Multiline = true;
            txtSearchStudent.Name = "txtSearchStudent";
            txtSearchStudent.PlaceholderText = "enter infor...";
            txtSearchStudent.Size = new Size(306, 29);
            txtSearchStudent.TabIndex = 1;
            txtSearchStudent.KeyDown += txtSearchStudent_KeyDown;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(255, 73, 102);
            btnSearch.ForeColor = SystemColors.ButtonHighlight;
            btnSearch.ImageIndex = 4;
            btnSearch.Location = new Point(407, 6);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(127, 53);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Search";
            btnSearch.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 73, 102);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.ImageIndex = 7;
            btnDelete.Location = new Point(274, 6);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(127, 53);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Delete";
            btnDelete.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 73, 102);
            btnUpdate.ForeColor = SystemColors.ButtonHighlight;
            btnUpdate.ImageIndex = 3;
            btnUpdate.Location = new Point(141, 6);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(127, 53);
            btnUpdate.TabIndex = 0;
            btnUpdate.Text = "Update";
            btnUpdate.TextImageRelation = TextImageRelation.ImageAboveText;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(255, 73, 102);
            btnAdd.ForeColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(8, 6);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(127, 53);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvStudent
            // 
            dgvStudent.AllowUserToAddRows = false;
            dgvStudent.AllowUserToDeleteRows = false;
            dgvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudent.Columns.AddRange(new DataGridViewColumn[] { id, student_name, class_id, majorss, SLot, birthday, gender, phone, address });
            dgvStudent.Location = new Point(8, 292);
            dgvStudent.Name = "dgvStudent";
            dgvStudent.ReadOnly = true;
            dgvStudent.RowHeadersWidth = 51;
            dgvStudent.RowTemplate.Height = 29;
            dgvStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudent.Size = new Size(838, 226);
            dgvStudent.TabIndex = 2;
            dgvStudent.CellBorderStyleChanged += dgvStudent_CellBorderStyleChanged;
            dgvStudent.CellClick += dgvStudent_CellClick;
            // 
            // tabPageMajorClassSchedule
            // 
            tabPageMajorClassSchedule.BackgroundImage = (Image)resources.GetObject("tabPageMajorClassSchedule.BackgroundImage");
            tabPageMajorClassSchedule.Controls.Add(btnSchedule);
            tabPageMajorClassSchedule.Controls.Add(btnClass);
            tabPageMajorClassSchedule.Controls.Add(btnMajor);
            tabPageMajorClassSchedule.ImageIndex = 5;
            tabPageMajorClassSchedule.Location = new Point(4, 31);
            tabPageMajorClassSchedule.Name = "tabPageMajorClassSchedule";
            tabPageMajorClassSchedule.Padding = new Padding(3);
            tabPageMajorClassSchedule.Size = new Size(851, 526);
            tabPageMajorClassSchedule.TabIndex = 2;
            tabPageMajorClassSchedule.Text = "Schedule";
            tabPageMajorClassSchedule.UseVisualStyleBackColor = true;
            // 
            // btnSchedule
            // 
            btnSchedule.BackColor = Color.FromArgb(39, 32, 105);
            btnSchedule.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            btnSchedule.ForeColor = Color.White;
            btnSchedule.Location = new Point(557, 41);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Size = new Size(242, 96);
            btnSchedule.TabIndex = 0;
            btnSchedule.Text = "Schedule";
            btnSchedule.UseVisualStyleBackColor = false;
            btnSchedule.Click += btnSchedule_Click;
            // 
            // btnClass
            // 
            btnClass.BackColor = Color.FromArgb(39, 32, 105);
            btnClass.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            btnClass.ForeColor = Color.White;
            btnClass.Location = new Point(309, 41);
            btnClass.Name = "btnClass";
            btnClass.Size = new Size(242, 96);
            btnClass.TabIndex = 0;
            btnClass.Text = "Class";
            btnClass.UseVisualStyleBackColor = false;
            btnClass.Click += btnClass_Click;
            // 
            // btnMajor
            // 
            btnMajor.BackColor = Color.FromArgb(39, 32, 105);
            btnMajor.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            btnMajor.ForeColor = Color.White;
            btnMajor.Location = new Point(61, 41);
            btnMajor.Name = "btnMajor";
            btnMajor.Size = new Size(242, 96);
            btnMajor.TabIndex = 0;
            btnMajor.Text = "Major";
            btnMajor.UseVisualStyleBackColor = false;
            btnMajor.Click += btnMajor_Click;
            // 
            // tabPageAttendance
            // 
            tabPageAttendance.BackColor = Color.FromArgb(239, 250, 252);
            tabPageAttendance.Controls.Add(groupBox1);
            tabPageAttendance.Controls.Add(txtSearchAtten);
            tabPageAttendance.Controls.Add(dgvAttendance);
            tabPageAttendance.Controls.Add(btnSearchAteen);
            tabPageAttendance.Controls.Add(btnattendance);
            tabPageAttendance.ImageIndex = 8;
            tabPageAttendance.Location = new Point(4, 31);
            tabPageAttendance.Name = "tabPageAttendance";
            tabPageAttendance.Padding = new Padding(3);
            tabPageAttendance.Size = new Size(851, 526);
            tabPageAttendance.TabIndex = 3;
            tabPageAttendance.Text = "Attendance";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimeAttenance);
            groupBox1.Controls.Add(cboStatusAttendance);
            groupBox1.Controls.Add(cboScheduleAtt);
            groupBox1.Controls.Add(cboClassAtt);
            groupBox1.Controls.Add(cboMajorAtt);
            groupBox1.Controls.Add(txtIDAtt);
            groupBox1.Controls.Add(txtNameAtt);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label9);
            groupBox1.Location = new Point(8, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(838, 160);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Infro";
            // 
            // dateTimeAttenance
            // 
            dateTimeAttenance.Format = DateTimePickerFormat.Custom;
            dateTimeAttenance.Location = new Point(532, 107);
            dateTimeAttenance.Name = "dateTimeAttenance";
            dateTimeAttenance.Size = new Size(151, 27);
            dateTimeAttenance.TabIndex = 3;
            // 
            // cboStatusAttendance
            // 
            cboStatusAttendance.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatusAttendance.FormattingEnabled = true;
            cboStatusAttendance.Items.AddRange(new object[] { "Present", "Absent" });
            cboStatusAttendance.Location = new Point(532, 70);
            cboStatusAttendance.Name = "cboStatusAttendance";
            cboStatusAttendance.Size = new Size(151, 28);
            cboStatusAttendance.TabIndex = 2;
            // 
            // cboScheduleAtt
            // 
            cboScheduleAtt.DropDownStyle = ComboBoxStyle.DropDownList;
            cboScheduleAtt.FormattingEnabled = true;
            cboScheduleAtt.Location = new Point(532, 32);
            cboScheduleAtt.Name = "cboScheduleAtt";
            cboScheduleAtt.Size = new Size(151, 28);
            cboScheduleAtt.TabIndex = 2;
            // 
            // cboClassAtt
            // 
            cboClassAtt.DropDownStyle = ComboBoxStyle.DropDownList;
            cboClassAtt.FormattingEnabled = true;
            cboClassAtt.Location = new Point(181, 109);
            cboClassAtt.Name = "cboClassAtt";
            cboClassAtt.Size = new Size(151, 28);
            cboClassAtt.TabIndex = 2;
            // 
            // cboMajorAtt
            // 
            cboMajorAtt.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMajorAtt.FormattingEnabled = true;
            cboMajorAtt.Location = new Point(181, 70);
            cboMajorAtt.Name = "cboMajorAtt";
            cboMajorAtt.Size = new Size(191, 28);
            cboMajorAtt.TabIndex = 2;
            // 
            // txtIDAtt
            // 
            txtIDAtt.Enabled = false;
            txtIDAtt.Location = new Point(781, 127);
            txtIDAtt.Name = "txtIDAtt";
            txtIDAtt.Size = new Size(51, 27);
            txtIDAtt.TabIndex = 1;
            // 
            // txtNameAtt
            // 
            txtNameAtt.Enabled = false;
            txtNameAtt.Location = new Point(181, 33);
            txtNameAtt.Name = "txtNameAtt";
            txtNameAtt.Size = new Size(191, 27);
            txtNameAtt.TabIndex = 1;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(448, 109);
            label14.Name = "label14";
            label14.Size = new Size(41, 20);
            label14.TabIndex = 0;
            label14.Text = "Date";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(448, 75);
            label13.Name = "label13";
            label13.Size = new Size(49, 20);
            label13.TabIndex = 0;
            label13.Text = "Status";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(448, 40);
            label12.Name = "label12";
            label12.Size = new Size(69, 20);
            label12.TabIndex = 0;
            label12.Text = "Schedule";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(92, 117);
            label10.Name = "label10";
            label10.Size = new Size(42, 20);
            label10.TabIndex = 0;
            label10.Text = "Class";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(92, 40);
            label11.Name = "label11";
            label11.Size = new Size(49, 20);
            label11.TabIndex = 0;
            label11.Text = "Name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(93, 78);
            label9.Name = "label9";
            label9.Size = new Size(48, 20);
            label9.TabIndex = 0;
            label9.Text = "Major";
            // 
            // txtSearchAtten
            // 
            txtSearchAtten.Location = new Point(357, 190);
            txtSearchAtten.Multiline = true;
            txtSearchAtten.Name = "txtSearchAtten";
            txtSearchAtten.PlaceholderText = "enter name";
            txtSearchAtten.Size = new Size(298, 34);
            txtSearchAtten.TabIndex = 2;
            txtSearchAtten.KeyDown += txtSearchAtten_KeyDown;
            // 
            // dgvAttendance
            // 
            dgvAttendance.AllowUserToAddRows = false;
            dgvAttendance.AllowUserToDeleteRows = false;
            dgvAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAttendance.Columns.AddRange(new DataGridViewColumn[] { Idd, student_namemm, majorr, scheduleee, classs, statuss, date });
            dgvAttendance.Location = new Point(10, 254);
            dgvAttendance.Name = "dgvAttendance";
            dgvAttendance.ReadOnly = true;
            dgvAttendance.RowHeadersWidth = 51;
            dgvAttendance.RowTemplate.Height = 29;
            dgvAttendance.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAttendance.Size = new Size(838, 264);
            dgvAttendance.TabIndex = 1;
            dgvAttendance.CellClick += dgvAttendance_CellClick;
            dgvAttendance.Click += dgvAttendance_Click;
            // 
            // Idd
            // 
            Idd.DataPropertyName = "id";
            Idd.HeaderText = "ID";
            Idd.MinimumWidth = 6;
            Idd.Name = "Idd";
            Idd.ReadOnly = true;
            Idd.Width = 125;
            // 
            // student_namemm
            // 
            student_namemm.DataPropertyName = "student_name";
            student_namemm.HeaderText = "Student Name";
            student_namemm.MinimumWidth = 6;
            student_namemm.Name = "student_namemm";
            student_namemm.ReadOnly = true;
            student_namemm.Width = 125;
            // 
            // majorr
            // 
            majorr.DataPropertyName = "major_id";
            majorr.HeaderText = "Major";
            majorr.MinimumWidth = 6;
            majorr.Name = "majorr";
            majorr.ReadOnly = true;
            majorr.Width = 125;
            // 
            // scheduleee
            // 
            scheduleee.DataPropertyName = "schedule_id";
            scheduleee.HeaderText = "Schedule";
            scheduleee.MinimumWidth = 6;
            scheduleee.Name = "scheduleee";
            scheduleee.ReadOnly = true;
            scheduleee.Width = 125;
            // 
            // classs
            // 
            classs.DataPropertyName = "class_id";
            classs.HeaderText = "Class";
            classs.MinimumWidth = 6;
            classs.Name = "classs";
            classs.ReadOnly = true;
            classs.Width = 125;
            // 
            // statuss
            // 
            statuss.DataPropertyName = "status";
            statuss.HeaderText = "Status";
            statuss.MinimumWidth = 6;
            statuss.Name = "statuss";
            statuss.ReadOnly = true;
            statuss.Width = 125;
            // 
            // date
            // 
            date.DataPropertyName = "date";
            date.HeaderText = "Date";
            date.MinimumWidth = 6;
            date.Name = "date";
            date.ReadOnly = true;
            date.Width = 125;
            // 
            // btnSearchAteen
            // 
            btnSearchAteen.BackColor = Color.FromArgb(255, 73, 102);
            btnSearchAteen.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearchAteen.ForeColor = Color.White;
            btnSearchAteen.Location = new Point(175, 172);
            btnSearchAteen.Name = "btnSearchAteen";
            btnSearchAteen.Size = new Size(176, 64);
            btnSearchAteen.TabIndex = 0;
            btnSearchAteen.Text = "Search";
            btnSearchAteen.UseVisualStyleBackColor = false;
            btnSearchAteen.Click += btnSearchAteen_Click;
            // 
            // btnattendance
            // 
            btnattendance.BackColor = Color.FromArgb(255, 73, 102);
            btnattendance.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnattendance.ForeColor = Color.White;
            btnattendance.Location = new Point(8, 172);
            btnattendance.Name = "btnattendance";
            btnattendance.Size = new Size(161, 64);
            btnattendance.TabIndex = 0;
            btnattendance.Text = "Attendance";
            btnattendance.UseVisualStyleBackColor = false;
            btnattendance.Click += btnattendance_Click;
            // 
            // tabPageUsers
            // 
            tabPageUsers.BackColor = Color.FromArgb(105, 213, 226);
            tabPageUsers.Controls.Add(cboRole);
            tabPageUsers.Controls.Add(cboGenderUser);
            tabPageUsers.Controls.Add(txtPass);
            tabPageUsers.Controls.Add(txtUserNameUser);
            tabPageUsers.Controls.Add(txtEmailUsers);
            tabPageUsers.Controls.Add(txtIDUser);
            tabPageUsers.Controls.Add(txtNameUsers);
            tabPageUsers.Controls.Add(btnDeleteUser);
            tabPageUsers.Controls.Add(btnUpdateUser);
            tabPageUsers.Controls.Add(btnAddUsers);
            tabPageUsers.Controls.Add(label20);
            tabPageUsers.Controls.Add(label17);
            tabPageUsers.Controls.Add(label19);
            tabPageUsers.Controls.Add(label16);
            tabPageUsers.Controls.Add(label18);
            tabPageUsers.Controls.Add(label15);
            tabPageUsers.Controls.Add(dgvUsers);
            tabPageUsers.ImageIndex = 10;
            tabPageUsers.Location = new Point(4, 31);
            tabPageUsers.Name = "tabPageUsers";
            tabPageUsers.Padding = new Padding(3);
            tabPageUsers.Size = new Size(851, 526);
            tabPageUsers.TabIndex = 4;
            tabPageUsers.Text = "User";
            // 
            // cboRole
            // 
            cboRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRole.FormattingEnabled = true;
            cboRole.Location = new Point(602, 119);
            cboRole.Name = "cboRole";
            cboRole.Size = new Size(125, 28);
            cboRole.TabIndex = 4;
            // 
            // cboGenderUser
            // 
            cboGenderUser.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGenderUser.FormattingEnabled = true;
            cboGenderUser.Items.AddRange(new object[] { "Male", "Female" });
            cboGenderUser.Location = new Point(221, 75);
            cboGenderUser.Name = "cboGenderUser";
            cboGenderUser.Size = new Size(125, 28);
            cboGenderUser.TabIndex = 4;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(602, 75);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(125, 27);
            txtPass.TabIndex = 3;
            // 
            // txtUserNameUser
            // 
            txtUserNameUser.Location = new Point(602, 34);
            txtUserNameUser.Name = "txtUserNameUser";
            txtUserNameUser.Size = new Size(125, 27);
            txtUserNameUser.TabIndex = 3;
            // 
            // txtEmailUsers
            // 
            txtEmailUsers.Location = new Point(221, 119);
            txtEmailUsers.Name = "txtEmailUsers";
            txtEmailUsers.Size = new Size(152, 27);
            txtEmailUsers.TabIndex = 3;
            // 
            // txtIDUser
            // 
            txtIDUser.Enabled = false;
            txtIDUser.Location = new Point(6, 6);
            txtIDUser.Name = "txtIDUser";
            txtIDUser.Size = new Size(50, 27);
            txtIDUser.TabIndex = 3;
            // 
            // txtNameUsers
            // 
            txtNameUsers.Location = new Point(221, 34);
            txtNameUsers.Name = "txtNameUsers";
            txtNameUsers.Size = new Size(152, 27);
            txtNameUsers.TabIndex = 3;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.BackColor = Color.FromArgb(39, 32, 105);
            btnDeleteUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteUser.ForeColor = Color.White;
            btnDeleteUser.Location = new Point(471, 189);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(166, 52);
            btnDeleteUser.TabIndex = 2;
            btnDeleteUser.Text = "Delete";
            btnDeleteUser.UseVisualStyleBackColor = false;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // btnUpdateUser
            // 
            btnUpdateUser.BackColor = Color.FromArgb(39, 32, 105);
            btnUpdateUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateUser.ForeColor = Color.White;
            btnUpdateUser.Location = new Point(299, 189);
            btnUpdateUser.Name = "btnUpdateUser";
            btnUpdateUser.Size = new Size(166, 52);
            btnUpdateUser.TabIndex = 2;
            btnUpdateUser.Text = "Update";
            btnUpdateUser.UseVisualStyleBackColor = false;
            btnUpdateUser.Click += btnUpdateUser_Click;
            // 
            // btnAddUsers
            // 
            btnAddUsers.BackColor = Color.FromArgb(39, 32, 105);
            btnAddUsers.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddUsers.ForeColor = Color.White;
            btnAddUsers.Location = new Point(127, 189);
            btnAddUsers.Name = "btnAddUsers";
            btnAddUsers.Size = new Size(166, 52);
            btnAddUsers.TabIndex = 2;
            btnAddUsers.Text = "Add";
            btnAddUsers.UseVisualStyleBackColor = false;
            btnAddUsers.Click += btnAddUsers_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(489, 122);
            label20.Name = "label20";
            label20.Size = new Size(39, 20);
            label20.TabIndex = 1;
            label20.Text = "Role";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(127, 122);
            label17.Name = "label17";
            label17.Size = new Size(46, 20);
            label17.TabIndex = 1;
            label17.Text = "Email";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(489, 78);
            label19.Name = "label19";
            label19.Size = new Size(70, 20);
            label19.TabIndex = 1;
            label19.Text = "Password";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(127, 78);
            label16.Name = "label16";
            label16.Size = new Size(57, 20);
            label16.TabIndex = 1;
            label16.Text = "Gender";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(489, 37);
            label18.Name = "label18";
            label18.Size = new Size(75, 20);
            label18.TabIndex = 1;
            label18.Text = "Username";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(127, 37);
            label15.Name = "label15";
            label15.Size = new Size(49, 20);
            label15.TabIndex = 1;
            label15.Text = "Name";
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Columns.AddRange(new DataGridViewColumn[] { idusers, fullname, genderU, email, username, password, role_id });
            dgvUsers.Location = new Point(8, 263);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.RowTemplate.Height = 29;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(840, 255);
            dgvUsers.TabIndex = 0;
            dgvUsers.CellClick += dgvUsers_CellClick;
            // 
            // idusers
            // 
            idusers.DataPropertyName = "id";
            idusers.HeaderText = "ID";
            idusers.MinimumWidth = 6;
            idusers.Name = "idusers";
            idusers.ReadOnly = true;
            idusers.Width = 125;
            // 
            // fullname
            // 
            fullname.DataPropertyName = "fullname";
            fullname.HeaderText = "Fullname";
            fullname.MinimumWidth = 6;
            fullname.Name = "fullname";
            fullname.ReadOnly = true;
            fullname.Width = 125;
            // 
            // genderU
            // 
            genderU.DataPropertyName = "gender";
            genderU.HeaderText = "Gender";
            genderU.MinimumWidth = 6;
            genderU.Name = "genderU";
            genderU.ReadOnly = true;
            genderU.Width = 125;
            // 
            // email
            // 
            email.DataPropertyName = "email";
            email.HeaderText = "Email";
            email.MinimumWidth = 6;
            email.Name = "email";
            email.ReadOnly = true;
            email.Width = 125;
            // 
            // username
            // 
            username.DataPropertyName = "username";
            username.HeaderText = "Username";
            username.MinimumWidth = 6;
            username.Name = "username";
            username.ReadOnly = true;
            username.Width = 125;
            // 
            // password
            // 
            password.DataPropertyName = "password";
            password.HeaderText = "Password";
            password.MinimumWidth = 6;
            password.Name = "password";
            password.ReadOnly = true;
            password.Width = 125;
            // 
            // role_id
            // 
            role_id.DataPropertyName = "role_id";
            role_id.HeaderText = "Role";
            role_id.MinimumWidth = 6;
            role_id.Name = "role_id";
            role_id.ReadOnly = true;
            role_id.Width = 125;
            // 
            // tabPageExit
            // 
            tabPageExit.BackgroundImage = (Image)resources.GetObject("tabPageExit.BackgroundImage");
            tabPageExit.BackgroundImageLayout = ImageLayout.Center;
            tabPageExit.Controls.Add(button1);
            tabPageExit.ImageIndex = 11;
            tabPageExit.Location = new Point(4, 31);
            tabPageExit.Name = "tabPageExit";
            tabPageExit.Padding = new Padding(3);
            tabPageExit.Size = new Size(851, 526);
            tabPageExit.TabIndex = 5;
            tabPageExit.Text = "Exit";
            tabPageExit.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(292, 17);
            button1.Name = "button1";
            button1.Size = new Size(323, 93);
            button1.TabIndex = 0;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "white home.png");
            imageList1.Images.SetKeyName(1, "icons8-student-48.png");
            imageList1.Images.SetKeyName(2, "icons8-check-48.png");
            imageList1.Images.SetKeyName(3, "icons8-update-64.png");
            imageList1.Images.SetKeyName(4, "icons8-search-48.png");
            imageList1.Images.SetKeyName(5, "icons8-schedule-50.png");
            imageList1.Images.SetKeyName(6, "icons8-clear-50 (1).png");
            imageList1.Images.SetKeyName(7, "icons8-delete-48.png");
            imageList1.Images.SetKeyName(8, "icons8-attendance-50.png");
            imageList1.Images.SetKeyName(9, "icons8-home-64.png");
            imageList1.Images.SetKeyName(10, "icons8-user-48.png");
            imageList1.Images.SetKeyName(11, "icons8-close-100.png");
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "id";
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // student_namee
            // 
            student_namee.DataPropertyName = "student_name";
            student_namee.HeaderText = "Student Name";
            student_namee.MinimumWidth = 6;
            student_namee.Name = "student_namee";
            student_namee.Width = 125;
            // 
            // major_id
            // 
            major_id.DataPropertyName = "major_id";
            major_id.HeaderText = "Major";
            major_id.MinimumWidth = 6;
            major_id.Name = "major_id";
            major_id.Width = 125;
            // 
            // schedule_id
            // 
            schedule_id.DataPropertyName = "schedule_id";
            schedule_id.HeaderText = "Schedule";
            schedule_id.MinimumWidth = 6;
            schedule_id.Name = "schedule_id";
            schedule_id.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "class_id";
            dataGridViewTextBoxColumn2.HeaderText = "Class";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // status
            // 
            status.DataPropertyName = "status";
            status.HeaderText = "Status";
            status.MinimumWidth = 6;
            status.Name = "status";
            status.Width = 125;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 125;
            // 
            // student_name
            // 
            student_name.DataPropertyName = "student_name";
            student_name.HeaderText = "Name";
            student_name.MinimumWidth = 6;
            student_name.Name = "student_name";
            student_name.ReadOnly = true;
            student_name.Width = 125;
            // 
            // class_id
            // 
            class_id.DataPropertyName = "class_name";
            class_id.HeaderText = "Class";
            class_id.MinimumWidth = 6;
            class_id.Name = "class_id";
            class_id.ReadOnly = true;
            class_id.Width = 125;
            // 
            // majorss
            // 
            majorss.DataPropertyName = "major_name";
            majorss.HeaderText = "Major";
            majorss.MinimumWidth = 6;
            majorss.Name = "majorss";
            majorss.ReadOnly = true;
            majorss.Width = 125;
            // 
            // SLot
            // 
            SLot.DataPropertyName = "start_end";
            SLot.HeaderText = "Slot";
            SLot.MinimumWidth = 6;
            SLot.Name = "SLot";
            SLot.ReadOnly = true;
            SLot.Width = 125;
            // 
            // birthday
            // 
            birthday.DataPropertyName = "birthday";
            birthday.HeaderText = "BIrthday";
            birthday.MinimumWidth = 6;
            birthday.Name = "birthday";
            birthday.ReadOnly = true;
            birthday.Width = 125;
            // 
            // gender
            // 
            gender.DataPropertyName = "gender";
            gender.HeaderText = "Gender";
            gender.MinimumWidth = 6;
            gender.Name = "gender";
            gender.ReadOnly = true;
            gender.Width = 125;
            // 
            // phone
            // 
            phone.DataPropertyName = "phone";
            phone.HeaderText = "Phone";
            phone.MinimumWidth = 6;
            phone.Name = "phone";
            phone.ReadOnly = true;
            phone.Width = 125;
            // 
            // address
            // 
            address.DataPropertyName = "address";
            address.HeaderText = "Address";
            address.MinimumWidth = 6;
            address.Name = "address";
            address.ReadOnly = true;
            address.Width = 125;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 561);
            Controls.Add(tabControl);
            Name = "FormAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAdmin";
            Load += DashBoard_Load;
            tabControl.ResumeLayout(false);
            tabPageHome.ResumeLayout(false);
            tabPageHome.PerformLayout();
            tabPageStudent.ResumeLayout(false);
            tabPageStudent.PerformLayout();
            Information.ResumeLayout(false);
            Information.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudent).EndInit();
            tabPageMajorClassSchedule.ResumeLayout(false);
            tabPageAttendance.ResumeLayout(false);
            tabPageAttendance.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).EndInit();
            tabPageUsers.ResumeLayout(false);
            tabPageUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            tabPageExit.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPageHome;
        private TabPage tabPageStudent;
        private TabPage tabPageMajorClassSchedule;
        private TabPage tabPageAttendance;
        private TabPage tabPageUsers;
        private ImageList imageList1;
        private Label label8;
        private Label label7;
        private GroupBox Information;
        private ComboBox cboGender;
        private ComboBox cboClass;
        private DateTimePicker dtPBirhtday;
        private TextBox txtPhone;
        private TextBox textBox3;
        private TextBox txtID;
        private TextBox txtAddress;
        private TextBox txtName;
        private Label label6;
        private Label label3;
        private Label label5;
        private Label label2;
        private Label label4;
        private Label label1;
        private TextBox txtSearchStudent;
        private Button btnSearch;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private DataGridView dgvStudent;
        private Button btnClass;
        private Button btnMajor;
        private GroupBox groupBox1;
        private DateTimePicker dateTimeAttenance;
        private ComboBox cboStatusAttendance;
        private ComboBox cboScheduleAtt;
        private ComboBox cboClassAtt;
        private ComboBox cboMajorAtt;
        private TextBox txtIDAtt;
        private TextBox txtNameAtt;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label10;
        private Label label11;
        private Label label9;
        private TextBox txtSearchAtten;
        private DataGridView dgvAttendance;
        private Button btnSearchAteen;
        private Button btnattendance;
        private ComboBox cboRole;
        private ComboBox cboGenderUser;
        private TextBox txtPass;
        private TextBox txtUserNameUser;
        private TextBox txtEmailUsers;
        private TextBox txtIDUser;
        private TextBox txtNameUsers;
        private Button btnDeleteUser;
        private Button btnUpdateUser;
        private Button btnAddUsers;
        private Label label20;
        private Label label17;
        private Label label19;
        private Label label16;
        private Label label18;
        private Label label15;
        private DataGridView dgvUsers;
        private TabPage tabPageExit;
        private Button button1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn student_namee;
        private DataGridViewTextBoxColumn major_id;
        private DataGridViewTextBoxColumn schedule_id;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn status;
        private ComboBox cboMajors;
        private Label label21;
        private DataGridViewTextBoxColumn idusers;
        private DataGridViewTextBoxColumn fullname;
        private DataGridViewTextBoxColumn genderU;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn username;
        private DataGridViewTextBoxColumn password;
        private DataGridViewTextBoxColumn role_id;
        private Button btnSchedule;
        private DataGridViewTextBoxColumn Idd;
        private DataGridViewTextBoxColumn student_namemm;
        private DataGridViewTextBoxColumn majorr;
        private DataGridViewTextBoxColumn scheduleee;
        private DataGridViewTextBoxColumn classs;
        private DataGridViewTextBoxColumn statuss;
        private DataGridViewTextBoxColumn date;
        private ComboBox cboSlot;
        private Label label22;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn student_name;
        private DataGridViewTextBoxColumn class_id;
        private DataGridViewTextBoxColumn majorss;
        private DataGridViewTextBoxColumn SLot;
        private DataGridViewTextBoxColumn birthday;
        private DataGridViewTextBoxColumn gender;
        private DataGridViewTextBoxColumn phone;
        private DataGridViewTextBoxColumn address;
    }
}