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
using System.Diagnostics;

namespace CMPT291Project
{
    public partial class Form2 : Form
    {
        public SqlConnection sqlConnection;
        public SqlCommand sqlCommand;
        public SqlDataReader sqlReader;

        string select_vin = "select vin from Car;";
        string select_type = "select type from CarType;";
        string select_branch = "select branch_id, building_number, street, city, province from Branch;";
        /*
        public bool IsUserAuthenticated { get; set; } // Added login auth
        */

        public Form2()
        {
            InitializeComponent();
            String connectionString = "Server = HAMMERPAD; Database = CMPT291Project; Trusted_Connection = yes";

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

            /*
            // Wire up the SelectedIndexChanged eevent of the TabControl
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            */
        }


        /*
        // Login private code
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!IsUserAuthenticated && (tabControl1.SelectedTab == tab_car || tabControl1.SelectedTab == tab_query))
            {
                MessageBox.Show("Unable to load tab. You have insufficient access privileges.");
                tabControl1.SelectedTab = tab_rental;
            }
        }
        */

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void search_button_Click(object sender, EventArgs e)
        {

        }

        private void search_button_Click_1(object sender, EventArgs e)
        {

        }

        private void pickup_date_picker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //   if cb_type
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            if (button_add.Checked)
            {
                try
                {
                    sqlCommand.CommandText = "insert into Car values ('" + vin.Text + "','" +
                        make.Text + "','" + model.Text + "'," + year.Text + ",'" +
                        colour.Text + "','" + license.Text + "'," + branch.Text + ",'" + type.Text + "')";

                    MessageBox.Show(sqlCommand.CommandText);

                    sqlCommand.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Couldn't add that vehicle, ensure all information listed.");
                }
            }
            else if (button_delete.Checked)
            {
                try
                {
                    sqlCommand.CommandText = "delete from Car where vin = '" + vin.Text + "';";
                    MessageBox.Show(sqlCommand.CommandText);

                    sqlCommand.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Couldn't delete that vehicle (check VIN).");
                }
            }
        }

        private void button_add_CheckedChanged(object sender, EventArgs e)
        {

            vin.Items.Clear();
            vin.Text = string.Empty;
            type.Items.Clear();
            type.Text = string.Empty;
            make.Clear();
            model.Clear();
            year.Clear();
            colour.Clear();
            license.Clear();
            branch.Items.Clear();
            branch.Text = string.Empty;

            using (sqlConnection)
            {
                sqlCommand.CommandText = select_type;
                sqlReader = sqlCommand.ExecuteReader();
                while (sqlReader.Read())
                {
                    type.Items.Add(sqlReader["type"].ToString());
                }
                sqlReader.Close();

                sqlCommand.CommandText = select_branch;
                sqlReader = sqlCommand.ExecuteReader();
                while (sqlReader.Read())
                {
                    branch.Items.Add(sqlReader["branch_id"].ToString());
                }
                sqlReader.Close();

            }
        }

        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_delete_CheckedChanged(object sender, EventArgs e)
        {
            vin.Items.Clear();
            vin.Text = string.Empty;
            type.Items.Clear();
            type.Text = string.Empty;
            make.Clear();
            model.Clear();
            year.Clear();
            colour.Clear();
            license.Clear();
            branch.Items.Clear();
            branch.Text = string.Empty;
            branch_info.Text = string.Empty;


            using (sqlConnection)
            {
                sqlCommand.CommandText = select_vin;
                sqlReader = sqlCommand.ExecuteReader();
                while (sqlReader.Read())
                {
                    vin.Items.Add(sqlReader["vin"].ToString());
                }
                sqlReader.Close();
            }
        }

        private void branch_info_Click(object sender, EventArgs e)
        {

        }

        private void branch_SelectedIndexChanged(object sender, EventArgs e)
        {
            branch_info.Visible = true;

            using (sqlConnection)
            {
                sqlCommand.CommandText = "select branch_id, building_number, street, city, province from Branch where branch_id = '" +
                    branch.Text + "';";
                sqlReader = sqlCommand.ExecuteReader();
                while (sqlReader.Read())
                {
                    branch_info.Text = sqlReader["branch_id"].ToString() + " - " + sqlReader["building_number"].ToString() + " " +
                        sqlReader["street"].ToString() + " " + sqlReader["city"].ToString() + " " + sqlReader["province"].ToString();
                }
                sqlReader.Close();

            }
        }

        private void vin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(button_delete.Checked)
            {
                try
                {
                    sqlCommand.CommandText = "select * from Car";
                    sqlReader = sqlCommand.ExecuteReader();
                    while (sqlReader.Read())
                    {
                        make.Text = sqlReader["make"].ToString();
                        make.Enabled = false;
                        type.Text = sqlReader["type"].ToString();
                        type.Enabled = false;
                        model.Text= sqlReader["model"].ToString();
                        model.Enabled = false;
                        year.Text = sqlReader["year"].ToString();
                        year.Enabled = false;   
                        colour.Text = sqlReader["colour"].ToString();
                        colour.Enabled = false;
                        license.Text = sqlReader["license_plate"].ToString();
                        license.Enabled = false;
                        branch.Text = sqlReader["branch_id"].ToString();
                        branch.Enabled = false;
                    }
                    sqlReader.Close();

                    sqlCommand.CommandText = "select branch_id, building_number, street, city, province from Branch where branch_id = '" +
                    branch.Text + "';";
                    sqlReader = sqlCommand.ExecuteReader();
                    while (sqlReader.Read())
                    {
                        branch_info.Text = sqlReader["branch_id"].ToString() + " - " + sqlReader["building_number"].ToString() + " " +
                            sqlReader["street"].ToString() + " " + sqlReader["city"].ToString() + " " + sqlReader["province"].ToString();
                    }
                    sqlReader.Close();
                }
                catch
                {
                    MessageBox.Show("Error");
                }
            }
        }
    }
}
