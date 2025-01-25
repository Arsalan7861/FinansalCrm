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
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
        }
        FinansalCrmDbEntities db = new FinansalCrmDbEntities();
        private void FrmCategory_Load(object sender, EventArgs e)
        {
            CategoryList();
        }

        private void CategoryList()
        {
            var values = db.Categories.Select(x => new
            {
                x.CategoryId,
                x.CategoryName
            }).ToList();
            dataGridView1.DataSource = values;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCategoryList_Click(object sender, EventArgs e)
        {
            CategoryList();
        }

        private void btnCreateCategory_Click(object sender, EventArgs e)
        {
            var name = txtCategoryName.Text;
            Category category = new Category();
            category.CategoryName = name;
            db.Categories.Add(category);
            db.SaveChanges();
            MessageBox.Show("Kategori Başarılı Bir Şekilde Sisteme Eklendi", "Kategori İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CategoryList();
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            var id = int.Parse(txtCategoryId.Text);
            var removedValue = db.Categories.Find(id);
            db.Categories.Remove(removedValue);
            db.SaveChanges();
            MessageBox.Show("Kategori Başarılı Bir Şekilde Sistemden Silindi", "Kategori İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CategoryList();
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            var name = txtCategoryName.Text;
            var id = int.Parse(txtCategoryId.Text);
            var updatedValue = db.Categories.Find(id);
            updatedValue.CategoryName = name;
            db.SaveChanges();
            MessageBox.Show("Kategori Başarılı Bir Şekilde Güncellendi", "Kategori İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CategoryList();
        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmBanks frmBank = new FrmBanks();
            frmBank.Show();
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
