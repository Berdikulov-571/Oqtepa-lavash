namespace OqTepaLavashProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btn_forget_password = new Button();
            btn_registration = new Button();
            btn_enter = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(39, -18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(522, 388);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(127, 413);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "ENTER YOUR EMAIL";
            textBox1.Size = new Size(308, 45);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(127, 497);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.PlaceholderText = "ENTER YOUR PASSWORD";
            textBox2.Size = new Size(308, 45);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // btn_forget_password
            // 
            btn_forget_password.BackColor = Color.Gold;
            btn_forget_password.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn_forget_password.ForeColor = Color.Red;
            btn_forget_password.Location = new Point(166, 695);
            btn_forget_password.Name = "btn_forget_password";
            btn_forget_password.Size = new Size(223, 42);
            btn_forget_password.TabIndex = 3;
            btn_forget_password.Text = "FORGET PASSWORD";
            btn_forget_password.UseVisualStyleBackColor = false;
            btn_forget_password.Click += button1_Click;
            // 
            // btn_registration
            // 
            btn_registration.BackColor = Color.Red;
            btn_registration.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn_registration.ForeColor = Color.Gold;
            btn_registration.Location = new Point(166, 633);
            btn_registration.Name = "btn_registration";
            btn_registration.Size = new Size(223, 42);
            btn_registration.TabIndex = 4;
            btn_registration.Text = "REGISTRATION";
            btn_registration.UseVisualStyleBackColor = false;
            btn_registration.Click += button2_Click;
            // 
            // btn_enter
            // 
            btn_enter.BackColor = Color.Gold;
            btn_enter.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn_enter.ForeColor = Color.Red;
            btn_enter.Location = new Point(166, 566);
            btn_enter.Name = "btn_enter";
            btn_enter.Size = new Size(223, 42);
            btn_enter.TabIndex = 5;
            btn_enter.Text = "ENTER";
            btn_enter.UseVisualStyleBackColor = false;
            btn_enter.Click += btn_enter_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(554, 791);
            Controls.Add(btn_enter);
            Controls.Add(btn_registration);
            Controls.Add(btn_forget_password);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Login";
            Text = "Login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btn_forget_password;
        private Button btn_registration;
        private Button btn_enter;
    }
}