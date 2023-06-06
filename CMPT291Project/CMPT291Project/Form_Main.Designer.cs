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
            tabPage1 = new TabPage();
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
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
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
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(10, 10);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(779, 430);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(quoted_price_label);
            tabPage1.Controls.Add(quoted_price_textbox);
            tabPage1.Controls.Add(return_same_loc_checkbox);
            tabPage1.Controls.Add(dropoff_location_combo);
            tabPage1.Controls.Add(pickup_location_combo);
            tabPage1.Controls.Add(dropoff_location_label);
            tabPage1.Controls.Add(pickup_location_label);
            tabPage1.Controls.Add(search_button);
            tabPage1.Controls.Add(dropoff_date_label);
            tabPage1.Controls.Add(dropoff_date_picker);
            tabPage1.Controls.Add(pickup_date_label);
            tabPage1.Controls.Add(pickup_date_picker);
            tabPage1.Controls.Add(vehicle_type_label);
            tabPage1.Controls.Add(vehicle_type_combo_box);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 3, 3, 3);
            tabPage1.Size = new Size(771, 402);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Car Rental";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
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
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 3, 3, 3);
            tabPage2.Size = new Size(771, 402);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 3, 3, 3);
            tabPage3.Size = new Size(771, 402);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form2";
            Text = "Form_Main";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
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
    }
}