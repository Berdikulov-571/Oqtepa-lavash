using DataBase;

namespace OqTepaLavashProject
{
    public partial class RegistrationPage : Form
    {
        public string? UserPhoneNumber = "???";
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void RegistrationPage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InfoPage infoPage = new InfoPage();
            Hide();
            infoPage.Show();
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            int count = 0;
            using (OqTepaContext contexts = new OqTepaContext())
            {
                Registration registration = new Registration();

                Zakaz zakaz = new Zakaz();

                var rows = from o in contexts.Zakazs
                           select o;

                foreach (var row in rows)
                {
                    contexts.Zakazs.Remove(row);
                }
                contexts.SaveChanges();

                if (textBox3.Text.Length >= 6)
                {
                    count++;
                    registration.Name = textBox3.Text;
                }
                else
                {
                    textBox3.ForeColor = Color.Red;
                    textBox3.PlaceholderText = "Error Name";
                    textBox3.Text = "";
                }

                if (textBox2.Text.Length >= 6)
                {
                    count++;
                    registration.Number = textBox2.Text;
                    UserPhoneNumber = registration.Number.ToString();
                }
                else
                {
                    textBox2.ForeColor = Color.Red;
                    textBox2.PlaceholderText = "Error phone number";
                    textBox2.Text = "";
                }

                if (textBox4.Text.Length >= 7)
                {
                    count++;
                    registration.Email = textBox4.Text;
                }
                else
                {
                    textBox4.ForeColor = Color.Red;
                    textBox4.PlaceholderText = "Error email";
                    textBox4.Text = "";
                }

                if (textBox1.Text.Length >= 7)
                {
                    count++;
                    registration.Password = textBox1.Text;
                }
                else
                {
                    textBox1.ForeColor = Color.Red;
                    textBox1.PlaceholderText = "Error password";
                    textBox4.Text = "";
                }


                //if (textBox1.Text.Length != 6)
                //{
                //    textBox1.ForeColor = Color.Red;
                //    textBox1.Text = "Password must be 6 character";
                //    count++;
                //}

                ////textBox2.Text = "+998";
                //if (textBox2.Text.Length != 0)
                //{
                //    textBox2.ForeColor = Color.Red;
                //    textBox2.Text = "Error phoneNumber";
                //    textBox2.ForeColor = Color.Black;
                //    count++;

                //}

                //if (textBox3.Text.Length != 6)
                //{
                //    textBox3.ForeColor = Color.Red;
                //    textBox3.Text = "Name must be 6 character";
                //    textBox3.ForeColor = Color.Black;
                //    count++;

                //}

                //if (textBox4.Text.Any(x => x != '@'))
                //{
                //    textBox4.ForeColor = Color.Red;
                //    textBox4.Text = "Error email";
                //    textBox4.ForeColor = Color.Black;
                //    count++;

                //}


                if (count == 4)
                {
                    contexts.Add(registration);
                    contexts.SaveChanges();
                    MenuPage menuPage = new MenuPage();
                    Hide();
                    menuPage.Show();
                }

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //if(textBox3.Text.Length < 6)
            //{
            //    textBox3.ForeColor = Color.Red;
            //    textBox3.Text = "Name must be 6 character";
            //    textBox3.ForeColor = Color.Black;
            //}
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //textBox2.Text = "+998";
            //if(textBox2.Text.Length != 9)
            //{
            //    textBox2.ForeColor = Color.Red;
            //    textBox2.Text = "Error phoneNumber";
            //    textBox2.ForeColor = Color.Black;
            //}
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //if (textBox4.Text.Any(x => x != 'a'))
            //{
            //    textBox4.ForeColor = Color.Red;
            //    textBox4.Text = "Error email";
            //    textBox4.ForeColor = Color.Black;
            //}
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //if (textBox1.Text.Length < 6) 
            //{
            //    textBox1.ForeColor = Color.Red;
            //    textBox1.Text = "Password must be 6 character";
            //}
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Login loginPage = new Login();
            this.Hide();
            loginPage.Show();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}




//using System;
//using System.Drawing;
//using System.Windows.Forms;

//namespace OqTepaLavashProject
//{
//    public class Button_WOC : Button
//    {
//        private Color _borderColor = Color.Silver;
//        private Color _onHoverBorderColor = Color.Gray;
//        private Color _buttonColor = Color.Red;
//        private Color _onHoverButtonColor = Color.Yellow;
//        private Color _textColor = Color.White;
//        private Color _onHoverTextColor = Color.Gray;

//        private bool _isHovering;
//        private int _borderThickness = 6;
//        private Button button1;
//        private int _borderThicknessByTwo = 3;


//        public Button_WOC()
//        {
//            DoubleBuffered = true;
//            MouseEnter += (sender, e) =>
//            {
//                _isHovering = true;
//                Invalidate();
//            };
//            MouseLeave += (sender, e) =>
//            {
//                _isHovering = false;
//                Invalidate();
//            };
//        }


//        protected override void OnPaint(PaintEventArgs e)
//        {
//            base.OnPaint(e);
//            Graphics g = e.Graphics;
//            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
//            Brush brush = new SolidBrush(_isHovering ? _onHoverBorderColor : _borderColor);

//            //Border
//            g.FillEllipse(brush, 0, 0, Height, Height);
//            g.FillEllipse(brush, Width - Height, 0, Height, Height);
//            g.FillRectangle(brush, Height / 2, 0, Width - Height, Height);

//            brush.Dispose();
//            brush = new SolidBrush(_isHovering ? _onHoverButtonColor : _buttonColor);

//            //Inner part. Button itself
//            g.FillEllipse(brush, _borderThicknessByTwo, _borderThicknessByTwo, Height - _borderThickness,
//                Height - _borderThickness);
//            g.FillEllipse(brush, (Width - Height) + _borderThicknessByTwo, _borderThicknessByTwo,
//                Height - _borderThickness, Height - _borderThickness);
//            g.FillRectangle(brush, Height / 2 + _borderThicknessByTwo, _borderThicknessByTwo,
//                Width - Height - _borderThickness, Height - _borderThickness);

//            brush.Dispose();
//            brush = new SolidBrush(_isHovering ? _onHoverTextColor : _textColor);

//            //Button Text
//            SizeF stringSize = g.MeasureString(Text, Font);
//            g.DrawString(Text, Font, brush, (Width - stringSize.Width) / 2, (Height - stringSize.Height) / 2);
//        }


//        public Color BorderColor
//        {
//            get => _borderColor;
//            set
//            {
//                _borderColor = value;
//                Invalidate();
//            }
//        }

//        public Color OnHoverBorderColor
//        {
//            get => _onHoverBorderColor;
//            set
//            {
//                _onHoverBorderColor = value;
//                Invalidate();
//            }
//        }

//        public Color ButtonColor
//        {
//            get => _buttonColor;
//            set
//            {
//                _buttonColor = value;
//                Invalidate();
//            }
//        }

//        public Color OnHoverButtonColor
//        {
//            get => _onHoverButtonColor;
//            set
//            {
//                _onHoverButtonColor = value;
//                Invalidate();
//            }
//        }

//        public Color TextColor
//        {
//            get => _textColor;
//            set
//            {
//                _textColor = value;
//                Invalidate();
//            }
//        }

//        public Color OnHoverTextColor
//        {
//            get => _onHoverTextColor;
//            set
//            {
//                _onHoverTextColor = value;
//                Invalidate();
//            }
//        }

//        private void InitializeComponent()
//        {
//            this.button1 = new System.Windows.Forms.Button();
//            this.SuspendLayout();
//            // 
//            // button1
//            // 
//            this.button1.Location = new System.Drawing.Point(0, 0);
//            this.button1.Name = "button1";
//            this.button1.Size = new System.Drawing.Size(75, 23);
//            this.button1.TabIndex = 0;
//            this.button1.Text = "button1";
//            this.button1.UseVisualStyleBackColor = true;
//            this.ResumeLayout(false);

//        }
//    }
//}