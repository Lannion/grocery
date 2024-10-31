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

namespace GroceryStore
{
    public partial class Orders : Form
    {
        private string sqlconnection = @"Data Source=DESKTOP-8RR688H;Initial Catalog=GroceryStore;Integrated Security=True;Encrypt=False;";
        public MainGrocery _MainGroceryInstance;
        public Orders(MainGrocery InstanceMainGrocery)
        {
            InitializeComponent();
            _MainGroceryInstance = InstanceMainGrocery;
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            OrdersTableData();
            timer1.Start();
        }

        private void OrdersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OrdersTableData() 
        {
            using (SqlConnection sql = new SqlConnection(sqlconnection))
            {
                sql.Open();
                string query = "SELECT * FROM Orders";
                SqlDataAdapter da = new SqlDataAdapter(query, sql);
                DataTable dt = new DataTable();
                da.Fill(dt);
                OrdersDGV.DataSource = dt;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            OrdersDGV.ClearSelection();
            timer1.Stop();
        }

        //Delete an order in the table
        //delete order selected by button
        private void DeleteRow_button_Click(object sender, EventArgs e)
        {
            if (OrdersDGV.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure to delete the order record?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string orderId = OrdersDGV.SelectedRows[0].Cells["OrderID"].Value.ToString();
                    using (SqlConnection sql = new SqlConnection(sqlconnection))
                    {
                        sql.Open();
                        string query = "DELETE FROM Orders WHERE OrderID = @OrderID";
                        SqlCommand cmd = new SqlCommand(query, sql);
                        cmd.Parameters.AddWithValue("@OrderID", orderId);
                        cmd.ExecuteNonQuery();
                    }
                    OrdersTableData();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }
    }
}
