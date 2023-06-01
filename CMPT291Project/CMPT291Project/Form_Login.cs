using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CMPT291Project
{

    public partial class Form1 : Form
    {

        private Form2 formMain;

        public Form1() // Add argument "Form2 formMain" for login auth
        {
            InitializeComponent();
            /*
            // Login addon
            this.formMain = formMain;
            */
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

                this.Hide();
                Form2 F2 = new Form2();
                F2.Show();
                
            }
            else if (cb_type.Text == "Employee" && text_user.Text == "admin" && text_pw.Text == "admin")
            {

                this.Hide();
                Form2 F2 = new Form2();
                F2.Show();

                /*
                // If login is successful:
                formMain.IsUserAuthenticated = true;
                this.Close();
                */
            }
            else
            {
                MessageBox.Show("Invalid username or password", "please try again", MessageBoxButtons.OK);
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