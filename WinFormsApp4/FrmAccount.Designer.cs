namespace WinFormsApp4
{
    partial class FrmAccount
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
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            txtUserName = new TextBox();
            Login = new Label();
            txtPassword = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-3, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(811, 135);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(714, 51);
            button1.Name = "button1";
            button1.Size = new Size(85, 33);
            button1.TabIndex = 1;
            button1.Text = "Log Out";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(43, 45);
            label1.Name = "label1";
            label1.Size = new Size(64, 26);
            label1.TabIndex = 0;
            label1.Text = "Logo";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(85, 178);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(280, 23);
            txtUserName.TabIndex = 12;
            txtUserName.TextChanged += txtUserName_TextChanged;
            // 
            // Login
            // 
            Login.AutoSize = true;
            Login.Location = new Point(85, 160);
            Login.Name = "Login";
            Login.Size = new Size(62, 15);
            Login.TabIndex = 13;
            Login.Text = "UserName";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(85, 224);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(280, 23);
            txtPassword.TabIndex = 14;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(85, 206);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 15;
            label3.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(85, 272);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(280, 23);
            txtEmail.TabIndex = 16;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 254);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 17;
            label2.Text = "Email";
            label2.Click += label2_Click;
            // 
            // button2
            // 
            button2.Location = new Point(85, 329);
            button2.Name = "button2";
            button2.Size = new Size(89, 28);
            button2.TabIndex = 18;
            button2.Text = "UpDate";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(276, 329);
            button3.Name = "button3";
            button3.Size = new Size(89, 28);
            button3.TabIndex = 19;
            button3.Text = "Save";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // FrmAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(Login);
            Controls.Add(txtUserName);
            Controls.Add(panel1);
            Name = "FrmAccount";
            Text = "FrmAccount";
            Load += FrmAccount_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button1;
        private TextBox txtUserName;
        private Label Login;
        private TextBox txtPassword;
        private Label label3;
        private TextBox txtEmail;
        private Label label2;
        private Button button2;
        private Button button3;
    }
}