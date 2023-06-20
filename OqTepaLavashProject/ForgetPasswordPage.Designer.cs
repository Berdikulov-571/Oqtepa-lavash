namespace OqTepaLavashProject
{
    partial class ForgetPasswordPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetPasswordPage));
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            btn_find = new Button();
            btn_back = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(40, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(503, 391);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(114, 366);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "ENTER YOUR EMAIL";
            textBox1.Size = new Size(344, 56);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btn_find
            // 
            btn_find.BackColor = Color.Gold;
            btn_find.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn_find.ForeColor = Color.Red;
            btn_find.Location = new Point(199, 441);
            btn_find.Name = "btn_find";
            btn_find.Size = new Size(165, 42);
            btn_find.TabIndex = 2;
            btn_find.Text = "FIND";
            btn_find.UseVisualStyleBackColor = false;
            btn_find.Click += btn_find_Click;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.Red;
            btn_back.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn_back.ForeColor = Color.Gold;
            btn_back.Location = new Point(25, 709);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(165, 42);
            btn_back.TabIndex = 3;
            btn_back.Text = "BACK";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // ForgetPasswordPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(555, 785);
            Controls.Add(btn_back);
            Controls.Add(btn_find);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Name = "ForgetPasswordPage";
            Text = "ForgetPasswordPage";
            Load += ForgetPasswordPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Button btn_find;
        private Button btn_back;
    }
}