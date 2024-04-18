using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Registor : Form
    {
        public Registor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text is not "" &&
                txtPassword.Text is not "" &&
                txtRepPassword.Text is not "" &&
                 txtUserName.Text is not "")
            {
                if (txtPassword.Text.Length > 5 == txtRepPassword.Text.Length > 5)
                {
                    if (txtPassword.Text == txtRepPassword.Text)
                    {
                        User newUser = new User();
                        newUser.Login = txtUserName.Text;
                        newUser.Email = txtEmail.Text;
                        newUser.Password = txtPassword.Text;
                        DataBASE.Instance.Users.Add(newUser);
                        MessageBox.Show("Qeydiyyat tamamlandı");
                        button1_Click(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Əsas parol təkrar parola bərabər deyil))");
                    }
                }

            }
            else
            {
                MessageBox.Show("Xanları boş buraxmayın");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
