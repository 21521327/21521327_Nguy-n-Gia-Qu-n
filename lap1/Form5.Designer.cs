namespace lap1
{
    partial class Frm5
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
            cb1 = new ComboBox();
            chuyen_ = new Button();
            t_tiendoi = new TextBox();
            tygia = new Label();
            txt_tien = new TextBox();
            lb_Don_vi = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(103, 122);
            label1.Name = "label1";
            label1.Size = new Size(142, 28);
            label1.TabIndex = 0;
            label1.Text = "Số tiền cần đổi";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(103, 282);
            label2.Name = "label2";
            label2.Size = new Size(145, 28);
            label2.TabIndex = 1;
            label2.Text = "Số tiền đã đổi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(103, 387);
            label3.Name = "label3";
            label3.Size = new Size(136, 28);
            label3.TabIndex = 2;
            label3.Text = "Tỷ giá quy đổi";
            // 
            // cb1
            // 
            cb1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cb1.FormattingEnabled = true;
            cb1.Items.AddRange(new object[] { "USD (Đô La Mỹ)", "EUR ", "GBP (Bảng Anh)", "SGD (Đô La Singapore)", "JPY (Đồng Yên Nhật)" });
            cb1.Location = new Point(540, 110);
            cb1.Name = "cb1";
            cb1.Size = new Size(244, 36);
            cb1.TabIndex = 3;
            cb1.Text = "Chọn loại tiền cần đổi";
            // 
            // chuyen_
            // 
            chuyen_.Location = new Point(103, 194);
            chuyen_.Name = "chuyen_";
            chuyen_.Size = new Size(123, 49);
            chuyen_.TabIndex = 4;
            chuyen_.Text = "Chuyển Đổi";
            chuyen_.UseVisualStyleBackColor = true;
            chuyen_.Click += chuyen__Click;
            // 
            // t_tiendoi
            // 
            t_tiendoi.Location = new Point(267, 283);
            t_tiendoi.Name = "t_tiendoi";
            t_tiendoi.ReadOnly = true;
            t_tiendoi.Size = new Size(125, 27);
            t_tiendoi.TabIndex = 5;
            t_tiendoi.TextChanged += t1_TextChanged;
            // 
            // tygia
            // 
            tygia.AutoSize = true;
            tygia.Location = new Point(287, 384);
            tygia.Name = "tygia";
            tygia.Size = new Size(0, 20);
            tygia.TabIndex = 7;
            // 
            // txt_tien
            // 
            txt_tien.Location = new Point(267, 119);
            txt_tien.Name = "txt_tien";
            txt_tien.Size = new Size(125, 27);
            txt_tien.TabIndex = 8;
            txt_tien.TextChanged += t_tien_TextChanged;
            // 
            // lb_Don_vi
            // 
            lb_Don_vi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Don_vi.Location = new Point(267, 387);
            lb_Don_vi.Name = "lb_Don_vi";
            lb_Don_vi.Size = new Size(203, 28);
            lb_Don_vi.TabIndex = 9;
            lb_Don_vi.Text = "00000";
            lb_Don_vi.Click += l4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(453, 387);
            label4.Name = "label4";
            label4.Size = new Size(53, 28);
            label4.TabIndex = 10;
            label4.Text = "VND";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(301, 26);
            label5.Name = "label5";
            label5.Size = new Size(298, 61);
            label5.TabIndex = 11;
            label5.Text = "CHUYỂN ĐỔI TIỀN TỆ";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Frm5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(900, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lb_Don_vi);
            Controls.Add(txt_tien);
            Controls.Add(tygia);
            Controls.Add(t_tiendoi);
            Controls.Add(chuyen_);
            Controls.Add(cb1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Frm5";
            Text = "Chuyển đổi tiền tệ";
            Load += Frm5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cb1;
        private Button chuyen_;
        private TextBox t_tiendoi;
        private Label tygia;
        private TextBox txt_tien;
        private Label lb_Don_vi;
        private Label label4;
        private Label label5;
    }
}