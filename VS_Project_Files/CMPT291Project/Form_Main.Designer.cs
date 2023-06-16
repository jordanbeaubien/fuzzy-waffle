namespace CMPT291Project
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            vehicle_type_combo_box = new ComboBox();
            tabControl1 = new TabControl();
            tab_rental = new TabPage();
            customer_id_label = new Label();
            customer_id_input = new TextBox();
            label_location_error = new Label();
            label_date_error = new Label();
            price = new Label();
            duration = new Label();
            label_price = new Label();
            label_duration = new Label();
            button_quote = new Button();
            dropoff_location_details = new Label();
            pickup_location_details = new Label();
            label_available = new Label();
            confirm_button = new Button();
            return_same_loc_checkbox = new CheckBox();
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
            year = new DateTimePicker();
            label_branch_date_current = new Label();
            combo_branch_transfer = new ComboBox();
            label_branch_info_transfer = new Label();
            label_branch_transfer = new Label();
            valid_vin = new Label();
            label_branch_info_current = new Label();
            type = new ComboBox();
            combo_branch_current = new ComboBox();
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
            vehicle_type_combo_box.Location = new Point(557, 88);
            vehicle_type_combo_box.Margin = new Padding(3, 2, 3, 2);
            vehicle_type_combo_box.Name = "vehicle_type_combo_box";
            vehicle_type_combo_box.Size = new Size(219, 23);
            vehicle_type_combo_box.TabIndex = 0;
            vehicle_type_combo_box.SelectedIndexChanged += vehicle_type_combo_box_SelectedIndexChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tab_rental);
            tabControl1.Controls.Add(tab_car);
            tabControl1.Controls.Add(tab_query);
            tabControl1.Location = new Point(10, 10);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(840, 405);
            tabControl1.TabIndex = 0;
            // 
            // tab_rental
            // 
            tab_rental.BackColor = Color.LightGray;
            tab_rental.BackgroundImage = (Image)resources.GetObject("tab_rental.BackgroundImage");
            tab_rental.BackgroundImageLayout = ImageLayout.Stretch;
            tab_rental.Controls.Add(customer_id_label);
            tab_rental.Controls.Add(customer_id_input);
            tab_rental.Controls.Add(label_location_error);
            tab_rental.Controls.Add(label_date_error);
            tab_rental.Controls.Add(price);
            tab_rental.Controls.Add(duration);
            tab_rental.Controls.Add(label_price);
            tab_rental.Controls.Add(label_duration);
            tab_rental.Controls.Add(button_quote);
            tab_rental.Controls.Add(dropoff_location_details);
            tab_rental.Controls.Add(pickup_location_details);
            tab_rental.Controls.Add(label_available);
            tab_rental.Controls.Add(confirm_button);
            tab_rental.Controls.Add(return_same_loc_checkbox);
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
            tab_rental.Location = new Point(4, 24);
            tab_rental.Name = "tab_rental";
            tab_rental.Padding = new Padding(3);
            tab_rental.Size = new Size(832, 377);
            tab_rental.TabIndex = 0;
            tab_rental.Text = "Rental";
            tab_rental.Click += tabPage1_Click;
            // 
            // customer_id_label
            // 
            customer_id_label.AutoSize = true;
            customer_id_label.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            customer_id_label.Location = new Point(461, 21);
            customer_id_label.Name = "customer_id_label";
            customer_id_label.Size = new Size(87, 19);
            customer_id_label.TabIndex = 30;
            customer_id_label.Text = "Customer ID";
            // 
            // customer_id_input
            // 
            customer_id_input.Location = new Point(557, 20);
            customer_id_input.Margin = new Padding(3, 2, 3, 2);
            customer_id_input.Name = "customer_id_input";
            customer_id_input.Size = new Size(106, 23);
            customer_id_input.TabIndex = 29;
            // 
            // label_location_error
            // 
            label_location_error.AutoSize = true;
            label_location_error.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_location_error.ForeColor = Color.Red;
            label_location_error.Location = new Point(150, 154);
            label_location_error.Name = "label_location_error";
            label_location_error.Size = new Size(175, 21);
            label_location_error.TabIndex = 28;
            label_location_error.Text = "Location Error Handling";
            label_location_error.Visible = false;
            label_location_error.Click += label_location_error_Click;
            // 
            // label_date_error
            // 
            label_date_error.AutoSize = true;
            label_date_error.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_date_error.ForeColor = Color.Red;
            label_date_error.Location = new Point(150, 64);
            label_date_error.Name = "label_date_error";
            label_date_error.Size = new Size(148, 21);
            label_date_error.TabIndex = 27;
            label_date_error.Text = "Date Error Handling";
            label_date_error.Visible = false;
            label_date_error.Click += label_date_error_Click;
            // 
            // price
            // 
            price.AutoSize = true;
            price.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            price.Location = new Point(623, 195);
            price.Name = "price";
            price.Size = new Size(51, 21);
            price.TabIndex = 26;
            price.Text = "PRICE";
            price.Visible = false;
            // 
            // duration
            // 
            duration.AutoSize = true;
            duration.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            duration.Location = new Point(620, 175);
            duration.Name = "duration";
            duration.Size = new Size(128, 19);
            duration.TabIndex = 25;
            duration.Text = "RENTAL DURATION";
            duration.Visible = false;
            // 
            // label_price
            // 
            label_price.AutoSize = true;
            label_price.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_price.Location = new Point(498, 195);
            label_price.Name = "label_price";
            label_price.Size = new Size(103, 21);
            label_price.TabIndex = 24;
            label_price.Text = "Quoted Price:";
            label_price.Visible = false;
            // 
            // label_duration
            // 
            label_duration.AutoSize = true;
            label_duration.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_duration.Location = new Point(494, 175);
            label_duration.Name = "label_duration";
            label_duration.Size = new Size(108, 19);
            label_duration.TabIndex = 23;
            label_duration.Text = "Rental Duration:";
            label_duration.Visible = false;
            // 
            // button_quote
            // 
            button_quote.Location = new Point(613, 125);
            button_quote.Name = "button_quote";
            button_quote.Size = new Size(114, 38);
            button_quote.TabIndex = 22;
            button_quote.Text = "Get Price";
            button_quote.UseVisualStyleBackColor = true;
            button_quote.Click += button_quote_Click;
            // 
            // dropoff_location_details
            // 
            dropoff_location_details.AutoSize = true;
            dropoff_location_details.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dropoff_location_details.Location = new Point(150, 277);
            dropoff_location_details.Name = "dropoff_location_details";
            dropoff_location_details.Size = new Size(196, 19);
            dropoff_location_details.TabIndex = 21;
            dropoff_location_details.Text = "DROPOFF LOCATION DETAILS";
            dropoff_location_details.Visible = false;
            // 
            // pickup_location_details
            // 
            pickup_location_details.AutoSize = true;
            pickup_location_details.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            pickup_location_details.Location = new Point(150, 200);
            pickup_location_details.Name = "pickup_location_details";
            pickup_location_details.Size = new Size(181, 19);
            pickup_location_details.TabIndex = 20;
            pickup_location_details.Text = "PICKUP LOCATION DETAILS";
            pickup_location_details.Visible = false;
            pickup_location_details.Click += pickup_location_details_Click;
            // 
            // label_available
            // 
            label_available.AutoSize = true;
            label_available.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_available.ForeColor = Color.Red;
            label_available.Location = new Point(557, 64);
            label_available.Name = "label_available";
            label_available.Size = new Size(155, 21);
            label_available.TabIndex = 19;
            label_available.Text = "No vehicles available";
            label_available.Visible = false;
            label_available.Click += label_available_Click;
            // 
            // confirm_button
            // 
            confirm_button.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            confirm_button.Location = new Point(557, 254);
            confirm_button.Name = "confirm_button";
            confirm_button.Size = new Size(219, 94);
            confirm_button.TabIndex = 18;
            confirm_button.Text = "Confirm Booking";
            confirm_button.UseVisualStyleBackColor = true;
            confirm_button.Click += confirm_button_Click;
            // 
            // return_same_loc_checkbox
            // 
            return_same_loc_checkbox.AutoSize = true;
            return_same_loc_checkbox.Checked = true;
            return_same_loc_checkbox.CheckState = CheckState.Checked;
            return_same_loc_checkbox.Location = new Point(150, 231);
            return_same_loc_checkbox.Margin = new Padding(3, 2, 3, 2);
            return_same_loc_checkbox.Name = "return_same_loc_checkbox";
            return_same_loc_checkbox.RightToLeft = RightToLeft.Yes;
            return_same_loc_checkbox.Size = new Size(152, 19);
            return_same_loc_checkbox.TabIndex = 14;
            return_same_loc_checkbox.Text = "Return to same location";
            return_same_loc_checkbox.UseVisualStyleBackColor = true;
            return_same_loc_checkbox.CheckedChanged += return_same_loc_checkbox_CheckedChanged;
            // 
            // dropoff_location_combo
            // 
            dropoff_location_combo.FormattingEnabled = true;
            dropoff_location_combo.Location = new Point(150, 254);
            dropoff_location_combo.Margin = new Padding(3, 2, 3, 2);
            dropoff_location_combo.Name = "dropoff_location_combo";
            dropoff_location_combo.Size = new Size(219, 23);
            dropoff_location_combo.TabIndex = 12;
            dropoff_location_combo.SelectedIndexChanged += dropoff_location_combo_SelectedIndexChanged;
            // 
            // pickup_location_combo
            // 
            pickup_location_combo.FormattingEnabled = true;
            pickup_location_combo.Location = new Point(150, 177);
            pickup_location_combo.Margin = new Padding(3, 2, 3, 2);
            pickup_location_combo.Name = "pickup_location_combo";
            pickup_location_combo.Size = new Size(219, 23);
            pickup_location_combo.TabIndex = 11;
            pickup_location_combo.SelectedIndexChanged += pickup_location_combo_SelectedIndexChanged;
            // 
            // dropoff_location_label
            // 
            dropoff_location_label.AutoSize = true;
            dropoff_location_label.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dropoff_location_label.Location = new Point(21, 257);
            dropoff_location_label.Name = "dropoff_location_label";
            dropoff_location_label.Size = new Size(112, 19);
            dropoff_location_label.TabIndex = 10;
            dropoff_location_label.Text = "Dropoff Location";
            // 
            // pickup_location_label
            // 
            pickup_location_label.AutoSize = true;
            pickup_location_label.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            pickup_location_label.Location = new Point(28, 181);
            pickup_location_label.Name = "pickup_location_label";
            pickup_location_label.Size = new Size(105, 19);
            pickup_location_label.TabIndex = 8;
            pickup_location_label.Text = "Pickup Location";
            // 
            // search_button
            // 
            search_button.Location = new Point(201, 308);
            search_button.Margin = new Padding(3, 2, 3, 2);
            search_button.Name = "search_button";
            search_button.Size = new Size(114, 40);
            search_button.TabIndex = 6;
            search_button.Text = "Search For Availability";
            search_button.UseVisualStyleBackColor = true;
            search_button.Click += search_button_Click_1;
            // 
            // dropoff_date_label
            // 
            dropoff_date_label.AutoSize = true;
            dropoff_date_label.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dropoff_date_label.Location = new Point(46, 125);
            dropoff_date_label.Name = "dropoff_date_label";
            dropoff_date_label.Size = new Size(89, 19);
            dropoff_date_label.TabIndex = 5;
            dropoff_date_label.Text = "Dropoff Date";
            // 
            // dropoff_date_picker
            // 
            dropoff_date_picker.Location = new Point(150, 122);
            dropoff_date_picker.Margin = new Padding(3, 2, 3, 2);
            dropoff_date_picker.Name = "dropoff_date_picker";
            dropoff_date_picker.Size = new Size(219, 23);
            dropoff_date_picker.TabIndex = 4;
            dropoff_date_picker.Value = new DateTime(2023, 6, 7, 0, 0, 0, 0);
            dropoff_date_picker.ValueChanged += dropoff_date_picker_ValueChanged;
            // 
            // pickup_date_label
            // 
            pickup_date_label.AutoSize = true;
            pickup_date_label.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            pickup_date_label.Location = new Point(53, 91);
            pickup_date_label.Name = "pickup_date_label";
            pickup_date_label.Size = new Size(82, 19);
            pickup_date_label.TabIndex = 3;
            pickup_date_label.Text = "Pickup Date";
            // 
            // pickup_date_picker
            // 
            pickup_date_picker.Location = new Point(150, 88);
            pickup_date_picker.Margin = new Padding(3, 2, 3, 2);
            pickup_date_picker.Name = "pickup_date_picker";
            pickup_date_picker.Size = new Size(219, 23);
            pickup_date_picker.TabIndex = 2;
            pickup_date_picker.Value = new DateTime(2023, 6, 1, 0, 0, 0, 0);
            pickup_date_picker.ValueChanged += pickup_date_picker_ValueChanged;
            // 
            // vehicle_type_label
            // 
            vehicle_type_label.AutoSize = true;
            vehicle_type_label.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            vehicle_type_label.Location = new Point(461, 89);
            vehicle_type_label.Name = "vehicle_type_label";
            vehicle_type_label.Size = new Size(83, 19);
            vehicle_type_label.TabIndex = 1;
            vehicle_type_label.Text = "Vehicle Type";
            // 
            // tab_car
            // 
            tab_car.Controls.Add(year);
            tab_car.Controls.Add(label_branch_date_current);
            tab_car.Controls.Add(combo_branch_transfer);
            tab_car.Controls.Add(label_branch_info_transfer);
            tab_car.Controls.Add(label_branch_transfer);
            tab_car.Controls.Add(valid_vin);
            tab_car.Controls.Add(label_branch_info_current);
            tab_car.Controls.Add(type);
            tab_car.Controls.Add(combo_branch_current);
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
            tab_car.Location = new Point(4, 24);
            tab_car.Name = "tab_car";
            tab_car.Padding = new Padding(3);
            tab_car.Size = new Size(832, 377);
            tab_car.TabIndex = 1;
            tab_car.Text = "Cars";
            tab_car.UseVisualStyleBackColor = true;
            tab_car.Click += tabPage2_Click;
            // 
            // year
            // 
            year.CustomFormat = "yyyy";
            year.Format = DateTimePickerFormat.Custom;
            year.Location = new Point(167, 252);
            year.Margin = new Padding(3, 2, 3, 2);
            year.Name = "year";
            year.ShowUpDown = true;
            year.Size = new Size(130, 23);
            year.TabIndex = 19;
            // 
            // label_branch_date_current
            // 
            label_branch_date_current.AutoSize = true;
            label_branch_date_current.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_branch_date_current.Location = new Point(590, 118);
            label_branch_date_current.Name = "label_branch_date_current";
            label_branch_date_current.Size = new Size(84, 19);
            label_branch_date_current.TabIndex = 18;
            label_branch_date_current.Text = "Branch Date";
            label_branch_date_current.Visible = false;
            // 
            // combo_branch_transfer
            // 
            combo_branch_transfer.FormattingEnabled = true;
            combo_branch_transfer.Location = new Point(590, 138);
            combo_branch_transfer.Name = "combo_branch_transfer";
            combo_branch_transfer.Size = new Size(180, 23);
            combo_branch_transfer.TabIndex = 17;
            combo_branch_transfer.SelectedIndexChanged += combo_branch_transfer_SelectedIndexChanged;
            // 
            // label_branch_info_transfer
            // 
            label_branch_info_transfer.AutoSize = true;
            label_branch_info_transfer.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_branch_info_transfer.Location = new Point(590, 162);
            label_branch_info_transfer.Name = "label_branch_info_transfer";
            label_branch_info_transfer.Size = new Size(127, 19);
            label_branch_info_transfer.TabIndex = 16;
            label_branch_info_transfer.Text = "Branch Information";
            label_branch_info_transfer.Visible = false;
            // 
            // label_branch_transfer
            // 
            label_branch_transfer.AutoSize = true;
            label_branch_transfer.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_branch_transfer.Location = new Point(404, 142);
            label_branch_transfer.Name = "label_branch_transfer";
            label_branch_transfer.Size = new Size(164, 19);
            label_branch_transfer.TabIndex = 15;
            label_branch_transfer.Text = "Initial / Tranfer Branch ID:";
            // 
            // valid_vin
            // 
            valid_vin.AutoSize = true;
            valid_vin.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            valid_vin.ForeColor = Color.Red;
            valid_vin.Location = new Point(167, 109);
            valid_vin.Name = "valid_vin";
            valid_vin.Size = new Size(73, 19);
            valid_vin.TabIndex = 14;
            valid_vin.Text = "Invalid Vin";
            valid_vin.Visible = false;
            // 
            // label_branch_info_current
            // 
            label_branch_info_current.AutoSize = true;
            label_branch_info_current.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_branch_info_current.Location = new Point(590, 98);
            label_branch_info_current.Name = "label_branch_info_current";
            label_branch_info_current.Size = new Size(127, 19);
            label_branch_info_current.TabIndex = 13;
            label_branch_info_current.Text = "Branch Information";
            label_branch_info_current.Visible = false;
            // 
            // type
            // 
            type.FormattingEnabled = true;
            type.Location = new Point(167, 137);
            type.Name = "type";
            type.Size = new Size(206, 23);
            type.TabIndex = 5;
            // 
            // combo_branch_current
            // 
            combo_branch_current.FormattingEnabled = true;
            combo_branch_current.Location = new Point(590, 74);
            combo_branch_current.Name = "combo_branch_current";
            combo_branch_current.Size = new Size(180, 23);
            combo_branch_current.TabIndex = 11;
            combo_branch_current.SelectedIndexChanged += branch_current_SelectedIndexChanged;
            // 
            // button_delete
            // 
            button_delete.AutoSize = true;
            button_delete.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button_delete.Location = new Point(227, 36);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(66, 23);
            button_delete.TabIndex = 2;
            button_delete.Text = "Delete";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.CheckedChanged += button_delete_CheckedChanged;
            // 
            // button_modify
            // 
            button_modify.AutoSize = true;
            button_modify.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button_modify.Location = new Point(300, 36);
            button_modify.Name = "button_modify";
            button_modify.Size = new Size(70, 23);
            button_modify.TabIndex = 3;
            button_modify.Text = "Modify";
            button_modify.UseVisualStyleBackColor = true;
            button_modify.CheckedChanged += button_modify_CheckedChanged;
            // 
            // button_add
            // 
            button_add.AutoSize = true;
            button_add.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button_add.Location = new Point(167, 36);
            button_add.Name = "button_add";
            button_add.Size = new Size(52, 23);
            button_add.TabIndex = 1;
            button_add.Text = "Add";
            button_add.UseVisualStyleBackColor = true;
            button_add.CheckedChanged += button_add_CheckedChanged;
            // 
            // make
            // 
            make.Location = new Point(167, 182);
            make.Name = "make";
            make.Size = new Size(130, 23);
            make.TabIndex = 6;
            // 
            // colour
            // 
            colour.Location = new Point(167, 282);
            colour.Name = "colour";
            colour.Size = new Size(130, 23);
            colour.TabIndex = 9;
            // 
            // license
            // 
            license.Location = new Point(167, 320);
            license.Name = "license";
            license.Size = new Size(130, 23);
            license.TabIndex = 10;
            // 
            // model
            // 
            model.Location = new Point(167, 217);
            model.Name = "model";
            model.Size = new Size(130, 23);
            model.TabIndex = 7;
            // 
            // vin
            // 
            vin.FormattingEnabled = true;
            vin.IntegralHeight = false;
            vin.Location = new Point(167, 74);
            vin.Name = "vin";
            vin.Size = new Size(206, 23);
            vin.TabIndex = 4;
            vin.SelectedIndexChanged += vin_SelectedIndexChanged;
            vin.Leave += vin_Leave;
            // 
            // button_confirm
            // 
            button_confirm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_confirm.Location = new Point(463, 224);
            button_confirm.Name = "button_confirm";
            button_confirm.Size = new Size(306, 116);
            button_confirm.TabIndex = 12;
            button_confirm.Text = "Confirm";
            button_confirm.UseVisualStyleBackColor = true;
            button_confirm.Click += button_confirm_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(81, 38);
            label3.Name = "label3";
            label3.Size = new Size(51, 19);
            label3.TabIndex = 10;
            label3.Text = "Action:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(94, 138);
            label8.Name = "label8";
            label8.Size = new Size(40, 19);
            label8.TabIndex = 8;
            label8.Text = "Type:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(80, 285);
            label7.Name = "label7";
            label7.Size = new Size(53, 19);
            label7.TabIndex = 7;
            label7.Text = "Colour:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(96, 254);
            label6.Name = "label6";
            label6.Size = new Size(38, 19);
            label6.TabIndex = 6;
            label6.Text = "Year:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(38, 320);
            label5.Name = "label5";
            label5.Size = new Size(90, 19);
            label5.TabIndex = 5;
            label5.Text = "License Plate:";
            // 
            // label_branch_current
            // 
            label_branch_current.AutoSize = true;
            label_branch_current.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_branch_current.Location = new Point(463, 77);
            label_branch_current.Name = "label_branch_current";
            label_branch_current.Size = new Size(113, 19);
            label_branch_current.TabIndex = 4;
            label_branch_current.Text = "Latest Branch ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(88, 185);
            label2.Name = "label2";
            label2.Size = new Size(46, 19);
            label2.TabIndex = 2;
            label2.Text = "Make:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(82, 220);
            label1.Name = "label1";
            label1.Size = new Size(51, 19);
            label1.TabIndex = 1;
            label1.Text = "Model:";
            // 
            // label_vin
            // 
            label_vin.AutoSize = true;
            label_vin.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_vin.Location = new Point(99, 74);
            label_vin.Name = "label_vin";
            label_vin.Size = new Size(35, 19);
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
            tab_query.Location = new Point(4, 24);
            tab_query.Name = "tab_query";
            tab_query.Padding = new Padding(3);
            tab_query.Size = new Size(832, 377);
            tab_query.TabIndex = 2;
            tab_query.Text = "Query";
            tab_query.UseVisualStyleBackColor = true;
            // 
            // combo_query_option
            // 
            combo_query_option.FormattingEnabled = true;
            combo_query_option.Location = new Point(138, 352);
            combo_query_option.Name = "combo_query_option";
            combo_query_option.Size = new Size(402, 23);
            combo_query_option.TabIndex = 5;
            // 
            // label_query_option
            // 
            label_query_option.AutoSize = true;
            label_query_option.Location = new Point(42, 354);
            label_query_option.Name = "label_query_option";
            label_query_option.Size = new Size(82, 15);
            label_query_option.TabIndex = 4;
            label_query_option.Text = "Query Option:";
            // 
            // label_query
            // 
            label_query.AutoSize = true;
            label_query.Location = new Point(35, 326);
            label_query.Name = "label_query";
            label_query.Size = new Size(89, 15);
            label_query.TabIndex = 3;
            label_query.Text = "Selected Query:";
            // 
            // button_query
            // 
            button_query.Location = new Point(579, 323);
            button_query.Name = "button_query";
            button_query.Size = new Size(214, 46);
            button_query.TabIndex = 2;
            button_query.Text = "Run Query";
            button_query.UseVisualStyleBackColor = true;
            button_query.Click += button_query_Click;
            // 
            // combo_query
            // 
            combo_query.FormattingEnabled = true;
            combo_query.Location = new Point(138, 323);
            combo_query.Name = "combo_query";
            combo_query.Size = new Size(402, 23);
            combo_query.TabIndex = 1;
            combo_query.SelectedIndexChanged += combo_query_SelectedIndexChanged;
            // 
            // data_query
            // 
            data_query.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_query.Location = new Point(6, 6);
            data_query.Name = "data_query";
            data_query.RowHeadersWidth = 51;
            data_query.RowTemplate.Height = 25;
            data_query.Size = new Size(822, 306);
            data_query.TabIndex = 0;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 425);
            Controls.Add(tabControl1);
            Name = "Form2";
            Text = "Form_Main";
            Load += Form2_Load;
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
        private CheckBox return_same_loc_checkbox;
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
        private ComboBox combo_branch_current;
        private ComboBox type;
        private Label label_branch_info_current;
        private Label valid_vin;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button confirm_button;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Label label_available;
        private DataGridView data_query;
        private Label dropoff_location_details;
        private Label pickup_location_details;
        private ComboBox combo_query;
        private Button button_query;
        private Label label_query;
        private ComboBox combo_query_option;
        private Label label_query_option;
        private Button button_quote;
        private Label price;
        private Label duration;
        private Label label_price;
        private Label label_duration;
        private Label label_branch_transfer;
        private ComboBox combo_branch_transfer;
        private Label label_branch_info_transfer;
        private Label label_branch_date_current;
        public TabControl tabControl1;
        private Label label_location_error;
        private Label label_date_error;
        private TextBox customer_id_input;
        public Label customer_id_label;
        private DateTimePicker year;
    }
}