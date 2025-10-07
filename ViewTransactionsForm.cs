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
    public partial class ViewTransactionsForm : Form
    {
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\.NET\ExpenseManager\Database1.mdf;Integrated Security=True";
        private readonly int currentUserId;

        public ViewTransactionsForm(int userId)
        {
            InitializeComponent();
            this.currentUserId = userId;
        }

        private void ViewTransactionsForm_Load(object sender, EventArgs e)
        {
            LoadTransactions();
        }

        private void LoadTransactions()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "SELECT TransactionID, Title, Amount, TransactionType, TransactionDate, (SELECT CategoryName FROM Categories WHERE Categories.CategoryID = Transactions.CategoryID) as Category FROM Transactions WHERE UserID = @UserID ORDER BY TransactionDate DESC";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    da.SelectCommand.Parameters.AddWithValue("@UserID", this.currentUserId);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvTransactions.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading transactions: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Delete Transaction Logic
        private void btnDeleteTransaction_Click(object sender, EventArgs e)
        {
            if (dgvTransactions.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a transaction to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult confirmation = MessageBox.Show("Are you sure you want to delete this transaction? This action cannot be undone.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmation == DialogResult.Yes)
            {
                try
                {
                  
                    object transactionIdValue = dgvTransactions.SelectedRows[0].Cells["TransactionID"].Value;

                    if (transactionIdValue == null || transactionIdValue == DBNull.Value)
                    {
                        MessageBox.Show("Could not identify the selected transaction. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!int.TryParse(transactionIdValue.ToString(), out int transactionId))
                    {
                        MessageBox.Show("Invalid Transaction ID format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        string query = "DELETE FROM Transactions WHERE TransactionID = @TransactionID AND UserID = @UserID";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@TransactionID", transactionId);
                            cmd.Parameters.AddWithValue("@UserID", this.currentUserId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Transaction deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh transactions
                    LoadTransactions();
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting transaction: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
