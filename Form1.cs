using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;


namespace ShoppingCart
{

    public partial class Form1 : Form
    {
        private ShoppingCart cart = new ShoppingCart();
        private List<Product> products = new List<Product>();
        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();
            InitializeDataGridView2();
            LoadProducts();
        }

        private void InitializeDataGridView()
        {

            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "Image", HeaderText = "Ảnh" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "Name", HeaderText = "Tên Sản Phẩm" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "Price", HeaderText = "Giá" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "Quantity", HeaderText = "Số Lượng" });

            // Set full row selection
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;

        }
        private void InitializeDataGridView2()
        {
            dataGridView2.Columns.Clear();
            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn { Name = "Name", HeaderText = "Tên Sản Phẩm" });
            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn { Name = "Price", HeaderText = "Giá" });
            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn { Name = "Quantity", HeaderText = "Số Lượng" });
            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn { Name = "Total", HeaderText = "Tổng Tiền" });

            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.ReadOnly = true;
        }
        private void LoadProducts()
        {
            products.Add(new Product(null,"Product 1", 100000, 1));
            products.Add(new Product(null,"Product 2", 200000, 1));
            products.Add(new Product(null,"Product 3", 150000, 1));

            dataGridView1.Rows.Clear();

            foreach (var product in products)
            {
                dataGridView1.Rows.Add(product.Image, product.Name, product.Price, product.Quantity);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                string name = selectedRow.Cells["Name"].Value.ToString();
                double price = Convert.ToDouble(selectedRow.Cells["Price"].Value);
                int quantity = Convert.ToInt32(selectedRow.Cells["Quantity"].Value);

                var product = new Product(null,name, price, quantity);
                cart.AddProduct(product);

                UpdateCartView();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                string name = dataGridView2.SelectedRows[0].Cells["Name"].Value.ToString();
                var productToRemove = cart.Items.FirstOrDefault(p => p.Name == name);

                if (productToRemove != null)
                {
                    cart.RemoveProduct(productToRemove);
                }

                UpdateCartView();
            }
        }
        private void UpdateCartView()
        {
            dataGridView2.Rows.Clear(); // Xóa các hàng hiện có trong DataGridView

            foreach (var item in cart.Items)
            {
                dataGridView2.Rows.Add(item.Name, item.Price, item.Quantity, item.Price * item.Quantity);
            }

           
            double total = cart.CalculateTotal();
            String setTotal = total.ToString();
            lbThanhToan.Text = $"Tổng Tiền: {setTotal}";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Thanh toán thành công");
            cart.Clear();
            UpdateCartView();
        }

        private void lbThanhToan_Click(object sender, EventArgs e)
        {

        }
    }
}
