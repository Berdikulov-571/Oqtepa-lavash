namespace OqTepaLavashProject
{
    partial class InfoPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoPage));
            btn_telegram = new Button();
            btn_instagram = new Button();
            btn_google = new Button();
            btn_facebook = new Button();
            button5 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_telegram
            // 
            btn_telegram.BackColor = Color.Gold;
            btn_telegram.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btn_telegram.ForeColor = Color.Red;
            btn_telegram.Location = new Point(159, 377);
            btn_telegram.Name = "btn_telegram";
            btn_telegram.Size = new Size(272, 62);
            btn_telegram.TabIndex = 0;
            btn_telegram.Text = "TELEGRAM";
            btn_telegram.UseVisualStyleBackColor = false;
            btn_telegram.Click += btn_telegram_Click;
            // 
            // btn_instagram
            // 
            btn_instagram.BackColor = Color.Red;
            btn_instagram.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btn_instagram.ForeColor = Color.Gold;
            btn_instagram.Location = new Point(159, 455);
            btn_instagram.Name = "btn_instagram";
            btn_instagram.Size = new Size(272, 62);
            btn_instagram.TabIndex = 1;
            btn_instagram.Text = "INSTAGRAM";
            btn_instagram.UseVisualStyleBackColor = false;
            btn_instagram.Click += btn_instagram_Click;
            // 
            // btn_google
            // 
            btn_google.BackColor = Color.Gold;
            btn_google.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btn_google.ForeColor = Color.Red;
            btn_google.Location = new Point(159, 536);
            btn_google.Name = "btn_google";
            btn_google.Size = new Size(272, 62);
            btn_google.TabIndex = 2;
            btn_google.Text = "GOOGLE";
            btn_google.UseVisualStyleBackColor = false;
            btn_google.Click += btn_google_Click;
            // 
            // btn_facebook
            // 
            btn_facebook.BackColor = Color.Red;
            btn_facebook.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btn_facebook.ForeColor = Color.Gold;
            btn_facebook.Location = new Point(159, 621);
            btn_facebook.Name = "btn_facebook";
            btn_facebook.Size = new Size(272, 62);
            btn_facebook.TabIndex = 3;
            btn_facebook.Text = "FACEBOOK";
            btn_facebook.UseVisualStyleBackColor = false;
            btn_facebook.Click += btn_facebook_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Gold;
            button5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.Red;
            button5.Location = new Point(22, 720);
            button5.Name = "button5";
            button5.Size = new Size(135, 54);
            button5.TabIndex = 4;
            button5.Text = "BACK";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(39, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(632, 361);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // InfoPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(639, 799);
            Controls.Add(pictureBox1);
            Controls.Add(button5);
            Controls.Add(btn_facebook);
            Controls.Add(btn_google);
            Controls.Add(btn_instagram);
            Controls.Add(btn_telegram);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "InfoPage";
            Text = "InfoPage";
            Load += InfoPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_telegram;
        private Button btn_instagram;
        private Button btn_google;
        private Button btn_facebook;
        private Button button5;
        private PictureBox pictureBox1;
    }
}