namespace lap1
{
    partial class Frm6
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
            txt_A = new TextBox();
            txt_B = new TextBox();
            label6 = new Label();
            txt_ket_qua = new TextBox();
            bt_tinh = new Button();
            button1 = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(60, 113);
            label1.Name = "label1";
            label1.Size = new Size(78, 28);
            label1.TabIndex = 0;
            label1.Text = "Nhập A";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(62, 172);
            label2.Name = "label2";
            label2.Size = new Size(76, 28);
            label2.TabIndex = 1;
            label2.Text = "Nhập B";
            label2.Click += label2_Click;
            // 
            // txt_A
            // 
            txt_A.Location = new Point(148, 114);
            txt_A.Name = "txt_A";
            txt_A.Size = new Size(125, 27);
            txt_A.TabIndex = 2;
            txt_A.TextChanged += tA_TextChanged;
            // 
            // txt_B
            // 
            txt_B.Location = new Point(148, 172);
            txt_B.Name = "txt_B";
            txt_B.Size = new Size(125, 27);
            txt_B.TabIndex = 3;
            txt_B.TextChanged += textBox1_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(62, 224);
            label6.Name = "label6";
            label6.Size = new Size(88, 28);
            label6.TabIndex = 7;
            label6.Text = "Kết Quả";
            label6.Click += label6_Click;
            // 
            // txt_ket_qua
            // 
            txt_ket_qua.Location = new Point(62, 267);
            txt_ket_qua.Multiline = true;
            txt_ket_qua.Name = "txt_ket_qua";
            txt_ket_qua.ReadOnly = true;
            txt_ket_qua.Size = new Size(502, 171);
            txt_ket_qua.TabIndex = 8;
            txt_ket_qua.TextChanged += textBox1_TextChanged_1;
            // 
            // bt_tinh
            // 
            bt_tinh.Location = new Point(585, 113);
            bt_tinh.Name = "bt_tinh";
            bt_tinh.Size = new Size(163, 51);
            bt_tinh.TabIndex = 9;
            bt_tinh.Text = "Tính các giá trị";
            bt_tinh.UseVisualStyleBackColor = true;
            bt_tinh.Click += btn__Click;
            // 
            // button1
            // 
            button1.Location = new Point(585, 216);
            button1.Name = "button1";
            button1.Size = new Size(163, 51);
            button1.TabIndex = 11;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(278, 21);
            label5.Name = "label5";
            label5.Size = new Size(298, 61);
            label5.TabIndex = 12;
            label5.Text = "TÍNH BIỂU THỨC";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Frm6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(bt_tinh);
            Controls.Add(txt_ket_qua);
            Controls.Add(label6);
            Controls.Add(txt_B);
            Controls.Add(txt_A);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Frm6";
            Text = "Tính Biểu Thức";
            Load += Frm6_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_A;
        private TextBox txt_B;
        private Label label6;
        private TextBox txt_ket_qua;
        private Button bt_tinh;
        private Button button1;
        private Label label5;
    }
}