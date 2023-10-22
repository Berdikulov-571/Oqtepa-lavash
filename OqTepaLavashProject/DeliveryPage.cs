using DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OqTepaLavashProject
{
    public partial class DeliveryPage : Form
    {
        public DeliveryPage()
        {
            InitializeComponent();
        }

        private void DeliveryPage_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button_woc2_Click(object sender, EventArgs e)
        {
            TotalAmoutPage totalAmoutPage = new TotalAmoutPage();

            totalAmoutPage.GetInfo();

            Hide();

            totalAmoutPage.Show();
        }

        private void button_woc1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >= 10 && textBox2.Text.Length == 13)
            {
                using (OqTepaContext contexts = new OqTepaContext())
                {
                    Deliver deliver = new Deliver();

                    deliver.PhoneNumber = textBox2.Text;
                    deliver.Name = textBox1.Text;

                    contexts.Add(deliver);
                    contexts.SaveChanges();
                }

                FinallyPage finallyPage = new FinallyPage();
                Hide();
                finallyPage.Show();
            }
            if (textBox1.Text.Length < 10)
            {
                textBox1.ForeColor = Color.Red;
                textBox1.Text = "Error Address";
            }
            if (textBox2.Text.Length < 13)
            {
                textBox2.ForeColor = Color.Red;
                textBox2.Text = "Error phoneNumber";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
