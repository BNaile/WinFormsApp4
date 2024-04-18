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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            
                FillTable();
            

           
        }
        private void FillTable()
        {

            var data = DataBASE.Instance.Users;
            int i = 0;
            dtTable.Rows.Clear();
            if (dtTable.Rows.Count < data.Count)
                dtTable.Rows.Add(data.Count - dtTable.Rows.Count);
            foreach (var item in data)
            {
                dtTable.Rows[i].Cells[0].Value = item.ID;
                dtTable.Rows[i].Cells[1].Value = item.Login;
                dtTable.Rows[i].Cells[2].Value = item.Email;
                dtTable.Rows[i].Cells[3].Value = item.Password;
                i++;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
                        MessageBox.Show("Istifadəçi əlavə edildi");
                        FillTable();



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

        private void btnUserDelete_Click(object sender, EventArgs e)
        {
            var data= DataBASE.Instance.Users.Find(x=>x.Login==txtUserName.Text);
            if (data != null)
            {
                DataBASE.Instance.Users.Remove(data);
                FillTable();
                MessageBox.Show("Silindi");
                return;
            }
            MessageBox.Show("Belə istifadəçi tapılmadı!");
        }
    }
}
