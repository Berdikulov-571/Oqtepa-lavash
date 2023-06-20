namespace Info
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
            btn_telegram = new Button();
            btn_instagram = new Button();
            btn_google = new Button();
            btn_facebook = new Button();
            button_back = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(75, -15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(513, 359);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btn_telegram
            // 
            btn_telegram.BackColor = Color.White;
            btn_telegram.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btn_telegram.Location = new Point(170, 350);
            btn_telegram.Name = "btn_telegram";
            btn_telegram.Size = new Size(318, 69);
            btn_telegram.TabIndex = 2;
            btn_telegram.Text = "TELEGRAM";
            btn_telegram.UseVisualStyleBackColor = false;
            // 
            // btn_instagram
            // 
            btn_instagram.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btn_instagram.Location = new Point(170, 437);
            btn_instagram.Name = "btn_instagram";
            btn_instagram.Size = new Size(318, 69);
            btn_instagram.TabIndex = 3;
            btn_instagram.Text = "INSTAGRAM";
            btn_instagram.UseVisualStyleBackColor = true;
            // 
            // btn_google
            // 
            btn_google.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btn_google.Location = new Point(170, 525);
            btn_google.Name = "btn_google";
            btn_google.Size = new Size(318, 69);
            btn_google.TabIndex = 4;
            btn_google.Text = "GOOGLE";
            btn_google.UseVisualStyleBackColor = true;
            btn_google.Click += button3_Click;
            // 
            // btn_facebook
            // 
            btn_facebook.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btn_facebook.Location = new Point(170, 610);
            btn_facebook.Name = "btn_facebook";
            btn_facebook.Size = new Size(318, 69);
            btn_facebook.TabIndex = 5;
            btn_facebook.Text = "FACEBOOK";
            btn_facebook.UseVisualStyleBackColor = true;
            // 
            // button_back
            // 
            button_back.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            button_back.Location = new Point(22, 711);
            button_back.Name = "button_back";
            button_back.Size = new Size(164, 62);
            button_back.TabIndex = 6;
            button_back.Text = "BACK";
            button_back.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(635, 785);
            Controls.Add(button_back);
            Controls.Add(btn_facebook);
            Controls.Add(btn_google);
            Controls.Add(btn_instagram);
            Controls.Add(btn_telegram);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btn_telegram;
        private Button btn_instagram;
        private Button btn_google;
        private Button btn_facebook;
        private Button button_back;
    }
}