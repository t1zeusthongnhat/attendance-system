namespace AttendanceSystem
{
    partial class SigUP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SigUP));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtFullName = new TextBox();
            txtEmail = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            cboGender = new ComboBox();
            btnSigup = new Button();
            btnSigin = new Button();
            checkBox = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(39, 56);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(80, 23);
            label1.TabIndex = 0;
            label1.Text = "Fullname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(39, 114);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 23);
            label2.TabIndex = 0;
            label2.Text = "Gender";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(39, 178);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(51, 23);
            label3.TabIndex = 0;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(446, 114);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(82, 23);
            label4.TabIndex = 0;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(446, 56);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(87, 23);
            label5.TabIndex = 0;
            label5.Text = "Username";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(156, 48);
            txtFullName.Margin = new Padding(4, 3, 4, 3);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(238, 30);
            txtFullName.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(156, 170);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(238, 30);
            txtEmail.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(579, 48);
            txtUsername.Margin = new Padding(4, 3, 4, 3);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(184, 30);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(579, 110);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(184, 30);
            txtPassword.TabIndex = 1;
            // 
            // cboGender
            // 
            cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGender.FormattingEnabled = true;
            cboGender.Items.AddRange(new object[] { "Male", "Female" });
            cboGender.Location = new Point(156, 105);
            cboGender.Margin = new Padding(4, 3, 4, 3);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(182, 31);
            cboGender.TabIndex = 2;
            // 
            // btnSigup
            // 
            btnSigup.BackColor = Color.FromArgb(255, 73, 102);
            btnSigup.Location = new Point(90, 291);
            btnSigup.Margin = new Padding(4, 3, 4, 3);
            btnSigup.Name = "btnSigup";
            btnSigup.Size = new Size(249, 67);
            btnSigup.TabIndex = 3;
            btnSigup.Text = "SIGN UP";
            btnSigup.UseVisualStyleBackColor = false;
            btnSigup.Click += btnSigup_Click;
            // 
            // btnSigin
            // 
            btnSigin.BackColor = Color.FromArgb(128, 255, 128);
            btnSigin.Location = new Point(446, 291);
            btnSigin.Margin = new Padding(4, 3, 4, 3);
            btnSigin.Name = "btnSigin";
            btnSigin.Size = new Size(249, 67);
            btnSigin.TabIndex = 3;
            btnSigin.Text = "SIGN IN";
            btnSigin.UseVisualStyleBackColor = false;
            btnSigin.Click += btnSigin_Click;
            // 
            // checkBox
            // 
            checkBox.AutoSize = true;
            checkBox.BackColor = Color.Transparent;
            checkBox.Location = new Point(446, 170);
            checkBox.Margin = new Padding(4, 3, 4, 3);
            checkBox.Name = "checkBox";
            checkBox.Size = new Size(151, 27);
            checkBox.TabIndex = 4;
            checkBox.Text = "Show Password";
            checkBox.UseVisualStyleBackColor = false;
            checkBox.CheckedChanged += checkBox_CheckedChanged;
            // 
            // SigUP
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(785, 435);
            Controls.Add(checkBox);
            Controls.Add(btnSigin);
            Controls.Add(btnSigup);
            Controls.Add(cboGender);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtEmail);
            Controls.Add(txtFullName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.White;
            Margin = new Padding(4, 3, 4, 3);
            Name = "SigUP";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SigUP";
            Load += SigUP_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtFullName;
        private TextBox txtEmail;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private ComboBox cboGender;
        private Button btnSigup;
        private Button btnSigin;
        private CheckBox checkBox;
    }
}