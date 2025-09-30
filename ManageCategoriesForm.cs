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
    public partial class ManageCategoriesForm : Form
    {
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\.NET\Demo\Database1.mdf;Integrated Security=True";
        private readonly int currentUserId;

        public ManageCategoriesForm(int userId)
        {
            InitializeComponent();
            this.currentUserId = userId;

            // --- THIS IS THE FIX ---
            // This line connects the form's Load event to your method.
            this.Load += new System.EventHandler(this.ManageCategoriesForm_Load);
            // --- END OF FIX ---
        }

        private void ManageCategoriesForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
            comboCategoryType.SelectedIndex = 0; // Default to "Expense"
        }

        private void LoadCategories()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "SELECT CategoryID, (CategoryName + ' (' + CategoryType + ')') AS DisplayName FROM Categories WHERE UserID = @UserID ORDER BY CategoryType, CategoryName";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    da.SelectCommand.Parameters.AddWithValue("@UserID", this.currentUserId);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    listCategories.DataSource = dt;
                    listCategories.DisplayMember = "DisplayName";
                    listCategories.ValueMember = "CategoryID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnAddCategory_Click_1(object sender, EventArgs e)
        {
            string categoryName = txtCategoryName.Text.Trim();
            string categoryType = comboCategoryType.SelectedItem.ToString();

            if (string.IsNullOrEmpty(categoryName))
            {
                MessageBox.Show("Please enter a category name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "INSERT INTO Categories (UserID, CategoryName, CategoryType) VALUES (@UserID, @CategoryName, @CategoryType)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@UserID", this.currentUserId);
                        cmd.Parameters.AddWithValue("@CategoryName", categoryName);
                        cmd.Parameters.AddWithValue("@CategoryType", categoryType);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Category added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCategoryName.Clear();
                LoadCategories(); // Refresh the list
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding category: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {

            if (listCategories.SelectedItem == null)
            {
                MessageBox.Show("Please select a category to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult confirmation = MessageBox.Show("Are you sure you want to delete this category? This may affect existing transactions.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmation == DialogResult.Yes)
            {
                try
                {
                    int categoryId = (int)listCategories.SelectedValue;
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        // Note: A more robust application might prevent deleting categories that are in use.
                        // For this project, we will allow it, but show a warning.
                        string query = "DELETE FROM Categories WHERE CategoryID = @CategoryID AND UserID = @UserID";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@CategoryID", categoryId);
                            cmd.Parameters.AddWithValue("@UserID", this.currentUserId);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Category deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCategories(); // Refresh the list
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting category: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
