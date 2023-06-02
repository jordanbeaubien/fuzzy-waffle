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
            vehicle_type_combo_box = new ComboBox();
            tabControl1 = new TabControl();
            tab_rental = new TabPage();
            quoted_price_label = new Label();
            quoted_price_textbox = new TextBox();
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
            valid_vin = new Label();
            branch_info = new Label();
            type = new ComboBox();
            branch = new ComboBox();
            button_delete = new RadioButton();
            button_modify = new RadioButton();
            button_add = new RadioButton();
            make = new TextBox();
            year = new TextBox();
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
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            label_vin = new Label();
            tab_query = new TabPage();
            tabControl1.SuspendLayout();
            tab_rental.SuspendLayout();
            tab_car.SuspendLayout();
            SuspendLayout();
            // 
            // vehicle_type_combo_box
            // 
            vehicle_type_combo_box.FormattingEnabled = true;
            vehicle_type_combo_box.Location = new Point(137, 182);
            vehicle_type_combo_box.Margin = new Padding(3, 2, 3, 2);
            vehicle_type_combo_box.Name = "vehicle_type_combo_box";
            vehicle_type_combo_box.Size = new Size(219, 23);
            vehicle_type_combo_box.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tab_rental);
            tabControl1.Controls.Add(tab_car);
            tabControl1.Controls.Add(tab_query);
            tabControl1.Location = new Point(10, 10);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(779, 430);
            tabControl1.TabIndex = 0;
            // 
            // tab_rental
            // 
            tab_rental.Controls.Add(quoted_price_label);
            tab_rental.Controls.Add(quoted_price_textbox);
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
            tab_rental.Size = new Size(771, 402);
            tab_rental.TabIndex = 0;
            tab_rental.Text = "Rental";
            tab_rental.UseVisualStyleBackColor = true;
            tab_rental.Click += tabPage1_Click;
            // 
            // quoted_price_label
            // 
            quoted_price_label.AutoSize = true;
            quoted_price_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            quoted_price_label.Location = new Point(562, 276);
            quoted_price_label.Name = "quoted_price_label";
            quoted_price_label.Size = new Size(100, 21);
            quoted_price_label.TabIndex = 16;
            quoted_price_label.Text = "Quoted Price";
            quoted_price_label.Click += label1_Click_1;
            // 
            // quoted_price_textbox
            // 
            quoted_price_textbox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            quoted_price_textbox.Location = new Point(552, 299);
            quoted_price_textbox.Margin = new Padding(3, 2, 3, 2);
            quoted_price_textbox.Name = "quoted_price_textbox";
            quoted_price_textbox.Size = new Size(126, 36);
            quoted_price_textbox.TabIndex = 15;
            // 
            // return_same_loc_checkbox
            // 
            return_same_loc_checkbox.AutoSize = true;
            return_same_loc_checkbox.Checked = true;
            return_same_loc_checkbox.CheckState = CheckState.Checked;
            return_same_loc_checkbox.Location = new Point(388, 127);
            return_same_loc_checkbox.Margin = new Padding(3, 2, 3, 2);
            return_same_loc_checkbox.Name = "return_same_loc_checkbox";
            return_same_loc_checkbox.RightToLeft = RightToLeft.Yes;
            return_same_loc_checkbox.Size = new Size(152, 19);
            return_same_loc_checkbox.TabIndex = 14;
            return_same_loc_checkbox.Text = "Return to same location";
            return_same_loc_checkbox.UseVisualStyleBackColor = true;
            // 
            // dropoff_location_combo
            // 
            dropoff_location_combo.FormattingEnabled = true;
            dropoff_location_combo.Location = new Point(518, 88);
            dropoff_location_combo.Margin = new Padding(3, 2, 3, 2);
            dropoff_location_combo.Name = "dropoff_location_combo";
            dropoff_location_combo.Size = new Size(219, 23);
            dropoff_location_combo.TabIndex = 12;
            // 
            // pickup_location_combo
            // 
            pickup_location_combo.FormattingEnabled = true;
            pickup_location_combo.Location = new Point(518, 38);
            pickup_location_combo.Margin = new Padding(3, 2, 3, 2);
            pickup_location_combo.Name = "pickup_location_combo";
            pickup_location_combo.Size = new Size(219, 23);
            pickup_location_combo.TabIndex = 11;
            // 
            // dropoff_location_label
            // 
            dropoff_location_label.AutoSize = true;
            dropoff_location_label.Location = new Point(388, 92);
            dropoff_location_label.Name = "dropoff_location_label";
            dropoff_location_label.Size = new Size(97, 15);
            dropoff_location_label.TabIndex = 10;
            dropoff_location_label.Text = "Dropoff Location";
            // 
            // pickup_location_label
            // 
            pickup_location_label.AutoSize = true;
            pickup_location_label.Location = new Point(388, 38);
            pickup_location_label.Name = "pickup_location_label";
            pickup_location_label.Size = new Size(92, 15);
            pickup_location_label.TabIndex = 8;
            pickup_location_label.Text = "Pickup Location";
            // 
            // search_button
            // 
            search_button.Location = new Point(137, 262);
            search_button.Margin = new Padding(3, 2, 3, 2);
            search_button.Name = "search_button";
            search_button.Size = new Size(219, 89);
            search_button.TabIndex = 6;
            search_button.Text = "Search For Availability";
            search_button.UseVisualStyleBackColor = true;
            search_button.Click += search_button_Click_1;
            // 
            // dropoff_date_label
            // 
            dropoff_date_label.AutoSize = true;
            dropoff_date_label.Location = new Point(22, 92);
            dropoff_date_label.Name = "dropoff_date_label";
            dropoff_date_label.Size = new Size(75, 15);
            dropoff_date_label.TabIndex = 5;
            dropoff_date_label.Text = "Dropoff Date";
            // 
            // dropoff_date_picker
            // 
            dropoff_date_picker.Location = new Point(137, 88);
            dropoff_date_picker.Margin = new Padding(3, 2, 3, 2);
            dropoff_date_picker.Name = "dropoff_date_picker";
            dropoff_date_picker.Size = new Size(219, 23);
            dropoff_date_picker.TabIndex = 4;
            // 
            // pickup_date_label
            // 
            pickup_date_label.AutoSize = true;
            pickup_date_label.Location = new Point(22, 38);
            pickup_date_label.Name = "pickup_date_label";
            pickup_date_label.Size = new Size(70, 15);
            pickup_date_label.TabIndex = 3;
            pickup_date_label.Text = "Pickup Date";
            // 
            // pickup_date_picker
            // 
            pickup_date_picker.Location = new Point(137, 38);
            pickup_date_picker.Margin = new Padding(3, 2, 3, 2);
            pickup_date_picker.Name = "pickup_date_picker";
            pickup_date_picker.Size = new Size(219, 23);
            pickup_date_picker.TabIndex = 2;
            pickup_date_picker.ValueChanged += pickup_date_picker_ValueChanged;
            // 
            // vehicle_type_label
            // 
            vehicle_type_label.AutoSize = true;
            vehicle_type_label.Location = new Point(22, 184);
            vehicle_type_label.Name = "vehicle_type_label";
            vehicle_type_label.Size = new Size(71, 15);
            vehicle_type_label.TabIndex = 1;
            vehicle_type_label.Text = "Vehicle Type";
            vehicle_type_label.Click += label1_Click;
            // 
            // tab_car
            // 
            tab_car.Controls.Add(valid_vin);
            tab_car.Controls.Add(branch_info);
            tab_car.Controls.Add(type);
            tab_car.Controls.Add(branch);
            tab_car.Controls.Add(button_delete);
            tab_car.Controls.Add(button_modify);
            tab_car.Controls.Add(button_add);
            tab_car.Controls.Add(make);
            tab_car.Controls.Add(year);
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
            tab_car.Controls.Add(label4);
            tab_car.Controls.Add(label2);
            tab_car.Controls.Add(label1);
            tab_car.Controls.Add(label_vin);
            tab_car.Location = new Point(4, 24);
            tab_car.Name = "tab_car";
            tab_car.Padding = new Padding(3);
            tab_car.Size = new Size(771, 402);
            tab_car.TabIndex = 1;
            tab_car.Text = "Cars";
            tab_car.UseVisualStyleBackColor = true;
            tab_car.Click += tabPage2_Click;
            // 
            // valid_vin
            // 
            valid_vin.AutoSize = true;
            valid_vin.ForeColor = Color.Red;
            valid_vin.Location = new Point(297, 64);
            valid_vin.Name = "valid_vin";
            valid_vin.Size = new Size(62, 15);
            valid_vin.TabIndex = 14;
            valid_vin.Text = "Invalid Vin";
            valid_vin.Visible = false;
            valid_vin.Click += label9_Click;
            // 
            // branch_info
            // 
            branch_info.AutoSize = true;
            branch_info.Location = new Point(155, 347);
            branch_info.Name = "branch_info";
            branch_info.Size = new Size(110, 15);
            branch_info.TabIndex = 13;
            branch_info.Text = "Branch Information";
            branch_info.Visible = false;
            branch_info.Click += branch_info_Click;
            // 
            // type
            // 
            type.FormattingEnabled = true;
            type.Location = new Point(155, 90);
            type.Name = "type";
            type.Size = new Size(121, 23);
            type.TabIndex = 5;
            type.SelectedIndexChanged += type_SelectedIndexChanged;
            // 
            // branch
            // 
            branch.FormattingEnabled = true;
            branch.Location = new Point(155, 310);
            branch.Name = "branch";
            branch.Size = new Size(121, 23);
            branch.TabIndex = 11;
            branch.SelectedIndexChanged += branch_SelectedIndexChanged;
            // 
            // button_delete
            // 
            button_delete.AutoSize = true;
            button_delete.Location = new Point(208, 27);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(58, 19);
            button_delete.TabIndex = 2;
            button_delete.Text = "Delete";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.CheckedChanged += button_delete_CheckedChanged;
            // 
            // button_modify
            // 
            button_modify.AutoSize = true;
            button_modify.Location = new Point(272, 27);
            button_modify.Name = "button_modify";
            button_modify.Size = new Size(63, 19);
            button_modify.TabIndex = 3;
            button_modify.Text = "Modify";
            button_modify.UseVisualStyleBackColor = true;
            button_modify.CheckedChanged += button_modify_CheckedChanged;
            // 
            // button_add
            // 
            button_add.AutoSize = true;
            button_add.Location = new Point(155, 27);
            button_add.Name = "button_add";
            button_add.Size = new Size(47, 19);
            button_add.TabIndex = 1;
            button_add.Text = "Add";
            button_add.UseVisualStyleBackColor = true;
            button_add.CheckedChanged += button_add_CheckedChanged;
            // 
            // make
            // 
            make.Location = new Point(155, 127);
            make.Name = "make";
            make.Size = new Size(100, 23);
            make.TabIndex = 6;
            // 
            // year
            // 
            year.Location = new Point(155, 193);
            year.Name = "year";
            year.Size = new Size(100, 23);
            year.TabIndex = 8;
            // 
            // colour
            // 
            colour.Location = new Point(155, 231);
            colour.Name = "colour";
            colour.Size = new Size(100, 23);
            colour.TabIndex = 9;
            // 
            // license
            // 
            license.Location = new Point(155, 260);
            license.Name = "license";
            license.Size = new Size(100, 23);
            license.TabIndex = 10;
            // 
            // model
            // 
            model.Location = new Point(155, 156);
            model.Name = "model";
            model.Size = new Size(100, 23);
            model.TabIndex = 7;
            // 
            // vin
            // 
            vin.FormattingEnabled = true;
            vin.IntegralHeight = false;
            vin.Location = new Point(155, 61);
            vin.Name = "vin";
            vin.Size = new Size(121, 23);
            vin.TabIndex = 4;
            vin.SelectedIndexChanged += vin_SelectedIndexChanged;
            vin.Leave += vin_Leave;
            // 
            // button_confirm
            // 
            button_confirm.Location = new Point(524, 270);
            button_confirm.Name = "button_confirm";
            button_confirm.Size = new Size(203, 101);
            button_confirm.TabIndex = 12;
            button_confirm.Text = "Confirm";
            button_confirm.UseVisualStyleBackColor = true;
            button_confirm.Click += button_confirm_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(104, 29);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 10;
            label3.Text = "Action:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(115, 98);
            label8.Name = "label8";
            label8.Size = new Size(34, 15);
            label8.TabIndex = 8;
            label8.Text = "Type:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(105, 234);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 7;
            label7.Text = "Colour:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(117, 201);
            label6.Name = "label6";
            label6.Size = new Size(32, 15);
            label6.TabIndex = 6;
            label6.Text = "Year:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(71, 270);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 5;
            label5.Text = "License Plate:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(88, 313);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 4;
            label4.Text = "Branch ID:";
            label4.Click += label4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(113, 133);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Make:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 164);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 1;
            label1.Text = "Model:";
            label1.Click += label1_Click_3;
            // 
            // label_vin
            // 
            label_vin.AutoSize = true;
            label_vin.Location = new Point(120, 64);
            label_vin.Name = "label_vin";
            label_vin.Size = new Size(29, 15);
            label_vin.TabIndex = 0;
            label_vin.Text = "VIN:";
            label_vin.Click += label1_Click_2;
            // 
            // tab_query
            // 
            tab_query.Location = new Point(4, 24);
            tab_query.Name = "tab_query";
            tab_query.Padding = new Padding(3);
            tab_query.Size = new Size(771, 402);
            tab_query.TabIndex = 2;
            tab_query.Text = "Query";
            tab_query.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form2";
            Text = "Form_Main";
            Load += Form2_Load;
            tabControl1.ResumeLayout(false);
            tab_rental.ResumeLayout(false);
            tab_rental.PerformLayout();
            tab_car.ResumeLayout(false);
            tab_car.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
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
        private TextBox quoted_price_textbox;
        private Label quoted_price_label;
        private Label label_vin;
        private Label label2;
        private Label label1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox make;
        private TextBox year;
        private TextBox colour;
        private TextBox license;
        private TextBox model;
        private ComboBox vin;
        private Button button_confirm;
        private Label label3;
        private RadioButton button_delete;
        private RadioButton button_modify;
        private RadioButton button_add;
        private ComboBox branch;
        private ComboBox type;
        private Label branch_info;
        private Label valid_vin;
    }
}