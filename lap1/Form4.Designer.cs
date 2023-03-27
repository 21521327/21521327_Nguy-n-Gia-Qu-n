namespace lap1
{
    partial class Frm4
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
            txt_number = new TextBox();
            txt_ket_qua = new TextBox();
            bt_doc = new Button();
            bt_xoa = new Button();
            bt_thoat = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(28, 127);
            label1.Name = "label1";
            label1.Size = new Size(229, 49);
            label1.TabIndex = 0;
            label1.Text = "Nhập một số từ 0 đến 9";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(28, 337);
            label2.Name = "label2";
            label2.Size = new Size(143, 49);
            label2.TabIndex = 1;
            label2.Text = "Kết Quả";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // txt_number
            // 
            txt_number.Location = new Point(299, 141);
            txt_number.Name = "txt_number";
            txt_number.Size = new Size(125, 27);
            txt_number.TabIndex = 2;
            txt_number.TextChanged += t1_TextChanged;
            // 
            // txt_ket_qua
            // 
            txt_ket_qua.Location = new Point(299, 351);
            txt_ket_qua.Name = "txt_ket_qua";
            txt_ket_qua.ReadOnly = true;
            txt_ket_qua.Size = new Size(125, 27);
            txt_ket_qua.TabIndex = 3;
            txt_ket_qua.TextChanged += ket_qua_TextChanged;
            // 
            // bt_doc
            // 
            bt_doc.Location = new Point(573, 132);
            bt_doc.Name = "bt_doc";
            bt_doc.Size = new Size(108, 34);
            bt_doc.TabIndex = 4;
            bt_doc.Text = "Doc";
            bt_doc.UseVisualStyleBackColor = true;
            bt_doc.Click += doc_Click;
            // 
            // bt_xoa
            // 
            bt_xoa.Location = new Point(573, 236);
            bt_xoa.Name = "bt_xoa";
            bt_xoa.Size = new Size(108, 34);
            bt_xoa.TabIndex = 5;
            bt_xoa.Text = "Xoa";
            bt_xoa.UseVisualStyleBackColor = true;
            bt_xoa.Click += xoa_Click;
            // 
            // bt_thoat
            // 
            bt_thoat.Location = new Point(573, 351);
            bt_thoat.Name = "bt_thoat";
            bt_thoat.Size = new Size(108, 34);
            bt_thoat.TabIndex = 6;
            bt_thoat.Text = "Thoat";
            bt_thoat.UseVisualStyleBackColor = true;
            bt_thoat.Click += bt_thoat_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(131, 26);
            label4.Name = "label4";
            label4.Size = new Size(531, 61);
            label4.TabIndex = 14;
            label4.Text = "ĐỌC SỐ TỰ NHIÊN CÓ MỘT CHỮ SỐ";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Frm4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(787, 475);
            Controls.Add(label4);
            Controls.Add(bt_thoat);
            Controls.Add(bt_xoa);
            Controls.Add(bt_doc);
            Controls.Add(txt_ket_qua);
            Controls.Add(txt_number);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Frm4";
            Text = "Đọc Số";
            Load += Frm4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_number;
        private TextBox txt_ket_qua;
        private Button bt_doc;
        private Button bt_xoa;
        private Button bt_thoat;
        private Label label4;
    }
}