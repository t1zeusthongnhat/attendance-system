namespace AttendanceSystem.Schedule
{
    partial class Slot
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
            dgvClass = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            St_end = new DataGridViewTextBoxColumn();
            btnBack = new Button();
            btnLoad = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtID = new TextBox();
            txtQuantity = new TextBox();
            txtName = new TextBox();
            Start_End = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClass).BeginInit();
            SuspendLayout();
            // 
            // dgvClass
            // 
            dgvClass.AllowUserToAddRows = false;
            dgvClass.AllowUserToDeleteRows = false;
            dgvClass.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClass.Columns.AddRange(new DataGridViewColumn[] { id, name, St_end });
            dgvClass.Location = new Point(12, 207);
            dgvClass.Name = "dgvClass";
            dgvClass.ReadOnly = true;
            dgvClass.RowHeadersWidth = 51;
            dgvClass.RowTemplate.Height = 29;
            dgvClass.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClass.Size = new Size(434, 188);
            dgvClass.TabIndex = 1;
            dgvClass.CellClick += dgvClass_CellClick;
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
            // name
            // 
            name.DataPropertyName = "name";
            name.HeaderText = "Name";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.ReadOnly = true;
            name.Width = 125;
            // 
            // St_end
            // 
            St_end.DataPropertyName = "start_end";
            St_end.HeaderText = "Start_End";
            St_end.MinimumWidth = 6;
            St_end.Name = "St_end";
            St_end.ReadOnly = true;
            St_end.Width = 125;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(352, 405);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(311, 142);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(134, 47);
            btnLoad.TabIndex = 13;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(160, 142);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(134, 47);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(11, 142);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(134, 47);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(384, 8);
            txtID.Name = "txtID";
            txtID.Size = new Size(61, 27);
            txtID.TabIndex = 8;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(160, 70);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(125, 27);
            txtQuantity.TabIndex = 9;
            // 
            // txtName
            // 
            txtName.Location = new Point(160, 32);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 10;
            // 
            // Start_End
            // 
            Start_End.AutoSize = true;
            Start_End.Location = new Point(60, 73);
            Start_End.Name = "Start_End";
            Start_End.Size = new Size(71, 20);
            Start_End.TabIndex = 6;
            Start_End.Text = "Start_End";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 39);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 7;
            label1.Text = "Name";
            // 
            // Slot
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 443);
            Controls.Add(btnLoad);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtID);
            Controls.Add(txtQuantity);
            Controls.Add(txtName);
            Controls.Add(Start_End);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(dgvClass);
            Name = "Slot";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Schedule";
            Load += Slot_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClass).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvClass;
        private Button btnBack;
        private Button btnLoad;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox txtID;
        private TextBox txtQuantity;
        private TextBox txtName;
        private Label Start_End;
        private Label label1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn St_end;
    }
}