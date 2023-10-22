namespace OqTepaLavashProject
{
    partial class FinallyPage
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
            label1 = new Label();
            label2 = new Label();
            button_woc1 = new ePOSOne.btnProduct.Button_WOC();
            button_woc2 = new ePOSOne.btnProduct.Button_WOC();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(24, 53);
            label1.Name = "label1";
            label1.Size = new Size(333, 28);
            label1.TabIndex = 0;
            label1.Text = "Your order has been accepted and";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(74, 101);
            label2.Name = "label2";
            label2.Size = new Size(233, 28);
            label2.TabIndex = 1;
            label2.Text = " we will deliver it soon ";
            // 
            // button_woc1
            // 
            button_woc1.BorderColor = Color.White;
            button_woc1.ButtonColor = Color.Red;
            button_woc1.FlatStyle = FlatStyle.Flat;
            button_woc1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button_woc1.ForeColor = Color.White;
            button_woc1.Location = new Point(24, 228);
            button_woc1.Name = "button_woc1";
            button_woc1.OnHoverBorderColor = Color.White;
            button_woc1.OnHoverButtonColor = Color.Yellow;
            button_woc1.OnHoverTextColor = Color.Black;
            button_woc1.Size = new Size(124, 46);
            button_woc1.TabIndex = 2;
            button_woc1.Text = "EXIT";
            button_woc1.TextColor = Color.White;
            button_woc1.UseVisualStyleBackColor = true;
            button_woc1.Click += button_woc1_Click;
            // 
            // button_woc2
            // 
            button_woc2.BackColor = Color.White;
            button_woc2.BorderColor = Color.White;
            button_woc2.ButtonColor = Color.Red;
            button_woc2.FlatStyle = FlatStyle.Flat;
            button_woc2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button_woc2.ForeColor = Color.White;
            button_woc2.Location = new Point(219, 228);
            button_woc2.Name = "button_woc2";
            button_woc2.OnHoverBorderColor = Color.White;
            button_woc2.OnHoverButtonColor = Color.Yellow;
            button_woc2.OnHoverTextColor = Color.Black;
            button_woc2.Size = new Size(138, 46);
            button_woc2.TabIndex = 3;
            button_woc2.Text = "GOTO MENU";
            button_woc2.TextColor = Color.White;
            button_woc2.UseVisualStyleBackColor = false;
            button_woc2.Click += button_woc2_Click;
            // 
            // FinallyPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(379, 295);
            Controls.Add(button_woc2);
            Controls.Add(button_woc1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FinallyPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FinallyPage";
            Load += FinallyPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MenuPage menu = new MenuPage();
            Hide();
            menu.Show();
        }

        private void button_woc2_Click(object sender, EventArgs e)
        {
            MenuPage menu = new MenuPage();
            Hide();
            menu.Show();
        }

        private void FinallyPage_Load(object sender, EventArgs e)
        {

        }

        private void button_woc1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ePOSOne.btnProduct.Button_WOC button_woc1;
        private ePOSOne.btnProduct.Button_WOC button_woc2;
    }
}