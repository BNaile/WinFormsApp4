namespace WinFormsApp4
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
            panel1 = new Panel();
            btnSignUp = new Button();
            btnLogin = new Button();
            linkExit = new LinkLabel();
            label3 = new Label();
            label2 = new Label();
            txtBxPassword = new TextBox();
            txtBxLogin = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Honeydew;
            panel1.Controls.Add(btnSignUp);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(linkExit);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtBxPassword);
            panel1.Controls.Add(txtBxLogin);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(79, 97);
            panel1.Name = "panel1";
            panel1.Size = new Size(428, 400);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnSignUp
            // 
            btnSignUp.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignUp.ForeColor = Color.Blue;
            btnSignUp.Location = new Point(81, 254);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(121, 39);
            btnSignUp.TabIndex = 7;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Blue;
            btnLogin.Location = new Point(235, 254);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(121, 39);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Sign In";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // linkExit
            // 
            linkExit.AutoSize = true;
            linkExit.LinkColor = Color.Orange;
            linkExit.Location = new Point(207, 343);
            linkExit.Name = "linkExit";
            linkExit.Size = new Size(26, 15);
            linkExit.TabIndex = 5;
            linkExit.TabStop = true;
            linkExit.Text = "Exit";
            linkExit.LinkClicked += linkExit_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(128, 128, 255);
            label3.Location = new Point(81, 197);
            label3.Name = "label3";
            label3.Size = new Size(81, 18);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(128, 128, 255);
            label2.Location = new Point(81, 135);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 3;
            label2.Text = "Login";
            label2.Click += label2_Click;
            // 
            // txtBxPassword
            // 
            txtBxPassword.Location = new Point(81, 215);
            txtBxPassword.Name = "txtBxPassword";
            txtBxPassword.Size = new Size(280, 23);
            txtBxPassword.TabIndex = 2;
            txtBxPassword.UseSystemPasswordChar = true;
            // 
            // txtBxLogin
            // 
            txtBxLogin.Location = new Point(81, 158);
            txtBxLogin.Name = "txtBxLogin";
            txtBxLogin.Size = new Size(280, 23);
            txtBxLogin.TabIndex = 1;
            txtBxLogin.TextChanged += txtBxLogin_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(172, 35);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 0;
            label1.Text = "Sign In";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 600);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox txtBxPassword;
        private TextBox txtBxLogin;
        private LinkLabel linkExit;
        private Button btnSignUp;
        private Button btnLogin;
    }
}
