﻿namespace CMPT291Project
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            vehicle_type_combo_box = new ComboBox();
            tabControl1 = new TabControl();
            tab_rental = new TabPage();
            customer_id_input = new ComboBox();
            label_type_not_selected = new Label();
            customer_id_label = new Label();
            price = new Label();
            duration = new Label();
            label_price = new Label();
            label_duration = new Label();
            dropoff_location_details = new Label();
            pickup_location_details = new Label();
            label_error = new Label();
            confirm_button = new Button();
            dropoff_location_combo = new ComboBox();
            pickup_location_combo = new ComboBox();
            dropoff_location_label = new Label();
            pickup_location_label = new Label();
            search_button = new Button();
            dropoff_date_label = new Label();
            dropoff_date_picker = new DateTimePicker();
            pickup_date_label = new Label();
            pickup_date_picker = new DateTimePicker();
            vehicle_type_label = new Label();
            tab_car = new TabPage();
            label_return_branch_details = new Label();
            label9 = new Label();
            label4 = new Label();
            branch_current = new Label();
            year = new DateTimePicker();
            label_branch_date_current = new Label();
            combo_branch_transfer = new ComboBox();
            branch_info_transfer = new Label();
            label_branch_transfer = new Label();
            valid_vin = new Label();
            branch_info_current = new Label();
            type = new ComboBox();
            button_delete = new RadioButton();
            button_modify = new RadioButton();
            button_add = new RadioButton();
            make = new TextBox();
            colour = new TextBox();
            license = new TextBox();
            model = new TextBox();
            vin = new ComboBox();
            button_confirm = new Button();
            label3 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label_branch_current = new Label();
            label2 = new Label();
            label1 = new Label();
            label_vin = new Label();
            tab_query = new TabPage();
            combo_query_option = new ComboBox();
            label_query_option = new Label();
            label_query = new Label();
            button_query = new Button();
            combo_query = new ComboBox();
            data_query = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            tabControl1.SuspendLayout();
            tab_rental.SuspendLayout();
            tab_car.SuspendLayout();
            tab_query.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_query).BeginInit();
            SuspendLayout();
            // 
            // vehicle_type_combo_box
            // 
            vehicle_type_combo_box.DropDownStyle = ComboBoxStyle.DropDownList;
            vehicle_type_combo_box.FormattingEnabled = true;
            vehicle_type_combo_box.Location = new Point(161, 356);
            vehicle_type_combo_box.Name = "vehicle_type_combo_box";
            vehicle_type_combo_box.Size = new Size(250, 28);
            vehicle_type_combo_box.TabIndex = 9;
            vehicle_type_combo_box.SelectedIndexChanged += vehicle_type_combo_box_SelectedIndexChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tab_rental);
            tabControl1.Controls.Add(tab_car);
            tabControl1.Controls.Add(tab_query);
            tabControl1.Location = new Point(11, 13);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(960, 540);
            tabControl1.TabIndex = 0;
            // 
            // tab_rental
            // 
            tab_rental.BackColor = Color.LightGray;
            tab_rental.BackgroundImage = (Image)resources.GetObject("tab_rental.BackgroundImage");
            tab_rental.BackgroundImageLayout = ImageLayout.Stretch;
            tab_rental.Controls.Add(customer_id_input);
            tab_rental.Controls.Add(label_type_not_selected);
            tab_rental.Controls.Add(customer_id_label);
            tab_rental.Controls.Add(price);
            tab_rental.Controls.Add(duration);
            tab_rental.Controls.Add(label_price);
            tab_rental.Controls.Add(label_duration);
            tab_rental.Controls.Add(dropoff_location_details);
            tab_rental.Controls.Add(pickup_location_details);
            tab_rental.Controls.Add(label_error);
            tab_rental.Controls.Add(confirm_button);
            tab_rental.Controls.Add(dropoff_location_combo);
            tab_rental.Controls.Add(pickup_location_combo);
            tab_rental.Controls.Add(dropoff_location_label);
            tab_rental.Controls.Add(pickup_location_label);
            tab_rental.Controls.Add(search_button);
            tab_rental.Controls.Add(dropoff_date_label);
            tab_rental.Controls.Add(dropoff_date_picker);
            tab_rental.Controls.Add(pickup_date_label);
            tab_rental.Controls.Add(pickup_date_picker);
            tab_rental.Controls.Add(vehicle_type_label);
            tab_rental.Controls.Add(vehicle_type_combo_box);
            tab_rental.Location = new Point(4, 29);
            tab_rental.Margin = new Padding(3, 4, 3, 4);
            tab_rental.Name = "tab_rental";
            tab_rental.Padding = new Padding(3, 4, 3, 4);
            tab_rental.Size = new Size(952, 507);
            tab_rental.TabIndex = 0;
            tab_rental.Text = "Rental";
            // 
            // customer_id_input
            // 
            customer_id_input.FormattingEnabled = true;
            customer_id_input.Location = new Point(766, 32);
            customer_id_input.Name = "customer_id_input";
            customer_id_input.Size = new Size(121, 28);
            customer_id_input.TabIndex = 7;
            // 
            // label_type_not_selected
            // 
            label_type_not_selected.AutoSize = true;
            label_type_not_selected.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_type_not_selected.ForeColor = Color.Red;
            label_type_not_selected.Location = new Point(650, 304);
            label_type_not_selected.Name = "label_type_not_selected";
            label_type_not_selected.Size = new Size(244, 28);
            label_type_not_selected.TabIndex = 31;
            label_type_not_selected.Text = "Please select a vehicle type";
            label_type_not_selected.Visible = false;
            // 
            // customer_id_label
            // 
            customer_id_label.AutoSize = true;
            customer_id_label.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            customer_id_label.Location = new Point(659, 32);
            customer_id_label.Name = "customer_id_label";
            customer_id_label.Size = new Size(106, 23);
            customer_id_label.TabIndex = 30;
            customer_id_label.Text = "Customer ID";
            // 
            // price
            // 
            price.AutoSize = true;
            price.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            price.Location = new Point(161, 436);
            price.Name = "price";
            price.Size = new Size(62, 28);
            price.TabIndex = 26;
            price.Text = "PRICE";
            price.Visible = false;
            // 
            // duration
            // 
            duration.AutoSize = true;
            duration.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            duration.Location = new Point(161, 397);
            duration.Name = "duration";
            duration.Size = new Size(158, 23);
            duration.TabIndex = 25;
            duration.Text = "RENTAL DURATION";
            duration.Visible = false;
            // 
            // label_price
            // 
            label_price.AutoSize = true;
            label_price.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_price.Location = new Point(38, 436);
            label_price.Name = "label_price";
            label_price.Size = new Size(130, 28);
            label_price.TabIndex = 24;
            label_price.Text = "Quoted Price:";
            label_price.Visible = false;
            // 
            // label_duration
            // 
            label_duration.AutoSize = true;
            label_duration.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_duration.Location = new Point(31, 397);
            label_duration.Name = "label_duration";
            label_duration.Size = new Size(134, 23);
            label_duration.TabIndex = 23;
            label_duration.Text = "Rental Duration:";
            label_duration.Visible = false;
            // 
            // dropoff_location_details
            // 
            dropoff_location_details.AutoSize = true;
            dropoff_location_details.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dropoff_location_details.Location = new Point(637, 191);
            dropoff_location_details.Name = "dropoff_location_details";
            dropoff_location_details.Size = new Size(237, 23);
            dropoff_location_details.TabIndex = 21;
            dropoff_location_details.Text = "DROPOFF LOCATION DETAILS";
            dropoff_location_details.Visible = false;
            // 
            // pickup_location_details
            // 
            pickup_location_details.AutoSize = true;
            pickup_location_details.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            pickup_location_details.Location = new Point(161, 191);
            pickup_location_details.Name = "pickup_location_details";
            pickup_location_details.Size = new Size(221, 23);
            pickup_location_details.TabIndex = 20;
            pickup_location_details.Text = "PICKUP LOCATION DETAILS";
            pickup_location_details.Visible = false;
            // 
            // label_error
            // 
            label_error.AutoSize = true;
            label_error.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_error.ForeColor = Color.Red;
            label_error.Location = new Point(161, 304);
            label_error.Name = "label_error";
            label_error.Size = new Size(194, 28);
            label_error.TabIndex = 19;
            label_error.Text = "No vehicles available";
            label_error.Visible = false;
            // 
            // confirm_button
            // 
            confirm_button.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            confirm_button.Location = new Point(637, 343);
            confirm_button.Margin = new Padding(3, 4, 3, 4);
            confirm_button.Name = "confirm_button";
            confirm_button.Size = new Size(250, 125);
            confirm_button.TabIndex = 10;
            confirm_button.Text = "Confirm Booking";
            confirm_button.UseVisualStyleBackColor = true;
            confirm_button.Click += confirm_button_Click;
            // 
            // dropoff_location_combo
            // 
            dropoff_location_combo.DropDownStyle = ComboBoxStyle.DropDownList;
            dropoff_location_combo.FormattingEnabled = true;
            dropoff_location_combo.Location = new Point(637, 159);
            dropoff_location_combo.Name = "dropoff_location_combo";
            dropoff_location_combo.Size = new Size(250, 28);
            dropoff_location_combo.TabIndex = 6;
            dropoff_location_combo.SelectedIndexChanged += dropoff_location_combo_SelectedIndexChanged;
            // 
            // pickup_location_combo
            // 
            pickup_location_combo.DropDownStyle = ComboBoxStyle.DropDownList;
            pickup_location_combo.FormattingEnabled = true;
            pickup_location_combo.Location = new Point(161, 157);
            pickup_location_combo.Name = "pickup_location_combo";
            pickup_location_combo.Size = new Size(250, 28);
            pickup_location_combo.TabIndex = 5;
            pickup_location_combo.SelectedIndexChanged += pickup_location_combo_SelectedIndexChanged;
            // 
            // dropoff_location_label
            // 
            dropoff_location_label.AutoSize = true;
            dropoff_location_label.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dropoff_location_label.Location = new Point(502, 155);
            dropoff_location_label.Name = "dropoff_location_label";
            dropoff_location_label.Size = new Size(138, 23);
            dropoff_location_label.TabIndex = 10;
            dropoff_location_label.Text = "Dropoff Location";
            // 
            // pickup_location_label
            // 
            pickup_location_label.AutoSize = true;
            pickup_location_label.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            pickup_location_label.Location = new Point(38, 159);
            pickup_location_label.Name = "pickup_location_label";
            pickup_location_label.Size = new Size(130, 23);
            pickup_location_label.TabIndex = 8;
            pickup_location_label.Text = "Pickup Location";
            // 
            // search_button
            // 
            search_button.BackColor = Color.White;
            search_button.Location = new Point(161, 233);
            search_button.Name = "search_button";
            search_button.Size = new Size(250, 53);
            search_button.TabIndex = 8;
            search_button.Text = "Search For Availability";
            search_button.UseVisualStyleBackColor = false;
            search_button.Click += search_button_Click_1;
            // 
            // dropoff_date_label
            // 
            dropoff_date_label.AutoSize = true;
            dropoff_date_label.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dropoff_date_label.Location = new Point(528, 113);
            dropoff_date_label.Name = "dropoff_date_label";
            dropoff_date_label.Size = new Size(109, 23);
            dropoff_date_label.TabIndex = 5;
            dropoff_date_label.Text = "Dropoff Date";
            // 
            // dropoff_date_picker
            // 
            dropoff_date_picker.Location = new Point(637, 113);
            dropoff_date_picker.Name = "dropoff_date_picker";
            dropoff_date_picker.Size = new Size(250, 27);
            dropoff_date_picker.TabIndex = 4;
            dropoff_date_picker.Value = new DateTime(2023, 6, 7, 0, 0, 0, 0);
            dropoff_date_picker.ValueChanged += dropoff_date_picker_ValueChanged;
            // 
            // pickup_date_label
            // 
            pickup_date_label.AutoSize = true;
            pickup_date_label.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            pickup_date_label.Location = new Point(62, 113);
            pickup_date_label.Name = "pickup_date_label";
            pickup_date_label.Size = new Size(101, 23);
            pickup_date_label.TabIndex = 3;
            pickup_date_label.Text = "Pickup Date";
            // 
            // pickup_date_picker
            // 
            pickup_date_picker.Location = new Point(161, 113);
            pickup_date_picker.Name = "pickup_date_picker";
            pickup_date_picker.Size = new Size(250, 27);
            pickup_date_picker.TabIndex = 2;
            pickup_date_picker.Value = new DateTime(2023, 6, 1, 0, 0, 0, 0);
            pickup_date_picker.ValueChanged += pickup_date_picker_ValueChanged;
            // 
            // vehicle_type_label
            // 
            vehicle_type_label.AutoSize = true;
            vehicle_type_label.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            vehicle_type_label.Location = new Point(61, 356);
            vehicle_type_label.Name = "vehicle_type_label";
            vehicle_type_label.Size = new Size(104, 23);
            vehicle_type_label.TabIndex = 1;
            vehicle_type_label.Text = "Vehicle Type";
            // 
            // tab_car
            // 
            tab_car.Controls.Add(label_return_branch_details);
            tab_car.Controls.Add(label9);
            tab_car.Controls.Add(label4);
            tab_car.Controls.Add(branch_current);
            tab_car.Controls.Add(year);
            tab_car.Controls.Add(label_branch_date_current);
            tab_car.Controls.Add(combo_branch_transfer);
            tab_car.Controls.Add(branch_info_transfer);
            tab_car.Controls.Add(label_branch_transfer);
            tab_car.Controls.Add(valid_vin);
            tab_car.Controls.Add(branch_info_current);
            tab_car.Controls.Add(type);
            tab_car.Controls.Add(button_delete);
            tab_car.Controls.Add(button_modify);
            tab_car.Controls.Add(button_add);
            tab_car.Controls.Add(make);
            tab_car.Controls.Add(colour);
            tab_car.Controls.Add(license);
            tab_car.Controls.Add(model);
            tab_car.Controls.Add(vin);
            tab_car.Controls.Add(button_confirm);
            tab_car.Controls.Add(label3);
            tab_car.Controls.Add(label8);
            tab_car.Controls.Add(label7);
            tab_car.Controls.Add(label6);
            tab_car.Controls.Add(label5);
            tab_car.Controls.Add(label_branch_current);
            tab_car.Controls.Add(label2);
            tab_car.Controls.Add(label1);
            tab_car.Controls.Add(label_vin);
            tab_car.Location = new Point(4, 29);
            tab_car.Margin = new Padding(3, 4, 3, 4);
            tab_car.Name = "tab_car";
            tab_car.Padding = new Padding(3, 4, 3, 4);
            tab_car.Size = new Size(952, 507);
            tab_car.TabIndex = 1;
            tab_car.Text = "Cars";
            tab_car.UseVisualStyleBackColor = true;
            // 
            // label_return_branch_details
            // 
            label_return_branch_details.AutoSize = true;
            label_return_branch_details.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_return_branch_details.Location = new Point(529, 232);
            label_return_branch_details.Name = "label_return_branch_details";
            label_return_branch_details.Size = new Size(123, 23);
            label_return_branch_details.TabIndex = 22;
            label_return_branch_details.Text = "Branch Details:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(497, 149);
            label9.Name = "label9";
            label9.Size = new Size(156, 23);
            label9.TabIndex = 21;
            label9.Text = "Latest Return Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(529, 124);
            label4.Name = "label4";
            label4.Size = new Size(123, 23);
            label4.TabIndex = 20;
            label4.Text = "Branch Details:";
            // 
            // branch_current
            // 
            branch_current.AutoSize = true;
            branch_current.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            branch_current.Location = new Point(649, 99);
            branch_current.Name = "branch_current";
            branch_current.Size = new Size(156, 23);
            branch_current.TabIndex = 19;
            branch_current.Text = "CURRENT BRANCH";
            // 
            // year
            // 
            year.AccessibleRole = AccessibleRole.Sound;
            year.CustomFormat = "yyyy";
            year.Format = DateTimePickerFormat.Custom;
            year.Location = new Point(191, 336);
            year.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            year.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            year.Name = "year";
            year.RightToLeftLayout = true;
            year.ShowUpDown = true;
            year.Size = new Size(148, 27);
            year.TabIndex = 8;
            // 
            // label_branch_date_current
            // 
            label_branch_date_current.AutoSize = true;
            label_branch_date_current.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_branch_date_current.Location = new Point(649, 149);
            label_branch_date_current.Name = "label_branch_date_current";
            label_branch_date_current.Size = new Size(104, 23);
            label_branch_date_current.TabIndex = 18;
            label_branch_date_current.Text = "Branch Date";
            label_branch_date_current.Visible = false;
            // 
            // combo_branch_transfer
            // 
            combo_branch_transfer.FormattingEnabled = true;
            combo_branch_transfer.Location = new Point(649, 197);
            combo_branch_transfer.Margin = new Padding(3, 4, 3, 4);
            combo_branch_transfer.Name = "combo_branch_transfer";
            combo_branch_transfer.Size = new Size(205, 28);
            combo_branch_transfer.TabIndex = 12;
            combo_branch_transfer.SelectedIndexChanged += combo_branch_transfer_SelectedIndexChanged;
            // 
            // branch_info_transfer
            // 
            branch_info_transfer.AutoSize = true;
            branch_info_transfer.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            branch_info_transfer.Location = new Point(649, 232);
            branch_info_transfer.Name = "branch_info_transfer";
            branch_info_transfer.Size = new Size(158, 23);
            branch_info_transfer.TabIndex = 16;
            branch_info_transfer.Text = "Branch Information";
            branch_info_transfer.Visible = false;
            // 
            // label_branch_transfer
            // 
            label_branch_transfer.AutoSize = true;
            label_branch_transfer.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_branch_transfer.Location = new Point(487, 197);
            label_branch_transfer.Name = "label_branch_transfer";
            label_branch_transfer.Size = new Size(169, 23);
            label_branch_transfer.TabIndex = 15;
            label_branch_transfer.Text = "Tranfer To Branch ID:";
            // 
            // valid_vin
            // 
            valid_vin.AutoSize = true;
            valid_vin.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            valid_vin.ForeColor = Color.Red;
            valid_vin.Location = new Point(191, 133);
            valid_vin.Name = "valid_vin";
            valid_vin.Size = new Size(90, 23);
            valid_vin.TabIndex = 14;
            valid_vin.Text = "Invalid Vin";
            valid_vin.Visible = false;
            // 
            // branch_info_current
            // 
            branch_info_current.AutoSize = true;
            branch_info_current.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            branch_info_current.Location = new Point(649, 124);
            branch_info_current.Name = "branch_info_current";
            branch_info_current.Size = new Size(158, 23);
            branch_info_current.TabIndex = 13;
            branch_info_current.Text = "Branch Information";
            branch_info_current.Visible = false;
            // 
            // type
            // 
            type.DropDownStyle = ComboBoxStyle.DropDownList;
            type.FormattingEnabled = true;
            type.Location = new Point(191, 197);
            type.Margin = new Padding(3, 4, 3, 4);
            type.Name = "type";
            type.Size = new Size(235, 28);
            type.TabIndex = 5;
            // 
            // button_delete
            // 
            button_delete.AutoSize = true;
            button_delete.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button_delete.Location = new Point(259, 48);
            button_delete.Margin = new Padding(3, 4, 3, 4);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(80, 27);
            button_delete.TabIndex = 2;
            button_delete.Text = "Delete";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.CheckedChanged += button_delete_CheckedChanged;
            // 
            // button_modify
            // 
            button_modify.AutoSize = true;
            button_modify.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button_modify.Location = new Point(343, 48);
            button_modify.Margin = new Padding(3, 4, 3, 4);
            button_modify.Name = "button_modify";
            button_modify.Size = new Size(83, 27);
            button_modify.TabIndex = 3;
            button_modify.Text = "Modify";
            button_modify.UseVisualStyleBackColor = true;
            button_modify.CheckedChanged += button_modify_CheckedChanged;
            // 
            // button_add
            // 
            button_add.AutoSize = true;
            button_add.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button_add.Location = new Point(191, 48);
            button_add.Margin = new Padding(3, 4, 3, 4);
            button_add.Name = "button_add";
            button_add.Size = new Size(62, 27);
            button_add.TabIndex = 1;
            button_add.Text = "Add";
            button_add.UseVisualStyleBackColor = true;
            button_add.CheckedChanged += button_add_CheckedChanged;
            // 
            // make
            // 
            make.Location = new Point(191, 243);
            make.Margin = new Padding(3, 4, 3, 4);
            make.Name = "make";
            make.Size = new Size(148, 27);
            make.TabIndex = 6;
            // 
            // colour
            // 
            colour.Location = new Point(191, 376);
            colour.Margin = new Padding(3, 4, 3, 4);
            colour.Name = "colour";
            colour.Size = new Size(148, 27);
            colour.TabIndex = 9;
            // 
            // license
            // 
            license.Location = new Point(191, 427);
            license.Margin = new Padding(3, 4, 3, 4);
            license.Name = "license";
            license.Size = new Size(148, 27);
            license.TabIndex = 10;
            // 
            // model
            // 
            model.Location = new Point(191, 289);
            model.Margin = new Padding(3, 4, 3, 4);
            model.Name = "model";
            model.Size = new Size(148, 27);
            model.TabIndex = 7;
            // 
            // vin
            // 
            vin.FormattingEnabled = true;
            vin.IntegralHeight = false;
            vin.Location = new Point(191, 99);
            vin.Margin = new Padding(3, 4, 3, 4);
            vin.Name = "vin";
            vin.Size = new Size(235, 28);
            vin.TabIndex = 4;
            vin.SelectedIndexChanged += vin_SelectedIndexChanged;
            vin.Leave += vin_Leave;
            // 
            // button_confirm
            // 
            button_confirm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_confirm.Location = new Point(529, 299);
            button_confirm.Margin = new Padding(3, 4, 3, 4);
            button_confirm.Name = "button_confirm";
            button_confirm.Size = new Size(350, 155);
            button_confirm.TabIndex = 13;
            button_confirm.Text = "Confirm";
            button_confirm.UseVisualStyleBackColor = true;
            button_confirm.Click += button_confirm_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(93, 51);
            label3.Name = "label3";
            label3.Size = new Size(63, 23);
            label3.TabIndex = 10;
            label3.Text = "Action:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(107, 203);
            label8.Name = "label8";
            label8.Size = new Size(49, 23);
            label8.TabIndex = 8;
            label8.Text = "Type:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(91, 380);
            label7.Name = "label7";
            label7.Size = new Size(65, 23);
            label7.TabIndex = 7;
            label7.Text = "Colour:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(110, 339);
            label6.Name = "label6";
            label6.Size = new Size(46, 23);
            label6.TabIndex = 6;
            label6.Text = "Year:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(43, 427);
            label5.Name = "label5";
            label5.Size = new Size(112, 23);
            label5.TabIndex = 5;
            label5.Text = "License Plate:";
            // 
            // label_branch_current
            // 
            label_branch_current.AutoSize = true;
            label_branch_current.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_branch_current.Location = new Point(462, 99);
            label_branch_current.Name = "label_branch_current";
            label_branch_current.Size = new Size(195, 23);
            label_branch_current.TabIndex = 4;
            label_branch_current.Text = "Latest Return Branch ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(101, 247);
            label2.Name = "label2";
            label2.Size = new Size(55, 23);
            label2.TabIndex = 2;
            label2.Text = "Make:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(94, 293);
            label1.Name = "label1";
            label1.Size = new Size(62, 23);
            label1.TabIndex = 1;
            label1.Text = "Model:";
            // 
            // label_vin
            // 
            label_vin.AutoSize = true;
            label_vin.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_vin.Location = new Point(113, 99);
            label_vin.Name = "label_vin";
            label_vin.Size = new Size(43, 23);
            label_vin.TabIndex = 0;
            label_vin.Text = "VIN:";
            // 
            // tab_query
            // 
            tab_query.Controls.Add(combo_query_option);
            tab_query.Controls.Add(label_query_option);
            tab_query.Controls.Add(label_query);
            tab_query.Controls.Add(button_query);
            tab_query.Controls.Add(combo_query);
            tab_query.Controls.Add(data_query);
            tab_query.Location = new Point(4, 29);
            tab_query.Margin = new Padding(3, 4, 3, 4);
            tab_query.Name = "tab_query";
            tab_query.Padding = new Padding(3, 4, 3, 4);
            tab_query.Size = new Size(952, 507);
            tab_query.TabIndex = 2;
            tab_query.Text = "Query";
            tab_query.UseVisualStyleBackColor = true;
            // 
            // combo_query_option
            // 
            combo_query_option.FormattingEnabled = true;
            combo_query_option.Location = new Point(158, 469);
            combo_query_option.Margin = new Padding(3, 4, 3, 4);
            combo_query_option.Name = "combo_query_option";
            combo_query_option.Size = new Size(459, 28);
            combo_query_option.TabIndex = 2;
            // 
            // label_query_option
            // 
            label_query_option.AutoSize = true;
            label_query_option.Location = new Point(48, 472);
            label_query_option.Name = "label_query_option";
            label_query_option.Size = new Size(101, 20);
            label_query_option.TabIndex = 4;
            label_query_option.Text = "Query Option:";
            // 
            // label_query
            // 
            label_query.AutoSize = true;
            label_query.Location = new Point(40, 435);
            label_query.Name = "label_query";
            label_query.Size = new Size(112, 20);
            label_query.TabIndex = 3;
            label_query.Text = "Selected Query:";
            // 
            // button_query
            // 
            button_query.Location = new Point(662, 431);
            button_query.Margin = new Padding(3, 4, 3, 4);
            button_query.Name = "button_query";
            button_query.Size = new Size(245, 61);
            button_query.TabIndex = 3;
            button_query.Text = "Run Query";
            button_query.UseVisualStyleBackColor = true;
            button_query.Click += button_query_Click;
            // 
            // combo_query
            // 
            combo_query.FormattingEnabled = true;
            combo_query.Location = new Point(158, 431);
            combo_query.Margin = new Padding(3, 4, 3, 4);
            combo_query.Name = "combo_query";
            combo_query.Size = new Size(459, 28);
            combo_query.TabIndex = 1;
            combo_query.SelectedIndexChanged += combo_query_SelectedIndexChanged;
            // 
            // data_query
            // 
            data_query.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_query.Location = new Point(7, 8);
            data_query.Margin = new Padding(3, 4, 3, 4);
            data_query.Name = "data_query";
            data_query.RowHeadersWidth = 51;
            data_query.RowTemplate.Height = 25;
            data_query.Size = new Size(939, 408);
            data_query.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 567);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "Car Rental";
            tabControl1.ResumeLayout(false);
            tab_rental.ResumeLayout(false);
            tab_rental.PerformLayout();
            tab_car.ResumeLayout(false);
            tab_car.PerformLayout();
            tab_query.ResumeLayout(false);
            tab_query.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)data_query).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabPage tab_rental;
        private TabPage tab_car;
        private TabPage tab_query;
        private Label vehicle_type_label;
        private ComboBox vehicle_type_combo_box;
        private ComboBox dropoff_location_combo;
        private ComboBox pickup_location_combo;
        private Label dropoff_location_label;
        private Label pickup_location_label;
        private Button search_button;
        private Label dropoff_date_label;
        private DateTimePicker dropoff_date_picker;
        private Label pickup_date_label;
        private DateTimePicker pickup_date_picker;
        private Label label_vin;
        private Label label2;
        private Label label1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label_branch_current;
        private TextBox make;
        private TextBox last_year;
        private TextBox colour;
        private TextBox license;
        private TextBox model;
        private ComboBox vin;
        private Button button_confirm;
        private Label label3;
        private RadioButton button_delete;
        private RadioButton button_modify;
        private RadioButton button_add;
        private ComboBox type;
        private Label branch_info_current;
        private Label valid_vin;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button confirm_button;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Label label_error;
        private DataGridView data_query;
        private Label dropoff_location_details;
        private Label pickup_location_details;
        private ComboBox combo_query;
        private Button button_query;
        private Label label_query;
        private ComboBox combo_query_option;
        private Label label_query_option;
        private Label price;
        private Label duration;
        private Label label_price;
        private Label label_duration;
        private Label label_branch_transfer;
        private ComboBox combo_branch_transfer;
        private Label branch_info_transfer;
        private Label label_branch_date_current;
        public TabControl tabControl1;
        public Label customer_id_label;
        private DateTimePicker year;
        private Label label_type_not_selected;
        private Label branch_current;
        private Label label_return_branch_details;
        private Label label9;
        private Label label4;
        private ComboBox customer_id_input;
    }
}