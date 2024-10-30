using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ShoppingCart
{
    public partial class Form1 : Form
    {
        private ShoppingCart cart = new ShoppingCart();
        private List<Product> products = new List<Product>();
        private bool isBorderVisible = false;
        public Form1()
        {
            InitializeComponent();
            LoadProducts();
            SetupListView();
            UpdateCartDisplay();



            // Gán sự kiện cho các flowLayoutPanels
            flowLayoutPanel1.Click += new EventHandler(flowLayoutPanel1_Click);
            flowLayoutPanel1.Paint += new PaintEventHandler(flowLayoutPanel1_Paint);
            flowLayoutPanel2.Click += new EventHandler(flowLayoutPanel2_Click);
            flowLayoutPanel2.Paint += new PaintEventHandler(flowLayoutPanel2_Paint);
            flowLayoutPanel4.Click += new EventHandler(flowLayoutPanel4_Click);
            flowLayoutPanel4.Paint += new PaintEventHandler(flowLayoutPanel4_Paint);
        }
        private void LoadProducts()
        {
            // Define sample products
            products.Add(new Product("OMO", 100000, 1, Image.FromFile("D:\\Code Lung Tung\\C and C++\\C#\\ShoppingCart\\OMO.png")));
            products.Add(new Product("ARIEL", 150000, 1, Image.FromFile("D:\\Code Lung Tung\\C and C++\\C#\\ShoppingCart\\ARIEL.jpg")));
            products.Add(new Product("ABA", 200000, 1, Image.FromFile("D:\\Code Lung Tung\\C and C++\\C#\\ShoppingCart\\ABA.jpg")));

            // Load products into flowLayoutPanel controls
            DisplayProduct(flowLayoutPanel1, products[0]);
            DisplayProduct(flowLayoutPanel2, products[1]);
            DisplayProduct(flowLayoutPanel4, products[2]);
        }
        private void DisplayProduct(FlowLayoutPanel panel, Product product)
        {
            PictureBox pictureBox = (PictureBox)panel.Controls[0];
            ListView listView = (ListView)panel.Controls[1];

            pictureBox.Image = product.Image;
            listView.Items.Clear();
            listView.Items.Add(new ListViewItem(new string[] { product.Name, product.Price.ToString("C"), product.Quantity.ToString() }));
        }
        private void SetupListView()
        {
            listView1.View = View.Details;
            listView1.Columns.Add("Tên sản phẩm", 150);
            listView1.Columns.Add("Giá", 100);
            listView1.Columns.Add("Số lượng", 100);
        }
        private void UpdateCartDisplay()
        {
            listView1.Items.Clear();
            foreach (var product in cart.Items)
            {
                var item = new ListViewItem(new string[] { product.Name, product.Price.ToString(), product.Quantity.ToString() });
                listView1.Items.Add(item);
            }

            // Cập nhật tổng giá trị
            lblTotal.Text = $"Tổng giá trị: {cart.CalculateTotal():C}";
        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            if (isBorderVisible)
            {
                // Vẽ viền nếu trạng thái là true
                Pen pen = new Pen(Color.Blue, 2); // Màu và độ dày của viền
                e.Graphics.DrawRectangle(pen, 0, 0, flowLayoutPanel1.Width - 1, flowLayoutPanel1.Height - 1); // Vẽ viền
            }
        }
        private void flowLayoutPanel1_Click(object sender, EventArgs e)
        {
            // Đặt màu khung cho FlowLayoutPanel
            isBorderVisible = !isBorderVisible;

            // Gọi lại sự kiện Paint để vẽ lại viền
            flowLayoutPanel1.Invalidate();
        }
        private void flowLayoutPanel2_Click(object sender, EventArgs e)
        {
            // Đảo ngược trạng thái hiển thị viền
            isBorderVisible = !isBorderVisible;

            // Gọi lại sự kiện Paint để vẽ lại viền
            flowLayoutPanel2.Invalidate();
        }
        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
            if (isBorderVisible)
            {
                // Vẽ viền nếu trạng thái là true
                Pen pen = new Pen(Color.Blue, 2);
                e.Graphics.DrawRectangle(pen, 0, 0, flowLayoutPanel1.Width - 1, flowLayoutPanel1.Height - 1);
            }
        }

        private void flowLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {
            if (isBorderVisible)
            {
                // Vẽ viền nếu trạng thái là true
                Pen pen = new Pen(Color.Blue, 2);
                e.Graphics.DrawRectangle(pen, 0, 0, flowLayoutPanel1.Width - 1, flowLayoutPanel1.Height - 1);
            }
        }
        private void flowLayoutPanel4_Click(object sender, EventArgs e)
        {
            // Đảo ngược trạng thái hiển thị viền
            isBorderVisible = !isBorderVisible;

            // Gọi lại sự kiện Paint để vẽ lại viền
            flowLayoutPanel4.Invalidate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cart.Items.Any())
            {
                MessageBox.Show($"Thanh toán thành công! Tổng cộng: {cart.CalculateTotal():C}");
                cart.Clear();
                UpdateCartDisplay();
            }
            else
            {
                MessageBox.Show("Giỏ hàng trống.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string selectedProductName = listView1.SelectedItems[0].SubItems[0].Text;
                var product = products.FirstOrDefault(p => p.Name == selectedProductName);

                if (product != null)
                {
                    cart.AddProduct(product);
                    UpdateCartDisplay();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để thêm vào giỏ hàng.");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (listView4.SelectedItems.Count > 0)
            {
                string selectedProductName = listView4.SelectedItems[0].SubItems[0].Text;
                var product = cart.Items.FirstOrDefault(p => p.Name == selectedProductName);

                if (product != null)
                {
                    cart.RemoveProduct(product);
                    UpdateCartDisplay();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để xóa khỏi giỏ hàng.");
            }
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {
            listView4.Items.Clear();
            foreach (var item in cart.Items)
            {
                var listViewItem = new ListViewItem(new string[] { item.Name, item.Price.ToString("C"), item.Quantity.ToString() });
                listView4.Items.Add(listViewItem);
            }

            lblTotal.Text = $"Tổng giá trị: {cart.CalculateTotal():C}";
        }
    }
}
