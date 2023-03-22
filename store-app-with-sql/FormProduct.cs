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
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-P5AC8NT;Initial Catalog=DBStore;Integrated Security=True");
        private void button_list_Click(object sender, EventArgs e)
        {
           ShowTheList();
        }

      

        private void FormProduct_Load(object sender, EventArgs e)
        {
            SqlCommand showComboBox = new SqlCommand("SELECT * FROM table_category",connection);
            SqlDataAdapter adapter = new SqlDataAdapter(showComboBox);
            DataTable dt = new DataTable(); 
            adapter.Fill(dt);
            comboBox_category.DisplayMember = "category_name";
            comboBox_category.ValueMember = "ID";
            comboBox_category.DataSource = dt;        
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand save = new SqlCommand("INSERT INTO table_products (product_name, product_stock,purchase_price,sale_price,category) Values (@p1,@p2,@p3,@p4,@p5)", connection);
            save.Parameters.AddWithValue("@p1", textBox_name.Text);
            save.Parameters.AddWithValue("@p2", numericUpDown_stock.Value);
            save.Parameters.AddWithValue("@p3", textBox_purchaseCost.Text);
            save.Parameters.AddWithValue("@p4", textBox_saleCost.Text);
            save.Parameters.AddWithValue("@p5", comboBox_category.SelectedValue);
            save.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Data's saved!");
            ShowTheList();
        
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand delete = new SqlCommand("DELETE FROM table_products WHERE product_id=@p1", connection);
            delete.Parameters.AddWithValue("@p1", textBox_id.Text);
            delete.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Item is deleted.");
            ShowTheList();
        }

        private void ShowTheList()
        {
            SqlCommand list = new SqlCommand("SELECT * FROM table_products", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(list);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox_name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            numericUpDown_stock.Value = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            textBox_purchaseCost.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox_saleCost.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            comboBox_category.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
    }
}
