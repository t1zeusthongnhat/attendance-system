namespace AttendanceSystem.Schedule
{
    partial class Major
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
            dataGridView1 = new DataGridView();
            btnBack = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtID = new TextBox();
            txtTeacher = new TextBox();
            txtName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            cboStatus = new ComboBox();
            txtDes = new TextBox();
            btnLoad = new Button();
            id = new DataGridViewTextBoxColumn();
            major_name = new DataGridViewTextBoxColumn();
            teacher_name = new DataGridViewTextBoxColumn();
            description = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, major_name, teacher_name, description });
            dataGridView1.Location = new Point(12, 207);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(638, 188);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(556, 401);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(171, 144);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(134, 47);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(31, 144);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(134, 47);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(607, 174);
            txtID.Multiline = true;
            txtID.Name = "txtID";
            txtID.ScrollBars = ScrollBars.Both;
            txtID.Size = new Size(43, 27);
            txtID.TabIndex = 7;
            // 
            // txtTeacher
            // 
            txtTeacher.Location = new Point(125, 57);
            txtTeacher.Name = "txtTeacher";
            txtTeacher.Size = new Size(125, 27);
            txtTeacher.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.Location = new Point(125, 19);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 60);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 5;
            label2.Text = "Teacher";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 26);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 6;
            label1.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(285, 26);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 6;
            label3.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 99);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 5;
            label4.Text = "Status";
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "Active", "Deactive" });
            cboStatus.Location = new Point(125, 91);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(125, 28);
            cboStatus.TabIndex = 12;
            // 
            // txtDes
            // 
            txtDes.Location = new Point(387, 26);
            txtDes.Multiline = true;
            txtDes.Name = "txtDes";
            txtDes.ScrollBars = ScrollBars.Both;
            txtDes.Size = new Size(263, 112);
            txtDes.TabIndex = 13;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(311, 144);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(134, 47);
            btnLoad.TabIndex = 14;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
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
            // major_name
            // 
            major_name.DataPropertyName = "major_name";
            major_name.HeaderText = "Major";
            major_name.MinimumWidth = 6;
            major_name.Name = "major_name";
            major_name.ReadOnly = true;
            major_name.Width = 125;
            // 
            // teacher_name
            // 
            teacher_name.DataPropertyName = "teacher_name";
            teacher_name.HeaderText = "Teacher";
            teacher_name.MinimumWidth = 6;
            teacher_name.Name = "teacher_name";
            teacher_name.ReadOnly = true;
            teacher_name.Width = 125;
            // 
            // description
            // 
            description.DataPropertyName = "description";
            description.HeaderText = "Description";
            description.MinimumWidth = 6;
            description.Name = "description";
            description.ReadOnly = true;
            description.Width = 125;
            // 
            // Major
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 444);
            Controls.Add(btnLoad);
            Controls.Add(txtDes);
            Controls.Add(cboStatus);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtID);
            Controls.Add(txtTeacher);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(dataGridView1);
            Name = "Major";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Major";
            Load += Major_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnBack;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox txtID;
        private TextBox txtTeacher;
        private TextBox txtName;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private ComboBox cboStatus;
        private TextBox txtDes;
        private Button btnLoad;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn major_name;
        private DataGridViewTextBoxColumn teacher_name;
        private DataGridViewTextBoxColumn description;
    }
}