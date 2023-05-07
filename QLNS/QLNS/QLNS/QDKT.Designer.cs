namespace QLNS
{
    partial class QDKT
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
            txttien = new TextBox();
            label3 = new Label();
            dtgqdkt = new DataGridView();
            txtsoqdkt = new TextBox();
            txttim = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnghi = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgqdkt).BeginInit();
            SuspendLayout();
            // 
            // txtnoidung
            // 
            txtnoidung.Location = new Point(173, 402);
            txtnoidung.Multiline = true;
            txtnoidung.Name = "txtnoidung";
            txtnoidung.Size = new Size(586, 94);
            txtnoidung.TabIndex = 46;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 402);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 45;
            label5.Text = "Nội Dung:";
            // 
            // dtngay
            // 
            dtngay.Location = new Point(509, 304);
            dtngay.Name = "dtngay";
            dtngay.Size = new Size(250, 27);
            dtngay.TabIndex = 44;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(404, 309);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 43;
            label4.Text = "Ngày QĐKT:";
            // 
            // lbbanghi
            // 
            lbbanghi.AutoSize = true;
            lbbanghi.Font = new Font("Tahoma", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lbbanghi.ForeColor = SystemColors.ControlText;
            lbbanghi.Location = new Point(43, 45);
            lbbanghi.Name = "lbbanghi";
            lbbanghi.Size = new Size(132, 18);
            lbbanghi.TabIndex = 42;
            lbbanghi.Text = "Tổng số: 0 bản ghi";
            // 
            // btntim
            // 
            btntim.Location = new Point(665, 8);
            btntim.Name = "btntim";
            btntim.Size = new Size(94, 29);
            btntim.TabIndex = 41;
            btntim.Text = "Tìm";
            btntim.UseVisualStyleBackColor = true;
            btntim.Click += btntim_Click;
            // 
            // btnhuy
            // 
            btnhuy.Location = new Point(619, 512);
            btnhuy.Name = "btnhuy";
            btnhuy.Size = new Size(94, 29);
            btnhuy.TabIndex = 40;
            btnhuy.Text = "Hủy bỏ";
            btnhuy.UseVisualStyleBackColor = true;
            btnhuy.Click += btnhuy_Click;
            // 
            // btnxoa
            // 
            btnxoa.Location = new Point(519, 512);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(94, 29);
            btnxoa.TabIndex = 39;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnxoa_Click;
            // 
            // btnsua
            // 
            btnsua.Location = new Point(319, 512);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(94, 29);
            btnsua.TabIndex = 38;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = true;
            btnsua.Click += btnsua_Click;
            // 
            // btnthem
            // 
            btnthem.Location = new Point(219, 512);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(94, 29);
            btnthem.TabIndex = 37;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = true;
            btnthem.Click += btnthem_Click;
            // 
            // txttien
            // 
            txttien.Location = new Point(176, 351);
            txttien.Name = "txttien";
            txttien.Size = new Size(583, 27);
            txttien.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 354);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 35;
            label3.Text = "Số Tiền Thưởng:";
            // 
            // dtgqdkt
            // 
            dtgqdkt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgqdkt.Location = new Point(43, 87);
            dtgqdkt.Name = "dtgqdkt";
            dtgqdkt.RowHeadersWidth = 51;
            dtgqdkt.RowTemplate.Height = 29;
            dtgqdkt.Size = new Size(716, 188);
            dtgqdkt.TabIndex = 34;
            dtgqdkt.CellClick += dtgqdkt_CellClick;
            // 
            // txtsoqdkt
            // 
            txtsoqdkt.Location = new Point(176, 306);
            txtsoqdkt.Name = "txtsoqdkt";
            txtsoqdkt.Size = new Size(211, 27);
            txtsoqdkt.TabIndex = 33;
            // 
            // txttim
            // 
            txttim.Location = new Point(124, 5);
            txttim.Name = "txttim";
            txttim.Size = new Size(523, 27);
            txttim.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 309);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 31;
            label2.Text = "Số QDDKT:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 8);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 30;
            label1.Text = "Tìm Kiếm:";
            // 
            // btnghi
            // 
            btnghi.Location = new Point(419, 512);
            btnghi.Name = "btnghi";
            btnghi.Size = new Size(94, 29);
            btnghi.TabIndex = 47;
            btnghi.Text = "Ghi dữ liệu";
            btnghi.UseVisualStyleBackColor = true;
            btnghi.Click += btnghi_Click;
            // 
            // QDKT
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(849, 565);
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
            Controls.Add(txttien);
            Controls.Add(label3);
            Controls.Add(dtgqdkt);
            Controls.Add(txtsoqdkt);
            Controls.Add(txttim);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "QDKT";
            Text = "QDKT";
            ((System.ComponentModel.ISupportInitialize)dtgqdkt).EndInit();
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
        private TextBox txttien;
        private Label label3;
        private DataGridView dtgqdkt;
        private TextBox txtsoqdkt;
        private TextBox txttim;
        private Label label2;
        private Label label1;
        private Button btnghi;
    }
}