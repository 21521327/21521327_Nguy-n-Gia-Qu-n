namespace lap1
{
    partial class Frm3
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
            L1 = new Label();
            L2 = new Label();
            L3 = new Label();
            txt_number1 = new TextBox();
            txt_number2 = new TextBox();
            txt_number3 = new TextBox();
            bt_tim = new Button();
            bt_xoa = new Button();
            bt_thoat = new Button();
            label1 = new Label();
            txt_max = new TextBox();
            txt_min = new TextBox();
            label2 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // L1
            // 
            L1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            L1.Location = new Point(41, 112);
            L1.Name = "L1";
            L1.Size = new Size(143, 49);
            L1.TabIndex = 0;
            L1.Text = "Số thứ nhất";
            L1.TextAlign = ContentAlignment.MiddleCenter;
            L1.Click += label1_Click;
            // 
            // L2
            // 
            L2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            L2.Location = new Point(34, 189);
            L2.Name = "L2";
            L2.Size = new Size(143, 49);
            L2.TabIndex = 1;
            L2.Text = "Số thứ hai";
            L2.TextAlign = ContentAlignment.MiddleCenter;
            L2.Click += L2_Click;
            // 
            // L3
            // 
            L3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            L3.Location = new Point(34, 270);
            L3.Name = "L3";
            L3.Size = new Size(143, 49);
            L3.TabIndex = 2;
            L3.Text = "Số thứ ba";
            L3.TextAlign = ContentAlignment.MiddleCenter;
            L3.Click += L3_Click;
            // 
            // txt_number1
            // 
            txt_number1.Location = new Point(201, 126);
            txt_number1.Name = "txt_number1";
            txt_number1.Size = new Size(125, 27);
            txt_number1.TabIndex = 3;
            txt_number1.TextChanged += t1_TextChanged;
            // 
            // txt_number2
            // 
            txt_number2.Location = new Point(201, 200);
            txt_number2.Name = "txt_number2";
            txt_number2.Size = new Size(125, 27);
            txt_number2.TabIndex = 4;
            txt_number2.TextChanged += t2_TextChanged;
            // 
            // txt_number3
            // 
            txt_number3.Location = new Point(201, 284);
            txt_number3.Name = "txt_number3";
            txt_number3.Size = new Size(125, 27);
            txt_number3.TabIndex = 5;
            txt_number3.TextChanged += textBox1_TextChanged;
            // 
            // bt_tim
            // 
            bt_tim.Location = new Point(486, 124);
            bt_tim.Name = "bt_tim";
            bt_tim.Size = new Size(106, 34);
            bt_tim.TabIndex = 6;
            bt_tim.Text = "Tim";
            bt_tim.UseVisualStyleBackColor = true;
            bt_tim.Click += tim_Click;
            // 
            // bt_xoa
            // 
            bt_xoa.Location = new Point(486, 202);
            bt_xoa.Name = "bt_xoa";
            bt_xoa.Size = new Size(108, 34);
            bt_xoa.TabIndex = 7;
            bt_xoa.Text = "Xoa";
            bt_xoa.UseVisualStyleBackColor = true;
            bt_xoa.Click += xoa_Click;
            // 
            // bt_thoat
            // 
            bt_thoat.Location = new Point(486, 282);
            bt_thoat.Name = "bt_thoat";
            bt_thoat.Size = new Size(108, 34);
            bt_thoat.TabIndex = 8;
            bt_thoat.Text = "Thoat";
            bt_thoat.UseVisualStyleBackColor = true;
            bt_thoat.Click += thoat_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(34, 372);
            label1.Name = "label1";
            label1.Size = new Size(143, 49);
            label1.TabIndex = 9;
            label1.Text = "Số lớn nhất";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click_1;
            // 
            // txt_max
            // 
            txt_max.Location = new Point(194, 386);
            txt_max.Multiline = true;
            txt_max.Name = "txt_max";
            txt_max.ReadOnly = true;
            txt_max.Size = new Size(127, 31);
            txt_max.TabIndex = 10;
            txt_max.TextChanged += t_max_TextChanged;
            // 
            // txt_min
            // 
            txt_min.Location = new Point(624, 386);
            txt_min.Multiline = true;
            txt_min.Name = "txt_min";
            txt_min.ReadOnly = true;
            txt_min.Size = new Size(127, 31);
            txt_min.TabIndex = 11;
            txt_min.TextChanged += t_min_TextChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(461, 372);
            label2.Name = "label2";
            label2.Size = new Size(143, 49);
            label2.TabIndex = 12;
            label2.Text = "Số nhỏ nhất";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(163, 20);
            label4.Name = "label4";
            label4.Size = new Size(441, 61);
            label4.TabIndex = 13;
            label4.Text = "TÌM SỐ LỚN NHẤT-NHỎ NHẤT";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Frm3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(807, 455);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(txt_min);
            Controls.Add(txt_max);
            Controls.Add(label1);
            Controls.Add(bt_thoat);
            Controls.Add(bt_xoa);
            Controls.Add(bt_tim);
            Controls.Add(txt_number3);
            Controls.Add(txt_number2);
            Controls.Add(txt_number1);
            Controls.Add(L3);
            Controls.Add(L2);
            Controls.Add(L1);
            Name = "Frm3";
            Load += Frm3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label L1;
        private Label L2;
        private Label L3;
        private TextBox txt_number1;
        private TextBox txt_number2;
        private TextBox txt_number3;
        private Button bt_tim;
        private Button bt_xoa;
        private Button bt_thoat;
        private Label label1;
        private TextBox txt_max;
        private TextBox txt_min;
        private Label label2;
        private Label label4;
    }
}