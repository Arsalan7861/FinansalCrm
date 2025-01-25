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
    public partial class FrmBilling : Form
    {
        public FrmBilling()
        {
            InitializeComponent();
        }

        FinansalCrmDbEntities db = new FinansalCrmDbEntities();

        private void FrmBilling_Load(object sender, EventArgs e)
        {
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnBillList_Click(object sender, EventArgs e)
        {
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            string title = txtBillTitle.Text;
            decimal amount = decimal.Parse( txtBillAmount.Text);
            string period = txtBillPeriod.Text;

            Bill bill = new Bill();
            bill.BillTitle = title;
            bill.BillAmount = amount;
            bill.BillPeriod = period;
            db.Bills.Add(bill);
            db.SaveChanges();
            MessageBox.Show("Ödeme Başarılı Bir Şekilde Sisteme Eklendi", "Ödeme ve Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnDeleteBill_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBillId.Text);
            var removedValue = db.Bills.Find(id);
            db.Bills.Remove(removedValue);
            db.SaveChanges();
            MessageBox.Show("Ödeme Başarılı Bir Şekilde Sistemden Silindi", "Ödeme ve Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnUpdateBill_Click(object sender, EventArgs e)
        {
            string title = txtBillTitle.Text;
            decimal amount = decimal.Parse(txtBillAmount.Text);
            string period = txtBillPeriod.Text;

            int id = int.Parse(txtBillId.Text);
            var values = db.Bills.Find(id);
            values.BillTitle = title;
            values.BillAmount = amount;
            values.BillPeriod = period;
            db.SaveChanges();
            MessageBox.Show("Ödeme Başarılı Bir Şekilde Sistemde Güncellendi", "Ödeme ve Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values2 = db.Bills.ToList();
            dataGridView1.DataSource = values2;
        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmBanks frm = new FrmBanks();
            frm.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSingOut_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin frm = new FrmLogin();
            frm.Show();
        }

        private void btnCategoryForm_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmCategory frm = new FrmCategory();
            frm.Show();
        }

        private void btnBillingForm_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmBilling frm = new FrmBilling();
            frm.Show();
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

        private void btnSettingForm_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmSetting frm = new FrmSetting();
            frm.Show();
        }
    }
}
