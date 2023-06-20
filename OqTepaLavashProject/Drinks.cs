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
    public partial class Drinks : Form
    {
        int count1 = 0;
        int count2 = 0;
        int count3 = 0;
        int count4 = 0;
        int count5 = 0;
        int count6 = 0;
        int count7 = 0;
        int count8 = 0;
        public Drinks()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
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
        private void button_woc5_Click(object sender, EventArgs e)
        {
            count5++;
            if (count5 > 0)
            {
                button10.Show();
                button11.Show();
                button_woc5.Hide();
                linkLabel5.Show();
                linkLabel5.Text = count5.ToString();
            }
            if (count5 == 0)
            {
                count5 = 0;
                button10.Hide();
                button11.Hide();
                button_woc5.Show();
            }
        }
        private void button_woc6_Click(object sender, EventArgs e)
        {
            count6++;
            if (count6 > 0)
            {
                button12.Show();
                button13.Show();
                button_woc6.Hide();
                linkLabel6.Show();
                linkLabel6.Text = count6.ToString();
            }
            if (count6 == 0)
            {
                count6 = 0;
                button12.Hide();
                button13.Hide();
                button_woc6.Show();
            }
        }

        private void button_woc7_Click(object sender, EventArgs e)
        {
            count7++;
            if (count7 > 0)
            {
                button14.Show();
                button15.Show();
                button_woc7.Hide();
                linkLabel7.Show();
                linkLabel7.Text = count7.ToString();
            }
            if (count7 == 0)
            {
                count7 = 0;
                button14.Hide();
                button15.Hide();
                button_woc7.Show();
            }
        }

        private void button_woc8_Click(object sender, EventArgs e)
        {
            count8++;
            if (count8 > 0)
            {
                button16.Show();
                button17.Show();
                button_woc8.Hide();
                linkLabel8.Show();
                linkLabel8.Text = count8.ToString();
            }
            if (count8 == 0)
            {
                count8 = 0;
                button16.Hide();
                button17.Hide();
                button_woc8.Show();
            }
        }



        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

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

        private void button10_Click(object sender, EventArgs e)
        {
            if (count5 >= 2)
            {
                count5--;
                linkLabel5.Text = count5.ToString();
            }
            else if (count5 == 1)
            {
                count5--;
                linkLabel5.Hide();
                button_woc5.Show();
                button11.Hide();
                button10.Hide();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            count5++;
            linkLabel5.Text = count5.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (count6 >= 2)
            {
                count6--;
                linkLabel6.Text = count6.ToString();
            }
            else if (count6 == 1)
            {
                count6--;
                linkLabel6.Hide();
                button_woc6.Show();
                button13.Hide();
                button12.Hide();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            count6++;
            linkLabel6.Text = count6.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (count7 >= 2)
            {
                count7--;
                linkLabel7.Text = count7.ToString();
            }
            else if (count7 == 1)
            {
                count7--;
                linkLabel7.Hide();
                button_woc7.Show();
                button14.Hide();
                button15.Hide();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            count7++;
            linkLabel7.Text = count7.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (count8 >= 2)
            {
                count8--;
                linkLabel8.Text = count8.ToString();
            }
            else if (count8 == 1)
            {
                count8--;
                linkLabel8.Hide();
                button_woc8.Show();
                button16.Hide();
                button17.Hide();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            count8++;
            linkLabel8.Text = count8.ToString();
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
            button10.Hide();
            button11.Hide();
            button12.Hide();
            button13.Hide();
            button14.Hide();
            button15.Hide();
            button16.Hide();
            button17.Hide();
        }
        public void HideAllLinkLabels()
        {
            linkLabel1.Hide();
            linkLabel2.Hide();
            linkLabel3.Hide();
            linkLabel4.Hide();
            linkLabel5.Hide();
            linkLabel6.Hide();
            linkLabel7.Hide();
            linkLabel8.Hide();
        }

        private void button_woc6_Click_1(object sender, EventArgs e)
        {
            count6++;
            if (count6 > 0)
            {
                button12.Show();
                button13.Show();
                button_woc6.Hide();
                linkLabel6.Show();
                linkLabel6.Text = count6.ToString();
            }
            if (count6 == 0)
            {
                count6 = 0;
                button12.Hide();
                button13.Hide();
                button_woc6.Show();
            }
        }

        private void button_woc7_Click_1(object sender, EventArgs e)
        {
            count7++;
            if (count7 > 0)
            {
                button14.Show();
                button15.Show();
                button_woc7.Hide();
                linkLabel7.Show();
                linkLabel7.Text = count7.ToString();
            }
            if (count7 == 0)
            {
                count7 = 0;
                button14.Hide();
                button15.Hide();
                button_woc7.Show();
            }
        }

        private void button_woc8_Click_1(object sender, EventArgs e)
        {
            count8++;
            if (count8 > 0)
            {
                button16.Show();
                button17.Show();
                button_woc8.Hide();
                linkLabel8.Show();
                linkLabel8.Text = count8.ToString();
            }
            if (count8 == 0)
            {
                count8 = 0;
                button16.Hide();
                button17.Hide();
                button_woc8.Show();
            }
        }

        private void button_woc9_Click(object sender, EventArgs e)
        {
            if (count1 > 0 || count2 > 0 || count3 > 0 || count4 > 0 || count5 > 0 || count6 > 0 || count7 > 0 || count8 > 0)
            {
                using (OqTepaContext contexts = new OqTepaContext())
                {
                    RegistrationPage registrationPage = new RegistrationPage();
                    Zakaz zakaz = new Zakaz();
                    if (count1 > 0)
                    {
                        zakaz.NameOfProduct = "Dolina 1.5L";
                        zakaz.NumOfProduct = count1.ToString();
                        zakaz.Price = 15000 * count1;
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
                        zakaz.NameOfProduct = "Pepsi";
                        zakaz.NumOfProduct = count2.ToString();
                        zakaz.Price = 7000 * count2;
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
                        zakaz.NameOfProduct = "Mirinda";
                        zakaz.NumOfProduct = count3.ToString();
                        zakaz.Price = 7000 * count3;
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
                        zakaz.NameOfProduct = "Cofe";
                        zakaz.NumOfProduct = count4.ToString();
                        zakaz.Price = 7000 * count4;
                        zakaz.PhoneNumber = registrationPage.UserPhoneNumber;
                        contexts.Add(zakaz);
                        contexts.SaveChanges();
                    }
                }
                using (OqTepaContext contexts = new OqTepaContext())
                {
                    RegistrationPage registrationPage = new RegistrationPage();
                    Zakaz zakaz = new Zakaz();
                    if (count5 > 0)
                    {
                        zakaz.NameOfProduct = "Rozliv";
                        zakaz.NumOfProduct = count5.ToString();
                        zakaz.Price = 5000 * count5;
                        zakaz.PhoneNumber = registrationPage.UserPhoneNumber;
                        contexts.Add(zakaz);
                        contexts.SaveChanges();
                    }
                }
                using (OqTepaContext contexts = new OqTepaContext())
                {
                    RegistrationPage registrationPage = new RegistrationPage();
                    Zakaz zakaz = new Zakaz();
                    if (count6 > 0)
                    {
                        zakaz.NameOfProduct = "Lemon choy";
                        zakaz.NumOfProduct = count6.ToString();
                        zakaz.Price = 5000 * count6;
                        zakaz.PhoneNumber = registrationPage.UserPhoneNumber;
                        contexts.Add(zakaz);
                        contexts.SaveChanges();
                    }
                }
                using (OqTepaContext contexts = new OqTepaContext())
                {
                    RegistrationPage registrationPage = new RegistrationPage();
                    Zakaz zakaz = new Zakaz();
                    if (count7 > 0)
                    {
                        zakaz.NameOfProduct = "Dolina 0.2L";
                        zakaz.NumOfProduct = count7.ToString();
                        zakaz.Price = 4000 * count7;
                        zakaz.PhoneNumber = registrationPage.UserPhoneNumber;
                        contexts.Add(zakaz);
                        contexts.SaveChanges();
                    }
                }
                using (OqTepaContext contexts = new OqTepaContext())
                {
                    RegistrationPage registrationPage = new RegistrationPage();
                    Zakaz zakaz = new Zakaz();
                    if (count8 > 0)
                    {
                        zakaz.NameOfProduct = "Choy";
                        zakaz.NumOfProduct = count8.ToString();
                        zakaz.Price = 3000 * count8;
                        zakaz.PhoneNumber = registrationPage.UserPhoneNumber;
                        contexts.Add(zakaz);
                        contexts.SaveChanges();
                    }
                }
                MenuPage page = new MenuPage();
                Hide();
                page.Show();
            }
        }

        private void Drinks_Load(object sender, EventArgs e)
        {

        }
    }
}
