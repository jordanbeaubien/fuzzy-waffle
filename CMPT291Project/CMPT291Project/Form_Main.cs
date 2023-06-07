﻿using System;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic;

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
        public bool IsUserAuthenticated { get; set; } // Added login auth

        public Form2()
        {
            InitializeComponent();
            String connectionString = "Server = .; Database = CMPT291Project; Trusted_Connection = yes";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            try
            {
                sqlConnection.Open(); // Open connection
                sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection; // Link the command stream to the connection
            }

            catch (Exception e_connect)
            {
                MessageBox.Show(e_connect.ToString(), "Error");
                this.Close();
            }

            // Wire up the SelectedIndexChanged eevent of the TabControl
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);

            dropoff_location_combo.Enabled = false;

            sqlCommand.CommandText = select_branch;
            try
            {
                sqlReader = sqlCommand.ExecuteReader();
                while (sqlReader.Read())
                {
                    pickup_location_combo.Items.Add(sqlReader["branch_id"].ToString());
                    dropoff_location_combo.Items.Add(sqlReader["branch_id"].ToString());
                    branch.Items.Add(sqlReader["branch_id"].ToString());
                }
                sqlReader.Close();
            }
            catch (Exception e_getbranchid)
            {
                MessageBox.Show(e_getbranchid.ToString(), "Error");
            }

            string query0 = "Name and Address of Customers who Spent Over $1000 Last Year";
            string query1 = "Number of Rentals by Car Type from Branches in Specified City";
            string query2 = "Percentage of Cartypes That Get Returned to Different Branches";
            string query3 = "Percentage Share of rentals by all Branches";
            string query4 = "Stock of All Vehicles Across All Locations";

            combo_query.Items.Add(query0);
            combo_query.Items.Add(query1);
            combo_query.Items.Add(query2);
            combo_query.Items.Add(query3);
            combo_query.Items.Add(query4);
            combo_query_option.Enabled = false;

            vehicle_type_combo_box.Enabled = false;
        }


        // Login private code
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!IsUserAuthenticated && (tabControl1.SelectedTab == tab_car || tabControl1.SelectedTab == tab_query))
            {
                MessageBox.Show("Unable to load tab. You have insufficient access privileges.");
                tabControl1.SelectedTab = tab_rental;
            }
        }

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
            if (dropoff_date_picker.Value < DateTime.Today || pickup_date_picker.Value < pickup_date_picker.Value)
            {
                label_available.ForeColor = Color.Red;
                label_available.Text = "Invalid date selection";
                label_available.Visible = true;
            }
            else if (pickup_location_combo.Text.Length == 0 || dropoff_location_combo.Text.Length == 0)
            {
                label_available.ForeColor = Color.Red;
                label_available.Text = "Pickup or dropoff location not selected";
                label_available.Visible = true;
            }
            else
            {
                vehicle_type_combo_box.Items.Clear();
                string types_available = "select distinct Car.type from Car where Car.vin not in" +
                    "(select R1.vin from Rental as R1 where R1.from_date <= '" + dropoff_date_picker.Value.ToString("yyyy-MM-dd") +
                    "' and R1.to_date >= '" + pickup_date_picker.Value.ToString("yyyy-MM-dd") + "') and Car.vin not in " +
                    "(select R2.vin from Rental as R2 join (select R3.vin, max(R3.to_date) as max_to_date " +
                    "from Rental as R3 where R3.to_date < '" + pickup_date_picker.Value.ToString("yyyy-MM-dd") + "' group by R3.vin)" +
                    "as T1 on T1.vin = R2.vin and T1.max_to_date = R2.to_date where R2.branch_id_return != " +
                    pickup_location_combo.Text + ");";

                MessageBox.Show(types_available);
                using (sqlConnection)
                {
                    sqlCommand.CommandText = types_available;
                    sqlReader = sqlCommand.ExecuteReader();
                    while (sqlReader.Read())
                    {
                        vehicle_type_combo_box.Items.Add(sqlReader["type"]);
                    }
                    sqlReader.Close();
                }
                if (vehicle_type_combo_box.Items.Count == 0)
                {
                    label_available.ForeColor = Color.Red;
                    label_available.Text = "No vehicles available from that branch during that timeframe";
                    label_available.Visible = true;
                }
                else
                {
                    label_available.ForeColor = Color.Black;
                    label_available.Text = "Select vehicle type below";
                    label_available.Visible = true;
                    vehicle_type_combo_box.Enabled = true;
                }
            }
        }

        private void pickup_date_picker_ValueChanged(object sender, EventArgs e)
        {
            vehicle_type_combo_box.Items.Clear();
            vehicle_type_combo_box.Enabled = false;
            label_available.Visible = false;
            label_duration.Visible = false;
            duration.Visible = false;
            label_price.Visible = false;
            price.Visible = false;

            /*
            pickup_location_combo.Items.Clear();
            dropoff_location_combo.Items.Clear();
            using (sqlConnection)
            {
                sqlCommand.CommandText = select_branch;
                sqlReader = sqlCommand.ExecuteReader();
                while (sqlReader.Read())
                {
                    pickup_location_combo.Items.Add(sqlReader["branch_id"].ToString());
                    dropoff_location_combo.Items.Add(sqlReader["branch_id"].ToString());
                }
                sqlReader.Close();
            }
            */
        }
        private void dropoff_date_picker_ValueChanged(object sender, EventArgs e)
        {
            vehicle_type_combo_box.Items.Clear();
            vehicle_type_combo_box.Enabled = false;
            label_available.Visible = false;
            label_duration.Visible = false;
            duration.Visible = false;
            label_price.Visible = false;
            price.Visible = false;
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
                catch (Exception e_add)
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
                catch (Exception e_delete)
                {
                    MessageBox.Show("Couldn't delete that vehicle (check VIN).");
                }
            }
            else if (button_modify.Checked)
            {
                try
                {
                    sqlCommand.CommandText = "update Car set make = '" + make.Text + "', model = '" +
                        model.Text + "', year = " + year.Text + ", colour = '" + colour.Text +
                        "', license_plate = '" + license.Text + "', branch_id =" + branch.Text +
                        ", type = '" + type.Text + "' where vin = '" + vin.Text + "';";
                    MessageBox.Show(sqlCommand.CommandText);

                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception e_modify)
                {
                    MessageBox.Show("Couldn't modify that vehicle (check VIN).");
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
            //branch.Items.Clear();
            branch.Text = string.Empty;
            valid_vin.Visible = false;

            make.Enabled = true;
            type.Enabled = true;
            model.Enabled = true;
            year.Enabled = true;
            colour.Enabled = true;
            license.Enabled = true;
            branch.Enabled = true;

            using (sqlConnection)
            {
                sqlCommand.CommandText = select_type;
                try
                {
                    sqlReader = sqlCommand.ExecuteReader();
                    while (sqlReader.Read())
                    {
                        type.Items.Add(sqlReader["type"].ToString());
                    }
                    sqlReader.Close();

                    /*sqlCommand.CommandText = select_branch;
                    sqlReader = sqlCommand.ExecuteReader();
                    while (sqlReader.Read())
                    {
                        branch.Items.Add(sqlReader["branch_id"].ToString());
                    }
                    sqlReader.Close();
                    */
                }
                catch (Exception e_add_type)
                {
                    MessageBox.Show(e_add_type.ToString(), "Error");
                }
            }

            vin.DropDownStyle = ComboBoxStyle.Simple;
            vin.DropDownHeight = 1;
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
            //branch.Items.Clear();
            branch.Text = string.Empty;
            branch_info.Text = string.Empty;
            valid_vin.Visible = false;

            make.Enabled = false;
            type.Enabled = false;
            model.Enabled = false;
            year.Enabled = false;
            colour.Enabled = false;
            license.Enabled = false;
            branch.Enabled = false;

            using (sqlConnection)
            {
                sqlCommand.CommandText = select_vin;
                try
                {
                    sqlReader = sqlCommand.ExecuteReader();
                    while (sqlReader.Read())
                    {
                        vin.Items.Add(sqlReader["vin"].ToString());
                    }
                    sqlReader.Close();
                }
                catch (Exception e_vinlistdelete)
                {
                    MessageBox.Show(e_vinlistdelete.ToString(), "Error");
                }
            }

            vin.DropDownStyle = ComboBoxStyle.DropDown;
            vin.DropDownHeight = 106;
            vin.AutoCompleteSource = AutoCompleteSource.ListItems;
            vin.AutoCompleteMode = AutoCompleteMode.Suggest;
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
                try
                {
                    sqlReader = sqlCommand.ExecuteReader();
                    while (sqlReader.Read())
                    {
                        branch_info.Text = "Branch Location: " + sqlReader["building_number"].ToString() + " " +
                            sqlReader["street"].ToString() + " " + sqlReader["city"].ToString() + " " + sqlReader["province"].ToString();
                    }
                    sqlReader.Close();
                }
                catch (Exception e_branchinfo)
                {
                    MessageBox.Show(e_branchinfo.ToString(), "Error");
                }
            }

        }

        private void vin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (button_delete.Checked || button_modify.Checked)
            {
                type.Items.Clear();
                type.Text = string.Empty;
                make.Clear();
                model.Clear();
                year.Clear();
                colour.Clear();
                license.Clear();
                //branch.Items.Clear();
                branch.Text = string.Empty;
                branch_info.Text = string.Empty;

                sqlCommand.CommandText = "select * from Car where vin = '" + vin.Text + "';";
                try
                {
                    sqlReader = sqlCommand.ExecuteReader();
                    while (sqlReader.Read())
                    {
                        make.Text = sqlReader["make"].ToString();
                        type.Text = sqlReader["type"].ToString();
                        model.Text = sqlReader["model"].ToString();
                        year.Text = sqlReader["year"].ToString();
                        colour.Text = sqlReader["colour"].ToString();
                        license.Text = sqlReader["license_plate"].ToString();
                        branch.Text = sqlReader["branch_id"].ToString();

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
                catch (Exception e_getinfo)
                {
                    MessageBox.Show(e_getinfo.ToString(), "Error");
                }

                if (button_modify.Checked)
                {
                    make.Enabled = true;
                    type.Enabled = true;
                    model.Enabled = true;
                    year.Enabled = true;
                    colour.Enabled = true;
                    license.Enabled = true;
                    branch.Enabled = true;

                    using (sqlConnection)
                    {

                        sqlCommand.CommandText = select_type;
                        try
                        {
                            sqlReader = sqlCommand.ExecuteReader();
                            while (sqlReader.Read())
                            {
                                type.Items.Add(sqlReader["type"].ToString());
                            }
                            sqlReader.Close();
                            /*
                            sqlCommand.CommandText = select_branch;
                            sqlReader = sqlCommand.ExecuteReader();
                            while (sqlReader.Read())
                            {
                                branch.Items.Add(sqlReader["branch_id"].ToString());
                            }
                            sqlReader.Close();
                            */
                        }
                        catch (Exception e_gettype)
                        {
                            MessageBox.Show(e_gettype.ToString(), "Error");
                        }
                    }
                }
            }
        }

        private void vin_Leave(object sender, EventArgs e)
        {
            if (button_modify.Checked || button_delete.Checked)
            {
                if (!vin.Items.Contains(vin.Text))
                {
                    valid_vin.Visible = true;
                }
                else
                {
                    valid_vin.Visible = false;
                }
            }
        }

        private void button_modify_CheckedChanged(object sender, EventArgs e)
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
            //branch.Items.Clear();
            branch.Text = string.Empty;
            branch_info.Text = string.Empty;
            valid_vin.Visible = false;

            make.Enabled = false;
            type.Enabled = false;
            model.Enabled = false;
            year.Enabled = false;
            colour.Enabled = false;
            license.Enabled = false;
            branch.Enabled = false;

            using (sqlConnection)
            {
                sqlCommand.CommandText = select_vin;
                try
                {
                    sqlReader = sqlCommand.ExecuteReader();
                    while (sqlReader.Read())
                    {
                        vin.Items.Add(sqlReader["vin"].ToString());
                    }
                    sqlReader.Close();
                }
                catch (Exception e_getvin)
                {
                    MessageBox.Show(e_getvin.ToString(), "Error");
                }
            }
            vin.DropDownStyle = ComboBoxStyle.DropDown;
            vin.DropDownHeight = 106;
            vin.AutoCompleteSource = AutoCompleteSource.ListItems;
            vin.AutoCompleteMode = AutoCompleteMode.Suggest;


        }

        private void label9_Click(object sender, EventArgs e)
        {

        }


        private void pickup_location_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            vehicle_type_combo_box.Items.Clear();
            vehicle_type_combo_box.Enabled = false;
            label_available.Visible = false;
            label_duration.Visible = false;
            duration.Visible = false;
            label_price.Visible = false;
            price.Visible = false;

            if (return_same_loc_checkbox.Checked)
            {
                dropoff_location_combo.Text = pickup_location_combo.Text;
            }

            pickup_location_details.Visible = true;

            using (sqlConnection)
            {
                sqlCommand.CommandText = "select branch_id, building_number, street, city, province from Branch where branch_id = '" +
                    pickup_location_combo.Text + "';";
                try
                {
                    sqlReader = sqlCommand.ExecuteReader();
                    while (sqlReader.Read())
                    {
                        pickup_location_details.Text = "Pickup Branch Location: " + sqlReader["building_number"].ToString() + " " +
                            sqlReader["street"].ToString() + " " + sqlReader["city"].ToString() + " " + sqlReader["province"].ToString();
                    }
                }
                catch (Exception e_getpickupbranchinfo)
                {
                    MessageBox.Show(e_getpickupbranchinfo.ToString(), "Error");
                }

                sqlReader.Close();

            }
        }

        private void return_same_loc_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            dropoff_location_combo.Enabled = !dropoff_location_combo.Enabled;

            if (return_same_loc_checkbox.Checked)
            {
                dropoff_location_combo.Text = pickup_location_combo.Text;
            }
        }

        private void dropoff_location_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            vehicle_type_combo_box.Items.Clear();
            vehicle_type_combo_box.Enabled = false;
            label_available.Visible = false;
            label_duration.Visible = false;
            duration.Visible = false;
            label_price.Visible = false;
            price.Visible = false;

            dropoff_location_details.Visible = true;

            using (sqlConnection)
            {
                sqlCommand.CommandText = "select branch_id, building_number, street, city, province from Branch where branch_id = '" +
                    dropoff_location_combo.Text + "';";
                try
                {
                    sqlReader = sqlCommand.ExecuteReader();
                    while (sqlReader.Read())
                    {
                        dropoff_location_details.Text = "Dropoff Branch Location: " + sqlReader["building_number"].ToString() + " " +
                            sqlReader["street"].ToString() + " " + sqlReader["city"].ToString() + " " + sqlReader["province"].ToString();
                    }
                }
                catch (Exception e_getdropoffbranchinfo)
                {
                    MessageBox.Show(e_getdropoffbranchinfo.ToString(), "Error");
                }

                sqlReader.Close();

            }
        }

        private void vehicle_type_combo_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_available.Visible = false;
            label_duration.Visible = false;
            duration.Visible = false;
            label_price.Visible = false;
            price.Visible = false;
        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dropoff_location_details_Click(object sender, EventArgs e)
        {

        }

        private void combo_query_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_query_option.Items.Clear();
            if (combo_query.SelectedIndex == 1)
            {
                combo_query_option.Enabled = true;
                using (sqlConnection)
                {
                    sqlCommand.CommandText = "select distinct city from branch";
                    try
                    {
                        sqlReader = sqlCommand.ExecuteReader();
                        while (sqlReader.Read())
                        {
                            combo_query_option.Items.Add(sqlReader["city"]);
                        }
                        sqlReader.Close();
                    }
                    catch (Exception e_selectcityquery)
                    {
                        MessageBox.Show(e_selectcityquery.ToString(), "Error");
                    }
                }
            }
            else
            {
                combo_query_option.Enabled = false;
                combo_query_option.Text = string.Empty;
            }
        }

        private void button_query_Click(object sender, EventArgs e)
        {
            switch (combo_query.SelectedIndex)
            {
                case 1:
                    sqlCommand.CommandText = "select count(*) as '# of Rentals', CT.Type from " +
                        "Rental as R, Car as C, CarType as CT, Branch as B " +
                        "where R.vin=C.vin and CT.type=C.type and B.branch_id=C.branch_id " +
                        "group by CT.type, B.city having B.city='" +
                        combo_query_option.Text + "';";
                    try
                    {
                        MessageBox.Show(sqlCommand.CommandText);
                        sqlReader = sqlCommand.ExecuteReader();
                        data_query.Columns.Clear();
                        data_query.Columns.Add("num_rentals", "# of Rentals");
                        data_query.Columns.Add("type", "Type");
                        data_query.Rows.Clear();
                        while (sqlReader.Read())
                        {
                            data_query.Rows.Add(sqlReader["# of Rentals"].ToString(), sqlReader["Type"].ToString());
                        }

                        sqlReader.Close();
                    }
                    catch (Exception e_executeQ2)
                    {
                        MessageBox.Show(e_executeQ2.ToString(), "Error");
                    }
                    break;
            }


        }

        private void combo_query_option_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_quote_Click(object sender, EventArgs e)
        {
            TimeSpan rental_duration = dropoff_date_picker.Value - pickup_date_picker.Value;
            int rental_days;
            int rental_weeks = 0;
            int rental_months = 0;
            int cost = 0;

            if (dropoff_date_picker.Value.ToString("yyyy-MM-dd") == pickup_date_picker.Value.ToString("yyyy-MM-dd"))
            {
                rental_days = 1;
            }
            else
            {
                rental_days = rental_duration.Days + 2;
            }
            for (; rental_days >= 30; rental_months += 1, rental_days -= 30) ;
            for (; rental_days >= 7; rental_weeks += 1, rental_days -= 7) ;
            if (vehicle_type_combo_box.Text.Length > 0)
            {
                label_duration.Visible = true;
                duration.Text = rental_months.ToString() + " months, " + rental_weeks.ToString() + " weeks, " + rental_days.ToString() + " days";
                duration.Visible = true;
                sqlCommand.CommandText = "select daily_rate, weekly_rate, monthly_rate from CarType where type = '" + vehicle_type_combo_box.Text.ToString() + "';";
                try
                {
                    sqlReader = sqlCommand.ExecuteReader();
                    sqlReader.Read();
                    cost = sqlReader.GetInt32("daily_rate") * rental_days + sqlReader.GetInt32("weekly_rate") * rental_weeks + sqlReader.GetInt32("monthly_rate") * rental_months;
                    sqlReader.Close();
                    label_price.Visible = true;
                    price.Text = "$" + cost.ToString() + ".00";
                    price.Visible = true;
                }
                catch (Exception e_calculateprice)
                {
                    MessageBox.Show(e_calculateprice.ToString(), "Error");
                }

            }
        }

    }
}
