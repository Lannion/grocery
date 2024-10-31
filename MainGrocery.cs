using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace GroceryStore
{
    public partial class MainGrocery : Form
    {
        private string sqlconnection = @"Data Source=DESKTOP-8RR688H;Initial Catalog=GroceryStore;Integrated Security=True;Encrypt=False;";
        private Form activeForm;
        public MainGrocery()
        {
            InitializeComponent();
            LableName.TextChanged += LableName_TextChanged;
        }

        private void MainGrocery_Load(object sender, EventArgs e)
        {

        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Exit Grocery POS?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void OpenChildForm(Form childForm, object clickedButton)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            this.Main_Panel.Controls.Add(childForm);
            this.Main_Panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void FreshProduce_button_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FreshProduce(this), sender);
            Main_Panel.Size = new Size(906, 671);
        }

        private void DairyEggs_button_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DairyEggs(this), sender);
            Main_Panel.Size = new Size(906, 671);
        }

        private void Bakery_button_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Bakery(this), sender);
            Main_Panel.Size = new Size(906, 671);
        }

        private void inventory_button_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Inventory(this), sender);
            Main_Panel.Size = new Size(906, 822);
            Main_Panel.BringToFront();
        }

        private void Orders_button_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Orders(this), sender);
            Main_Panel.Size = new Size(906, 822);
            Main_Panel.BringToFront();
        }

        //Adding borders to panel as design
        //add a black border to panel
        private void DrawPanelBorder(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            int penThickness = 2;
            Pen borderPen = new Pen(Color.Black, penThickness);
            Rectangle rect = new Rectangle(penThickness / 2, penThickness / 2, panel.Width - penThickness, panel.Height - penThickness);
            e.Graphics.DrawRectangle(borderPen, rect);
        }

        private void panel1_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }
        private void panel3_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }
        private void Main_Panel_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }
        private void panel2_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }
        private void panel5_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }
        private void panel6_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }
        private void panel7_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }
        private void panel4_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }
        private void panel8_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }
        private void panel9_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }
        private void panel10_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }
        

        private void receiptdgv_CellContentClick(object sender, DataGridViewCellEventArgs e) { }


        //Finding the product in sql tables
        //Using the product name
        //Creating sql connection when labelname changes
        //Also updating the price based on quantity
        public void SetProductName(string productName)
        {
            LableName.Text = productName;
        }

        private void LableName_TextChanged(object sender, EventArgs e)
        {
            string productName = LableName.Text;
            string productPrice = GetProductPrice(productName);
            LabelPrice.Text = productPrice;
        }

        private string GetProductPrice(string productName)
        {
            string price = "- - - -";
            using (SqlConnection sql = new SqlConnection(sqlconnection))
            {
                sql.Open();
                string query = "SELECT FreshProducePrice AS Price FROM FreshProduce WHERE FreshProduceName = @productName " +
                               "UNION " +
                               "SELECT DairyAndEggsPrice AS Price FROM DairyAndEggs WHERE DairyAndEggsName = @productName " +
                               "UNION " +
                               "SELECT BakeryPrice AS Price FROM Bakery WHERE BakeryName = @productName";
                using (SqlCommand cmd = new SqlCommand(query, sql))
                {
                    cmd.Parameters.AddWithValue("@productName", productName);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        price = reader["Price"].ToString();
                    }
                }
            }
            return price;
        }

        //quantity button function
        //increase and decreas quantity
        private void minus_button_Click(object sender, EventArgs e)
        {
            int currentQuantity;
            if (int.TryParse(LabelQuantity.Text, out currentQuantity))
            {
                if (currentQuantity > 1)
                {
                    currentQuantity--;
                }
            }
            else
            {
                currentQuantity = 1;
            }
            LabelQuantity.Text = currentQuantity.ToString();

            UpdateTotalPrice();
        }

        private void plus_button_Click(object sender, EventArgs e)
        {
            int currentQuantity;
            if (int.TryParse(LabelQuantity.Text, out currentQuantity))
            {
                currentQuantity++;
            }
            else
            {
                currentQuantity = 1;
            }
            LabelQuantity.Text = currentQuantity.ToString();

           
            UpdateTotalPrice();
        }

        private void UpdateTotalPrice()
        {
            string productName = LableName.Text;
            decimal pricePerItem;
            if (decimal.TryParse(GetProductPrice(productName), out pricePerItem))
            {
                int quantity;
                if (int.TryParse(LabelQuantity.Text, out quantity))
                {
                    decimal totalPrice = pricePerItem * quantity;
                    LabelPrice.Text = totalPrice.ToString();
                }
            }
        }

        //add the item to receipt
        //with product name price and quantity
        private void addreceipt_button_Click(object sender, EventArgs e)
        {
            if (LableName.Text == "- - - -")
            {
                MessageBox.Show("Please select a product");
            }
            else if (LabelQuantity.Text == "- - - -")
            {
                MessageBox.Show("Please add a quantity");
            }
            else
            {
                string productName = LableName.Text;
                string productPrice = LabelPrice.Text;
                string productQuantity = LabelQuantity.Text;

                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(receiptdgv);
                row.Cells[0].Value = productName;
                row.Cells[1].Value = productPrice;
                row.Cells[2].Value = productQuantity;
                receiptdgv.Rows.Add(row);

                ReceiptTotal();
                receiptdgv.ClearSelection();
            }

        }

        private void ReceiptTotal()
        {
            if (receiptdgv.Rows.Count > 0)
            {
                TotalPrice_textbox.Clear();
                ItemQuantity_textbox.Clear();
            }

            double totalPrice = 0;
            int totalQuantity = 0;

            foreach (DataGridViewRow row in receiptdgv.Rows)
            {
                double price = Convert.ToDouble(row.Cells["PriceColumn"].Value);
                int quantity = Convert.ToInt32(row.Cells["QuantityColumn"].Value);

                totalPrice += price;
                totalQuantity += quantity;
            }

            TotalPrice_textbox.Text = totalPrice.ToString();
            ItemQuantity_textbox.Text = totalQuantity.ToString();
        }

        //confrim purchase on the receipt
        //save to database in orders table
        //generate order id based on previous order id

        private void confirmPurchase_button_Click(object sender, EventArgs e)
        {
            if (receiptdgv.Rows.Count == 0)
            {
                MessageBox.Show("Please select a product");
            }
            else 
            {
                DialogResult result = MessageBox.Show("Do you want to confirm the purchase?", "Confirm Purchase", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    commitpurchase();
                    DeductProducts();
                }
            }
            
        }
        private void commitpurchase()
        {
            using (SqlConnection sql = new SqlConnection(sqlconnection))
            {
                sql.Open();
                int purchaseQuantity = Convert.ToInt32(ItemQuantity_textbox.Text);
                decimal totalPaid = Convert.ToDecimal(TotalPrice_textbox.Text);
                string orderId = GenerateOrderID(sql);

                string query = "INSERT INTO Orders (OrderID, ProductQuantity, TotalPaid) VALUES (@OrderID, @ProductQuantity, @TotalPaid)";

                using (SqlCommand cmd = new SqlCommand(query, sql))
                {
                    cmd.Parameters.AddWithValue("@OrderID", orderId);
                    cmd.Parameters.AddWithValue("@ProductQuantity", purchaseQuantity);
                    cmd.Parameters.AddWithValue("@TotalPaid", totalPaid);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Purchase confirmed.");
                }
            }
        }

        private string GenerateOrderID(SqlConnection connection)
        {
            try
            {
                SqlCommand getMaxId = new SqlCommand("SELECT MAX(CAST(SUBSTRING(OrderID,7, LEN( OrderID) - 6) AS INT)) FROM Orders", connection);
                object maxIdResult = getMaxId.ExecuteScalar();
                int maxId;
                if (maxIdResult == DBNull.Value)
                {
                    maxId = 0;
                }
                else
                {
                    maxId = Convert.ToInt32(maxIdResult);
                }
                int nextId = maxId + 1;
                string orderId = "Order_" + nextId.ToString();
                return orderId;

            }
            finally
            {
            }
        }

        //Remove items form list
        //remove selected item
        //remove all items
        private void ClearAll_button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Clear all items?", "Clear items Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                receiptdgv.Rows.Clear();
                TotalPrice_textbox.Clear();
                ItemQuantity_textbox.Clear();
                LabelPrice.Text = "- - - -";
                LabelQuantity.Text = "- - - -";
                LableName.Text = "- - - -";
            }
        }

        private void ClearSelected_button_Click(object sender, EventArgs e)
        {
            if (receiptdgv.SelectedRows.Count > 0)
            {
                receiptdgv.Rows.Remove(receiptdgv.SelectedRows[0]);
                ReceiptTotal();
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }


        //Update current stock of inventory
        //deduct from quantity of products
        private void DeductProducts()
        {
            using (SqlConnection sql = new SqlConnection(sqlconnection))
            {
                sql.Open();
                foreach (DataGridViewRow row in receiptdgv.Rows)
                {
                    int quantity = Convert.ToInt32(row.Cells["QuantityColumn"].Value);
                    string productName = row.Cells["ProductColumn"].Value.ToString();
                    
                    DeductProductQuantity(sql, productName, quantity);
                }
            }
        }

        private void DeductProductQuantity(SqlConnection sql, string productName, int quantity)
        {
            string query = "UPDATE FreshProduce SET Quantity = Quantity - @Quantity WHERE FreshProduceName = @ProductName " +
                           "UPDATE DairyAndEggs SET Quantity = Quantity - @Quantity WHERE DairyAndEggsName = @ProductName " +
                           "UPDATE Bakery SET Quantity = Quantity - @Quantity WHERE BakeryName = @ProductName";

            using (SqlCommand cmd = new SqlCommand(query, sql))
            {
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                cmd.Parameters.AddWithValue("@ProductName", productName);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
