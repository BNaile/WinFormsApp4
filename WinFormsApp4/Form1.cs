using System.Diagnostics.Eventing.Reader;
using System.Reflection;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtBxLogin.Text is not "" && txtBxPassword.Text is not "")
            {
                if (txtBxPassword.Text.Length > 5)
                {
                    if (CheckUser(txtBxLogin.Text, txtBxPassword.Text,out User model))
                    {
                        if (txtBxLogin.Text == "admin")
                        {
                            FrmAdmin frmAdmin = new FrmAdmin();
                            this.Hide();
                            frmAdmin.Show();
                        }
                        else
                        {
                            if (model is not null)
                            {
                                Account accountt = new Account(model);
                                FrmAccount frmAccount = new FrmAccount(accountt);
                                this.Hide();
                                frmAccount.Show();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Yalnış login və password daxil edilib");
                    }
                }
                else
                {
                    MessageBox.Show("Parol 5 simvoldan az olmamalıdır!");
                }
            }
            else
            {
                MessageBox.Show("Boş xana saxlamayın !");
            }
        }

        private bool CheckUser(string login, string password , out User model)
        {
            foreach (var users in DataBASE.Instance.Users)
            {
                
                 if (login == users.Login && password == users.Password)
                {
                    MessageBox.Show("Girişiniz uğurla başa çatdı :)");
                    model=users;
                    return true;
                }

            }
            model = new User();
            return false;
        }

        private void txtBxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Registor registor = new Registor();
            this.Hide();
            registor.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
