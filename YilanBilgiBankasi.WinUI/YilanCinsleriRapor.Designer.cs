namespace YilanBilgiBankasi.WinUI
{
    partial class YilanCinsleriRapor
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
            this.dgvCinsler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCinsler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCinsler
            // 
            this.dgvCinsler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCinsler.Location = new System.Drawing.Point(13, 20);
            this.dgvCinsler.Name = "dgvCinsler";
            this.dgvCinsler.Size = new System.Drawing.Size(462, 418);
            this.dgvCinsler.TabIndex = 0;
            // 
            // YilanCinsleriRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 453);
            this.Controls.Add(this.dgvCinsler);
            this.Name = "YilanCinsleriRapor";
            this.Text = "YilanCinsleriRapor";
            this.Load += new System.EventHandler(this.YilanCinsleriRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCinsler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCinsler;
    }
}