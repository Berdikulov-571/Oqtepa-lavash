using DataBase;

namespace OqTepaLavashProject
{
    public partial class Login : Form
    {
        Registration Registration = new Registration();
        public Login()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            RegistrationPage registrationPage = new RegistrationPage();
            Hide();
            registrationPage.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ForgetPasswordPage forgetPassword = new ForgetPasswordPage();
            Hide();
            forgetPassword.Show();
        }
        private void btn_enter_Click(object sender, EventArgs e)
        {
            using (OqTepaContext checkUser = new OqTepaContext())
            {
                Zakaz zakaz = new Zakaz();

                var rows = from o in checkUser.Zakazs
                           select o;
                foreach (var row in rows)
                {
                    checkUser.Zakazs.Remove(row);
                }
                checkUser.SaveChanges();

                var users = checkUser.Registrations.ToList();

                foreach (var i in users)
                {
                    if (i.Email == textBox1.Text && i.Password == textBox2.Text)
                    {
                        MenuPage menuPage = new MenuPage();
                        this.Hide();
                        menuPage.Show();
                    }
                }
                textBox1.ForeColor = Color.Lime;
                textBox1.PlaceholderText = "Error email or password";
                textBox2.ForeColor = Color.Lime;
                textBox2.PlaceholderText = "Error email or password";
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.PlaceholderText = "Error email";
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}