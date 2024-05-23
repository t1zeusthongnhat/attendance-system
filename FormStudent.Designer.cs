namespace AttendanceSystem
{
    partial class FormStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStudent));
            tabControl1 = new TabControl();
            tabPageHome = new TabPage();
            label8 = new Label();
            label7 = new Label();
            tabPageAttendance = new TabPage();
            txtSearch = new TextBox();
            btnSearch = new Button();
            dgvAttendance = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            student_name = new DataGridViewTextBoxColumn();
            major_name = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            class_name = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            tabPageExit = new TabPage();
            btnExit = new Button();
            imageList1 = new ImageList(components);
            tabControl1.SuspendLayout();
            tabPageHome.SuspendLayout();
            tabPageAttendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).BeginInit();
            tabPageExit.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageHome);
            tabControl1.Controls.Add(tabPageAttendance);
            tabControl1.Controls.Add(tabPageExit);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.ImageList = imageList1;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPageHome
            // 
            tabPageHome.BackgroundImage = (Image)resources.GetObject("tabPageHome.BackgroundImage");
            tabPageHome.BackgroundImageLayout = ImageLayout.Stretch;
            tabPageHome.Controls.Add(label8);
            tabPageHome.Controls.Add(label7);
            tabPageHome.ImageIndex = 0;
            tabPageHome.Location = new Point(4, 33);
            tabPageHome.Name = "tabPageHome";
            tabPageHome.Padding = new Padding(3);
            tabPageHome.Size = new Size(792, 413);
            tabPageHome.TabIndex = 0;
            tabPageHome.Text = "Home";
            tabPageHome.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(39, 32, 105);
            label8.Location = new Point(101, 170);
            label8.Name = "label8";
            label8.Size = new Size(203, 50);
            label8.TabIndex = 1;
            label8.Text = "WELCOME";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(39, 32, 105);
            label7.Location = new Point(0, 103);
            label7.Name = "label7";
            label7.Size = new Size(414, 50);
            label7.TabIndex = 2;
            label7.Text = "ATTENDANCE SYSTEM";
            // 
            // tabPageAttendance
            // 
            tabPageAttendance.Controls.Add(txtSearch);
            tabPageAttendance.Controls.Add(btnSearch);
            tabPageAttendance.Controls.Add(dgvAttendance);
            tabPageAttendance.ImageIndex = 1;
            tabPageAttendance.Location = new Point(4, 33);
            tabPageAttendance.Name = "tabPageAttendance";
            tabPageAttendance.Padding = new Padding(3);
            tabPageAttendance.Size = new Size(792, 413);
            tabPageAttendance.TabIndex = 1;
            tabPageAttendance.Text = "Attendance";
            tabPageAttendance.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(184, 270);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "enter your name or your class";
            txtSearch.Size = new Size(286, 39);
            txtSearch.TabIndex = 2;
            txtSearch.KeyDown += txt_KeyDown;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(128, 255, 128);
            btnSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.Black;
            btnSearch.Location = new Point(476, 265);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(143, 51);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvAttendance
            // 
            dgvAttendance.AllowUserToAddRows = false;
            dgvAttendance.AllowUserToDeleteRows = false;
            dgvAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAttendance.Columns.AddRange(new DataGridViewColumn[] { id, student_name, major_name, name, class_name, status, date });
            dgvAttendance.Location = new Point(8, 6);
            dgvAttendance.Name = "dgvAttendance";
            dgvAttendance.ReadOnly = true;
            dgvAttendance.RowHeadersWidth = 51;
            dgvAttendance.RowTemplate.Height = 29;
            dgvAttendance.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAttendance.Size = new Size(776, 236);
            dgvAttendance.TabIndex = 0;
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
            student_name.HeaderText = "Student Name";
            student_name.MinimumWidth = 6;
            student_name.Name = "student_name";
            student_name.ReadOnly = true;
            student_name.Width = 125;
            // 
            // major_name
            // 
            major_name.DataPropertyName = "major_name";
            major_name.HeaderText = "Major";
            major_name.MinimumWidth = 6;
            major_name.Name = "major_name";
            major_name.ReadOnly = true;
            major_name.Width = 125;
            // 
            // name
            // 
            name.DataPropertyName = "name";
            name.HeaderText = "Schedule";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.ReadOnly = true;
            name.Width = 125;
            // 
            // class_name
            // 
            class_name.DataPropertyName = "class_name";
            class_name.HeaderText = "Class";
            class_name.MinimumWidth = 6;
            class_name.Name = "class_name";
            class_name.ReadOnly = true;
            class_name.Width = 125;
            // 
            // status
            // 
            status.DataPropertyName = "status";
            status.HeaderText = "Status";
            status.MinimumWidth = 6;
            status.Name = "status";
            status.ReadOnly = true;
            status.Width = 125;
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
            // tabPageExit
            // 
            tabPageExit.BackgroundImage = (Image)resources.GetObject("tabPageExit.BackgroundImage");
            tabPageExit.BackgroundImageLayout = ImageLayout.Zoom;
            tabPageExit.Controls.Add(btnExit);
            tabPageExit.ImageIndex = 2;
            tabPageExit.Location = new Point(4, 33);
            tabPageExit.Name = "tabPageExit";
            tabPageExit.Padding = new Padding(3);
            tabPageExit.Size = new Size(792, 413);
            tabPageExit.TabIndex = 2;
            tabPageExit.Text = "Exit";
            tabPageExit.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnExit.Location = new Point(280, 321);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(227, 70);
            btnExit.TabIndex = 0;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "icons8-home-64.png");
            imageList1.Images.SetKeyName(1, "icons8-check-48.png");
            imageList1.Images.SetKeyName(2, "icons8-exit-64.png");
            // 
            // FormStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "FormStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormStudent";
            Load += FormStudent_Load;
            tabControl1.ResumeLayout(false);
            tabPageHome.ResumeLayout(false);
            tabPageHome.PerformLayout();
            tabPageAttendance.ResumeLayout(false);
            tabPageAttendance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).EndInit();
            tabPageExit.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageHome;
        private TabPage tabPageAttendance;
        private ImageList imageList1;
        private TabPage tabPageExit;
        private Label label8;
        private Label label7;
        private TextBox txtSearch;
        private Button btnSearch;
        private DataGridView dgvAttendance;
        private Button btnExit;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn student_name;
        private DataGridViewTextBoxColumn major_name;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn class_name;
        private DataGridViewTextBoxColumn status;
        private DataGridViewTextBoxColumn date;
    }
}