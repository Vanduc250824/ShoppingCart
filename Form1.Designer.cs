namespace ShoppingCart
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            flowLayoutPanel4 = new FlowLayoutPanel();
            pictureBox3 = new PictureBox();
            listView3 = new ListView();
            flowLayoutPanel3 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            pictureBox2 = new PictureBox();
            listView2 = new ListView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            listView1 = new ListView();
            button1 = new Button();
            button2 = new Button();
            groupBox2 = new GroupBox();
            listView4 = new ListView();
            lblTotal = new Label();
            button3 = new Button();
            groupBox1.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(flowLayoutPanel4);
            groupBox1.Controls.Add(flowLayoutPanel3);
            groupBox1.Controls.Add(flowLayoutPanel2);
            groupBox1.Controls.Add(flowLayoutPanel1);
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(24, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1168, 393);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách sản phẩm";
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(pictureBox3);
            flowLayoutPanel4.Controls.Add(listView3);
            flowLayoutPanel4.Location = new Point(796, 37);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(338, 350);
            flowLayoutPanel4.TabIndex = 9;
            flowLayoutPanel4.Paint += flowLayoutPanel4_Paint;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(3, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(160, 215);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // listView3
            // 
            listView3.Font = new Font("Verdana", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listView3.Location = new Point(1, 221);
            listView3.Margin = new Padding(1, 0, 1, 0);
            listView3.Name = "listView3";
            listView3.OwnerDraw = true;
            listView3.Scrollable = false;
            listView3.Size = new Size(332, 126);
            listView3.TabIndex = 7;
            listView3.UseCompatibleStateImageBehavior = false;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Location = new Point(850, 67);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(250, 125);
            flowLayoutPanel3.TabIndex = 8;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(pictureBox2);
            flowLayoutPanel2.Controls.Add(listView2);
            flowLayoutPanel2.Location = new Point(413, 37);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(337, 350);
            flowLayoutPanel2.TabIndex = 7;
            flowLayoutPanel2.Paint += flowLayoutPanel2_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(160, 215);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // listView2
            // 
            listView2.Font = new Font("Verdana", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listView2.Location = new Point(1, 221);
            listView2.Margin = new Padding(1, 0, 1, 0);
            listView2.Name = "listView2";
            listView2.OwnerDraw = true;
            listView2.Scrollable = false;
            listView2.Size = new Size(332, 126);
            listView2.TabIndex = 5;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Controls.Add(listView1);
            flowLayoutPanel1.Location = new Point(6, 37);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(338, 350);
            flowLayoutPanel1.TabIndex = 6;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 215);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // listView1
            // 
            listView1.Font = new Font("Verdana", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listView1.Location = new Point(1, 221);
            listView1.Margin = new Padding(1, 0, 1, 0);
            listView1.Name = "listView1";
            listView1.OwnerDraw = true;
            listView1.Scrollable = false;
            listView1.Size = new Size(332, 126);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            button1.Location = new Point(319, 429);
            button1.Name = "button1";
            button1.Size = new Size(210, 43);
            button1.TabIndex = 1;
            button1.Text = "Thêm vào giỏ hàng";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(657, 429);
            button2.Name = "button2";
            button2.Size = new Size(210, 43);
            button2.TabIndex = 2;
            button2.Text = "Xóa khỏi giỏ hàng";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listView4);
            groupBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(24, 478);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1168, 187);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Giỏ hàng";
            // 
            // listView4
            // 
            listView4.Font = new Font("Verdana", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listView4.Location = new Point(15, 45);
            listView4.Margin = new Padding(1, 0, 1, 0);
            listView4.Name = "listView4";
            listView4.OwnerDraw = true;
            listView4.Scrollable = false;
            listView4.Size = new Size(1131, 126);
            listView4.TabIndex = 2;
            listView4.UseCompatibleStateImageBehavior = false;
            // 
            // lblTotal
            // 
            lblTotal.Location = new Point(24, 684);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(302, 56);
            lblTotal.TabIndex = 4;
            lblTotal.Click += lblTotal_Click;
            // 
            // button3
            // 
            button3.Location = new Point(856, 684);
            button3.Name = "button3";
            button3.Size = new Size(302, 43);
            button3.TabIndex = 5;
            button3.Text = "Thanh toán";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1219, 749);
            Controls.Add(button3);
            Controls.Add(lblTotal);
            Controls.Add(groupBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            flowLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private Button button2;
        private GroupBox groupBox2;
        private ListView listView4;
        private Label lblTotal;
        private Button button3;
        private FlowLayoutPanel flowLayoutPanel4;
        private PictureBox pictureBox3;
        private ListView listView3;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel2;
        private PictureBox pictureBox2;
        private ListView listView2;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox1;
        private ListView listView1;
    }
}
