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
            dataGridView1 = new DataGridView();
            cotAnh = new DataGridViewTextBoxColumn();
            tenSP = new DataGridViewTextBoxColumn();
            gia = new DataGridViewTextBoxColumn();
            sl = new DataGridViewTextBoxColumn();
            lbDanhMuc = new Label();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            lbThanhToan = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { cotAnh, tenSP, gia, sl });
            dataGridView1.Location = new Point(176, 78);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(555, 184);
            dataGridView1.TabIndex = 0;
            // 
            // cotAnh
            // 
            cotAnh.HeaderText = "Ảnh";
            cotAnh.MinimumWidth = 6;
            cotAnh.Name = "cotAnh";
            cotAnh.Width = 125;
            // 
            // tenSP
            // 
            tenSP.HeaderText = "Tên Sản Phẩm";
            tenSP.MinimumWidth = 6;
            tenSP.Name = "tenSP";
            tenSP.Width = 125;
            // 
            // gia
            // 
            gia.HeaderText = "Giá";
            gia.MinimumWidth = 6;
            gia.Name = "gia";
            gia.Width = 125;
            // 
            // sl
            // 
            sl.HeaderText = "Số Lượng";
            sl.MinimumWidth = 6;
            sl.Name = "sl";
            sl.Width = 125;
            // 
            // lbDanhMuc
            // 
            lbDanhMuc.AccessibleRole = AccessibleRole.None;
            lbDanhMuc.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDanhMuc.Location = new Point(281, 9);
            lbDanhMuc.Name = "lbDanhMuc";
            lbDanhMuc.Size = new Size(407, 49);
            lbDanhMuc.TabIndex = 1;
            lbDanhMuc.Text = "DANH MỤC SẢN PHẨM";
            lbDanhMuc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridView2.Location = new Point(176, 339);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(555, 130);
            dataGridView2.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Tên Sản Phẩm";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Giá";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Số Lượng";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Tổng tiền";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // button1
            // 
            button1.Location = new Point(603, 499);
            button1.Name = "button1";
            button1.Size = new Size(128, 29);
            button1.TabIndex = 5;
            button1.Text = "Thanh Toán";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(332, 290);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 6;
            button2.Text = "Thêm";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(479, 290);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 7;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // lbThanhToan
            // 
            lbThanhToan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbThanhToan.Location = new Point(194, 491);
            lbThanhToan.Name = "lbThanhToan";
            lbThanhToan.Size = new Size(283, 37);
            lbThanhToan.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 579);
            Controls.Add(lbThanhToan);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView2);
            Controls.Add(lbDanhMuc);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn cotAnh;
        private DataGridViewTextBoxColumn tenSP;
        private DataGridViewTextBoxColumn gia;
        private DataGridViewTextBoxColumn sl;
        private Label lbDanhMuc;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label lbThanhToan;
    }
}
