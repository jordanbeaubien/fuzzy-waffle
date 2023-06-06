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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;
using System.Reflection;

namespace CMPT291Project
{
   
    public partial class Form1 : Form
    {
        public SqlConnection sqlConnection;
        public SqlCommand sqlCommand;
        public SqlDataReader sqlReader;
        
        private Form2 formMain;

        public Form1(Form2 formMain) // Added argument "Form2 formMain" for login auth
        {
            InitializeComponent();
            // Login addon
            this.formMain = formMain;

            String connectionString = "Server = .; Database = CMPT291Project; Trusted_Connection = yes";

            SqlConnection sqlConnection = new SqlConnection(connectionString);
            
            try
            {
                sqlConnection.Open(); // Open connection
                sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection; // Link the command stream to the connection
            }

            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }
            
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

            Console.WriteLine("cb_type " + cb_type.Text);
            Console.WriteLine("text_user: " + text_user.Text);
            Console.WriteLine("text_pw: " + text_pw.Text);

            try
            {
                sqlCommand.CommandText = "select count(*) as existing from Login where user_type = '" + cb_type.Text + "' and username = '" +
                    text_user.Text + "' and password = '" + text_pw.Text + "';";
                MessageBox.Show(sqlCommand.CommandText);
                sqlReader = sqlCommand.ExecuteReader();
                sqlReader.Read();
                
                if (sqlReader["existing"].ToString() != "0")
                {
                    if (cb_type.Text == "Customer")
                    {
                        //sqlReader.Close();
                        this.Hide();
                        formMain.Show();

                    }
                    else if (cb_type.Text == "Employee")
                    {
                        //sqlReader.Close();
                        this.Hide();
                        formMain.Show();

                        // If login is successful:
                        formMain.IsUserAuthenticated = true;
                      
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Please try again", MessageBoxButtons.OK);
                }
                
                sqlReader.Close();
            }
            catch
            {
                MessageBox.Show("Error");
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