namespace WinFormsApp4
{
    partial class FrmAdmin
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
            dtTable = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            label4 = new Label();
            txtRepPassword = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label1 = new Label();
            txtPassword = new TextBox();
            Login = new Label();
            txtUserName = new TextBox();
            button1 = new Button();
            panel1 = new Panel();
            btnUserDelete = new Button();
            label5 = new Label();
            label3 = new Label();
            txtBxDeletedUser = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtTable).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dtTable
            // 
            dtTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtTable.Columns.AddRange(new DataGridViewColumn[] { ID, Column1, Email, Password });
            dtTable.Location = new Point(0, 334);
            dtTable.Name = "dtTable";
            dtTable.Size = new Size(797, 117);
            dtTable.TabIndex = 0;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // Column1
            // 
            Column1.HeaderText = "İstifadəçi adı";
            Column1.Name = "Column1";
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
            // 
            // Password
            // 
            Password.HeaderText = "Password";
            Password.Name = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 136);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 19;
            label4.Text = "Repeat Password";
            // 
            // txtRepPassword
            // 
            txtRepPassword.Location = new Point(43, 154);
            txtRepPassword.Name = "txtRepPassword";
            txtRepPassword.Size = new Size(280, 23);
            txtRepPassword.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 180);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 17;
            label2.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(43, 198);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(280, 23);
            txtEmail.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 88);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 15;
            label1.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(43, 106);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(280, 23);
            txtPassword.TabIndex = 14;
            // 
            // Login
            // 
            Login.AutoSize = true;
            Login.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Login.Location = new Point(43, 42);
            Login.Name = "Login";
            Login.Size = new Size(70, 17);
            Login.TabIndex = 13;
            Login.Text = "UserName";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(43, 60);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(280, 23);
            txtUserName.TabIndex = 12;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(214, 251);
            button1.Name = "button1";
            button1.Size = new Size(109, 36);
            button1.TabIndex = 20;
            button1.Text = "UserAdd";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PeachPuff;
            panel1.Controls.Add(btnUserDelete);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtBxDeletedUser);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(469, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(269, 271);
            panel1.TabIndex = 21;
            // 
            // btnUserDelete
            // 
            btnUserDelete.BackColor = Color.LightSalmon;
            btnUserDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUserDelete.Location = new Point(115, 196);
            btnUserDelete.Name = "btnUserDelete";
            btnUserDelete.Size = new Size(109, 36);
            btnUserDelete.TabIndex = 21;
            btnUserDelete.Text = "User Delete";
            btnUserDelete.UseVisualStyleBackColor = false;
            btnUserDelete.Click += btnUserDelete_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(89, 26);
            label5.Name = "label5";
            label5.Size = new Size(96, 18);
            label5.TabIndex = 16;
            label5.Text = "Delete User";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 85);
            label3.Name = "label3";
            label3.Size = new Size(70, 17);
            label3.TabIndex = 15;
            label3.Text = "UserName";
            // 
            // txtBxDeletedUser
            // 
            txtBxDeletedUser.Location = new Point(16, 109);
            txtBxDeletedUser.Name = "txtBxDeletedUser";
            txtBxDeletedUser.Size = new Size(208, 23);
            txtBxDeletedUser.TabIndex = 14;
            txtBxDeletedUser.TextChanged += textBox1_TextChanged;
            // 
            // FrmAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(txtRepPassword);
            Controls.Add(label2);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(Login);
            Controls.Add(txtUserName);
            Controls.Add(dtTable);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAdmin";
            Text = "FrmAdmin";
            Load += FrmAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)dtTable).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtTable;
        private Label label4;
        private TextBox txtRepPassword;
        private Label label2;
        private TextBox txtEmail;
        private Label label1;
        private TextBox txtPassword;
        private Label Login;
        private TextBox txtUserName;
        private Button button1;
        private Panel panel1;
        private Label label3;
        private TextBox txtBxDeletedUser;
        private Button btnUserDelete;
        private Label label5;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Password;
    }
}