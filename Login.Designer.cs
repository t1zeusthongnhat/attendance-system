namespace AttendanceSystem
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            txtUser = new TextBox();
            txtPass = new TextBox();
            btnLogin = new Button();
            imageList1 = new ImageList(components);
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            checkBox1 = new CheckBox();
            label4 = new Label();
            lbRegister = new Label();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.Location = new Point(285, 161);
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = " username";
            txtUser.Size = new Size(143, 27);
            txtUser.TabIndex = 0;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(285, 235);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.PlaceholderText = "password";
            txtPass.Size = new Size(143, 27);
            txtPass.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(128, 255, 255);
            btnLogin.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.Black;
            btnLogin.Image = (Image)resources.GetObject("btnLogin.Image");
            btnLogin.Location = new Point(197, 312);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(130, 53);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Login";
            btnLogin.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "icons8-login-64.png");
            imageList1.Images.SetKeyName(1, "icons8-register-48 (1).png");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(197, 147);
            label2.Name = "label2";
            label2.Size = new Size(74, 41);
            label2.TabIndex = 2;
            label2.Text = "       ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(187, 214);
            label1.Name = "label1";
            label1.Size = new Size(92, 50);
            label1.TabIndex = 2;
            label1.Text = "       ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Transparent;
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.Location = new Point(515, 74);
            label3.Name = "label3";
            label3.Size = new Size(32, 28);
            label3.TabIndex = 3;
            label3.Text = "    ";
            label3.Click += label3_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Location = new Point(336, 285);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(136, 24);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Show Password ";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(197, 388);
            label4.Name = "label4";
            label4.Size = new Size(163, 20);
            label4.TabIndex = 5;
            label4.Text = "Don't have an account?";
            // 
            // lbRegister
            // 
            lbRegister.AutoSize = true;
            lbRegister.BackColor = Color.Transparent;
            lbRegister.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbRegister.Location = new Point(363, 389);
            lbRegister.Name = "lbRegister";
            lbRegister.Size = new Size(103, 20);
            lbRegister.TabIndex = 5;
            lbRegister.Text = "Register here";
            lbRegister.Click += lbRegister_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(666, 487);
            Controls.Add(lbRegister);
            Controls.Add(label4);
            Controls.Add(checkBox1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(btnLogin);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            TransparencyKey = Color.LightGray;
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUser;
        private TextBox txtPass;
        private Button btnLogin;
        private Label label2;
        private Label label1;
        private Label label3;
        private ImageList imageList1;
        private CheckBox checkBox1;
        private Label label4;
        private Label lbRegister;
    }
}