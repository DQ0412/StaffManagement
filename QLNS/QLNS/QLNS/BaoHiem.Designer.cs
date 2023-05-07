namespace QLNS
{
    partial class BaoHiem
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
            txttenbh = new TextBox();
            label3 = new Label();
            dtgbh = new DataGridView();
            txtmabh = new TextBox();
            txttim = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            dtngay = new DateTimePicker();
            label5 = new Label();
            txtth = new TextBox();
            btnghi = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgbh).BeginInit();
            SuspendLayout();
            // 
            // lbbanghi
            // 
            lbbanghi.AutoSize = true;
            lbbanghi.Font = new Font("Tahoma", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lbbanghi.ForeColor = SystemColors.ControlText;
            lbbanghi.Location = new Point(78, 76);
            lbbanghi.Name = "lbbanghi";
            lbbanghi.Size = new Size(132, 18);
            lbbanghi.TabIndex = 25;
            lbbanghi.Text = "Tổng số: 0 bản ghi";
            // 
            // btntim
            // 
            btntim.Location = new Point(700, 39);
            btntim.Name = "btntim";
            btntim.Size = new Size(94, 29);
            btntim.TabIndex = 24;
            btntim.Text = "Tìm";
            btntim.UseVisualStyleBackColor = true;
            btntim.Click += btntim_Click;
            // 
            // btnhuy
            // 
            btnhuy.Location = new Point(588, 445);
            btnhuy.Name = "btnhuy";
            btnhuy.Size = new Size(94, 29);
            btnhuy.TabIndex = 23;
            btnhuy.Text = "Hủy bỏ";
            btnhuy.UseVisualStyleBackColor = true;
            btnhuy.Click += btnhuy_Click;
            // 
            // btnxoa
            // 
            btnxoa.Location = new Point(388, 445);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(94, 29);
            btnxoa.TabIndex = 22;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnxoa_Click;
            // 
            // btnsua
            // 
            btnsua.Location = new Point(288, 445);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(94, 29);
            btnsua.TabIndex = 21;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = true;
            btnsua.Click += btnsua_Click;
            // 
            // btnthem
            // 
            btnthem.Location = new Point(188, 445);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(94, 29);
            btnthem.TabIndex = 20;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = true;
            btnthem.Click += btnthem_Click;
            // 
            // txttenbh
            // 
            txttenbh.Location = new Point(211, 382);
            txttenbh.Name = "txttenbh";
            txttenbh.Size = new Size(211, 27);
            txttenbh.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 385);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 18;
            label3.Text = "Tên Bảo Hiểm";
            // 
            // dtgbh
            // 
            dtgbh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgbh.Location = new Point(78, 118);
            dtgbh.Name = "dtgbh";
            dtgbh.RowHeadersWidth = 51;
            dtgbh.RowTemplate.Height = 29;
            dtgbh.Size = new Size(716, 188);
            dtgbh.TabIndex = 17;
            dtgbh.CellContentClick += dtgcv_CellContentClick;
            // 
            // txtmabh
            // 
            txtmabh.Location = new Point(211, 337);
            txtmabh.Name = "txtmabh";
            txtmabh.Size = new Size(211, 27);
            txtmabh.TabIndex = 16;
            // 
            // txttim
            // 
            txttim.Location = new Point(159, 36);
            txttim.Name = "txttim";
            txttim.Size = new Size(523, 27);
            txttim.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 340);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 14;
            label2.Text = "Mã Bảo Hiểm:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 39);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 13;
            label1.Text = "Tìm Kiếm:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(454, 340);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 26;
            label4.Text = "Ngày Lập:";
            // 
            // dtngay
            // 
            dtngay.Location = new Point(544, 335);
            dtngay.Name = "dtngay";
            dtngay.Size = new Size(250, 27);
            dtngay.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(463, 385);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 28;
            label5.Text = "Thời Hạn:";
            // 
            // txtth
            // 
            txtth.Location = new Point(544, 382);
            txtth.Name = "txtth";
            txtth.Size = new Size(250, 27);
            txtth.TabIndex = 29;
            // 
            // btnghi
            // 
            btnghi.Location = new Point(488, 445);
            btnghi.Name = "btnghi";
            btnghi.Size = new Size(94, 29);
            btnghi.TabIndex = 30;
            btnghi.Text = "Ghi dữ liệu";
            btnghi.UseVisualStyleBackColor = true;
            btnghi.Click += btnghi_Click;
            // 
            // BaoHiem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(870, 513);
            Controls.Add(btnghi);
            Controls.Add(txtth);
            Controls.Add(label5);
            Controls.Add(dtngay);
            Controls.Add(label4);
            Controls.Add(lbbanghi);
            Controls.Add(btntim);
            Controls.Add(btnhuy);
            Controls.Add(btnxoa);
            Controls.Add(btnsua);
            Controls.Add(btnthem);
            Controls.Add(txttenbh);
            Controls.Add(label3);
            Controls.Add(dtgbh);
            Controls.Add(txtmabh);
            Controls.Add(txttim);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BaoHiem";
            Text = "BaoHiem";
            ((System.ComponentModel.ISupportInitialize)dtgbh).EndInit();
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
        private TextBox txttenbh;
        private Label label3;
        private DataGridView dtgbh;
        private TextBox txtmabh;
        private TextBox txttim;
        private Label label2;
        private Label label1;
        private Label label4;
        private DateTimePicker dtngay;
        private Label label5;
        private TextBox txtth;
        private Button btnghi;
    }
}