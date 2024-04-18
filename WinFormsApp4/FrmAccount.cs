using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Profil = WinFormsApp4.Account;
namespace WinFormsApp4
{
    public partial class FrmAccount : Form
    {
        private List<TextBox> boxes = new List<TextBox>();
        private UserManager _manager = new UserManager();

        private Profil _account;
        public FrmAccount(Profil account)
        {
            InitializeComponent();
            _account = account;
        }

        private void FrmAccount_Load(object sender, EventArgs e)
        {
            boxes.Add(txtEmail);
            boxes.Add(txtPassword);
            boxes.Add(txtUserName);
            TextBoxFill();
        }

        private void TextBoxClear()
        {
            foreach (var box in boxes)
            {
                box.Text = "";
            }
        }
        private void TextBoxFill()
        {
            txtUserName.Text = _account.Profile.Login;
            txtEmail.Text = _account.Profile.Email;
            txtPassword.Text = _account.Profile.Password;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            _account = null;
            Form1 form = new Form1();
            form.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextBoxClear();
            BoxsEnabled();
           
        }


        private void BoxsEnabledFalse()
        {
            foreach (var box in boxes)
            {
                box.Enabled = false;
            }
        }
        private void BoxsEnabled()
        {
            foreach (var box in boxes)
            {
                box.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var oldProfile = _account.Profile;
            oldProfile.Login = txtUserName.Text;
            oldProfile.Email = txtEmail.Text;
            oldProfile.Password = txtPassword.Text;
            _manager.Update(oldProfile);
            BoxsEnabledFalse();
            TextBoxFill();
        }
    }
}
