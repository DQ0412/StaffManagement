namespace QLNS
{
    partial class ChangePass
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
            label3 = new Label();
            label4 = new Label();
            txtUser = new TextBox();
            txtOldPass = new TextBox();
            txtNewPass = new TextBox();
            txtNewPass2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 37);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 108);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu hiện tại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 186);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu mới";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(79, 252);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(134, 20);
            label4.TabIndex = 3;
            label4.Text = "Xác nhận mật khẩu";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(229, 37);
            txtUser.Margin = new Padding(2, 2, 2, 2);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(198, 27);
            txtUser.TabIndex = 4;
            // 
            // txtOldPass
            // 
            txtOldPass.Location = new Point(229, 108);
            txtOldPass.Margin = new Padding(2, 2, 2, 2);
            txtOldPass.Name = "txtOldPass";
            txtOldPass.PasswordChar = '*';
            txtOldPass.Size = new Size(198, 27);
            txtOldPass.TabIndex = 5;
            // 
            // txtNewPass
            // 
            txtNewPass.Location = new Point(229, 184);
            txtNewPass.Margin = new Padding(2, 2, 2, 2);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.PasswordChar = '*';
            txtNewPass.Size = new Size(198, 27);
            txtNewPass.TabIndex = 6;
            // 
            // txtNewPass2
            // 
            txtNewPass2.Location = new Point(229, 247);
            txtNewPass2.Margin = new Padding(2, 2, 2, 2);
            txtNewPass2.Name = "txtNewPass2";
            txtNewPass2.PasswordChar = '*';
            txtNewPass2.Size = new Size(198, 27);
            txtNewPass2.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(166, 310);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(143, 27);
            button1.TabIndex = 8;
            button1.Text = "Đổi mật khẩu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(363, 310);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(143, 27);
            button2.TabIndex = 9;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ChangePass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(640, 360);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtNewPass2);
            Controls.Add(txtNewPass);
            Controls.Add(txtOldPass);
            Controls.Add(txtUser);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "ChangePass";
            Text = "ChangePass";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtUser;
        private TextBox txtOldPass;
        private TextBox txtNewPass;
        private TextBox txtNewPass2;
        private Button button1;
        private Button button2;
    }
}