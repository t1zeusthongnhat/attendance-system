namespace AttendanceSystem.Schedule
{
    partial class Clash
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
            class_name = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            btnBack = new Button();
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            txtQuantity = new TextBox();
            txtID = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClass).BeginInit();
            SuspendLayout();
            // 
            // dgvClass
            // 
            dgvClass.AllowUserToAddRows = false;
            dgvClass.AllowUserToDeleteRows = false;
            dgvClass.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClass.Columns.AddRange(new DataGridViewColumn[] { id, class_name, quantity });
            dgvClass.Location = new Point(12, 215);
            dgvClass.Name = "dgvClass";
            dgvClass.ReadOnly = true;
            dgvClass.RowHeadersWidth = 51;
            dgvClass.RowTemplate.Height = 29;
            dgvClass.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClass.Size = new Size(434, 188);
            dgvClass.TabIndex = 0;
            dgvClass.CellClick += dgvClass_CellClick_1;
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
            // class_name
            // 
            class_name.DataPropertyName = "class_name";
            class_name.HeaderText = "Name";
            class_name.MinimumWidth = 6;
            class_name.Name = "class_name";
            class_name.ReadOnly = true;
            class_name.Width = 125;
            // 
            // quantity
            // 
            quantity.DataPropertyName = "quantity";
            quantity.HeaderText = "Quantity";
            quantity.MinimumWidth = 6;
            quantity.Name = "quantity";
            quantity.ReadOnly = true;
            quantity.Width = 125;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(352, 409);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 43);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 77);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 2;
            label2.Text = "Quantity";
            // 
            // txtName
            // 
            txtName.Location = new Point(161, 36);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 3;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(161, 74);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(125, 27);
            txtQuantity.TabIndex = 3;
            // 
            // txtID
            // 
            txtID.Location = new Point(385, 12);
            txtID.Name = "txtID";
            txtID.Size = new Size(61, 27);
            txtID.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 146);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(134, 47);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(161, 146);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(134, 47);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(312, 146);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(134, 47);
            btnLoad.TabIndex = 5;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // Clash
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 442);
            Controls.Add(btnLoad);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtID);
            Controls.Add(txtQuantity);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(dgvClass);
            Name = "Clash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Class";
            Load += Class_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClass).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvClass;
        private Button btnBack;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn class_name;
        private DataGridViewTextBoxColumn quantity;
        private Label label1;
        private Label label2;
        private TextBox txtName;
        private TextBox txtQuantity;
        private TextBox txtID;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnLoad;
    }
}