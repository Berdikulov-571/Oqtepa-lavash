using DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OqTepaLavashProject
{
    public partial class SaladPage : Form
    {
        int count1 = 0;
        int count2 = 0;
        public SaladPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuPage menuPage = new MenuPage();
            Hide();
            menuPage.Show();
        }

        private void button_woc1_Click(object sender, EventArgs e)
        {
            count1++;
            if (count1 > 0)
            {
                button2.Show();
                button3.Show();
                button_woc1.Hide();
                linkLabel1.Show();
                linkLabel1.Text = count1.ToString();
            }
            if (count1 == 0)
            {
                count1 = 0;
                button2.Hide();
                button3.Hide();
                button_woc1.Show();
            }
        }

        private void button_woc2_Click(object sender, EventArgs e)
        {
            count2++;
            if (count2 > 0)
            {
                button4.Show();
                button5.Show();
                button_woc2.Hide();
                linkLabel2.Show();
                linkLabel2.Text = count2.ToString();
            }
            if (count2 == 0)
            {
                count2 = 0;
                button4.Hide();
                button5.Hide();
                button_woc2.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (count1 >= 2)
            {
                count1--;
                linkLabel1.Text = count1.ToString();
            }
            else if (count1 == 1)
            {
                count1--;
                linkLabel1.Hide();
                button_woc1.Show();
                button2.Hide();
                button3.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            count1++;
            linkLabel1.Text = count1.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (count2 >= 2)
            {
                count2--;
                linkLabel2.Text = count2.ToString();
            }
            else if (count2 == 1)
            {
                count2--;
                linkLabel2.Hide();
                button_woc2.Show();
                button4.Hide();
                button5.Hide();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            count2++;
            linkLabel2.Text = count2.ToString();
        }
        public void HideAllButtons()
        {
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
        }
        public void HideAllLinkLabels()
        {
            linkLabel1.Hide();
            linkLabel2.Hide();
        }

        private void button_woc3_Click(object sender, EventArgs e)
        {
            if (count1 > 0 || count2 > 0)
            {
                using (OqTepaContext contexts = new OqTepaContext())
                {
                    RegistrationPage registrationPage = new RegistrationPage();
                    Zakaz zakaz = new Zakaz();
                    if (count1 > 0)
                    {
                        zakaz.NameOfProduct = "Murskoy kapriz";
                        zakaz.NumOfProduct = count1.ToString();
                        zakaz.Price = 21000 * count1;
                        zakaz.PhoneNumber = registrationPage.UserPhoneNumber;
                        contexts.Add(zakaz);
                        contexts.SaveChanges();
                    }
                }
                using (OqTepaContext contexts = new OqTepaContext())
                {
                    RegistrationPage registrationPage = new RegistrationPage();
                    Zakaz zakaz = new Zakaz();
                    if (count2 > 0)
                    {
                        zakaz.NameOfProduct = "Sezar salat";
                        zakaz.NumOfProduct = count2.ToString();
                        zakaz.Price = 20000 * count2;
                        zakaz.PhoneNumber = registrationPage.UserPhoneNumber;
                        contexts.Add(zakaz);
                        contexts.SaveChanges();
                    }
                }
                MenuPage menuPage = new MenuPage();
                Hide();
                menuPage.Show();
            }
        }
    }
}
