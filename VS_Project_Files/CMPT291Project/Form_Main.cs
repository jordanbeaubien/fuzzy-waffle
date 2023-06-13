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

        int rental_days;
        int rental_weeks;
        int rental_months;
        int rental_diff_branch;
        int cost;

        bool fuckered = false;

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

            // If not authenticated, Cars and Query tabs will be removed
            if (!IsUserAuthenticated)
            {
                // Store the tabs in global variables
                tabCar = tab_car;
                tabQuery = tab_query;

                // Remove the tabs
                tabControl1.TabPages.Remove(tab_car);
                tabControl1.TabPages.Remove(tab_query);
            }

            dropoff_location_combo.Enabled = false;

            sqlCommand.CommandText = select_branch;
            try
            {
                sqlReader = sqlCommand.ExecuteReader();
                while (sqlReader.Read())
                {
                    pickup_location_combo.Items.Add(sqlReader["branch_id"].ToString());
                    dropoff_location_combo.Items.Add(sqlReader["branch_id"].ToString());
                    combo_branch_transfer.Items.Add(sqlReader["branch_id"].ToString());
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
            vin.Enabled = false;
            make.Enabled = false;
            type.Enabled = false;
            model.Enabled = false;
            year.Enabled = false;
            colour.Enabled = false;
            license.Enabled = false;
            combo_branch_current.Enabled = false;
            combo_branch_transfer.Enabled = false;
        }


        // Declare global variables to store the Car and Query tabs, so can access in Form_Login
        public TabPage tabCar;
        public TabPage tabQuery;

        private void tabPage1_Click(object sender, EventArgs e)
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

        private void Form2_Load(object sender, EventArgs e)
        {
            //   if cb_type
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            bool add_success = true;

            if (button_add.Checked && combo_branch_transfer.Text.Length > 0)
            {
                try
                {
                    sqlCommand.CommandText = "insert into Car values ('" + vin.Text + "','" +
                        make.Text + "','" + model.Text + "'," + year.Text + ",'" +
                        colour.Text + "','" + license.Text + "'," + combo_branch_transfer.Text + ",'" + type.Text + "')";

                    MessageBox.Show(sqlCommand.CommandText);

                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception e_add)
                {
                    MessageBox.Show(e_add.ToString(), "Error");
                    MessageBox.Show("Couldn't add that vehicle, ensure all information listed.");
                    add_success = false;

                }
                if (add_success == true)
                {
                    try
                    {
                        sqlCommand.CommandText = "insert into Rental values((select MAX(reservation_id) + 1 from Rental), '" +
                            DateTime.Now.ToString("yyyy-MM-dd") + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "', 1, '" + vin.Text +
                            "', " + combo_branch_transfer.Text + ", " + combo_branch_transfer.Text + ')';

                        MessageBox.Show(sqlCommand.CommandText);
                        sqlCommand.ExecuteNonQuery();
                    }
                    catch (Exception e_add_transfer)
                    {
                        MessageBox.Show(e_add_transfer.ToString(), "Error");
                    }
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
                        "', license_plate = '" + license.Text + "', branch_id =" + combo_branch_current.Text +
                        ", type = '" + type.Text + "' where vin = '" + vin.Text + "';";
                    MessageBox.Show(sqlCommand.CommandText);

                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception e_modify)
                {
                    MessageBox.Show("Couldn't modify that vehicle (check VIN).");
                }
                if (combo_branch_transfer.Text.Length > 0)
                {
                    try
                    {
                        sqlCommand.CommandText = "insert into Rental values((select MAX(reservation_id) + 1 from Rental), '" +
                            label_branch_date_current.Text + "', '" + label_branch_date_current.Text + "', 1, '" + vin.Text +
                            "', " + combo_branch_current.Text + ", " + combo_branch_transfer.Text + ')';

                        MessageBox.Show(sqlCommand.CommandText);
                        sqlCommand.ExecuteNonQuery();
                    }
                    catch (Exception e_mod_transfer)
                    {
                        MessageBox.Show(e_mod_transfer.ToString(), "Error");
                    }
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
            combo_branch_current.Text = string.Empty;
            label_branch_info_current.Visible = false;
            label_branch_date_current.Visible = false;
            valid_vin.Visible = false;
            combo_branch_transfer.Text = string.Empty;
            label_branch_info_transfer.Visible = false;

            vin.Enabled = true;
            make.Enabled = true;
            type.Enabled = true;
            model.Enabled = true;
            year.Enabled = true;
            colour.Enabled = true;
            license.Enabled = true;
            combo_branch_current.Enabled = true;
            combo_branch_transfer.Enabled = true;

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
            combo_branch_current.Text = string.Empty;
            label_branch_info_current.Text = string.Empty;
            valid_vin.Visible = false;

            vin.Enabled = true;
            make.Enabled = false;
            type.Enabled = false;
            model.Enabled = false;
            year.Enabled = false;
            colour.Enabled = false;
            license.Enabled = false;
            combo_branch_current.Enabled = false;
            combo_branch_transfer.Enabled = false;

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

        private void branch_current_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!fuckered)
            {
                using (sqlConnection)
                {
                    sqlCommand.CommandText = "select branch_id, building_number, street, city, province from Branch where branch_id = '" +
                        combo_branch_current.Text + "';";
                    try
                    {
                        sqlReader = sqlCommand.ExecuteReader();
                        while (sqlReader.Read())
                        {
                            label_branch_info_current.Text = "Branch Location: " + sqlReader["building_number"].ToString() + " " +
                                sqlReader["street"].ToString() + " " + sqlReader["city"].ToString() + " " + sqlReader["province"].ToString();
                        }
                        sqlReader.Close();
                    }
                    catch (Exception e_branchinfo_curr)
                    {
                        MessageBox.Show(e_branchinfo_curr.ToString(), "Error");
                    }
                }
            }
            label_branch_info_current.Visible = true;
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
                combo_branch_current.Text = string.Empty;
                label_branch_info_current.Visible = false;
                label_branch_date_current.Visible = false;
                label_branch_info_transfer.Visible = false;

                sqlCommand.CommandText = "select * from Car where vin = '" + vin.Text + "';";
                using (sqlConnection)
                {
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

                        }
                        sqlReader.Close();

                        sqlCommand.CommandText = "select rental.branch_id_return, case when rental.to_date >= convert(date, GETDATE()) " +
                            "then rental.to_date else convert(date, GETDATE()) end as move_date from rental where rental.vin = '" + vin.Text +
                             "' and rental.to_date >= all (select R2.to_date from Rental R2, Car where R2.vin = '" + vin.Text + "' and R2.vin = car.vin);";
                        MessageBox.Show(sqlCommand.CommandText);
                        sqlReader = sqlCommand.ExecuteReader();
                        while (sqlReader.Read())
                        {
                            label_branch_date_current.Text = Convert.ToDateTime(sqlReader["move_date"]).ToString("yyyy-MM-dd");
                            label_branch_date_current.Visible = true;
                            fuckered = true;
                            combo_branch_current.Text = sqlReader["branch_id_return"].ToString();
                            //if label_branch_date_current.Text

                        }
                        sqlReader.Close();
                        fuckered = false;

                        sqlCommand.CommandText = "select branch_id, building_number, street, city, province from Branch where branch_id = '" +
                            combo_branch_current.Text + "';";
                        sqlReader = sqlCommand.ExecuteReader();
                        while (sqlReader.Read())
                        {

                            label_branch_info_current.Text = sqlReader["building_number"].ToString() + " " + sqlReader["street"].ToString() +
                                " " + sqlReader["city"].ToString() + " " + sqlReader["province"].ToString();
                        }
                        sqlReader.Close();
                        label_branch_info_current.Visible = true;
                    }
                    catch (Exception e_getinfo)
                    {
                        MessageBox.Show(e_getinfo.ToString(), "Error");
                    }
                }
                if (button_modify.Checked)
                {
                    make.Enabled = true;
                    type.Enabled = true;
                    model.Enabled = true;
                    year.Enabled = true;
                    colour.Enabled = true;
                    license.Enabled = true;
                    combo_branch_current.Enabled = false;
                    combo_branch_transfer.Enabled = true;

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
            combo_branch_current.Text = string.Empty;
            label_branch_info_current.Text = string.Empty;
            valid_vin.Visible = false;

            vin.Enabled = true;
            make.Enabled = false;
            type.Enabled = false;
            model.Enabled = false;
            year.Enabled = false;
            colour.Enabled = false;
            license.Enabled = false;
            combo_branch_current.Enabled = false;
            combo_branch_transfer.Enabled = false;

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            TimeSpan rental_duration = dropoff_date_picker.Value.Date - pickup_date_picker.Value.Date;

            rental_days = rental_duration.Days + 1;
            rental_weeks = 0;
            rental_months = 0;
            rental_diff_branch = 0;
            cost = 0;

            for (; rental_days >= 30; rental_months += 1, rental_days -= 30) ;
            for (; rental_days >= 7; rental_weeks += 1, rental_days -= 7) ;
            if (vehicle_type_combo_box.Text.Length > 0)
            {
                label_duration.Visible = true;
                duration.Text = rental_months.ToString() + " months, " + rental_weeks.ToString() + " weeks, " + rental_days.ToString() + " days";
                duration.Visible = true;
                sqlCommand.CommandText = "select daily_rate, weekly_rate, monthly_rate, dif_branch_ret_price from CarType where type = '" +
                    vehicle_type_combo_box.Text.ToString() + "';";
                if (pickup_location_combo.Text != dropoff_location_combo.Text)
                {
                    rental_diff_branch = 1;
                }

                try
                {
                    sqlReader = sqlCommand.ExecuteReader();
                    sqlReader.Read();
                    cost = sqlReader.GetInt32("daily_rate") * rental_days + sqlReader.GetInt32("weekly_rate") * rental_weeks +
                        sqlReader.GetInt32("monthly_rate") * rental_months + sqlReader.GetInt32("dif_branch_ret_price") * rental_diff_branch;
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

        private void combo_branch_transfer_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (sqlConnection)
            {
                sqlCommand.CommandText = "select branch_id, building_number, street, city, province from Branch where branch_id = '" +
                    combo_branch_transfer.Text + "';";
                try
                {
                    sqlReader = sqlCommand.ExecuteReader();
                    while (sqlReader.Read())
                    {
                        label_branch_info_transfer.Text = "Branch Location: " + sqlReader["building_number"].ToString() + " " +
                            sqlReader["street"].ToString() + " " + sqlReader["city"].ToString() + " " + sqlReader["province"].ToString();
                    }
                    sqlReader.Close();
                }
                catch (Exception e_branchinfo_curr)
                {
                    MessageBox.Show(e_branchinfo_curr.ToString(), "Error");
                }
            }
            label_branch_info_transfer.Visible = true;
        }

        private void label_branch_info_transfer_Click(object sender, EventArgs e)
        {

        }
    }
}
