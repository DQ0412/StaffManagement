namespace QLNS
{
    partial class DangNhap
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
            txttklg = new TextBox();
            txtmklg = new TextBox();
            llbquen = new LinkLabel();
            btndn = new Button();
            cbmk = new CheckBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // txttklg
            // 
            txttklg.Location = new Point(174, 221);
            txttklg.Name = "txttklg";
            txttklg.Size = new Size(254, 27);
            txttklg.TabIndex = 2;
            // 
            // txtmklg
            // 
            txtmklg.Location = new Point(174, 282);
            txtmklg.Name = "txtmklg";
            txtmklg.Size = new Size(254, 27);
            txtmklg.TabIndex = 3;
            txtmklg.UseSystemPasswordChar = true;
            txtmklg.TextChanged += txtmklg_TextChanged;
            // 
            // llbquen
            // 
            llbquen.AutoSize = true;
            llbquen.Location = new Point(122, 334);
            llbquen.Name = "llbquen";
            llbquen.Size = new Size(109, 20);
            llbquen.TabIndex = 4;
            llbquen.TabStop = true;
            llbquen.Text = "Quên mật khẩu";
            llbquen.LinkClicked += llbquen_LinkClicked;
            // 
            // btndn
            // 
            btndn.BackColor = SystemColors.Info;
            btndn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btndn.Location = new Point(240, 364);
            btndn.Name = "btndn";
            btndn.Size = new Size(139, 51);
            btndn.TabIndex = 5;
            btndn.Text = "Đăng nhập";
            btndn.UseVisualStyleBackColor = false;
            btndn.Click += btndn_Click;
            // 
            // cbmk
            // 
            cbmk.AutoSize = true;
            cbmk.BackgroundImage = Properties.Resources.hide;
            cbmk.ImageAlign = ContentAlignment.MiddleLeft;
            cbmk.Location = new Point(405, 334);
            cbmk.Name = "cbmk";
            cbmk.Size = new Size(127, 24);
            cbmk.TabIndex = 8;
            cbmk.Text = "Hiện mật khẩu";
            cbmk.UseVisualStyleBackColor = true;
            cbmk.CheckedChanged += cbmk_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(89, 206);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Image = Properties.Resources.padlock;
            pictureBox2.Location = new Point(89, 268);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(56, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.None;
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Image = Properties.Resources.man;
            pictureBox3.Location = new Point(207, 79);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(187, 112);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Info;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(174, 32);
            label1.Name = "label1";
            label1.Size = new Size(254, 41);
            label1.TabIndex = 12;
            label1.Text = "Quản Lý Nhân Sự";
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(587, 450);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(cbmk);
            Controls.Add(btndn);
            Controls.Add(llbquen);
            Controls.Add(txtmklg);
            Controls.Add(txttklg);
            Name = "DangNhap";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txttklg;
        private TextBox txtmklg;
        private LinkLabel llbquen;
        private Button btndn;
        private CheckBox cbmk;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
    }
}