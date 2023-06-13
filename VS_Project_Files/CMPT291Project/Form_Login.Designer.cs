namespace CMPT291Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cb_type = new ComboBox();
            text_user = new TextBox();
            text_pw = new TextBox();
            button_login = new Button();
            label_user = new Label();
            label_pw = new Label();
            label_type = new Label();
            fileSystemWatcher1 = new FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // cb_type
            // 
            cb_type.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_type.FormattingEnabled = true;
            cb_type.Items.AddRange(new object[] { "Customer", "Employee" });
            cb_type.Location = new Point(154, 59);
            cb_type.Margin = new Padding(3, 4, 3, 4);
            cb_type.Name = "cb_type";
            cb_type.Size = new Size(282, 28);
            cb_type.TabIndex = 0;
            cb_type.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // text_user
            // 
            text_user.Cursor = Cursors.Cross;
            text_user.Location = new Point(154, 112);
            text_user.Margin = new Padding(3, 4, 3, 4);
            text_user.Name = "text_user";
            text_user.Size = new Size(282, 27);
            text_user.TabIndex = 1;
            text_user.TextChanged += textBox1_TextChanged;
            // 
            // text_pw
            // 
            text_pw.Location = new Point(154, 161);
            text_pw.Margin = new Padding(3, 4, 3, 4);
            text_pw.Name = "text_pw";
            text_pw.PasswordChar = '*';
            text_pw.Size = new Size(282, 27);
            text_pw.TabIndex = 2;
            text_pw.TextChanged += textBox2_TextChanged;
            // 
            // button_login
            // 
            button_login.Location = new Point(484, 59);
            button_login.Margin = new Padding(3, 4, 3, 4);
            button_login.Name = "button_login";
            button_login.Size = new Size(230, 129);
            button_login.TabIndex = 3;
            button_login.Text = "Login";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button1_Click;
            // 
            // label_user
            // 
            label_user.AutoSize = true;
            label_user.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_user.Location = new Point(53, 113);
            label_user.Name = "label_user";
            label_user.Size = new Size(91, 23);
            label_user.TabIndex = 4;
            label_user.Text = "Username:";
            // 
            // label_pw
            // 
            label_pw.AutoSize = true;
            label_pw.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_pw.Location = new Point(60, 162);
            label_pw.Name = "label_pw";
            label_pw.Size = new Size(84, 23);
            label_pw.TabIndex = 5;
            label_pw.Text = "Password:";
            // 
            // label_type
            // 
            label_type.AutoSize = true;
            label_type.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_type.Location = new Point(56, 60);
            label_type.Name = "label_type";
            label_type.Size = new Size(88, 23);
            label_type.TabIndex = 6;
            label_type.Text = "User Type:";
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 252);
            Controls.Add(label_type);
            Controls.Add(label_pw);
            Controls.Add(label_user);
            Controls.Add(button_login);
            Controls.Add(text_pw);
            Controls.Add(text_user);
            Controls.Add(cb_type);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Login Screen";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cb_type;
        private TextBox text_user;
        private TextBox text_pw;
        private Button button_login;
        private Label label_user;
        private Label label_pw;
        private Label label_type;
        private FileSystemWatcher fileSystemWatcher1;
    }
}