namespace QLNS
{
    partial class PhongBan
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
            lbbanghi = new Label();
            btntim = new Button();
            btnhuy = new Button();
            btnxoa = new Button();
            btnsua = new Button();
            btnthem = new Button();
            txttenpb = new TextBox();
            label3 = new Label();
            dtgpb = new DataGridView();
            txtmapb = new TextBox();
            txttim = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnghi = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgpb).BeginInit();
            SuspendLayout();
            // 
            // lbbanghi
            // 
            lbbanghi.AutoSize = true;
            lbbanghi.Font = new Font("Tahoma", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lbbanghi.ForeColor = SystemColors.ControlText;
            lbbanghi.Location = new Point(43, 71);
            lbbanghi.Name = "lbbanghi";
            lbbanghi.Size = new Size(132, 18);
            lbbanghi.TabIndex = 25;
            lbbanghi.Text = "Tổng số: 0 bản ghi";
            // 
            // btntim
            // 
            btntim.Location = new Point(665, 34);
            btntim.Name = "btntim";
            btntim.Size = new Size(94, 29);
            btntim.TabIndex = 24;
            btntim.Text = "Tìm";
            btntim.UseVisualStyleBackColor = true;
            btntim.Click += btntim_Click;
            // 
            // btnhuy
            // 
            btnhuy.Location = new Point(582, 426);
            btnhuy.Name = "btnhuy";
            btnhuy.Size = new Size(94, 29);
            btnhuy.TabIndex = 23;
            btnhuy.Text = "Hủy bỏ";
            btnhuy.UseVisualStyleBackColor = true;
            btnhuy.Click += btnhuy_Click;
            // 
            // btnxoa
            // 
            btnxoa.Location = new Point(482, 426);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(94, 29);
            btnxoa.TabIndex = 22;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnxoa_Click;
            // 
            // btnsua
            // 
            btnsua.Location = new Point(282, 426);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(94, 29);
            btnsua.TabIndex = 21;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = true;
            btnsua.Click += btnsua_Click;
            // 
            // btnthem
            // 
            btnthem.Location = new Point(182, 426);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(94, 29);
            btnthem.TabIndex = 20;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = true;
            btnthem.Click += btnthem_Click;
            // 
            // txttenpb
            // 
            txttenpb.Location = new Point(221, 368);
            txttenpb.Name = "txttenpb";
            txttenpb.Size = new Size(471, 27);
            txttenpb.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 371);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 18;
            label3.Text = "Tên Phòng Ban:";
            // 
            // dtgpb
            // 
            dtgpb.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgpb.Location = new Point(43, 113);
            dtgpb.Name = "dtgpb";
            dtgpb.RowHeadersWidth = 51;
            dtgpb.RowTemplate.Height = 29;
            dtgpb.Size = new Size(716, 188);
            dtgpb.TabIndex = 17;
            dtgpb.CellClick += dtgpb_CellClick;
            // 
            // txtmapb
            // 
            txtmapb.Location = new Point(221, 323);
            txtmapb.Name = "txtmapb";
            txtmapb.Size = new Size(471, 27);
            txtmapb.TabIndex = 16;
            txtmapb.TextChanged += txtmapb_TextChanged;
            // 
            // txttim
            // 
            txttim.Location = new Point(124, 31);
            txttim.Name = "txttim";
            txttim.Size = new Size(523, 27);
            txttim.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 326);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 14;
            label2.Text = "Mã Phòng Ban:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 34);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 13;
            label1.Text = "Tìm Kiếm:";
            // 
            // btnghi
            // 
            btnghi.Location = new Point(382, 426);
            btnghi.Name = "btnghi";
            btnghi.Size = new Size(94, 29);
            btnghi.TabIndex = 26;
            btnghi.Text = "Ghi dữ liệu";
            btnghi.UseVisualStyleBackColor = true;
            btnghi.Click += btnghi_Click;
            // 
            // PhongBan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(801, 491);
            Controls.Add(btnghi);
            Controls.Add(lbbanghi);
            Controls.Add(btntim);
            Controls.Add(btnhuy);
            Controls.Add(btnxoa);
            Controls.Add(btnsua);
            Controls.Add(btnthem);
            Controls.Add(txttenpb);
            Controls.Add(label3);
            Controls.Add(dtgpb);
            Controls.Add(txtmapb);
            Controls.Add(txttim);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PhongBan";
            Text = "PhongBan";
            ((System.ComponentModel.ISupportInitialize)dtgpb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbbanghi;
        private Button btntim;
        private Button btnhuy;
        private Button btnxoa;
        private Button btnsua;
        private Button btnthem;
        private TextBox txttenpb;
        private Label label3;
        private DataGridView dtgpb;
        private TextBox txtmapb;
        private TextBox txttim;
        private Label label2;
        private Label label1;
        private Button btnghi;
    }
}