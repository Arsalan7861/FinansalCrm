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
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        FinansalCrmDbEntities db = new FinansalCrmDbEntities();
        int count = 0;

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            var totalBalance = db.Banks.Sum(x => x.BankBalance);
            lblTotalBalance.Text = totalBalance.ToString();

            var lastBankProcessAmount = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).Select(x => x.Amount).FirstOrDefault();
            lblLastBankProcessAmount.Text = lastBankProcessAmount.ToString() + " ₺";

            // Chart 1 kodlari
            var bankData = db.Banks.Select(x => new
            {
                x.BankTitle,
                x.BankBalance
            }).ToList();
            chart1.Series.Clear();
            var series = chart1.Series.Add("Bankalar");
            foreach (var item in bankData)
            {
                series.Points.AddXY(item.BankTitle, item.BankBalance);
            }

            // Chart 2 kodlari
            var billData = db.Bills.Select(x => new
            {
                x.BillTitle,
                x.BillAmount
            }).ToList();
            chart2.Series.Clear();
            var series2 = chart2.Series.Add("Faturalar");
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pyramid;
            foreach (var item in billData)
            {
                series2.Points.AddXY(item.BillTitle, item.BillAmount);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            if (count % 4 == 1)
            {
                var bill = db.Bills.Where(x => x.BillTitle == "Elektrik Faturası").Select(x => x.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Elektrik Faturası";
                lblBillAmount.Text = bill.ToString() + " ₺";
            }
            if (count % 4 == 2)
            {
                var bill = db.Bills.Where(x => x.BillTitle == "Doğalgaz Faturası").Select(x => x.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Doğalgaz Faturası";
                lblBillAmount.Text = bill.ToString() + " ₺";
            }
            if (count % 4 == 3)
            {
                var bill = db.Bills.Where(x => x.BillTitle == "Su Faturası").Select(x => x.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Su Faturası";
                lblBillAmount.Text = bill.ToString() + " ₺";
            }
            if (count % 4 == 0)
            {
                var bill = db.Bills.Where(x => x.BillTitle == "İnternet Faturası").Select(x => x.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "İnternet Faturası";
                lblBillAmount.Text = bill.ToString() + " ₺";
            }
        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmBanks frmBanks = new FrmBanks();
            frmBanks.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBillingForm_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmBilling frmBilling = new FrmBilling();
            frmBilling.Show();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
        }

        private void btnCategoryForm_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmCategory frmCategory = new FrmCategory();
            frmCategory.Show();
        }

        private void btnSpendingsForm_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmSpending frmSpending = new FrmSpending();
            frmSpending.Show();
        }

        private void btnBankProcessesForm_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmBankProcess frmBankProcess = new FrmBankProcess();
            frmBankProcess.Show();
        }

        private void btnDashboardForm_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmDashboard frmDashboard = new FrmDashboard();
            frmDashboard.Show();
        }

        private void btnSettingForm_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmSetting frmSetting = new FrmSetting();
            frmSetting.Show();
        }
    }
}
