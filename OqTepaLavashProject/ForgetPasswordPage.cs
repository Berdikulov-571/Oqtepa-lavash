using DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OqTepaLavashProject
{
    public partial class ForgetPasswordPage : Form
    {
        public ForgetPasswordPage()
        {
            InitializeComponent();
        }

        private void ForgetPasswordPage_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Login loginPage = new Login();
            Hide();
            loginPage.Show();
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            using (OqTepaContext checkUser = new OqTepaContext())
            {
                var users = checkUser.Registrations.ToList();

                int c = 0;

                foreach (var i in users)
                {
                    if (i.Email == textBox1.Text)
                    {
                        textBox1.ForeColor = Color.Green;
                        textBox1.Text = $"PWD: {i.Password}";
                        c++;
                    }
                }
                if (c == 0)
                {
                    textBox1.ForeColor = Color.Red;
                    textBox1.Text = "Email Not Found";
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
