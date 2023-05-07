namespace QLNS
{
    partial class HopDong
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
            txtnoidung = new TextBox();
            label5 = new Label();
            dtngay = new DateTimePicker();
            label4 = new Label();
            lbbanghi = new Label();
            btntim = new Button();
            btnhuy = new Button();
            btnxoa = new Button();
            btnsua = new Button();
            btnthem = new Button();
            txtmaloai = new TextBox();
            label3 = new Label();
            dtghd = new DataGridView();
            txtsohd = new TextBox();
            txttim = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnghi = new Button();
            ((System.ComponentModel.ISupportInitialize)dtghd).BeginInit();
            SuspendLayout();
            // 
            // txtnoidung
            // 
            txtnoidung.Location = new Point(202, 409);
            txtnoidung.Multiline = true;
            txtnoidung.Name = "txtnoidung";
            txtnoidung.Size = new Size(586, 94);
            txtnoidung.TabIndex = 63;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(71, 409);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 62;
            label5.Text = "Nội Dung:";
            // 
            // dtngay
            // 
            dtngay.Location = new Point(538, 311);
            dtngay.Name = "dtngay";
            dtngay.Size = new Size(250, 27);
            dtngay.TabIndex = 61;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(433, 316);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 60;
            label4.Text = "Ngày Lập:";
            // 
            // lbbanghi
            // 
            lbbanghi.AutoSize = true;
            lbbanghi.Font = new Font("Tahoma", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lbbanghi.ForeColor = SystemColors.ControlText;
            lbbanghi.Location = new Point(72, 52);
            lbbanghi.Name = "lbbanghi";
            lbbanghi.Size = new Size(132, 18);
            lbbanghi.TabIndex = 59;
            lbbanghi.Text = "Tổng số: 0 bản ghi";
            // 
            // btntim
            // 
            btntim.Location = new Point(694, 15);
            btntim.Name = "btntim";
            btntim.Size = new Size(94, 29);
            btntim.TabIndex = 58;
            btntim.Text = "Tìm";
            btntim.UseVisualStyleBackColor = true;
            btntim.Click += btntim_Click;
            // 
            // btnhuy
            // 
            btnhuy.Location = new Point(605, 519);
            btnhuy.Name = "btnhuy";
            btnhuy.Size = new Size(94, 29);
            btnhuy.TabIndex = 57;
            btnhuy.Text = "Hủy bỏ";
            btnhuy.UseVisualStyleBackColor = true;
            btnhuy.Click += btnhuy_Click;
            // 
            // btnxoa
            // 
            btnxoa.Location = new Point(505, 519);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(94, 29);
            btnxoa.TabIndex = 56;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnxoa_Click;
            // 
            // btnsua
            // 
            btnsua.Location = new Point(305, 519);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(94, 29);
            btnsua.TabIndex = 55;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = true;
            btnsua.Click += btnsua_Click;
            // 
            // btnthem
            // 
            btnthem.Location = new Point(205, 519);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(94, 29);
            btnthem.TabIndex = 54;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = true;
            btnthem.Click += btnthem_Click;
            // 
            // txtmaloai
            // 
            txtmaloai.Location = new Point(205, 358);
            txtmaloai.Name = "txtmaloai";
            txtmaloai.Size = new Size(583, 27);
            txtmaloai.TabIndex = 53;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 361);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 52;
            label3.Text = "Mã Loại:";
            // 
            // dtghd
            // 
            dtghd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtghd.Location = new Point(72, 94);
            dtghd.Name = "dtghd";
            dtghd.RowHeadersWidth = 51;
            dtghd.RowTemplate.Height = 29;
            dtghd.Size = new Size(716, 188);
            dtghd.TabIndex = 51;
            dtghd.CellClick += dtghd_CellClick;
            // 
            // txtsohd
            // 
            txtsohd.Location = new Point(205, 313);
            txtsohd.Name = "txtsohd";
            txtsohd.Size = new Size(211, 27);
            txtsohd.TabIndex = 50;
            txtsohd.TextChanged += txtsohd_TextChanged;
            // 
            // txttim
            // 
            txttim.Location = new Point(153, 12);
            txttim.Name = "txttim";
            txttim.Size = new Size(523, 27);
            txttim.TabIndex = 49;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 316);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 48;
            label2.Text = "Số Hợp Đồng:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 15);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 47;
            label1.Text = "Tìm Kiếm:";
            // 
            // btnghi
            // 
            btnghi.Location = new Point(405, 519);
            btnghi.Name = "btnghi";
            btnghi.Size = new Size(94, 29);
            btnghi.TabIndex = 64;
            btnghi.Text = "Ghi dữ liệu";
            btnghi.UseVisualStyleBackColor = true;
            btnghi.Click += btnghi_Click;
            // 
            // HopDong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(880, 584);
            Controls.Add(btnghi);
            Controls.Add(txtnoidung);
            Controls.Add(label5);
            Controls.Add(dtngay);
            Controls.Add(label4);
            Controls.Add(lbbanghi);
            Controls.Add(btntim);
            Controls.Add(btnhuy);
            Controls.Add(btnxoa);
            Controls.Add(btnsua);
            Controls.Add(btnthem);
            Controls.Add(txtmaloai);
            Controls.Add(label3);
            Controls.Add(dtghd);
            Controls.Add(txtsohd);
            Controls.Add(txttim);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "HopDong";
            Text = "HopDong";
            ((System.ComponentModel.ISupportInitialize)dtghd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtnoidung;
        private Label label5;
        private DateTimePicker dtngay;
        private Label label4;
        private Label lbbanghi;
        private Button btntim;
        private Button btnhuy;
        private Button btnxoa;
        private Button btnsua;
        private Button btnthem;
        private TextBox txtmaloai;
        private Label label3;
        private DataGridView dtghd;
        private TextBox txtsohd;
        private TextBox txttim;
        private Label label2;
        private Label label1;
        private Button btnghi;
    }
}