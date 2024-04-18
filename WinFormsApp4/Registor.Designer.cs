namespace WinFormsApp4
{
    partial class Registor
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
            btnRegister = new Button();
            button2 = new Button();
            label4 = new Label();
            txtRepPassword = new TextBox();
            lblExit = new LinkLabel();
            label3 = new Label();
            label2 = new Label();
            txtEmail = new TextBox();
            label1 = new Label();
            txtPassword = new TextBox();
            Login = new Label();
            txtUserName = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.WindowFrame;
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtRepPassword);
            panel1.Controls.Add(lblExit);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(Login);
            panel1.Controls.Add(txtUserName);
            panel1.ForeColor = Color.PeachPuff;
            panel1.Location = new Point(50, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 500);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = SystemColors.ControlDark;
            btnRegister.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(286, 396);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(101, 35);
            btnRegister.TabIndex = 14;
            btnRegister.Text = "Sign In";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDark;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(107, 396);
            button2.Name = "button2";
            button2.Size = new Size(101, 35);
            button2.TabIndex = 13;
            button2.Text = "Sign Up";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(107, 289);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 11;
            label4.Text = "Repeat Password";
            // 
            // txtRepPassword
            // 
            txtRepPassword.Location = new Point(107, 307);
            txtRepPassword.Name = "txtRepPassword";
            txtRepPassword.Size = new Size(280, 23);
            txtRepPassword.TabIndex = 10;
            // 
            // lblExit
            // 
            lblExit.AutoSize = true;
            lblExit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExit.LinkColor = Color.FromArgb(224, 224, 224);
            lblExit.Location = new Point(226, 453);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(36, 21);
            lblExit.TabIndex = 9;
            lblExit.TabStop = true;
            lblExit.Text = "Exit";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(199, 55);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 8;
            label3.Text = "Sign Up";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 333);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 7;
            label2.Text = "Email";
            label2.Click += label2_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(107, 351);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(280, 23);
            txtEmail.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 241);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 5;
            label1.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(107, 259);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(280, 23);
            txtPassword.TabIndex = 4;
            // 
            // Login
            // 
            Login.AutoSize = true;
            Login.Location = new Point(107, 195);
            Login.Name = "Login";
            Login.Size = new Size(62, 15);
            Login.TabIndex = 3;
            Login.Text = "UserName";
            Login.Click += label1_Click;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(107, 213);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(280, 23);
            txtUserName.TabIndex = 2;
            // 
            // Registor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 600);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Registor";
            Text = "Registor";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtUserName;
        private Label Login;
        private Label label2;
        private TextBox txtEmail;
        private Label label1;
        private TextBox txtPassword;
        private Label label3;
        private LinkLabel lblExit;
        private Label label4;
        private TextBox txtRepPassword;
        private Button btnRegister;
        private Button button2;
    }
}