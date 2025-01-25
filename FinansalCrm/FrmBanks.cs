using System;
using System.Linq;
using System.Windows.Forms;

using FinansalCrm.Models;

namespace FinansalCrm
{
    public partial class FrmBanks : Form
    {
        public FrmBanks()
        {
            InitializeComponent();
        }

        FinansalCrmDbEntities db = new FinansalCrmDbEntities();

        private void FrmBanks_Load(object sender, EventArgs e)
        {
            // Banka Bakiyeleri
            var ziraatBankBalance = db.Banks.Where(x => x.BankTitle == "Ziraat Bankasi").Select(x => x.BankBalance).FirstOrDefault();
            var vakifBankBalance = db.Banks.Where(x => x.BankTitle == "Vakifbank").Select(x => x.BankBalance).FirstOrDefault();
            var isBankBalance = db.Banks.Where(x => x.BankTitle == "Is Bankasi").Select(x => x.BankBalance).FirstOrDefault();
            lblisBankasiBalance.Text = isBankBalance.ToString() + " ₺";
            lblVakifbankBalance.Text = vakifBankBalance.ToString() + " ₺";
            lblZiraatBankBalance.Text = ziraatBankBalance.ToString() + " ₺";

            // Banka hareketleri
            var bankProcess1 = db.BankProcesses.OrderByDescending(x =>x.BankProcessId).Take(1).FirstOrDefault();
            lblBankProcess1.Text = bankProcess1.Description + " " + bankProcess1.Amount + " " + bankProcess1.ProcessDate;

            var bankProcess2 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(2).Skip(1).FirstOrDefault();
            lblBankProcess2.Text = bankProcess2.Description + " " + bankProcess2.Amount + " " + bankProcess2.ProcessDate;

            var bankProcess3 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(3).Skip(2).FirstOrDefault();
            lblBankProcess3.Text = bankProcess3.Description + " " + bankProcess3.Amount + " " + bankProcess3.ProcessDate;

            var bankProcess4 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(4).Skip(3).FirstOrDefault();
            lblBankProcess4.Text = bankProcess4.Description + " " + bankProcess4.Amount + " " + bankProcess4.ProcessDate;

            var bankProcess5 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(5).Skip(4).FirstOrDefault();
            lblBankProcess5.Text = bankProcess5.Description + " " + bankProcess5.Amount + " " + bankProcess5.ProcessDate;
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

        private void btnBillingForm_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmBilling frm = new FrmBilling();
            frm.Show();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
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

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmBanks frm = new FrmBanks();
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

        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmSetting frm = new FrmSetting();
            frm.Show();
        }
    }
}