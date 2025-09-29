namespace ExpenseManager
{
    partial class AddTransactionForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioIncome = new System.Windows.Forms.RadioButton();
            this.radioExpense = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.datePicker);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboCategory);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.radioIncome);
            this.groupBox1.Controls.Add(this.radioExpense);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(480, 524);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Transaction";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(33, 454);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(412, 49);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save Transaction";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // datePicker
            // 
            this.datePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 11.25F);
            this.datePicker.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.datePicker.Location = new System.Drawing.Point(33, 395);
            this.datePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(411, 32);
            this.datePicker.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label5.Location = new System.Drawing.Point(28, 367);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Date";
            // 
            // comboCategory
            // 
            this.comboCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.comboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboCategory.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.comboCategory.ForeColor = System.Drawing.Color.White;
            this.comboCategory.FormattingEnabled = true;
            this.comboCategory.Location = new System.Drawing.Point(33, 310);
            this.comboCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(411, 33);
            this.comboCategory.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label4.Location = new System.Drawing.Point(28, 282);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Category";
            // 
            // radioIncome
            // 
            this.radioIncome.AutoSize = true;
            this.radioIncome.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.radioIncome.Location = new System.Drawing.Point(180, 233);
            this.radioIncome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioIncome.Name = "radioIncome";
            this.radioIncome.Size = new System.Drawing.Size(95, 29);
            this.radioIncome.TabIndex = 4;
            this.radioIncome.Text = "Income";
            this.radioIncome.UseVisualStyleBackColor = true;
            this.radioIncome.CheckedChanged += new System.EventHandler(this.radioType_CheckedChanged);
            // 
            // radioExpense
            // 
            this.radioExpense.AutoSize = true;
            this.radioExpense.Checked = true;
            this.radioExpense.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.radioExpense.Location = new System.Drawing.Point(33, 233);
            this.radioExpense.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioExpense.Name = "radioExpense";
            this.radioExpense.Size = new System.Drawing.Size(102, 29);
            this.radioExpense.TabIndex = 3;
            this.radioExpense.TabStop = true;
            this.radioExpense.Text = "Expense";
            this.radioExpense.UseVisualStyleBackColor = true;
            this.radioExpense.CheckedChanged += new System.EventHandler(this.radioType_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label3.Location = new System.Drawing.Point(28, 204);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Type";
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.ForeColor = System.Drawing.Color.White;
            this.txtAmount.Location = new System.Drawing.Point(33, 153);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(411, 32);
            this.txtAmount.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Amount";
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.ForeColor = System.Drawing.Color.White;
            this.txtTitle.Location = new System.Drawing.Point(33, 73);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(411, 32);
            this.txtTitle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // AddTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(512, 554);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddTransactionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Transaction";
            this.Load += new System.EventHandler(this.AddTransactionForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioIncome;
        private System.Windows.Forms.RadioButton radioExpense;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
    }
}
