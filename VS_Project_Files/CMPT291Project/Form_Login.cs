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

        bool populate_test_data = false;

        // Properly close all running processes on app exit
        private void Form_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public Form1(Form2 formMain) // Added argument "Form2 formMain" for login auth
        {
            InitializeComponent();
            // Login addon
            this.formMain = formMain;

            // Properly close all running processes on app exit
            this.FormClosing += Form_Login_FormClosing;


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

            if (populate_test_data)
            {
                DB_Helper dbHelper = new DB_Helper();
                List<string> commands = dbHelper.populate_data(20, 20, 20);

                foreach(string command in commands)
                {
                    sqlCommand.CommandText = command;
                    sqlReader = sqlCommand.ExecuteReader();
                    sqlReader.Read();
                    sqlReader.Close();

                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Console.WriteLine("cb_type " + cb_type.Text);
            Console.WriteLine("text_user: " + text_user.Text);
            Console.WriteLine("text_pw: " + text_pw.Text);

            if (cb_type.Text.Length == 0)
            {
                MessageBox.Show("Need to select Customer or Employee", "Please try again", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    //sqlCommand.CommandText = "select count(*) as existing from Login where user_type = '" + cb_type.Text + "' and username = '" +
                    //    text_user.Text + "' and password = '" + text_pw.Text + "';";
                    sqlCommand.CommandText = $"select count(*) as existing " +
                                             $"from {cb_type.Text}Login " +
                                             $"where username = '{text_user.Text}' and password = '{text_pw.Text}';";
                    MessageBox.Show(sqlCommand.CommandText);
                    sqlReader = sqlCommand.ExecuteReader();
                    sqlReader.Read();

                    if (sqlReader["existing"].ToString() == "1")
                    {

                        if (cb_type.Text == "Customer")
                        {
                            sqlReader.Close();
                            this.Hide();
                            formMain.Show();

                            sqlCommand.CommandText = $"select customer_id from CustomerLogin where username = '{text_user.Text}';";
                            MessageBox.Show(sqlCommand.CommandText);
                            sqlReader = sqlCommand.ExecuteReader();
                            sqlReader.Read();

                            formMain.customer_id = (int)sqlReader["customer_id"];

                        }
                        else if (cb_type.Text == "Employee")
                        {
                            //sqlReader.Close();
                            this.Hide();
                            formMain.Show();

                            // Add the tabs back
                            if (formMain.tabCar != null)
                            {
                                formMain.tabControl1.TabPages.Add(formMain.tabCar);
                            }
                            if (formMain.tabQuery != null)
                            {
                                formMain.tabControl1.TabPages.Add(formMain.tabQuery);
                            }
                            formMain.show_customer_id();

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
                catch (Exception e_login)
                {
                    MessageBox.Show(e_login.ToString(), "Error");
                }
            }
        }
    }
}