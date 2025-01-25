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
    public partial class FrmSpending : Form
    {
        public FrmSpending()
        {
            InitializeComponent();
        }
        FinansalCrmDbEntities db = new FinansalCrmDbEntities();
        private void FrmSpending_Load(object sender, EventArgs e)
        {
            SpendingList();

            var categories = db.Categories.Select(x=>x.CategoryName).ToList();
            cmbCategory.DataSource = categories;
        }

        private void SpendingList()
        {
            var values = db.Spendings.Select(x => new
            {
                x.SpendingId,
                x.SpendingTitle,
                x.SpendingAmount,
                x.SpendingDate,
                x.Category.CategoryName
            }).ToList();
            dataGridView1.DataSource = values;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSpedingList_Click(object sender, EventArgs e)
        {
            SpendingList();
        }

        private void btnCreateSpending_Click(object sender, EventArgs e)
        {
            var title = txtSpendingTitle.Text;
            var amount = decimal.Parse(txtSpendingAmount.Text);
            var date = DateTime.Now;
            var categoryId = db.Categories.FirstOrDefault(x => x.CategoryName == cmbCategory.Text).CategoryId;
            var spending = new Spending();
            spending.SpendingTitle = title;
            spending.SpendingAmount = amount;
            spending.SpendingDate = date;
            spending.CategoryId = categoryId;
            db.Spendings.Add(spending);
            db.SaveChanges();
            MessageBox.Show("Harcama Başarılı Bir Şekilde Sisteme Eklendi", "Harcamalar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SpendingList();
        }

        private void btnDeleteSpending_Click(object sender, EventArgs e)
        {
            var id = int.Parse(txtSpendingId.Text);
            var removedValue = db.Spendings.Find(id);
            db.Spendings.Remove(removedValue);
            db.SaveChanges();
            MessageBox.Show("Harcama Başarılı Bir Şekilde Sistemden Silindi", "Harcamalar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SpendingList();
        }

        private void btnUpdateSpending_Click(object sender, EventArgs e)
        {
            var title = txtSpendingTitle.Text;
            var amount = decimal.Parse(txtSpendingAmount.Text);
            var date = DateTime.Now;
            var categoryId = db.Categories.FirstOrDefault(x => x.CategoryName == cmbCategory.Text).CategoryId;
            var id = int.Parse(txtSpendingId.Text);
            var values = db.Spendings.Find(id);
            values.SpendingTitle = title;
            values.SpendingAmount = amount;
            values.SpendingDate = date;
            values.CategoryId = categoryId;
            db.SaveChanges();
            MessageBox.Show("Harcama Başarılı Bir Şekilde Sistemde Güncellendi", "Harcamalar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SpendingList();
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
            FrmBanks frm = new FrmBanks();
            frm.Show();
        }

        private void btnBillingForm_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmBilling frm = new FrmBilling();
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

        private void btnSettingForm_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmSetting frm = new FrmSetting();
            frm.Show();
        }

        private void btnSingOut_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin frm = new FrmLogin();
            frm.Show();
        }
    }
}
