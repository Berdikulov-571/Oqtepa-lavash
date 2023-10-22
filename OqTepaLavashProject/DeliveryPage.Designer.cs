namespace OqTepaLavashProject
{
    partial class DeliveryPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliveryPage));
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button_woc1 = new ePOSOne.btnProduct.Button_WOC();
            button_woc2 = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(420, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(461, 367);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(420, 439);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(425, 69);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(420, 553);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(425, 69);
            textBox2.TabIndex = 6;
            textBox2.Text = "+998";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.SandyBrown;
            label1.Location = new Point(237, 450);
            label1.Name = "label1";
            label1.Size = new Size(172, 46);
            label1.TabIndex = 7;
            label1.Text = "ADDRESS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.SlateBlue;
            label2.Location = new Point(147, 566);
            label2.Name = "label2";
            label2.Size = new Size(262, 46);
            label2.TabIndex = 8;
            label2.Text = "Phone Number";
            // 
            // button_woc1
            // 
            button_woc1.BorderColor = Color.White;
            button_woc1.ButtonColor = Color.Green;
            button_woc1.FlatStyle = FlatStyle.Flat;
            button_woc1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button_woc1.ForeColor = Color.White;
            button_woc1.Location = new Point(507, 657);
            button_woc1.Name = "button_woc1";
            button_woc1.OnHoverBorderColor = Color.Gray;
            button_woc1.OnHoverButtonColor = Color.Yellow;
            button_woc1.OnHoverTextColor = Color.Gray;
            button_woc1.Size = new Size(238, 67);
            button_woc1.TabIndex = 9;
            button_woc1.Text = "CONFIRM";
            button_woc1.TextColor = Color.White;
            button_woc1.UseVisualStyleBackColor = true;
            button_woc1.Click += button_woc1_Click;
            // 
            // button_woc2
            // 
            button_woc2.BorderColor = Color.White;
            button_woc2.ButtonColor = Color.Red;
            button_woc2.FlatStyle = FlatStyle.Flat;
            button_woc2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button_woc2.ForeColor = Color.White;
            button_woc2.Location = new Point(12, 698);
            button_woc2.Name = "button_woc2";
            button_woc2.OnHoverBorderColor = Color.Gray;
            button_woc2.OnHoverButtonColor = Color.Yellow;
            button_woc2.OnHoverTextColor = Color.Gray;
            button_woc2.Size = new Size(124, 47);
            button_woc2.TabIndex = 10;
            button_woc2.Text = "BACK";
            button_woc2.TextColor = Color.White;
            button_woc2.UseVisualStyleBackColor = true;
            button_woc2.Click += button_woc2_Click;
            // 
            // DeliveryPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 768);
            Controls.Add(button_woc2);
            Controls.Add(button_woc1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Name = "DeliveryPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DeliveryPage";
            Load += DeliveryPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private ePOSOne.btnProduct.Button_WOC button_woc1;
        private ePOSOne.btnProduct.Button_WOC button_woc2;
    }
}