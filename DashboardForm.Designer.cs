namespace ExpenseManager
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelNav = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnManageCategories = new System.Windows.Forms.Button();
            this.btnViewTransactions = new System.Windows.Forms.Button();
            this.btnAddTransaction = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.chartExpenses = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelBalance = new System.Windows.Forms.Panel();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelExpense = new System.Windows.Forms.Panel();
            this.lblTotalExpense = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelIncome = new System.Windows.Forms.Panel();
            this.lblTotalIncome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelNav.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartExpenses)).BeginInit();
            this.panelBalance.SuspendLayout();
            this.panelExpense.SuspendLayout();
            this.panelIncome.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelNav.Controls.Add(this.btnLogout);
            this.panelNav.Controls.Add(this.btnManageCategories);
            this.panelNav.Controls.Add(this.btnViewTransactions);
            this.panelNav.Controls.Add(this.btnAddTransaction);
            this.panelNav.Controls.Add(this.label1);
            this.panelNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNav.Location = new System.Drawing.Point(0, 0);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(200, 661);
            this.panelNav.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 621);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(200, 40);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnManageCategories
            // 
            this.btnManageCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnManageCategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageCategories.FlatAppearance.BorderSize = 0;
            this.btnManageCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageCategories.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnManageCategories.ForeColor = System.Drawing.Color.White;
            this.btnManageCategories.Location = new System.Drawing.Point(0, 120);
            this.btnManageCategories.Name = "btnManageCategories";
            this.btnManageCategories.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnManageCategories.Size = new System.Drawing.Size(200, 40);
            this.btnManageCategories.TabIndex = 3;
            this.btnManageCategories.Text = "Manage Categories";
            this.btnManageCategories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageCategories.UseVisualStyleBackColor = false;
            this.btnManageCategories.Click += new System.EventHandler(this.btnManageCategories_Click);
            // 
            // btnViewTransactions
            // 
            this.btnViewTransactions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnViewTransactions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewTransactions.FlatAppearance.BorderSize = 0;
            this.btnViewTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewTransactions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnViewTransactions.ForeColor = System.Drawing.Color.White;
            this.btnViewTransactions.Location = new System.Drawing.Point(0, 80);
            this.btnViewTransactions.Name = "btnViewTransactions";
            this.btnViewTransactions.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnViewTransactions.Size = new System.Drawing.Size(200, 40);
            this.btnViewTransactions.TabIndex = 2;
            this.btnViewTransactions.Text = "View Transactions";
            this.btnViewTransactions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewTransactions.UseVisualStyleBackColor = false;
            this.btnViewTransactions.Click += new System.EventHandler(this.btnViewTransactions_Click);
            // 
            // btnAddTransaction
            // 
            this.btnAddTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAddTransaction.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddTransaction.FlatAppearance.BorderSize = 0;
            this.btnAddTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTransaction.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddTransaction.ForeColor = System.Drawing.Color.White;
            this.btnAddTransaction.Location = new System.Drawing.Point(0, 40);
            this.btnAddTransaction.Name = "btnAddTransaction";
            this.btnAddTransaction.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAddTransaction.Size = new System.Drawing.Size(200, 40);
            this.btnAddTransaction.TabIndex = 1;
            this.btnAddTransaction.Text = "Add Transaction";
            this.btnAddTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTransaction.UseVisualStyleBackColor = false;
            this.btnAddTransaction.Click += new System.EventHandler(this.btnAddTransaction_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panelMain.Controls.Add(this.chartExpenses);
            this.panelMain.Controls.Add(this.panelBalance);
            this.panelMain.Controls.Add(this.panelExpense);
            this.panelMain.Controls.Add(this.panelIncome);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(200, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(20);
            this.panelMain.Size = new System.Drawing.Size(884, 661);
            this.panelMain.TabIndex = 1;
            // 
            // chartExpenses
            // 
            this.chartExpenses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            chartArea1.Name = "ChartArea1";
            this.chartExpenses.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartExpenses.Legends.Add(legend1);
            this.chartExpenses.Location = new System.Drawing.Point(23, 172);
            this.chartExpenses.Name = "chartExpenses";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Expenses";
            this.chartExpenses.Series.Add(series1);
            this.chartExpenses.Size = new System.Drawing.Size(838, 466);
            this.chartExpenses.TabIndex = 3;
            this.chartExpenses.Text = "chart1";
            // 
            // panelBalance
            // 
            this.panelBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panelBalance.Controls.Add(this.lblBalance);
            this.panelBalance.Controls.Add(this.label4);
            this.panelBalance.Location = new System.Drawing.Point(595, 23);
            this.panelBalance.Name = "panelBalance";
            this.panelBalance.Size = new System.Drawing.Size(266, 129);
            this.panelBalance.TabIndex = 2;
            // 
            // lblBalance
            // 
            this.lblBalance.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblBalance.Location = new System.Drawing.Point(3, 50);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(260, 59);
            this.lblBalance.TabIndex = 1;
            this.lblBalance.Text = "₹0.00";
            this.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Balance";
            // 
            // panelExpense
            // 
            this.panelExpense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panelExpense.Controls.Add(this.lblTotalExpense);
            this.panelExpense.Controls.Add(this.label3);
            this.panelExpense.Location = new System.Drawing.Point(309, 23);
            this.panelExpense.Name = "panelExpense";
            this.panelExpense.Size = new System.Drawing.Size(266, 129);
            this.panelExpense.TabIndex = 1;
            // 
            // lblTotalExpense
            // 
            this.lblTotalExpense.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalExpense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotalExpense.Location = new System.Drawing.Point(3, 50);
            this.lblTotalExpense.Name = "lblTotalExpense";
            this.lblTotalExpense.Size = new System.Drawing.Size(260, 59);
            this.lblTotalExpense.TabIndex = 1;
            this.lblTotalExpense.Text = "₹0.00";
            this.lblTotalExpense.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total Expense";
            // 
            // panelIncome
            // 
            this.panelIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panelIncome.Controls.Add(this.lblTotalIncome);
            this.panelIncome.Controls.Add(this.label2);
            this.panelIncome.Location = new System.Drawing.Point(23, 23);
            this.panelIncome.Name = "panelIncome";
            this.panelIncome.Size = new System.Drawing.Size(266, 129);
            this.panelIncome.TabIndex = 0;
            // 
            // lblTotalIncome
            // 
            this.lblTotalIncome.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalIncome.ForeColor = System.Drawing.Color.White;
            this.lblTotalIncome.Location = new System.Drawing.Point(3, 50);
            this.lblTotalIncome.Name = "lblTotalIncome";
            this.lblTotalIncome.Size = new System.Drawing.Size(260, 59);
            this.lblTotalIncome.TabIndex = 1;
            this.lblTotalIncome.Text = "₹0.00";
            this.lblTotalIncome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Income";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelNav);
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expense Manager Dashboard";
            this.panelNav.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartExpenses)).EndInit();
            this.panelBalance.ResumeLayout(false);
            this.panelBalance.PerformLayout();
            this.panelExpense.ResumeLayout(false);
            this.panelExpense.PerformLayout();
            this.panelIncome.ResumeLayout(false);
            this.panelIncome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddTransaction;
        private System.Windows.Forms.Button btnViewTransactions;
        private System.Windows.Forms.Button btnManageCategories;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelIncome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalIncome;
        private System.Windows.Forms.Panel panelExpense;
        private System.Windows.Forms.Label lblTotalExpense;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelBalance;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartExpenses;
    }
}