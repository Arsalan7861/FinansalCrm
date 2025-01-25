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
    public partial class FrmBankProcess : Form
    {
        public FrmBankProcess()
        {
            InitializeComponent();
        }
        FinansalCrmDbEntities db = new FinansalCrmDbEntities();
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmBankProcess_Load(object sender, EventArgs e)
        {
            BankProcessList();

            var banks = db.Banks.Select(x => x.BankTitle).ToList();
            cmbBank.DataSource = banks;
        }

        private void BankProcessList()
        {
            var values = db.BankProcesses.Select(x => new
            {
                x.BankProcessId,
                x.Description,
                x.ProcessDate,
                x.ProcessType,
                x.Amount,
                x.Bank.BankTitle
            }).ToList();
            dataGridView1.DataSource = values;
        }

        private void btnBankProcessList_Click(object sender, EventArgs e)
        {
            BankProcessList();
        }

        private void btnCreateBankProcess_Click(object sender, EventArgs e)
        {
            var description = txtDescription.Text;
            var processDate = DateTime.Now;
            var processType = txtProcessType.Text;
            var amount = decimal.Parse(txtProcessAmount.Text);
            var bankId = db.Banks.FirstOrDefault(x => x.BankTitle == cmbBank.Text).BankId;
            var bankProcess = new BankProcess();
            bankProcess.Description = description;
            bankProcess.ProcessDate = processDate;
            bankProcess.ProcessType = processType;
            bankProcess.Amount = amount;
            bankProcess.BankId = bankId;
            db.BankProcesses.Add(bankProcess);
            db.SaveChanges();
            MessageBox.Show("İşlem başarılı bir şekilde gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BankProcessList();
        }

        private void btnDeleteBankProcess_Click(object sender, EventArgs e)
        {
            var id = int.Parse(txtBankProcessId.Text);
            var removedValue = db.BankProcesses.Find(id);
            db.BankProcesses.Remove(removedValue);
            db.SaveChanges();
            MessageBox.Show("İşlem başarılı bir şekilde silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BankProcessList();
        }

        private void btnUpdateBankProcess_Click(object sender, EventArgs e)
        {
            var id = int.Parse(txtBankProcessId.Text);
            var updatedValue = db.BankProcesses.Find(id);
            updatedValue.Description = txtDescription.Text;
            updatedValue.ProcessDate = DateTime.Now;
            updatedValue.ProcessType = txtProcessType.Text;
            updatedValue.Amount = decimal.Parse(txtProcessAmount.Text);
            updatedValue.BankId = db.Banks.FirstOrDefault(x => x.BankTitle == cmbBank.Text).BankId;
            db.SaveChanges();
            MessageBox.Show("İşlem başarılı bir şekilde güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BankProcessList();
        }

        private void btnCategoryForm_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmCategory frm = new FrmCategory();
            frm.Show();
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
