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
    public partial class TotalAmoutPage : Form
    {
        public TotalAmoutPage()
        {
            InitializeComponent();
        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        public void label2_Click(object sender, EventArgs e)
        {

        }
        public void GetInfo()
        {
            using (OqTepaContext contexts = new OqTepaContext())
            {
                var zakaz = contexts.Zakazs.ToList();

                foreach (var user in zakaz)
                {
                    label1.Text += user.NameOfProduct + "\n";
                }
                foreach (var user in zakaz)
                {
                    label2.Text += user.NumOfProduct + "\n";
                }

                foreach (var user in zakaz)
                {
                    label3.Text += user.Price + "\n";
                }

                int? sum = 0;

                foreach (var i in zakaz)
                {
                    sum += i.Price;
                }

                label8.Text = sum.ToString();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button_woc1_Click(object sender, EventArgs e)
        {
            MenuPage menuPage = new MenuPage();
            Hide();
            menuPage.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button_woc2_Click(object sender, EventArgs e)
        {
            using (OqTepaContext contexts = new OqTepaContext())
            {
                Zakaz zakaz = new Zakaz();

                var rows = from o in contexts.Zakazs
                           select o;
                foreach (var row in rows)
                {
                    contexts.Zakazs.Remove(row);
                }
                contexts.SaveChanges();

                MenuPage menu = new MenuPage();
                Hide();
                menu.Show();
            }
        }

        private void TotalAmoutPage_Load(object sender, EventArgs e)
        {

        }

        private void button_woc3_Click(object sender, EventArgs e)
        {
            DeliveryPage deliveryPage = new DeliveryPage();
            Hide();
            deliveryPage.Show();
        }
    }
}
