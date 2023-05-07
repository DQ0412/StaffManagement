namespace QLNS
{
    partial class ChucVu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txttim = new TextBox();
            txtmacv = new TextBox();
            dtgcv = new DataGridView();
            txttencv = new TextBox();
            label3 = new Label();
            btnthem = new Button();
            btnsua = new Button();
            btnxoa = new Button();
            btnhuy = new Button();
            btntim = new Button();
            lbbanghi = new Label();
            btnghi = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgcv).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 33);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Tìm Kiếm:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 334);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã Chức Vụ:";
            // 
            // txttim
            // 
            txttim.Location = new Point(135, 30);
            txttim.Name = "txttim";
            txttim.Size = new Size(523, 27);
            txttim.TabIndex = 2;
            // 
            // txtmacv
            // 
            txtmacv.Location = new Point(187, 331);
            txtmacv.Name = "txtmacv";
            txtmacv.Size = new Size(471, 27);
            txtmacv.TabIndex = 3;
            txtmacv.TextChanged += txtmacv_TextChanged;
            // 
            // dtgcv
            // 
            dtgcv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgcv.Location = new Point(54, 112);
            dtgcv.Name = "dtgcv";
            dtgcv.RowHeadersWidth = 51;
            dtgcv.RowTemplate.Height = 29;
            dtgcv.Size = new Size(716, 188);
            dtgcv.TabIndex = 4;
            dtgcv.CellContentClick += dtgcv_CellContentClick;
            // 
            // txttencv
            // 
            txttencv.Location = new Point(187, 376);
            txttencv.Name = "txttencv";
            txttencv.Size = new Size(471, 27);
            txttencv.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 379);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 5;
            label3.Text = "Tên Chức Vụ";
            // 
            // btnthem
            // 
            btnthem.Location = new Point(187, 442);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(94, 29);
            btnthem.TabIndex = 7;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = true;
            btnthem.Click += button1_Click;
            // 
            // btnsua
            // 
            btnsua.Location = new Point(287, 442);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(94, 29);
            btnsua.TabIndex = 8;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = true;
            btnsua.Click += btnsua_Click;
            // 
            // btnxoa
            // 
            btnxoa.Location = new Point(487, 442);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(94, 29);
            btnxoa.TabIndex = 9;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnxoa_Click;
            // 
            // btnhuy
            // 
            btnhuy.Location = new Point(587, 442);
            btnhuy.Name = "btnhuy";
            btnhuy.Size = new Size(94, 29);
            btnhuy.TabIndex = 10;
            btnhuy.Text = "Hủy bỏ";
            btnhuy.UseVisualStyleBackColor = true;
            btnhuy.Click += btnhuy_Click;
            // 
            // btntim
            // 
            btntim.Location = new Point(676, 33);
            btntim.Name = "btntim";
            btntim.Size = new Size(94, 29);
            btntim.TabIndex = 11;
            btntim.Text = "Tìm";
            btntim.UseVisualStyleBackColor = true;
            btntim.Click += btntim_Click;
            // 
            // lbbanghi
            // 
            lbbanghi.AutoSize = true;
            lbbanghi.Font = new Font("Tahoma", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lbbanghi.ForeColor = SystemColors.ControlText;
            lbbanghi.Location = new Point(54, 70);
            lbbanghi.Name = "lbbanghi";
            lbbanghi.Size = new Size(132, 18);
            lbbanghi.TabIndex = 12;
            lbbanghi.Text = "Tổng số: 0 bản ghi";
            // 
            // btnghi
            // 
            btnghi.Location = new Point(387, 442);
            btnghi.Name = "btnghi";
            btnghi.Size = new Size(94, 29);
            btnghi.TabIndex = 13;
            btnghi.Text = "Ghi dữ liệu";
            btnghi.UseVisualStyleBackColor = true;
            btnghi.Click += btnghi_Click;
            // 
            // ChucVu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(820, 511);
            Controls.Add(btnghi);
            Controls.Add(lbbanghi);
            Controls.Add(btntim);
            Controls.Add(btnhuy);
            Controls.Add(btnxoa);
            Controls.Add(btnsua);
            Controls.Add(btnthem);
            Controls.Add(txttencv);
            Controls.Add(label3);
            Controls.Add(dtgcv);
            Controls.Add(txtmacv);
            Controls.Add(txttim);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ChucVu";
            Text = "ChucVu";
            Load += PhongBan_Load;
            ((System.ComponentModel.ISupportInitialize)dtgcv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txttim;
        private TextBox txtmacv;
        private DataGridView dtgcv;
        private TextBox txttencv;
        private Label label3;
        private Button btnthem;
        private Button btnsua;
        private Button btnxoa;
        private Button btnhuy;
        private Button btntim;
        private Label lbbanghi;
        private Button btnghi;
    }
}