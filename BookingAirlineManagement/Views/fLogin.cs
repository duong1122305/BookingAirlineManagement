namespace BookingAirlineManagement
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = "admin";
            string b = "admin";

            if (tb_email.Text == a && tb_pass.Text == b)
            {
                MessageBox.Show("Thanh cong");
            }
        }
    }
}