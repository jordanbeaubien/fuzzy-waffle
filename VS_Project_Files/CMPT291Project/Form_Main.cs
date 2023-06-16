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
using System.Security.AccessControl;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

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
        public int customer_id;

        int rental_days;
        int rental_weeks;
        int rental_months;
        int rental_diff_branch;
        int cost;

        bool borked = false;

        // Properly close all running processes on app exit
        private void Form_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        public Form2()
        {
            InitializeComponent();

            // Properly close all running processes on app exit
            this.FormClosing += Form_Login_FormClosing;

            // Connect to SQL server
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

                // Hide customer id input field
                customer_id_input.Visible = false;
                customer_id_label.Visible = false;
            }

            //dropoff_location_combo.Enabled = false;

            // Populate all combo boxes with branch_id from database
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

            // Populate the customer id combo box with customer_id from database
            sqlCommand.CommandText = "select customer_id from customer;";
            try
            {
                sqlReader = sqlCommand.ExecuteReader();
                while (sqlReader.Read())
                {
                    customer_id_input.Items.Add(sqlReader["customer_id"].ToString());
                }
                sqlReader.Close();
            }
            catch (Exception e_getbranchid)
            {
                MessageBox.Show(e_getbranchid.ToString(), "Error");
            }


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
            catch (Exception e_gettype)
            {
                MessageBox.Show(e_gettype.ToString(), "Error");
            }


            // INITIALIZE ALL VIEWS AT STARTUP


            // Check if pricebyrental View already exists (used for query0)
            sqlCommand.CommandText = "SELECT OBJECT_ID('pricebyrental', 'V')";
            object view_check_query0 = sqlCommand.ExecuteScalar();
            if (view_check_query0 == DBNull.Value)
            {
                // If pricebyrental view does not exist, run SQL code to create the view
                sqlCommand.CommandText = "CREATE VIEW pricebyrental AS (select reservation_id, CASE when branch_id_return is not null " +
                    "then (select CASE when branch_id_pickup <> branch_id_return then dif_branch_ret_price else 0 END) +CASE when " +
                    "DATEDIFF(day, from_date, to_date)< 7 then daily_rate *DATEDIFF(day, from_date, to_date) when " +
                    "DATEDIFF(day, from_date, to_date)>= 7 AND DATEDIFF(day, from_date, to_date)< 30 then weekly_rate " +
                    "*DATEDIFF(week, from_date, to_date) when DATEDIFF(day, from_date, to_date)>= 30 then monthly_rate " +
                    "*DATEDIFF(month, from_date, to_date) END else null END as price from rental as R, Car as C, CarType as CT " +
                    "where R.vin = C.vin AND C.type = CT.type)";
                try
                {
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception e_start_view_query0)
                {
                    MessageBox.Show(e_start_view_query0.ToString(), "Error");
                }

            }
            else
            {
                // If the view exists, do nothing
            }


            // No views for query1

            // Check if rentalsbybranchyr View already exists (used for query0)
            sqlCommand.CommandText = "SELECT OBJECT_ID('rentalsbybranchyr', 'V')";
            object view_check_query2 = sqlCommand.ExecuteScalar();
            if (view_check_query0 == DBNull.Value)
            {
                // If rentalsbybranchyr view does not exist, run SQL code to create the view
                sqlCommand.CommandText = "CREATE VIEW rentalsbybranchyr AS\r\n(select sum(times) as times, branch_id, year " +
                    "from((select count(*) as times, branch_id_return as branch_id, year(from_date) as year from Branch, Rental " +
                    "where branch_id=branch_id_return group by year(from_date), branch_id_return) UNION ALL " +
                    "(select count(*) as times, branch_id_pickup as branch_id, year(from_date) as year from Branch, Rental " +
                    "where branch_id=branch_id_pickup group by year(from_date), branch_id_pickup)) as X group by year, branch_id)";
                try
                {
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception e_start_view_query2)
                {
                    MessageBox.Show(e_start_view_query2.ToString(), "Error");
                }

            }
            else
            {
                // If the view exists, do nothing
            }


            // Check if vehstockbybranch View already exists (used for query4)
            sqlCommand.CommandText = "SELECT OBJECT_ID('vehstockbybranch', 'V')";
            object view_check_query4 = sqlCommand.ExecuteScalar();
            if (view_check_query4 == DBNull.Value)
            {
                // If vehstockbybranch view does not exist, run SQL code to create the view
                /*sqlCommand.CommandText = "CREATE VIEW vehstockbybranch AS (select branch_id, "
                + "(select count(*) from (select C5.vin from Car as C5 where C5.branch_id=B.branch_id AND C5.vin not in "
                + "(select C1.vin from Car as C1, Rental as R1 where C1.vin=R1.vin AND to_date>GETDATE() AND from_date<GETDATE())) "
                + "as X) as vehicle_stock from Branch as B)";*/

                sqlCommand.CommandText = "CREATE VIEW vehstockbybranch as (select R1.branch_id_return as branch_id, count(R1.vin)" +
                    "as vehicle_stock from rental R1 where R1.to_date = (select max(R2.to_date) from rental as R2 where R2.to_date < GETDATE() " +
                    "and R2.vin = R1.vin) and R1.vin not in (select distinct R3.vin from rental R3 where GETDATE() > R3.from_date " +
                    "and GETDATE() < R3.to_date) group by R1.branch_id_return);";
                try
                {
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception e_start_view_query4)
                {
                    MessageBox.Show(e_start_view_query4.ToString(), "Error");
                }

            }
            else
            {
                // If the view exists, do nothing
            }


            // Add all 5 queries to combo drop down menu on Query tab
            string query0 = "Name and Address of Customers who Spent Over $1000 Last Year";
            string query1 = "Number of Rentals by Car Type from Branches in Specified City";
            string query2 = "Branches that See Less Than 100 Rentals or Returns for 3 Years in a Row";
            string query3 = "Percentage Share of Rentals by all Branches";
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
            combo_branch_transfer.Enabled = false;
            branch_current.Text = String.Empty;

            pickup_date_picker.Value = DateTime.Today;
            dropoff_date_picker.Value = DateTime.Today.AddDays(1);
        }


        // Declare global variables to store the Car and Query tabs, so can access in Form_Login
        public TabPage tabCar;
        public TabPage tabQuery;

        public void show_customer_id()
        {
            customer_id_label.Visible = true;
            customer_id_input.Visible = true;
        }

        private void search_button_Click_1(object sender, EventArgs e)
        {
            label_error.Visible = false;
            label_duration.Visible = false;
            duration.Visible = false;
            label_price.Visible = false;
            price.Visible = false;
            label_type_not_selected.Visible = false;

            // Date error handling
            if (pickup_date_picker.Value < DateTime.Today)
            {
                label_error.ForeColor = Color.Red;
                label_error.Text = "Pickup date must be in the future";
                label_error.Visible = true;
            }
            else if (dropoff_date_picker.Value < DateTime.Today)
            {
                label_error.ForeColor = Color.Red;
                label_error.Text = "Dropoff date must be in the future";
                label_error.Visible = true;
            }
            else if (dropoff_date_picker.Value < pickup_date_picker.Value)
            {
                label_error.ForeColor = Color.Red;
                label_error.Text = "Dropoff date must be after Pickup date";
                label_error.Visible = true;
            }

            // Location error handling
            else if (pickup_location_combo.Text.Length == 0)
            {
                label_error.ForeColor = Color.Red;
                label_error.Text = "Pickup location not selected";
                label_error.Visible = true;
            }
            else if (dropoff_location_combo.Text.Length == 0)
            {
                label_error.ForeColor = Color.Red;
                label_error.Text = "Dropoff location not selected";
                label_error.Visible = true;
            }

            // Customer ID error handling
            else if (IsUserAuthenticated && customer_id_input.Text.Length == 0)
            {
                label_error.ForeColor = Color.Red;
                label_error.Text = "Customer ID not selected";
                label_error.Visible = true;
            }
            else
            {
                vehicle_type_combo_box.Items.Clear();

                string vins_available = "select V.vin from (select vin, MAX(to_date) as Latest_Return from rental R1 where R1.to_date < '" +
                        pickup_date_picker.Value.ToString("yyyy-MM-dd") + "' and R1.vin not in " + "(select R2.vin from rental R2 where (R2.from_date <= '" +
                        pickup_date_picker.Value.ToString("yyyy-MM-dd") + "' and R2.to_date >= '" + dropoff_date_picker.Value.ToString("yyyy-MM-dd") + "') or " +
                        "(R2.from_date <= '" + dropoff_date_picker.Value.ToString("yyyy-MM-dd") + "' and R2.from_date >= '" + pickup_date_picker.Value.ToString("yyyy-MM-dd") +
                        "') or (R2.to_date <= '" + dropoff_date_picker.Value.ToString("yyyy-MM-dd") + "' and R2.to_date >= '" + pickup_date_picker.Value.ToString("yyyy-MM-dd") +
                        "')) group by vin) as V, Rental R3 where V.vin = R3.vin and V.Latest_Return = R3.to_date and R3.branch_id_return = '" + pickup_location_combo.Text + "'";

                /*string vins_available = "select V.vin from (select vin, MAX(to_date) as Latest_Return from rental where to_date < '" +
                    pickup_date_picker.Value.ToString("yyyy-MM-dd") + "' group by vin) as V, Rental R where V.vin = R.vin and V.Latest_Return = R.to_date and " +
                    "R.branch_id_return = '" + pickup_location_combo.Text + "' and R.vin not in " +
                    "(select vin from rental where (from_date <= '" + pickup_date_picker.Value.ToString("yyyy-MM-dd") + "' and to_date >= '" + dropoff_date_picker.Value.ToString("yyyy-MM-dd") + "') or" +
                    "(from_date <= '" + dropoff_date_picker.Value.ToString("yyyy-MM-dd") + "' and from_date >= '" + pickup_date_picker.Value.ToString("yyyy-MM-dd") + "') or " +
                    "(to_date <= '" + dropoff_date_picker.Value.ToString("yyyy-MM-dd") + "' and to_date >= '" + pickup_date_picker.Value.ToString("yyyy-MM-dd") + "'))";*/

                string types_available = "select distinct type from Car C1 where C1.vin in (" + vins_available + ");";
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
                    label_error.ForeColor = Color.Red;
                    label_error.Text = "No vehicles available from that branch during that timeframe";
                    label_error.Visible = true;
                }
                else
                {
                    label_error.ForeColor = Color.Black;
                    label_error.Text = "Select vehicle type below";
                    label_error.Visible = true;
                    vehicle_type_combo_box.Enabled = true;
                }
            }
        }

        private void pickup_date_picker_ValueChanged(object sender, EventArgs e)
        {
            vehicle_type_combo_box.Items.Clear();
            vehicle_type_combo_box.Enabled = false;
            label_error.Visible = false;
            label_duration.Visible = false;
            duration.Visible = false;
            label_price.Visible = false;
            price.Visible = false;
            label_type_not_selected.Visible = false;

        }

        private void dropoff_date_picker_ValueChanged(object sender, EventArgs e)
        {
            vehicle_type_combo_box.Items.Clear();
            vehicle_type_combo_box.Enabled = false;
            label_error.Visible = false;
            label_duration.Visible = false;
            duration.Visible = false;
            label_price.Visible = false;
            price.Visible = false;
            label_type_not_selected.Visible = false;
        }


        private void pickup_location_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            vehicle_type_combo_box.Items.Clear();
            vehicle_type_combo_box.Enabled = false;
            label_error.Visible = false;
            label_duration.Visible = false;
            duration.Visible = false;
            label_price.Visible = false;
            price.Visible = false;
            pickup_location_details.Visible = true;
            label_type_not_selected.Visible = false;

            using (sqlConnection)
            {
                sqlCommand.CommandText = "select branch_id, building_number, street, city, province from Branch where branch_id = '" +
                    pickup_location_combo.Text + "';";
                try
                {
                    sqlReader = sqlCommand.ExecuteReader();
                    while (sqlReader.Read())
                    {
                        pickup_location_details.Text = sqlReader["building_number"].ToString() + " " +
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

        private void dropoff_location_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            vehicle_type_combo_box.Items.Clear();
            vehicle_type_combo_box.Enabled = false;
            label_error.Visible = false;
            label_duration.Visible = false;
            duration.Visible = false;
            label_price.Visible = false;
            price.Visible = false;
            label_type_not_selected.Visible = false;

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
                        dropoff_location_details.Text = sqlReader["building_number"].ToString() + " " +
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
            label_error.Visible = false;
            label_duration.Visible = false;
            duration.Visible = false;
            label_price.Visible = false;
            price.Visible = false;
            label_type_not_selected.Visible = false;
            label_type_not_selected.Visible = false;

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

        private void button_confirm_Click(object sender, EventArgs e)
        {
            bool add_success = true;

            if (button_add.Checked)
            {
                try
                {
                    sqlCommand.CommandText = "insert into Car values ('" + vin.Text + "','" +
                        make.Text + "','" + model.Text + "'," + year.Text + ",'" +
                        colour.Text + "','" + license.Text + "','" + type.Text + "')";

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
                    if (combo_branch_transfer.Text.Length > 0)
                    {
                        try
                        {
                            sqlCommand.CommandText = "insert into Rental values((select MAX(reservation_id) + 1 from Rental), '" +
                                DateTime.Now.ToString("yyyy-MM-dd") + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "', 1, '" + vin.Text +
                                "', " + combo_branch_transfer.Text + ", " + combo_branch_transfer.Text + ')';

                            MessageBox.Show(sqlCommand.CommandText);
                            sqlCommand.ExecuteNonQuery();
                            MessageBox.Show("Vehicle added and transfered to initial branch.");
                        }
                        catch (Exception e_add_transfer)
                        {
                            MessageBox.Show(e_add_transfer.ToString(), "Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vehicle Added, must transfer to a branch to be available to rent.");
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
                    MessageBox.Show("Vehicle Successfully Deleted.");
                    vin.Items.Remove(vin.SelectedItem);
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
                    sqlCommand.CommandText = "update Car set make = '" + make.Text + "', model = '" + model.Text +
                        "', year = " + year.Value.Year.ToString() + ", colour = '" + colour.Text + "', license_plate = '" +
                        license.Text + "', type = '" + type.Text + "' where vin = '" + vin.Text + "';";
                    MessageBox.Show(sqlCommand.CommandText);

                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Vehicle Successfully Modified.");
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
                            "', " + branch_current.Text + ", " + combo_branch_transfer.Text + ')';

                        MessageBox.Show(sqlCommand.CommandText);
                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Vehicle Successfully Transferred.");
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
            type.Text = string.Empty;
            make.Clear();
            model.Clear();
            colour.Clear();
            license.Clear();
            branch_current.Text = string.Empty;
            branch_info_current.Visible = false;
            label_branch_date_current.Visible = false;
            valid_vin.Visible = false;
            combo_branch_transfer.Text = string.Empty;
            branch_info_transfer.Visible = false;

            vin.Enabled = true;
            make.Enabled = true;
            type.Enabled = true;
            model.Enabled = true;
            year.Enabled = true;
            colour.Enabled = true;
            license.Enabled = true;
            combo_branch_transfer.Enabled = true;

            vin.DropDownStyle = ComboBoxStyle.Simple;
            vin.DropDownHeight = 1;
        }

        private void button_delete_CheckedChanged(object sender, EventArgs e)
        {
            vin.Items.Clear();
            vin.Text = string.Empty;
            type.Text = string.Empty;
            make.Clear();
            model.Clear();
            colour.Clear();
            license.Clear();
            branch_current.Text = string.Empty;
            branch_info_current.Text = string.Empty;
            valid_vin.Visible = false;

            vin.Enabled = true;
            make.Enabled = false;
            type.Enabled = false;
            model.Enabled = false;
            year.Enabled = false;
            colour.Enabled = false;
            license.Enabled = false;
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

        private void vin_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (button_delete.Checked || button_modify.Checked)
            {
                type.Text = string.Empty;
                make.Clear();
                model.Clear();
                colour.Clear();
                license.Clear();
                branch_current.Text = string.Empty;
                branch_info_current.Visible = false;
                label_branch_date_current.Visible = false;
                branch_info_transfer.Visible = false;

                sqlCommand.CommandText = "select * from Car where vin = '" + vin.Text + "';";
                using (sqlConnection)
                {
                    try
                    {
                        sqlReader = sqlCommand.ExecuteReader();
                        while (sqlReader.Read())
                        {
                            make.Text = sqlReader["make"].ToString();
                            type.SelectedItem = sqlReader["type"].ToString();
                            model.Text = sqlReader["model"].ToString();
                            year.Value = new DateTime((int)sqlReader["year"], 1, 1);
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
                            borked = true;
                            branch_current.Text = sqlReader["branch_id_return"].ToString();
                        }
                        sqlReader.Close();
                        borked = false;

                        sqlCommand.CommandText = "select branch_id, building_number, street, city, province from Branch where branch_id = '" +
                            branch_current.Text + "';";
                        sqlReader = sqlCommand.ExecuteReader();
                        while (sqlReader.Read())
                        {

                            branch_info_current.Text = sqlReader["building_number"].ToString() + " " + sqlReader["street"].ToString() +
                                " " + sqlReader["city"].ToString() + " " + sqlReader["province"].ToString();
                        }
                        sqlReader.Close();
                        branch_info_current.Visible = true;
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
                    combo_branch_transfer.Enabled = true;
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
            type.Text = string.Empty;
            make.Clear();
            model.Clear();
            colour.Clear();
            license.Clear();
            branch_current.Text = string.Empty;
            branch_info_current.Text = string.Empty;
            valid_vin.Visible = false;

            vin.Enabled = true;
            make.Enabled = false;
            type.Enabled = false;
            model.Enabled = false;
            year.Enabled = false;
            colour.Enabled = false;
            license.Enabled = false;
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

                case 0: // string query0 = "Name and Address of Customers who Spent Over $1000 Last Year";
                    sqlCommand.CommandText = "select X.customer_id, spent, first_name, last_name, house_number, street, city, province from " +
                        "(select sum(price) as spent, R.customer_id from pricebyrental as P, (select * from Rental where year(from_date)=year(GETDATE())-1) as R " +
                        "where R.reservation_id=P.reservation_id group by R.customer_id) as X, Customer as C where X.customer_id=C.customer_id and X.spent>=1000";
                    try
                    {
                        MessageBox.Show(sqlCommand.CommandText);
                        sqlReader = sqlCommand.ExecuteReader();
                        data_query.Columns.Clear();
                        data_query.Columns.Add("first_name", "First Name");
                        data_query.Columns.Add("last_name", "Last Name");
                        data_query.Columns.Add("house_number", "House Number");
                        data_query.Columns.Add("street", "Street");
                        data_query.Columns.Add("city", "City");
                        data_query.Columns.Add("province", "Province");
                        data_query.Rows.Clear();
                        while (sqlReader.Read())
                        {
                            data_query.Rows.Add(sqlReader["First_Name"].ToString(), sqlReader["Last_Name"].ToString(), sqlReader["House_Number"].ToString(),
                                sqlReader["Street"].ToString(), sqlReader["City"].ToString(), sqlReader["Province"].ToString());
                        }

                        sqlReader.Close();
                    }
                    catch (Exception e_executeQ0)
                    {
                        MessageBox.Show(e_executeQ0.ToString(), "Error");
                    }
                    break;




                case 1: // string query1 = "Number of Rentals by Car Type from Branches in Specified City";
                    sqlCommand.CommandText = "select C.type as 'car_type', R.branch_id_pickup as 'branch_id', count(*) as 'num_rentals' " +
                        "from Rental R, Car C where C.vin=R.vin and R.branch_id_pickup " +
                        "in (select branch_id from Branch where city='" + combo_query_option.Text + "') " +
                        "group by R.branch_id_pickup, C.type;";
                    try
                    {
                        MessageBox.Show(sqlCommand.CommandText);
                        sqlReader = sqlCommand.ExecuteReader();
                        data_query.Columns.Clear();
                        data_query.Columns.Add("num_rentals", "# of Rentals");
                        data_query.Columns.Add("car_type", "Car Type");
                        data_query.Rows.Clear();
                        while (sqlReader.Read())
                        {
                            data_query.Rows.Add(sqlReader["num_rentals"].ToString(), sqlReader["car_type"].ToString());
                        }

                        sqlReader.Close();
                    }
                    catch (Exception e_executeQ1)
                    {
                        MessageBox.Show(e_executeQ1.ToString(), "Error");
                    }
                    break;


                case 2: // string query2 = "Branches that See Less Than 100 Rentals or Returns for 3 Years in a Row";
                    sqlCommand.CommandText = "select year, branch_id from rentalsbybranchyr as X1 where X1.times < 100 AND X1.year " +
                        "IN(select year+1 from rentalsbybranchyr as X2 where X2.branch_id = X1.branch_id AND X2.times < 100 AND X2.year " +
                        "IN(select year+1 from rentalsbybranchyr as X3 where X3.branch_id = X1.branch_id AND X3.times < 100))";
                    try
                    {
                        MessageBox.Show(sqlCommand.CommandText);
                        sqlReader = sqlCommand.ExecuteReader();
                        data_query.Columns.Clear();
                        data_query.Columns.Add("branch_id", "Branch ID");
                        data_query.Columns.Add("year", "From");
                        data_query.Columns.Add("year", "To");
                        data_query.Rows.Clear();
                        while (sqlReader.Read())
                        {
                            data_query.Rows.Add(sqlReader["branch_id"].ToString(), (sqlReader.GetInt32("year") - 2).ToString(), sqlReader["year"].ToString());
                        }

                        sqlReader.Close();
                    }
                    catch (Exception e_executeQ2)
                    {
                        MessageBox.Show(e_executeQ2.ToString(), "Error");
                    }
                    break;


                case 3: // string query3 = "Percentage Share of Rentals by all Branches";
                    sqlCommand.CommandText = "select branch_id_pickup as 'pickup/return branch', " +
                        "(count(*)*100)/(select count(*) from Rental) as 'percent' from Rental as R " +
                        "group by branch_id_pickup UNION ALL select null as 'pickup/return branch', null as 'percent' UNION ALL " +
                        "select branch_id_return as 'pickup/return branch', (count(*)*100)/(select count(*) from Rental) as 'percent' from Rental as R " +
                        "group by branch_id_return;";
                    try
                    {
                        MessageBox.Show(sqlCommand.CommandText);
                        sqlReader = sqlCommand.ExecuteReader();
                        data_query.Columns.Clear();
                        data_query.Columns.Add("pickup_return", "Branch ID");
                        data_query.Columns.Add("type", "Type");
                        data_query.Columns.Add("percent", "Percent of Rentals");
                        data_query.Rows.Clear();
                        bool pickup = true;
                        string type_pickup_return = "Pickup";
                        while (sqlReader.Read())
                        {
                            if (sqlReader["pickup/return branch"].ToString() != string.Empty)
                            {
                                data_query.Rows.Add(sqlReader["pickup/return branch"].ToString(), type_pickup_return, sqlReader["percent"].ToString());
                            }
                            else
                            {
                                data_query.Rows.Add(sqlReader["pickup/return branch"].ToString(), "", sqlReader["percent"].ToString());
                                type_pickup_return = "Return";
                            }
                        }

                        sqlReader.Close();
                    }
                    catch (Exception e_executeQ3)
                    {
                        MessageBox.Show(e_executeQ3.ToString(), "Error");
                    }
                    break;


                case 4: // string query4 = "Stock of All Vehicles Across All Locations";
                    sqlCommand.CommandText = "select 'All Branches' as city, sum(vehicle_stock) as available_vehs, 0 as branch_id, 0 as building_number, " +
                        "'' as street, '' as province from vehstockbybranch UNION ALL select city, vehicle_stock, B.branch_id, building_number, " +
                        "street, province from Branch as B, vehstockbybranch as V where B.branch_id=V.branch_id order by city";
                    try
                    {
                        MessageBox.Show(sqlCommand.CommandText);
                        sqlReader = sqlCommand.ExecuteReader();
                        data_query.Columns.Clear();
                        data_query.Columns.Add("city", "City");
                        data_query.Columns.Add("available_vehs", "Available Vehicles");
                        data_query.Columns.Add("branch_id", "Branch ID");
                        data_query.Columns.Add("building_number", "Building Number");
                        data_query.Columns.Add("street", "Street");
                        data_query.Columns.Add("province", "Province");
                        data_query.Rows.Clear();
                        sqlReader.Read();
                        data_query.Rows.Add(sqlReader["city"].ToString(), sqlReader["available_vehs"].ToString());
                        while (sqlReader.Read())
                        {
                            data_query.Rows.Add(sqlReader["city"].ToString(), sqlReader["available_vehs"].ToString(), sqlReader["branch_id"].ToString(),
                                sqlReader["building_number"].ToString(), sqlReader["street"].ToString(), sqlReader["province"].ToString());
                        }

                        sqlReader.Close();
                    }
                    catch (Exception e_executeQ4)
                    {
                        MessageBox.Show(e_executeQ4.ToString(), "Error");
                    }
                    break;
            }


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
                        branch_info_transfer.Text = sqlReader["building_number"].ToString() + " " +
                            sqlReader["street"].ToString() + " " + sqlReader["city"].ToString() + " " + sqlReader["province"].ToString();
                    }
                    sqlReader.Close();
                }
                catch (Exception e_branchinfo_curr)
                {
                    MessageBox.Show(e_branchinfo_curr.ToString(), "Error");
                }
            }
            branch_info_transfer.Visible = true;
        }

        private void confirm_button_Click(object sender, EventArgs e)
        {
            string id;
            string vin_rented;
            if (vehicle_type_combo_box.Text.Length == 0)
            {
                label_type_not_selected.Visible = true;
            }
            else
            {
                if (!IsUserAuthenticated)
                {
                    id = customer_id.ToString();
                }
                else
                {
                    id = customer_id_input.Text;
                }

                string vins_available = "select V.vin from (select vin, MAX(to_date) as Latest_Return from rental R1 where R1.to_date < '" +
                    pickup_date_picker.Value.ToString("yyyy-MM-dd") + "' and R1.vin not in " + "(select R2.vin from rental R2 where (R2.from_date <= '" +
                    pickup_date_picker.Value.ToString("yyyy-MM-dd") + "' and R2.to_date >= '" + dropoff_date_picker.Value.ToString("yyyy-MM-dd") + "') or " +
                    "(R2.from_date <= '" + dropoff_date_picker.Value.ToString("yyyy-MM-dd") + "' and R2.from_date >= '" + pickup_date_picker.Value.ToString("yyyy-MM-dd") +
                    "') or (R2.to_date <= '" + dropoff_date_picker.Value.ToString("yyyy-MM-dd") + "' and R2.to_date >= '" + pickup_date_picker.Value.ToString("yyyy-MM-dd") +
                    "')) group by vin) as V, Rental R3 where V.vin = R3.vin and V.Latest_Return = R3.to_date and R3.branch_id_return = '" + pickup_location_combo.Text + "'";

                /*string vins_available = "select V.vin from (select vin, MAX(to_date) as Latest_Return from rental where to_date < '" +
                    pickup_date_picker.Value.ToString("yyyy-MM-dd") + "' group by vin) as V, Rental R where V.vin = R.vin and V.Latest_Return = R.to_date and " +
                    "R.branch_id_return = '" + pickup_location_combo.Text + "' and R.vin not in " +
                    "(select vin from rental where (from_date <= '" + pickup_date_picker.Value.ToString("yyyy-MM-dd") + "' and to_date >= '" + dropoff_date_picker.Value.ToString("yyyy-MM-dd") + "') or" +
                    "(from_date <= '" + dropoff_date_picker.Value.ToString("yyyy-MM-dd") + "' and from_date >= '" + pickup_date_picker.Value.ToString("yyyy-MM-dd") + "') or " +
                    "(to_date <= '" + dropoff_date_picker.Value.ToString("yyyy-MM-dd") + "' and to_date >= '" + pickup_date_picker.Value.ToString("yyyy-MM-dd") + "'))";*/

                string vin_selected = "select min(vin) from Car C1 where C1.type = '" + vehicle_type_combo_box.Text + "' and C1.vin in (" + vins_available + ")";

                using (sqlConnection)
                {
                    sqlCommand.CommandText = "select * from Car where vin = (" + vin_selected + ");";
                    sqlReader = sqlCommand.ExecuteReader();
                    sqlReader.Read();
                    vin_rented = sqlReader["vin"].ToString();
                    string confirm_msg = "Confirming rental for " + sqlReader["year"].ToString() + " " + sqlReader["make"].ToString() + " " + sqlReader["model"] + ", Vin # " + vin_rented;
                    MessageBox.Show(confirm_msg);
                    sqlReader.Close();
                }
                string rented = "insert into rental values ((select (max(reservation_id) + 1) from rental), '" + pickup_date_picker.Value.ToString("yyyy-MM-dd") + "', '" + dropoff_date_picker.Value.ToString("yyyy-MM-dd") + "', " +
                    id + ", '" + vin_rented + "', '" + pickup_location_combo.Text + "', '" + dropoff_location_combo.Text + "')";

                MessageBox.Show(rented);
                using (sqlConnection)
                {
                    sqlCommand.CommandText = rented;
                    sqlCommand.ExecuteNonQuery();
                }
                MessageBox.Show("Rental confirmed.");
            }

        }

    }
}
