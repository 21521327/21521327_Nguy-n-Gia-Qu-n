namespace lap2_21521327_GiaQUan
{
    partial class Bai6
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
            this.tv_file = new System.Windows.Forms.TreeView();
            this.gb_text_pnj = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // tv_file
            // 
            this.tv_file.Location = new System.Drawing.Point(30, 78);
            this.tv_file.Name = "tv_file";
            this.tv_file.Size = new System.Drawing.Size(284, 345);
            this.tv_file.TabIndex = 1;
            this.tv_file.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_file_AfterSelect);
            // 
            // gb_text_pnj
            // 
            this.gb_text_pnj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gb_text_pnj.Location = new System.Drawing.Point(344, 58);
            this.gb_text_pnj.Name = "gb_text_pnj";
            this.gb_text_pnj.Size = new System.Drawing.Size(435, 365);
            this.gb_text_pnj.TabIndex = 3;
            this.gb_text_pnj.TabStop = false;
            this.gb_text_pnj.Text = "Nội dung";
            // 
            // Bai6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gb_text_pnj);
            this.Controls.Add(this.tv_file);
            this.Name = "Bai6";
            this.Text = "Bai6";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tv_file;
        private System.Windows.Forms.GroupBox gb_text_pnj;
    }
}