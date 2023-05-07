namespace QLNS
{
    partial class PhanQuyen
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
            btnns = new Button();
            btnkt = new Button();
            SuspendLayout();
            // 
            // btnns
            // 
            btnns.Location = new Point(154, 181);
            btnns.Name = "btnns";
            btnns.Size = new Size(185, 65);
            btnns.TabIndex = 0;
            btnns.Text = "Bộ Phận Nhân Sự";
            btnns.UseVisualStyleBackColor = true;
            btnns.Click += btnns_Click;
            // 
            // btnkt
            // 
            btnkt.Location = new Point(474, 189);
            btnkt.Name = "btnkt";
            btnkt.Size = new Size(170, 57);
            btnkt.TabIndex = 1;
            btnkt.Text = "Bộ Phận Kế Toán";
            btnkt.UseVisualStyleBackColor = true;
            // 
            // PhanQuyen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnkt);
            Controls.Add(btnns);
            Name = "PhanQuyen";
            Text = "PhanQuyen";
            ResumeLayout(false);
        }

        #endregion

        private Button btnns;
        private Button btnkt;
    }
}