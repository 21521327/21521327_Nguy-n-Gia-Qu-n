namespace lap1
{
    partial class LAP_1
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
            bt_bai1 = new Button();
            bt_bai2 = new Button();
            bt_bai3 = new Button();
            bt_bai4 = new Button();
            bt_bai5 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // bt_bai1
            // 
            bt_bai1.Location = new Point(95, 152);
            bt_bai1.Name = "bt_bai1";
            bt_bai1.Size = new Size(101, 48);
            bt_bai1.TabIndex = 1;
            bt_bai1.Text = "Bài 1";
            bt_bai1.UseVisualStyleBackColor = true;
            bt_bai1.Click += button1_Click;
            // 
            // bt_bai2
            // 
            bt_bai2.Location = new Point(95, 276);
            bt_bai2.Name = "bt_bai2";
            bt_bai2.Size = new Size(101, 48);
            bt_bai2.TabIndex = 3;
            bt_bai2.Text = "Bài 2";
            bt_bai2.UseVisualStyleBackColor = true;
            bt_bai2.Click += bai2_Click;
            // 
            // bt_bai3
            // 
            bt_bai3.Location = new Point(589, 152);
            bt_bai3.Name = "bt_bai3";
            bt_bai3.Size = new Size(101, 48);
            bt_bai3.TabIndex = 5;
            bt_bai3.Text = "Bài 3";
            bt_bai3.UseVisualStyleBackColor = true;
            bt_bai3.Click += dọc_so_Click;
            // 
            // bt_bai4
            // 
            bt_bai4.Location = new Point(589, 276);
            bt_bai4.Name = "bt_bai4";
            bt_bai4.Size = new Size(101, 48);
            bt_bai4.TabIndex = 7;
            bt_bai4.Text = "Bài 4";
            bt_bai4.UseVisualStyleBackColor = true;
            bt_bai4.Click += b4_Click;
            // 
            // bt_bai5
            // 
            bt_bai5.Location = new Point(359, 364);
            bt_bai5.Name = "bt_bai5";
            bt_bai5.Size = new Size(101, 48);
            bt_bai5.TabIndex = 9;
            bt_bai5.Text = "Bài 5";
            bt_bai5.UseVisualStyleBackColor = true;
            bt_bai5.Click += Frm6_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(176, 27);
            label1.Name = "label1";
            label1.Size = new Size(430, 72);
            label1.TabIndex = 11;
            label1.Text = "BÀI THỰC HÀNH SỐ 1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LAP_1
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(807, 469);
            Controls.Add(label1);
            Controls.Add(bt_bai5);
            Controls.Add(bt_bai4);
            Controls.Add(bt_bai3);
            Controls.Add(bt_bai2);
            Controls.Add(bt_bai1);
            IsMdiContainer = true;
            Name = "LAP_1";
            Text = "LAP 1";
            Load += MENU_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button bt_bai1;
        private Button bt_bai2;
        private Button bt_bai3;
        private Button bt_bai4;
        private Button bt_bai5;
        private Label label1;
    }
}