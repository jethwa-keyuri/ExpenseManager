using ExpenseManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseManager
{
    public partial class AddTransactionForm : Form
    {
        private int currentUserID;
        private DashboardForm dashboard;
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\.NET\ExpenseManager\Database1.mdf;Integrated Security=True";

        public AddTransactionForm(int userId, DashboardForm dash)
        {
            InitializeComponent();
            currentUserID = userId;
            dashboard = dash;
        }

        private void AddTransactionForm_Load(object sender, EventArgs e)
        {
            radioExpense.Checked = true;
            LoadCategories("Expense");
        }

        private void LoadCategories(string type)
        {
            comboCategory.DataSource = null;
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT CategoryID, CategoryName FROM Categories WHERE UserID = @UserID AND CategoryType = @Type ORDER BY CategoryName";
                using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                {
                    da.SelectCommand.Parameters.AddWithValue("@UserID", currentUserID);
                    da.SelectCommand.Parameters.AddWithValue("@Type", type);
                    da.Fill(dt);
                }
            }
            comboCategory.DisplayMember = "CategoryName";
            comboCategory.ValueMember = "CategoryID";
            comboCategory.DataSource = dt;
        }

        private void radioType_CheckedChanged(object sender, EventArgs e)
        {
            if (radioIncome.Checked)
            {
                LoadCategories("Income");
            }
            else
            {
                LoadCategories("Expense");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtTitle.Text) || comboCategory.SelectedValue == null)
            {
                MessageBox.Show("Title and Category are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtAmount.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid positive amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string transactionType = radioIncome.Checked ? "Income" : "Expense";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Transactions (UserID, Title, Amount, TransactionType, CategoryID, TransactionDate) 
                                 VALUES (@UserID, @Title, @Amount, @Type, @CategoryID, @Date)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@UserID", currentUserID);
                    cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
                    cmd.Parameters.AddWithValue("@Amount", amount);
                    cmd.Parameters.AddWithValue("@Type", transactionType);
                    cmd.Parameters.AddWithValue("@CategoryID", comboCategory.SelectedValue);
                    cmd.Parameters.AddWithValue("@Date", datePicker.Value.Date);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }

            MessageBox.Show("Transaction saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dashboard.LoadDashboardData(); // Refresh the dashboard data
            this.Close();
        }
    }
}
