namespace QLNS
{
    partial class TDHV
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
            txtcn = new TextBox();
            label5 = new Label();
            lbbanghi = new Label();
            btntim = new Button();
            btnhuy = new Button();
            btnxoa = new Button();
            btnsua = new Button();
            btnthem = new Button();
            txttentdhv = new TextBox();
            label3 = new Label();
            dtgtdhv = new DataGridView();
            txtmatdhv = new TextBox();
            txttim = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnghi = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgtdhv).BeginInit();
            SuspendLayout();
            // 
            // txtcn
            // 
            txtcn.Location = new Point(228, 395);
            txtcn.Name = "txtcn";
            txtcn.Size = new Size(471, 27);
            txtcn.TabIndex = 46;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(95, 398);
            label5.Name = "label5";
            label5.Size = new Size(108, 20);
            label5.TabIndex = 45;
            label5.Text = "Chuyên Ngành:";
            // 
            // lbbanghi
            // 
            lbbanghi.AutoSize = true;
            lbbanghi.Font = new Font("Tahoma", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lbbanghi.ForeColor = SystemColors.ControlText;
            lbbanghi.Location = new Point(43, 54);
            lbbanghi.Name = "lbbanghi";
            lbbanghi.Size = new Size(132, 18);
            lbbanghi.TabIndex = 42;
            lbbanghi.Text = "Tổng số: 0 bản ghi";
            // 
            // btntim
            // 
            btntim.Location = new Point(665, 23);
            btntim.Name = "btntim";
            btntim.Size = new Size(94, 29);
            btntim.TabIndex = 41;
            btntim.Text = "Tìm";
            btntim.UseVisualStyleBackColor = true;
            btntim.Click += btntim_Click;
            // 
            // btnhuy
            // 
            btnhuy.Location = new Point(580, 443);
            btnhuy.Name = "btnhuy";
            btnhuy.Size = new Size(94, 29);
            btnhuy.TabIndex = 40;
            btnhuy.Text = "Hủy bỏ";
            btnhuy.UseVisualStyleBackColor = true;
            btnhuy.Click += btnhuy_Click;
            // 
            // btnxoa
            // 
            btnxoa.Location = new Point(480, 442);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(94, 29);
            btnxoa.TabIndex = 39;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnxoa_Click;
            // 
            // btnsua
            // 
            btnsua.Location = new Point(280, 441);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(94, 29);
            btnsua.TabIndex = 38;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = true;
            btnsua.Click += btnsua_Click;
            // 
            // btnthem
            // 
            btnthem.Location = new Point(180, 441);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(94, 29);
            btnthem.TabIndex = 37;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = true;
            btnthem.Click += btnthem_Click;
            // 
            // txttentdhv
            // 
            txttentdhv.Location = new Point(228, 349);
            txttentdhv.Name = "txttentdhv";
            txttentdhv.Size = new Size(471, 27);
            txttentdhv.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(95, 352);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 35;
            label3.Text = "Tên TDHV:";
            // 
            // dtgtdhv
            // 
            dtgtdhv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgtdhv.Location = new Point(43, 87);
            dtgtdhv.Name = "dtgtdhv";
            dtgtdhv.RowHeadersWidth = 51;
            dtgtdhv.RowTemplate.Height = 29;
            dtgtdhv.Size = new Size(716, 188);
            dtgtdhv.TabIndex = 34;
            dtgtdhv.CellClick += dtgtdhv_CellClick;
            // 
            // txtmatdhv
            // 
            txtmatdhv.Location = new Point(228, 304);
            txtmatdhv.Name = "txtmatdhv";
            txtmatdhv.Size = new Size(471, 27);
            txtmatdhv.TabIndex = 33;
            // 
            // txttim
            // 
            txttim.Location = new Point(124, 24);
            txttim.Name = "txttim";
            txttim.Size = new Size(523, 27);
            txttim.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 307);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 31;
            label2.Text = "Mã TDHV:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 27);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 30;
            label1.Text = "Tìm Kiếm:";
            // 
            // btnghi
            // 
            btnghi.Location = new Point(380, 443);
            btnghi.Name = "btnghi";
            btnghi.Size = new Size(94, 28);
            btnghi.TabIndex = 47;
            btnghi.Text = "Ghi dữ liệu";
            btnghi.UseVisualStyleBackColor = true;
            btnghi.Click += btnghi_Click;
            // 
            // TDHV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(857, 493);
            Controls.Add(btnghi);
            Controls.Add(txtcn);
            Controls.Add(label5);
            Controls.Add(lbbanghi);
            Controls.Add(btntim);
            Controls.Add(btnhuy);
            Controls.Add(btnxoa);
            Controls.Add(btnsua);
            Controls.Add(btnthem);
            Controls.Add(txttentdhv);
            Controls.Add(label3);
            Controls.Add(dtgtdhv);
            Controls.Add(txtmatdhv);
            Controls.Add(txttim);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TDHV";
            Text = "TDHV";
            ((System.ComponentModel.ISupportInitialize)dtgtdhv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtcn;
        private Label label5;
        private Label lbbanghi;
        private Button btntim;
        private Button btnhuy;
        private Button btnxoa;
        private Button btnsua;
        private Button btnthem;
        private TextBox txttentdhv;
        private Label label3;
        private DataGridView dtgtdhv;
        private TextBox txtmatdhv;
        private TextBox txttim;
        private Label label2;
        private Label label1;
        private Button btnghi;
    }
}