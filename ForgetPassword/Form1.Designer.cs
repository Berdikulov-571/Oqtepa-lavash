namespace ForgetPassword
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
            email = new TextBox();
            btn_find = new Button();
            btn_back = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(36, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(447, 325);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // email
            // 
            email.BackColor = Color.White;
            email.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            email.Location = new Point(107, 383);
            email.Multiline = true;
            email.Name = "email";
            email.PlaceholderText = "ENTER YOUR EMAIL";
            email.Size = new Size(345, 49);
            email.TabIndex = 2;
            email.TextChanged += textBox1_TextChanged;
            // 
            // btn_find
            // 
            btn_find.BackColor = Color.Gold;
            btn_find.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
            btn_find.ForeColor = Color.Red;
            btn_find.Location = new Point(167, 463);
            btn_find.Name = "btn_find";
            btn_find.Size = new Size(184, 49);
            btn_find.TabIndex = 3;
            btn_find.Text = "FIND";
            btn_find.UseVisualStyleBackColor = false;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.Red;
            btn_back.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn_back.ForeColor = Color.Gold;
            btn_back.Location = new Point(22, 717);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(184, 49);
            btn_back.TabIndex = 4;
            btn_back.Text = "BACK";
            btn_back.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(558, 790);
            Controls.Add(btn_back);
            Controls.Add(btn_find);
            Controls.Add(email);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox email;
        private Button btn_find;
        private Button btn_back;
    }
}