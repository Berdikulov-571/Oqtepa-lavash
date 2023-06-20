using System.Windows.Forms;
using System.Xml.Linq;

namespace RegistrationPage
{
    //partial class RegistrationPage
    //{
    //    /// <summary>
    //    ///  Required designer variable.
    //    /// </summary>
    //    private System.ComponentModel.IContainer components = null;

    //    /// <summary>
    //    ///  Clean up any resources being used.
    //    /// </summary>
    //    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    //    protected override void Dispose(bool disposing)
    //    {
    //        if (disposing && (components != null))
    //        {
    //            components.Dispose();
    //        }
    //        base.Dispose(disposing);
    //    }

    //    #region Windows Form Designer generated code

    //    /// <summary>
    //    ///  Required method for Designer support - do not modify
    //    ///  the contents of this method with the code editor.
    //    /// </summary>
    //    private void InitializeComponent()
    //    {
    //        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationPage));
    //        pictureBox1 = new PictureBox();
    //        nameRN = new TextBox();
    //        textBox1 = new TextBox();
    //        textBox2 = new TextBox();
    //        textBox3 = new TextBox();
    //        btn_enter = new Button();
    //        btn_login = new Button();
    //        btn_info = new Button();
    //        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
    //        SuspendLayout();
    //        // 
    //        // pictureBox1
    //        // 
    //        pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
    //        pictureBox1.Location = new Point(11, 8);
    //        pictureBox1.Name = "pictureBox1";
    //        pictureBox1.Size = new Size(623, 476);
    //        pictureBox1.TabIndex = 0;
    //        pictureBox1.TabStop = false;
    //        // 
    //        // nameRN
    //        // 
    //        nameRN.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
    //        nameRN.Location = new Point(112, 390);
    //        nameRN.Multiline = true;
    //        nameRN.Name = "nameRN";
    //        nameRN.PlaceholderText = "WRITE NAME";
    //        nameRN.Size = new Size(309, 51);
    //        nameRN.TabIndex = 1;
    //        nameRN.TextChanged += nameRN_TextChanged;
    //        // 
    //        // textBox1
    //        // 
    //        textBox1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
    //        textBox1.Location = new Point(112, 460);
    //        textBox1.Multiline = true;
    //        textBox1.Name = "textBox1";
    //        textBox1.PlaceholderText = "WRITE PHONE NUMBER";
    //        textBox1.Size = new Size(309, 51);
    //        textBox1.TabIndex = 2;
    //        textBox1.TextChanged += textBox1_TextChanged;
    //        // 
    //        // textBox2
    //        // 
    //        textBox2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
    //        textBox2.Location = new Point(112, 529);
    //        textBox2.Multiline = true;
    //        textBox2.Name = "textBox2";
    //        textBox2.PlaceholderText = "WRITE EMAIL";
    //        textBox2.Size = new Size(309, 50);
    //        textBox2.TabIndex = 3;
    //        textBox2.TextChanged += textBox2_TextChanged;
    //        // 
    //        // textBox3
    //        // 
    //        textBox3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
    //        textBox3.Location = new Point(112, 596);
    //        textBox3.Multiline = true;
    //        textBox3.Name = "textBox3";
    //        textBox3.PlaceholderText = "WRITE PASSWORD";
    //        textBox3.Size = new Size(309, 50);
    //        textBox3.TabIndex = 4;
    //        textBox3.TextChanged += textBox3_TextChanged;
    //        // 
    //        // btn_enter
    //        // 
    //        btn_enter.BackColor = Color.Gold;
    //        btn_enter.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
    //        btn_enter.ForeColor = Color.Red;
    //        btn_enter.Location = new Point(170, 661);
    //        btn_enter.Name = "btn_enter";
    //        btn_enter.Size = new Size(167, 46);
    //        btn_enter.TabIndex = 5;
    //        btn_enter.Text = "ENTER";
    //        btn_enter.UseVisualStyleBackColor = false;
    //        btn_enter.Click += btn_enter_Click;
    //        // 
    //        // btn_login
    //        // 
    //        btn_login.BackColor = Color.Red;
    //        btn_login.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
    //        btn_login.ForeColor = Color.Gold;
    //        btn_login.Location = new Point(31, 713);
    //        btn_login.Name = "btn_login";
    //        btn_login.RightToLeft = RightToLeft.No;
    //        btn_login.Size = new Size(167, 46);
    //        btn_login.TabIndex = 6;
    //        btn_login.Text = "LOGIN";
    //        btn_login.UseVisualStyleBackColor = false;
    //        // 
    //        // btn_info
    //        // 
    //        btn_info.BackColor = Color.Red;
    //        btn_info.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
    //        btn_info.ForeColor = Color.Gold;
    //        btn_info.Location = new Point(301, 713);
    //        btn_info.Name = "btn_info";
    //        btn_info.Size = new Size(167, 46);
    //        btn_info.TabIndex = 7;
    //        btn_info.Text = "INFO";
    //        btn_info.UseVisualStyleBackColor = false;
    //        // 
    //        // Form1
    //        // 
    //        AutoScaleDimensions = new SizeF(7F, 15F);
    //        AutoScaleMode = AutoScaleMode.Font;
    //        BackColor = Color.White;
    //        ClientSize = new Size(558, 786);
    //        Controls.Add(btn_info);
    //        Controls.Add(btn_login);
    //        Controls.Add(btn_enter);
    //        Controls.Add(textBox3);
    //        Controls.Add(textBox2);
    //        Controls.Add(textBox1);
    //        Controls.Add(nameRN);
    //        Controls.Add(pictureBox1);
    //        Name = "Form1";
    //        Text = "Form1";
    //        Load += Form1_Load;
    //        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
    //        ResumeLayout(false);
    //        PerformLayout();
    //    }

    //    #endregion

    //    private PictureBox pictureBox1;
    //    private TextBox nameRN;
    //    private TextBox textBox1;
    //    private TextBox textBox2;
    //    private TextBox textBox3;
    //    private Button btn_enter;
    //    private Button btn_login;
    //    private Button btn_info;
    //}
    partial class RegistrationPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
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
            //pictureBox1.Click += pictureBox1_Click;
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