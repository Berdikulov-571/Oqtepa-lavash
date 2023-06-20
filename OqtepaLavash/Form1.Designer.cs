namespace OqtepaLavash
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            LoginEmail = new TextBox();
            PasswordLogin = new TextBox();
            btn_enter = new Button();
            btn_registration = new Button();
            btn_forget_password = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(32, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(486, 368);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // LoginEmail
            // 
            LoginEmail.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            LoginEmail.ForeColor = Color.Black;
            LoginEmail.Location = new Point(95, 415);
            LoginEmail.Margin = new Padding(3, 32, 23, 23);
            LoginEmail.Multiline = true;
            LoginEmail.Name = "LoginEmail";
            LoginEmail.PlaceholderText = "Enter your email";
            LoginEmail.Size = new Size(340, 55);
            LoginEmail.TabIndex = 1;
            LoginEmail.TextChanged += LoginEmail_TextChanged;
            // 
            // PasswordLogin
            // 
            PasswordLogin.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordLogin.Location = new Point(95, 496);
            PasswordLogin.Multiline = true;
            PasswordLogin.Name = "PasswordLogin";
            PasswordLogin.PlaceholderText = "Enter your password";
            PasswordLogin.Size = new Size(340, 50);
            PasswordLogin.TabIndex = 2;
            PasswordLogin.TextChanged += PasswordLogin_TextChanged;
            // 
            // btn_enter
            // 
            btn_enter.BackColor = Color.Gold;
            btn_enter.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn_enter.ForeColor = Color.Red;
            btn_enter.Location = new Point(153, 569);
            btn_enter.Name = "btn_enter";
            btn_enter.Size = new Size(215, 46);
            btn_enter.TabIndex = 3;
            btn_enter.Text = "ENTER";
            btn_enter.UseVisualStyleBackColor = false;
            btn_enter.Click += btn_enter_Click;
            // 
            // btn_registration
            // 
            btn_registration.BackColor = Color.Red;
            btn_registration.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn_registration.ForeColor = Color.Gold;
            btn_registration.Location = new Point(153, 621);
            btn_registration.Name = "btn_registration";
            btn_registration.Size = new Size(215, 46);
            btn_registration.TabIndex = 4;
            btn_registration.Text = "REGISTRATION";
            btn_registration.UseVisualStyleBackColor = false;
            btn_registration.Click += btn_registration_Click;
            // 
            // btn_forget_password
            // 
            btn_forget_password.BackColor = Color.Gold;
            btn_forget_password.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn_forget_password.ForeColor = Color.Red;
            btn_forget_password.Location = new Point(153, 673);
            btn_forget_password.Name = "btn_forget_password";
            btn_forget_password.Size = new Size(215, 46);
            btn_forget_password.TabIndex = 5;
            btn_forget_password.Text = "FORGET PASSWORD";
            btn_forget_password.UseVisualStyleBackColor = false;
            btn_forget_password.Click += btn_forget_password_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(554, 761);
            Controls.Add(btn_forget_password);
            Controls.Add(btn_registration);
            Controls.Add(btn_enter);
            Controls.Add(PasswordLogin);
            Controls.Add(LoginEmail);
            Controls.Add(pictureBox1);
            ForeColor = Color.Blue;
            KeyPreview = true;
            Name = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox LoginEmail;
        private TextBox PasswordLogin;
        private Button btn_enter;
        private Button btn_registration;
        private Button btn_forget_password;
    }
}