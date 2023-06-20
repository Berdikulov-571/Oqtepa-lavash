namespace OqTepaLavashProject
{
    partial class RegistrationPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationPage));
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            btn_info = new Button();
            btn_enter = new Button();
            btn_login = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(561, 380);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(147, 621);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "WRITE PASSWORD";
            textBox1.Size = new Size(259, 45);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(147, 475);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "WRITE PHONE NUMBER";
            textBox2.Size = new Size(259, 45);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(147, 399);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "WRITE NAME";
            textBox3.Size = new Size(259, 45);
            textBox3.TabIndex = 3;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(147, 544);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "WRITE EMAIL";
            textBox4.Size = new Size(259, 45);
            textBox4.TabIndex = 4;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // btn_info
            // 
            btn_info.BackColor = Color.Red;
            btn_info.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn_info.ForeColor = Color.Gold;
            btn_info.ImageAlign = ContentAlignment.MiddleLeft;
            btn_info.Location = new Point(316, 743);
            btn_info.Name = "btn_info";
            btn_info.Size = new Size(168, 38);
            btn_info.TabIndex = 5;
            btn_info.Text = "INFO";
            btn_info.UseVisualStyleBackColor = false;
            btn_info.Click += button1_Click;
            // 
            // btn_enter
            // 
            btn_enter.BackColor = Color.Gold;
            btn_enter.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn_enter.ForeColor = Color.Red;
            btn_enter.Location = new Point(185, 689);
            btn_enter.Name = "btn_enter";
            btn_enter.Size = new Size(168, 38);
            btn_enter.TabIndex = 6;
            btn_enter.Text = "ENTER";
            btn_enter.UseVisualStyleBackColor = false;
            btn_enter.Click += btn_enter_Click;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.Red;
            btn_login.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn_login.ForeColor = Color.Gold;
            btn_login.ImageAlign = ContentAlignment.MiddleLeft;
            btn_login.Location = new Point(51, 743);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(168, 38);
            btn_login.TabIndex = 7;
            btn_login.Text = "LOGIN";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // RegistrationPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(556, 793);
            Controls.Add(btn_login);
            Controls.Add(btn_enter);
            Controls.Add(btn_info);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "RegistrationPage";
            Text = "RegistrationPage";
            Load += RegistrationPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button btn_info;
        private Button btn_enter;
        private Button btn_login;
    }
}