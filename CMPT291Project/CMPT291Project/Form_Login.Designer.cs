namespace CMPT291Project
{
    partial class form_login
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
            label_invalid = new TextBox();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // cb_type
            // 
            cb_type.FormattingEnabled = true;
            cb_type.Items.AddRange(new object[] { "Customer", "Employee" });
            cb_type.Location = new Point(115, 28);
            cb_type.Name = "cb_type";
            cb_type.Size = new Size(461, 23);
            cb_type.TabIndex = 0;
            cb_type.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // text_user
            // 
            text_user.Cursor = Cursors.Cross;
            text_user.Location = new Point(115, 77);
            text_user.Name = "text_user";
            text_user.Size = new Size(247, 23);
            text_user.TabIndex = 1;
            text_user.TextChanged += textBox1_TextChanged;
            // 
            // text_pw
            // 
            text_pw.Location = new Point(115, 106);
            text_pw.Name = "text_pw";
            text_pw.PasswordChar = '*';
            text_pw.Size = new Size(247, 23);
            text_pw.TabIndex = 2;
            text_pw.TextChanged += textBox2_TextChanged;
            // 
            // button_login
            // 
            button_login.Location = new Point(523, 106);
            button_login.Name = "button_login";
            button_login.Size = new Size(105, 78);
            button_login.TabIndex = 3;
            button_login.Text = "Login";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button1_Click;
            // 
            // label_user
            // 
            label_user.AutoSize = true;
            label_user.Location = new Point(26, 77);
            label_user.Name = "label_user";
            label_user.Size = new Size(63, 15);
            label_user.TabIndex = 4;
            label_user.Text = "Username:";
            // 
            // label_pw
            // 
            label_pw.AutoSize = true;
            label_pw.Location = new Point(26, 114);
            label_pw.Name = "label_pw";
            label_pw.Size = new Size(60, 15);
            label_pw.TabIndex = 5;
            label_pw.Text = "Password:";
            // 
            // label_type
            // 
            label_type.AutoSize = true;
            label_type.Location = new Point(29, 31);
            label_type.Name = "label_type";
            label_type.Size = new Size(60, 15);
            label_type.TabIndex = 6;
            label_type.Text = "User Type:";
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label_invalid
            // 
            label_invalid.BackColor = SystemColors.Control;
            label_invalid.BorderStyle = BorderStyle.None;
            label_invalid.ForeColor = Color.Red;
            label_invalid.Location = new Point(29, 135);
            label_invalid.Name = "label_invalid";
            label_invalid.ReadOnly = true;
            label_invalid.Size = new Size(488, 16);
            label_invalid.TabIndex = 7;
            label_invalid.Tag = "";
            label_invalid.Text = "CLEAR ON STARTUP";
            label_invalid.TextChanged += textBox1_TextChanged_1;
            // 
            // form_login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 189);
            Controls.Add(label_invalid);
            Controls.Add(label_type);
            Controls.Add(label_pw);
            Controls.Add(label_user);
            Controls.Add(button_login);
            Controls.Add(text_pw);
            Controls.Add(text_user);
            Controls.Add(cb_type);
            Name = "form_login";
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
        private TextBox label_invalid;
    }
}