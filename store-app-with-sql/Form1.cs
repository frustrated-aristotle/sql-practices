using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace store_app_with_sql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBStoreDataSet.table_category' table. You can move, or remove it, as needed.
            this.table_categoryTableAdapter.Fill(this.dBStoreDataSet.table_category);

        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-P5AC8NT;Initial Catalog=DBStore;Integrated Security=True");

        private void button_list_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM table_category", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource= dataTable;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand addCategoryCommand = new SqlCommand("INSERT INTO table_category(category_name) Values (@p1)", connection);
            addCategoryCommand.Parameters.AddWithValue("@p1", textBox_categoryName.Text);
            addCategoryCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("New Category is Saved!");
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand deleteCategoryCommand = new SqlCommand("DELETE FROM table_category WHERE ID=@p1", connection);
            deleteCategoryCommand.Parameters.AddWithValue("@p1", textBox_id.Text);
            deleteCategoryCommand.ExecuteNonQuery();    
            connection.Close();
            MessageBox.Show("Category is Deleted!");

        }

        private void button_update_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand updateCategoryCommand = new SqlCommand("UPDATE table_category SET category_name=@p1 WHERE ID=@p2", connection);
            updateCategoryCommand.Parameters.AddWithValue("@p1", textBox_categoryName.Text);
            updateCategoryCommand.Parameters.AddWithValue("@p2", textBox_id.Text);
            updateCategoryCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Updated!");
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            SqlCommand searchCategoryCommand = new SqlCommand("SELECT * FROM table_category WHERE category_name=@p1", connection);
            searchCategoryCommand.Parameters.AddWithValue("@p1", textBox_categoryName.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(searchCategoryCommand);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource= dt;
            MessageBox.Show("Search is completed!");
        }
    }
}
