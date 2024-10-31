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
using System.Xml;


namespace GroceryStore
{
    public partial class Inventory : Form
    {
        private string sqlconnection = @"Data Source=DESKTOP-8RR688H;Initial Catalog=GroceryStore;Integrated Security=True;Encrypt=False;";
        public MainGrocery _MainGroceryInstance;
        public Inventory(MainGrocery InstanceMainGrocery)
        {
            InitializeComponent();
            _MainGroceryInstance = InstanceMainGrocery;
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            ProductID_comboBox.SelectedIndexChanged += new EventHandler(ProductID_comboBox_SelectedIndexChanged);
        }

        //buttons for inventory
        //select between 3 tables
        private void SetButtonBackgrounds(Button clickedButton)
        {
            foreach (Button b in new Button[] {FreshProduce_Button,DairyEggs_Button,Bakery_Button})
            {
                if (b == clickedButton)
                {
                    b.BackColor = Color.DarkSlateGray;
                    b.ForeColor = Color.White;
                }
                else
                {
                    b.BackColor = Color.Chartreuse;
                    b.ForeColor = Color.Black;
                }

            }
        }

        private void FreshProduce_Button_Click(object sender, EventArgs e)
        {
            SetButtonBackgrounds(sender as Button);
            FreshProduce();
            OrdersDGV.ClearSelection();
            DisplayComboBoxIDs("FreshProduce");
        }
        private void FreshProduce() 
        {
            using (SqlConnection sql = new SqlConnection(sqlconnection))
            {
                sql.Open();
                string query = "SELECT * FROM FreshProduce";
                SqlDataAdapter da = new SqlDataAdapter(query, sql);
                DataTable dt = new DataTable();
                da.Fill(dt);
                OrdersDGV.DataSource = dt;
            }
        }

        private void DairyEggs_Button_Click(object sender, EventArgs e)
        {
            SetButtonBackgrounds(sender as Button);
            DairyEggs();
            OrdersDGV.ClearSelection();
            DisplayComboBoxIDs("DairyEggs");
        }
        private void DairyEggs() 
        {
            using (SqlConnection sql = new SqlConnection(sqlconnection))
            {
                sql.Open();
                string query = "SELECT * FROM DairyAndEggs";
                SqlDataAdapter da = new SqlDataAdapter(query, sql);
                DataTable dt = new DataTable();
                da.Fill(dt);
                OrdersDGV.DataSource = dt;
            }
        }
        private void Bakery_Button_Click(object sender, EventArgs e)
        {
            SetButtonBackgrounds(sender as Button);
            Bakery();
            OrdersDGV.ClearSelection();
            DisplayComboBoxIDs("Bakery");
        }
        private void Bakery() 
        {
            using (SqlConnection sql = new SqlConnection(sqlconnection))
            {
                sql.Open();
                string query = "SELECT * FROM Bakery";
                SqlDataAdapter da = new SqlDataAdapter(query, sql);
                DataTable dt = new DataTable();
                da.Fill(dt);
                OrdersDGV.DataSource = dt;
            }
        }

        //display ids on combobox
        //dislay data of selected id
        private void DisplayComboBoxIDs(string tablename)
        {
            ProductID_comboBox.Items.Clear();

            string query = "";
            string column = "";
            switch (tablename)
            {
                case "Bakery":
                    query = "SELECT BakeryID FROM Bakery";
                    column = "BakeryID";
                    break;
                case "DairyEggs":
                    query = "SELECT DairyAndEggsID FROM DairyAndEggs";
                    column = "DairyAndEggsID";
                    break;
                case "FreshProduce":
                    query = "SELECT FreshProduceID FROM FreshProduce";
                    column = "FreshProduceID";
                    break;
                default:
                    return; 
            }

            using (SqlConnection sql = new SqlConnection(sqlconnection))
            {
                sql.Open();
                SqlCommand cmd = new SqlCommand(query, sql);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ProductID_comboBox.Items.Add(reader[column].ToString());
                }

                reader.Close();
            }
        }
        private void ProductID_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedID = ProductID_comboBox.SelectedItem.ToString();
            string query = "";

            if (selectedID.StartsWith("BK"))
            {
                query = "SELECT BakeryPrice AS Price, Quantity FROM Bakery WHERE BakeryID = @ProductID";
            }
            else if (selectedID.StartsWith("DE"))
            {
                query = "SELECT DairyAndEggsPrice AS Price, Quantity FROM DairyAndEggs WHERE DairyAndEggsID = @ProductID";
            }
            else if (selectedID.StartsWith("FP"))
            {
                query = "SELECT FreshProducePrice AS Price, Quantity FROM FreshProduce WHERE FreshProduceID = @ProductID";
            }

            if (!string.IsNullOrEmpty(query))
            {
                using (SqlConnection sql = new SqlConnection(sqlconnection))
                {
                    sql.Open();
                    SqlCommand cmd = new SqlCommand(query, sql);
                    cmd.Parameters.AddWithValue("@ProductID", selectedID);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        Price_textbox.Text = reader["Price"].ToString();
                        Quantity_textbox.Text = reader["Quantity"].ToString();
                    }

                    reader.Close();
                }
            }
        }

        //Confirm Changes in the inventory table
        //Update table inventory
        private void Confrim_button_Click(object sender, EventArgs e)
        {
            string selectedID = ProductID_comboBox.SelectedItem.ToString();
            string priceText = Price_textbox.Text;
            string quantityText = Quantity_textbox.Text;

            if (!decimal.TryParse(priceText, out decimal price) || !int.TryParse(quantityText, out int quantity))
            {
                MessageBox.Show("Please enter valid numeric values for price and quantity.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "";
            if (selectedID.StartsWith("BK"))
            {
                query = "UPDATE Bakery SET BakeryPrice = @Price, Quantity = @Quantity WHERE BakeryID = @ProductID";
            }
            else if (selectedID.StartsWith("DE"))
            {
                query = "UPDATE DairyAndEggs SET DairyAndEggsPrice = @Price, Quantity = @Quantity WHERE DairyAndEggsID = @ProductID";
            }
            else if (selectedID.StartsWith("FP"))
            {
                query = "UPDATE FreshProduce SET FreshProducePrice = @Price, Quantity = @Quantity WHERE FreshProduceID = @ProductID";
            }

            if (!string.IsNullOrEmpty(query))
            {
                using (SqlConnection sql = new SqlConnection(sqlconnection))
                {
                    sql.Open();
                    SqlCommand cmd = new SqlCommand(query, sql);
                    cmd.Parameters.AddWithValue("@ProductID", selectedID);
                    cmd.Parameters.AddWithValue("@Price", price);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        DialogResult result = MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (result == DialogResult.OK) 
                        {
                            if (selectedID.StartsWith("BK"))
                            {
                                Bakery();
                                OrdersDGV.ClearSelection();
                            }
                            else if (selectedID.StartsWith("DE"))
                            { 
                                DairyEggs();
                                OrdersDGV.ClearSelection();
                            }
                            else if (selectedID.StartsWith("FP"))
                            {
                                FreshProduce();
                                OrdersDGV.ClearSelection(); 
                            }
                        }
                        else 
                        {
                            if(selectedID.StartsWith("BK"))
                            {
                                Bakery();
                                OrdersDGV.ClearSelection();
                            }
                            else if (selectedID.StartsWith("DE"))
                            {
                                DairyEggs();
                                OrdersDGV.ClearSelection();
                            }
                            else if (selectedID.StartsWith("FP"))
                            {
                                FreshProduce();
                                OrdersDGV.ClearSelection();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No record found with the given ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

       
    }
}
