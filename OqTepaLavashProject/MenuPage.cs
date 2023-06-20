using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OqTepaLavashProject
{
    public partial class MenuPage : Form
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KefsiPage kefsi = new KefsiPage();
            Hide();
            kefsi.Show();

            kefsi.HideAllButtons();
            kefsi.HideAllLinkLabels();
        }

        private void MenuPage_Load(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            SetPage setPage = new SetPage();
            Hide();
            setPage.Show();
            setPage.HideAllButtons();
            setPage.HideAllLinkLabels();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            SousPage seousPage = new SousPage();
            Hide();
            seousPage.Show();
            seousPage.HideAllButtons();
            seousPage.HideAllLinkLabels();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Login loginPage = new Login();
            Hide();
            loginPage.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LavashPage lavashPage = new LavashPage();
            Hide();
            lavashPage.Show();
            lavashPage.HideAllButtons();
            lavashPage.HideAllLinkLabels();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            XaggiAndClub xaggiAndClub = new XaggiAndClub();
            Hide();
            xaggiAndClub.Show();
            xaggiAndClub.HideAllButtons();
            xaggiAndClub.HideAllLinkLabels();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hamburger hamburger = new Hamburger();
            Hide();
            hamburger.Show();
            hamburger.HideAllButtons();
            hamburger.HideAllLinkLabels();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PizzaPage pizzaPage = new PizzaPage();
            Hide();
            pizzaPage.Show();
            pizzaPage.HideAllButtons();
            pizzaPage.HideAllLinkLabels();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            XotDog xotDog = new XotDog();
            Hide();
            xotDog.Show();
            xotDog.HideAllButtons();
            xotDog.HideAllLinkLabels();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Snek snek = new Snek();
            Hide();
            snek.Show();
            snek.HideAllButtons();
            snek.HideAllLinkLabels();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Desert desert = new Desert();
            Hide();
            desert.Show();
            desert.HideAllButtons();
            desert.HideAllLinkLabels();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Drinks drinks = new Drinks();
            Hide();
            drinks.Show();
            drinks.HideAllButtons();
            drinks.HideAllLinkLabels();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SaladPage sportage = new SaladPage();
            Hide();
            sportage.Show();
            sportage.HideAllButtons();
            sportage.HideAllLinkLabels();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            TotalAmoutPage totalAmoutPage = new TotalAmoutPage();

            totalAmoutPage.GetInfo();

            Hide();
            totalAmoutPage.Show();
        }
    }
}
