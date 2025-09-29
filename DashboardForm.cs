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
using System.Windows.Forms.DataVisualization.Charting;

namespace ExpenseManager
{
    public partial class DashboardForm : Form
    {
        private int currentUserID;
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\.NET\ExpenseManager\Database1.mdf;Integrated Security=True";

        public DashboardForm(int userId)
        {
            InitializeComponent();
            currentUserID = userId;
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            LoadDashboardData();
        }

        public void LoadDashboardData()
        {
            decimal totalIncome = 0;
            decimal totalExpense = 0;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT TransactionType, SUM(Amount) as Total FROM Transactions WHERE UserID = @UserID GROUP BY TransactionType";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@UserID", currentUserID);
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader["TransactionType"].ToString() == "Income")
                                totalIncome = Convert.ToDecimal(reader["Total"]);
                            else if (reader["TransactionType"].ToString() == "Expense")
                                totalExpense = Convert.ToDecimal(reader["Total"]);
                        }
                    }
                    con.Close();
                }
            }

            // Update UI Labels
            lblTotalIncome.Text = $"{totalIncome:C}"; // Currency format
            lblTotalExpense.Text = $"{totalExpense:C}";
            decimal balance = totalIncome - totalExpense;
            lblBalance.Text = $"{balance:C}";
            lblBalance.ForeColor = balance >= 0 ? Color.Green : Color.Red;

            LoadExpenseChart();
        }
        private void LoadExpenseChart()
        {
            chartExpenses.Series.Clear();
            Series series = new Series
            {
                Name = "Expenses",
                IsVisibleInLegend = true,
                ChartType = SeriesChartType.Pie
            };
            chartExpenses.Series.Add(series);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT C.CategoryName, SUM(T.Amount) as Total 
                                 FROM Transactions T 
                                 JOIN Categories C ON T.CategoryID = C.CategoryID 
                                 WHERE T.UserID = @UserID AND T.TransactionType = 'Expense' 
                                 GROUP BY C.CategoryName";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@UserID", currentUserID);
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            series.Points.AddXY(reader["CategoryName"].ToString(), reader["Total"]);
                        }
                    }
                    con.Close();
                }
            }
            chartExpenses.Invalidate();
        }


        // --- Navigation Button Clicks ---
        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            AddTransactionForm addform1=new AddTransactionForm(currentUserID,this);
            AddTransactionForm addForm = new AddTransactionForm(currentUserID, this);
            addForm.ShowDialog(); 
        }

        private void btnViewTransactions_Click(object sender, EventArgs e)
        {
            ViewTransactionsForm viewForm = new ViewTransactionsForm();
            viewForm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            login loginForm = new login();
            loginForm.Show();
            this.Close();
        }
        private void btnManageCategories_Click(object sender, EventArgs e)
        {
            ManageCategoriesForm manageCategoriesForm = new ManageCategoriesForm();

            manageCategoriesForm.ShowDialog();

            LoadDashboardData();
        }
    }
}
