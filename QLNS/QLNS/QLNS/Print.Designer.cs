﻿namespace QLNS
{
    partial class Print
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
            dtgprint = new DataGridView();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgprint).BeginInit();
            SuspendLayout();
            // 
            // dtgprint
            // 
            dtgprint.AllowUserToAddRows = false;
            dtgprint.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgprint.Location = new Point(21, 110);
            dtgprint.Name = "dtgprint";
            dtgprint.RowHeadersWidth = 51;
            dtgprint.RowTemplate.Height = 29;
            dtgprint.Size = new Size(728, 188);
            dtgprint.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(286, 34);
            label1.Name = "label1";
            label1.Size = new Size(193, 38);
            label1.TabIndex = 1;
            label1.Text = "Xuất File PDF";
            // 
            // button1
            // 
            button1.Location = new Point(319, 357);
            button1.Name = "button1";
            button1.Size = new Size(115, 42);
            button1.TabIndex = 2;
            button1.Text = "Xuất ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Print
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dtgprint);
            Name = "Print";
            Text = "Form1";
            Load += Print_Load;
            ((System.ComponentModel.ISupportInitialize)dtgprint).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgprint;
        private Label label1;
        private Button button1;
    }
}