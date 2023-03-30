namespace UDP_client_sever1
{
    partial class Form1
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
            this.btsever = new System.Windows.Forms.Button();
            this.btClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btsever
            // 
            this.btsever.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btsever.Location = new System.Drawing.Point(123, 246);
            this.btsever.Name = "btsever";
            this.btsever.Size = new System.Drawing.Size(154, 54);
            this.btsever.TabIndex = 2;
            this.btsever.Text = "Sever";
            this.btsever.UseVisualStyleBackColor = true;
            this.btsever.Click += new System.EventHandler(this.btsever_Click);
            // 
            // btClient
            // 
            this.btClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btClient.Location = new System.Drawing.Point(542, 246);
            this.btClient.Name = "btClient";
            this.btClient.Size = new System.Drawing.Size(154, 54);
            this.btClient.TabIndex = 3;
            this.btClient.Text = "Client";
            this.btClient.UseVisualStyleBackColor = true;
            this.btClient.Click += new System.EventHandler(this.btClient_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btClient);
            this.Controls.Add(this.btsever);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btsever;
        private System.Windows.Forms.Button btClient;
    }
}

