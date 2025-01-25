namespace FinansalCrm
{
    partial class FrmSpending
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSpending));
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUpdateSpending = new System.Windows.Forms.Button();
            this.btnDeleteSpending = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.btnCreateSpending = new System.Windows.Forms.Button();
            this.btnSpedingList = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSpendingTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSpendingAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSpendingId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCategoryForm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSingOut = new System.Windows.Forms.Button();
            this.btnSettingForm = new System.Windows.Forms.Button();
            this.btnBanksForm = new System.Windows.Forms.Button();
            this.btnBillingForm = new System.Windows.Forms.Button();
            this.btnDashboardForm = new System.Windows.Forms.Button();
            this.btnBankProcessesForm = new System.Windows.Forms.Button();
            this.btnSpendingsForm = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(12, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Giderler Formu";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.btnClose);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(0, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(958, 46);
            this.panel4.TabIndex = 8;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(922, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 21);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 3;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(225, 263);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(721, 284);
            this.panel3.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(721, 284);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnUpdateSpending
            // 
            this.btnUpdateSpending.BackColor = System.Drawing.Color.Silver;
            this.btnUpdateSpending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateSpending.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSpending.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdateSpending.Location = new System.Drawing.Point(548, 132);
            this.btnUpdateSpending.Name = "btnUpdateSpending";
            this.btnUpdateSpending.Size = new System.Drawing.Size(156, 40);
            this.btnUpdateSpending.TabIndex = 12;
            this.btnUpdateSpending.Text = "Güncelle";
            this.btnUpdateSpending.UseVisualStyleBackColor = false;
            this.btnUpdateSpending.Click += new System.EventHandler(this.btnUpdateSpending_Click);
            // 
            // btnDeleteSpending
            // 
            this.btnDeleteSpending.BackColor = System.Drawing.Color.Silver;
            this.btnDeleteSpending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSpending.Font = new System.Drawing.Font("Calibri", 11F);
            this.btnDeleteSpending.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeleteSpending.Location = new System.Drawing.Point(411, 132);
            this.btnDeleteSpending.Name = "btnDeleteSpending";
            this.btnDeleteSpending.Size = new System.Drawing.Size(131, 40);
            this.btnDeleteSpending.TabIndex = 11;
            this.btnDeleteSpending.Text = "Sil";
            this.btnDeleteSpending.UseVisualStyleBackColor = false;
            this.btnDeleteSpending.Click += new System.EventHandler(this.btnDeleteSpending_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbCategory);
            this.panel2.Controls.Add(this.btnUpdateSpending);
            this.panel2.Controls.Add(this.btnDeleteSpending);
            this.panel2.Controls.Add(this.btnCreateSpending);
            this.panel2.Controls.Add(this.btnSpedingList);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtSpendingTitle);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtSpendingAmount);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtSpendingId);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(225, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(721, 199);
            this.panel2.TabIndex = 6;
            // 
            // cmbCategory
            // 
            this.cmbCategory.BackColor = System.Drawing.Color.IndianRed;
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(98, 100);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(606, 24);
            this.cmbCategory.TabIndex = 13;
            // 
            // btnCreateSpending
            // 
            this.btnCreateSpending.BackColor = System.Drawing.Color.Silver;
            this.btnCreateSpending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateSpending.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateSpending.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCreateSpending.Location = new System.Drawing.Point(249, 132);
            this.btnCreateSpending.Name = "btnCreateSpending";
            this.btnCreateSpending.Size = new System.Drawing.Size(156, 40);
            this.btnCreateSpending.TabIndex = 10;
            this.btnCreateSpending.Text = "Yeni Gider";
            this.btnCreateSpending.UseVisualStyleBackColor = false;
            this.btnCreateSpending.Click += new System.EventHandler(this.btnCreateSpending_Click);
            // 
            // btnSpedingList
            // 
            this.btnSpedingList.BackColor = System.Drawing.Color.Silver;
            this.btnSpedingList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpedingList.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpedingList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSpedingList.Location = new System.Drawing.Point(98, 132);
            this.btnSpedingList.Name = "btnSpedingList";
            this.btnSpedingList.Size = new System.Drawing.Size(145, 40);
            this.btnSpedingList.TabIndex = 9;
            this.btnSpedingList.Text = "Gider Listesi";
            this.btnSpedingList.UseVisualStyleBackColor = false;
            this.btnSpedingList.Click += new System.EventHandler(this.btnSpedingList_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kategori:";
            // 
            // txtSpendingTitle
            // 
            this.txtSpendingTitle.BackColor = System.Drawing.Color.IndianRed;
            this.txtSpendingTitle.Location = new System.Drawing.Point(98, 43);
            this.txtSpendingTitle.Name = "txtSpendingTitle";
            this.txtSpendingTitle.Size = new System.Drawing.Size(606, 22);
            this.txtSpendingTitle.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Başlık:";
            // 
            // txtSpendingAmount
            // 
            this.txtSpendingAmount.BackColor = System.Drawing.Color.IndianRed;
            this.txtSpendingAmount.Location = new System.Drawing.Point(98, 71);
            this.txtSpendingAmount.Name = "txtSpendingAmount";
            this.txtSpendingAmount.Size = new System.Drawing.Size(606, 22);
            this.txtSpendingAmount.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Miktar:";
            // 
            // txtSpendingId
            // 
            this.txtSpendingId.BackColor = System.Drawing.Color.IndianRed;
            this.txtSpendingId.Location = new System.Drawing.Point(98, 15);
            this.txtSpendingId.Name = "txtSpendingId";
            this.txtSpendingId.Size = new System.Drawing.Size(606, 22);
            this.txtSpendingId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gider Id:";
            // 
            // btnCategoryForm
            // 
            this.btnCategoryForm.BackColor = System.Drawing.Color.Transparent;
            this.btnCategoryForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoryForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoryForm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCategoryForm.Location = new System.Drawing.Point(17, 28);
            this.btnCategoryForm.Name = "btnCategoryForm";
            this.btnCategoryForm.Size = new System.Drawing.Size(189, 40);
            this.btnCategoryForm.TabIndex = 1;
            this.btnCategoryForm.Text = "Kategoriler";
            this.btnCategoryForm.UseVisualStyleBackColor = false;
            this.btnCategoryForm.Click += new System.EventHandler(this.btnCategoryForm_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.btnSingOut);
            this.panel1.Controls.Add(this.btnSettingForm);
            this.panel1.Controls.Add(this.btnBanksForm);
            this.panel1.Controls.Add(this.btnBillingForm);
            this.panel1.Controls.Add(this.btnDashboardForm);
            this.panel1.Controls.Add(this.btnBankProcessesForm);
            this.panel1.Controls.Add(this.btnSpendingsForm);
            this.panel1.Controls.Add(this.btnCategoryForm);
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 507);
            this.panel1.TabIndex = 5;
            // 
            // btnSingOut
            // 
            this.btnSingOut.BackColor = System.Drawing.Color.Transparent;
            this.btnSingOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSingOut.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSingOut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSingOut.Location = new System.Drawing.Point(17, 434);
            this.btnSingOut.Name = "btnSingOut";
            this.btnSingOut.Size = new System.Drawing.Size(189, 40);
            this.btnSingOut.TabIndex = 8;
            this.btnSingOut.Text = "Çıkış Yap";
            this.btnSingOut.UseVisualStyleBackColor = false;
            this.btnSingOut.Click += new System.EventHandler(this.btnSingOut_Click);
            // 
            // btnSettingForm
            // 
            this.btnSettingForm.BackColor = System.Drawing.Color.Transparent;
            this.btnSettingForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettingForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettingForm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSettingForm.Location = new System.Drawing.Point(17, 376);
            this.btnSettingForm.Name = "btnSettingForm";
            this.btnSettingForm.Size = new System.Drawing.Size(189, 40);
            this.btnSettingForm.TabIndex = 7;
            this.btnSettingForm.Text = "Ayarlar";
            this.btnSettingForm.UseVisualStyleBackColor = false;
            this.btnSettingForm.Click += new System.EventHandler(this.btnSettingForm_Click);
            // 
            // btnBanksForm
            // 
            this.btnBanksForm.BackColor = System.Drawing.Color.Transparent;
            this.btnBanksForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanksForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanksForm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBanksForm.Location = new System.Drawing.Point(17, 86);
            this.btnBanksForm.Name = "btnBanksForm";
            this.btnBanksForm.Size = new System.Drawing.Size(189, 40);
            this.btnBanksForm.TabIndex = 6;
            this.btnBanksForm.Text = "Bankalar";
            this.btnBanksForm.UseVisualStyleBackColor = false;
            this.btnBanksForm.Click += new System.EventHandler(this.btnBanksForm_Click);
            // 
            // btnBillingForm
            // 
            this.btnBillingForm.BackColor = System.Drawing.Color.Transparent;
            this.btnBillingForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillingForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBillingForm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBillingForm.Location = new System.Drawing.Point(17, 144);
            this.btnBillingForm.Name = "btnBillingForm";
            this.btnBillingForm.Size = new System.Drawing.Size(189, 40);
            this.btnBillingForm.TabIndex = 5;
            this.btnBillingForm.Text = "Faturalar";
            this.btnBillingForm.UseVisualStyleBackColor = false;
            this.btnBillingForm.Click += new System.EventHandler(this.btnBillingForm_Click);
            // 
            // btnDashboardForm
            // 
            this.btnDashboardForm.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboardForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboardForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboardForm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDashboardForm.Location = new System.Drawing.Point(17, 318);
            this.btnDashboardForm.Name = "btnDashboardForm";
            this.btnDashboardForm.Size = new System.Drawing.Size(189, 40);
            this.btnDashboardForm.TabIndex = 4;
            this.btnDashboardForm.Text = "Dashboard";
            this.btnDashboardForm.UseVisualStyleBackColor = false;
            this.btnDashboardForm.Click += new System.EventHandler(this.btnDashboardForm_Click);
            // 
            // btnBankProcessesForm
            // 
            this.btnBankProcessesForm.BackColor = System.Drawing.Color.Transparent;
            this.btnBankProcessesForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBankProcessesForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBankProcessesForm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBankProcessesForm.Location = new System.Drawing.Point(17, 260);
            this.btnBankProcessesForm.Name = "btnBankProcessesForm";
            this.btnBankProcessesForm.Size = new System.Drawing.Size(189, 40);
            this.btnBankProcessesForm.TabIndex = 3;
            this.btnBankProcessesForm.Text = "Banka Hareketleri";
            this.btnBankProcessesForm.UseVisualStyleBackColor = false;
            this.btnBankProcessesForm.Click += new System.EventHandler(this.btnBankProcessesForm_Click);
            // 
            // btnSpendingsForm
            // 
            this.btnSpendingsForm.BackColor = System.Drawing.Color.Transparent;
            this.btnSpendingsForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpendingsForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpendingsForm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSpendingsForm.Location = new System.Drawing.Point(17, 202);
            this.btnSpendingsForm.Name = "btnSpendingsForm";
            this.btnSpendingsForm.Size = new System.Drawing.Size(189, 40);
            this.btnSpendingsForm.TabIndex = 2;
            this.btnSpendingsForm.Text = "Giderler";
            this.btnSpendingsForm.UseVisualStyleBackColor = false;
            // 
            // FrmSpending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 550);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSpending";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSpending";
            this.Load += new System.EventHandler(this.FrmSpending_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUpdateSpending;
        private System.Windows.Forms.Button btnDeleteSpending;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCreateSpending;
        private System.Windows.Forms.Button btnSpedingList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSpendingTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSpendingAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSpendingId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCategoryForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSingOut;
        private System.Windows.Forms.Button btnSettingForm;
        private System.Windows.Forms.Button btnBanksForm;
        private System.Windows.Forms.Button btnBillingForm;
        private System.Windows.Forms.Button btnDashboardForm;
        private System.Windows.Forms.Button btnBankProcessesForm;
        private System.Windows.Forms.Button btnSpendingsForm;
        private System.Windows.Forms.ComboBox cmbCategory;
    }
}