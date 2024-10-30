using System.Windows.Forms;

namespace ShoppingCart
{
    public partial class Form1 : Form
    {
        private bool isBorderVisible = false;
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("D:\\Code Lung Tung\\C and C++\\C#\\ShoppingCart\\OMO.png");
            pictureBox2.Image = Image.FromFile("D:\\Code Lung Tung\\C and C++\\C#\\ShoppingCart\\ARIEL.jpg");
            pictureBox3.Image = Image.FromFile("D:\\Code Lung Tung\\C and C++\\C#\\ShoppingCart\\ABA.jpg");
            flowLayoutPanel1.Click += new EventHandler(flowLayoutPanel1_Click);
            flowLayoutPanel1.Paint += new PaintEventHandler(flowLayoutPanel1_Paint);
            flowLayoutPanel2.Click += new EventHandler(flowLayoutPanel2_Click); // Gán sự kiện Click
            flowLayoutPanel2.Paint += new PaintEventHandler(flowLayoutPanel2_Paint); // Gán sự kiện Paint
            flowLayoutPanel4.Click += new EventHandler(flowLayoutPanel4_Click);
            flowLayoutPanel4.Paint += new PaintEventHandler(flowLayoutPanel4_Paint);
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

        private void SetupListView()
        {
            listView1.View = View.Details;
            listView1.Columns.Add("Tên sản phẩm", 150);
            listView1.Columns.Add("Giá", 100);
            listView1.Columns.Add("Số lượng", 100);


            //listView1.SmallImageList = ; // Kết nối ImageList với ListView
        }

    }
}
