namespace CMPT291Project
{
    public partial class form_login : Form
    {

        public form_login()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cb_type.Text == "Customer" && text_user.Text == "user" && text_pw.Text == "password")
            {
                Form2 F2 = new Form2();
                F2.Show();
                F2.
            }
            else if (cb_type.Text == "Customer" && text_user.Text == "admin" && text_pw.Text == "admin")
            {
            }
            {
                MessageBox.Show("Invalid username or password", "please try again", MessageBoxButtons.OK);
                label_invalid.Text = "Invalid Username or Password, please try again.";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}