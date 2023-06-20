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
    public partial class XotDog : Form
    {
        int count1 = 0;
        int count2 = 0;
        int count3 = 0;
        int count4 = 0;
        public XotDog()
        {
            InitializeComponent();
        }

        private void XotDog_Load(object sender, EventArgs e)
        {

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

        private void button_woc3_Click(object sender, EventArgs e)
        {
            count3++;
            if (count3 > 0)
            {
                button6.Show();
                button7.Show();
                button_woc3.Hide();
                linkLabel3.Show();
                linkLabel3.Text = count3.ToString();
            }
            if (count3 == 0)
            {
                count3 = 0;
                button6.Hide();
                button7.Hide();
                button_woc3.Show();
            }
        }

        private void button_woc4_Click(object sender, EventArgs e)
        {
            count4++;
            if (count4 > 0)
            {
                button8.Show();
                button9.Show();
                button_woc4.Hide();
                linkLabel4.Show();
                linkLabel4.Text = count4.ToString();
            }
            if (count4 == 0)
            {
                count4 = 0;
                button8.Hide();
                button9.Hide();
                button_woc4.Show();
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

        private void button6_Click(object sender, EventArgs e)
        {
            if (count3 >= 2)
            {
                count3--;
                linkLabel3.Text = count3.ToString();
            }
            else if (count3 == 1)
            {
                count3--;
                linkLabel3.Hide();
                button_woc3.Show();
                button6.Hide();
                button7.Hide();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            count3++;
            linkLabel3.Text = count3.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (count4 >= 2)
            {
                count4--;
                linkLabel4.Text = count4.ToString();
            }
            else if (count4 == 1)
            {
                count4--;
                linkLabel4.Hide();
                button_woc4.Show();
                button9.Hide();
                button8.Hide();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            count4++;
            linkLabel4.Text = count4.ToString();
        }
        public void HideAllButtons()
        {
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Hide();
            button7.Hide();
            button8.Hide();
            button9.Hide();
        }
        public void HideAllLinkLabels()
        {
            linkLabel1.Hide();
            linkLabel2.Hide();
            linkLabel3.Hide();
            linkLabel4.Hide();
        }

        private void button_woc5_Click(object sender, EventArgs e)
        {
            if (count1 > 0 || count1 > 0 || count3 > 0 || count4 > 0)
            {
                using (OqTepaContext contexts = new OqTepaContext())
                {
                    RegistrationPage registrationPage = new RegistrationPage();
                    Zakaz zakaz = new Zakaz();
                    if (count1 > 0)
                    {
                        zakaz.NameOfProduct = "korovensie xot-dog";
                        zakaz.NumOfProduct = count1.ToString();
                        zakaz.Price = 20000 * count1;
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
                        zakaz.NameOfProduct = "Xalapeno xot-dog";
                        zakaz.NumOfProduct = count2.ToString();
                        zakaz.Price = 15000 * count2;
                        zakaz.PhoneNumber = registrationPage.UserPhoneNumber;
                        contexts.Add(zakaz);
                        contexts.SaveChanges();
                    }
                }
                using (OqTepaContext contexts = new OqTepaContext())
                {
                    RegistrationPage registrationPage = new RegistrationPage();
                    Zakaz zakaz = new Zakaz();
                    if (count3 > 0)
                    {
                        zakaz.NameOfProduct = "Sirli xot-dog";
                        zakaz.NumOfProduct = count3.ToString();
                        zakaz.Price = 13000 * count3;
                        zakaz.PhoneNumber = registrationPage.UserPhoneNumber;
                        contexts.Add(zakaz);
                        contexts.SaveChanges();
                    }
                }
                using (OqTepaContext contexts = new OqTepaContext())
                {
                    RegistrationPage registrationPage = new RegistrationPage();
                    Zakaz zakaz = new Zakaz();
                    if (count4 > 0)
                    {
                        zakaz.NameOfProduct = "Xot-dog";
                        zakaz.NumOfProduct = count4.ToString();
                        zakaz.Price = 10000 * count4;
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
