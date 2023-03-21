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
            SqlCommand list = new SqlCommand("SELECT * FROM table_products", connection);
            SqlDataAdapter adapter= new SqlDataAdapter(list);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
