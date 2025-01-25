using FinansalCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinansalCrm
{
    public partial class FrmSetting : Form
    {
        public FrmSetting()
        {
            InitializeComponent();
        }
        FinansalCrmDbEntities db = new FinansalCrmDbEntities();
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmSetting_Load(object sender, EventArgs e)
        {
            USerLoad();
        }

        private void USerLoad()
        {
            var user = db.Users.Take(1).FirstOrDefault();
            lblPassword.Text = user.Password;
            lblUserName.Text = user.UserName;
            lblUserId.Text = user.UserId.ToString();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(lblUserId.Text);
            var userName = txtUserName.Text;
            var password = txtPassword.Text;
            var user = db.Users.Where(x => x.UserId == id).FirstOrDefault();
            user.UserName = userName;
            user.Password = password;
            db.SaveChanges();
            MessageBox.Show("Kullanıcı Bilgileri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            USerLoad();
        }

        private void btnCategoryForm_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmCategory frmCategory = new FrmCategory();
            frmCategory.Show();
        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmBanks frmBanks = new FrmBanks();
            frmBanks.Show();
        }

        private void btnBillingForm_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmBilling frmBilling = new FrmBilling();
            frmBilling.Show();
        }

        private void btnSpendingsForm_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmSpending frm = new FrmSpending();
            frm.Show();
        }

        private void btnBankProcessesForm_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmBankProcess frm = new FrmBankProcess();
            frm.Show();
        }

        private void btnDashboardForm_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin frm = new FrmLogin();
            frm.Show();
        }
    }
}
