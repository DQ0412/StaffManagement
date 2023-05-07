namespace QLNS
{
    partial class Dangky
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
            grbdk = new GroupBox();
            cbbcauhoi = new ComboBox();
            dtns = new DateTimePicker();
            txttraloi = new TextBox();
            label8 = new Label();
            btndk = new Button();
            label7 = new Label();
            txtemail = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txtsdt = new TextBox();
            label4 = new Label();
            txtmk = new TextBox();
            label3 = new Label();
            txttendn = new TextBox();
            label2 = new Label();
            txthoten = new TextBox();
            label1 = new Label();
            grbdk.SuspendLayout();
            SuspendLayout();
            // 
            // grbdk
            // 
            grbdk.Controls.Add(cbbcauhoi);
            grbdk.Controls.Add(dtns);
            grbdk.Controls.Add(txttraloi);
            grbdk.Controls.Add(label8);
            grbdk.Controls.Add(btndk);
            grbdk.Controls.Add(label7);
            grbdk.Controls.Add(txtemail);
            grbdk.Controls.Add(label6);
            grbdk.Controls.Add(label5);
            grbdk.Controls.Add(txtsdt);
            grbdk.Controls.Add(label4);
            grbdk.Controls.Add(txtmk);
            grbdk.Controls.Add(label3);
            grbdk.Controls.Add(txttendn);
            grbdk.Controls.Add(label2);
            grbdk.Controls.Add(txthoten);
            grbdk.Controls.Add(label1);
            grbdk.Location = new Point(151, 40);
            grbdk.Name = "grbdk";
            grbdk.Size = new Size(703, 605);
            grbdk.TabIndex = 0;
            grbdk.TabStop = false;
            grbdk.Text = "Form Đăng Ký";
            // 
            // cbbcauhoi
            // 
            cbbcauhoi.FormattingEnabled = true;
            cbbcauhoi.Items.AddRange(new object[] { "Họ và Tên của Cha bạn ?", "Sở thích của bạn là gì ? ", "Mật khẩu Email ?" });
            cbbcauhoi.Location = new Point(237, 408);
            cbbcauhoi.Name = "cbbcauhoi";
            cbbcauhoi.Size = new Size(308, 28);
            cbbcauhoi.TabIndex = 18;
            // 
            // dtns
            // 
            dtns.Location = new Point(237, 307);
            dtns.Name = "dtns";
            dtns.Size = new Size(308, 27);
            dtns.TabIndex = 17;
            // 
            // txttraloi
            // 
            txttraloi.Location = new Point(237, 465);
            txttraloi.Name = "txttraloi";
            txttraloi.Size = new Size(308, 27);
            txttraloi.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(33, 472);
            label8.Name = "label8";
            label8.Size = new Size(77, 20);
            label8.TabIndex = 15;
            label8.Text = "Câu trả lời";
            // 
            // btndk
            // 
            btndk.Location = new Point(268, 537);
            btndk.Name = "btndk";
            btndk.Size = new Size(94, 29);
            btndk.TabIndex = 14;
            btndk.Text = "Đăng Ký";
            btndk.UseVisualStyleBackColor = true;
            btndk.Click += btndk_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 408);
            label7.Name = "label7";
            label7.Size = new Size(119, 20);
            label7.TabIndex = 12;
            label7.Text = "Câu hỏi bảo mật";
            // 
            // txtemail
            // 
            txtemail.Location = new Point(237, 357);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(308, 27);
            txtemail.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 357);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 10;
            label6.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 307);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 8;
            label5.Text = "Ngày sinh";
            // 
            // txtsdt
            // 
            txtsdt.Location = new Point(237, 245);
            txtsdt.Name = "txtsdt";
            txtsdt.Size = new Size(308, 27);
            txtsdt.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 245);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 6;
            label4.Text = "SĐT";
            // 
            // txtmk
            // 
            txtmk.Location = new Point(237, 185);
            txtmk.Name = "txtmk";
            txtmk.Size = new Size(308, 27);
            txtmk.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 185);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 4;
            label3.Text = "Mật khẩu";
            // 
            // txttendn
            // 
            txttendn.Location = new Point(237, 124);
            txttendn.Name = "txttendn";
            txttendn.Size = new Size(308, 27);
            txttendn.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 124);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên đăng nhập";
            // 
            // txthoten
            // 
            txthoten.Location = new Point(237, 60);
            txthoten.Name = "txthoten";
            txthoten.Size = new Size(308, 27);
            txthoten.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 60);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Họ và Tên";
            // 
            // Dangky
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 704);
            Controls.Add(grbdk);
            Name = "Dangky";
            Text = "Dangky";
            grbdk.ResumeLayout(false);
            grbdk.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbdk;
        private ComboBox cbbcauhoi;
        private DateTimePicker dtns;
        private TextBox txttraloi;
        private Label label8;
        private Button btndk;
        private Label label7;
        private TextBox txtemail;
        private Label label6;
        private Label label5;
        private TextBox txtsdt;
        private Label label4;
        private TextBox txtmk;
        private Label label3;
        private TextBox txttendn;
        private Label label2;
        private TextBox txthoten;
        private Label label1;
        

    }
}