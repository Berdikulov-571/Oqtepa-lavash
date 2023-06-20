using System.Diagnostics;

namespace OqTepaLavashProject
{
    public partial class InfoPage : Form
    {
        public InfoPage()
        {
            InitializeComponent();
        }

        private void btn_google_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome", "https://oqtepalavash.uz/");
        }

        private void btn_instagram_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome", "https://www.instagram.com/oqtepalavash.official/");
        }

        private void btn_facebook_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome", "https://www.facebook.com/search/top?q=oqtepa%20lavash");
        }

        private void btn_telegram_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome", "https://t.me/oqtepalavash_bot");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            RegistrationPage registrationPage = new RegistrationPage();
            Hide();
            registrationPage.Show();
        }

        private void InfoPage_Load(object sender, EventArgs e)
        {

        }
    }
}
