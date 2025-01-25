using FinansalCrm.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FinansalCrm
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        FinansalCrmDbEntities db = new FinansalCrmDbEntities();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var userName = txtUserName.Text;
            var password = txtUserPassword.Text;

            var user = db.Users.FirstOrDefault(x => x.UserName == userName && x.Password == password);
            if (user != null)
            {
                MessageBox.Show("Giriş Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmBanks frm = new FrmBanks();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtUserPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtUserPassword.UseSystemPasswordChar = true;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
