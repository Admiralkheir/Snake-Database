namespace YilanBilgiBankasi.WinUI
{
    partial class YilanRapor
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
            this.dgvYilanRapor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYilanRapor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvYilanRapor
            // 
            this.dgvYilanRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYilanRapor.Location = new System.Drawing.Point(12, 55);
            this.dgvYilanRapor.Name = "dgvYilanRapor";
            this.dgvYilanRapor.Size = new System.Drawing.Size(533, 314);
            this.dgvYilanRapor.TabIndex = 1;
            // 
            // YilanRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 399);
            this.Controls.Add(this.dgvYilanRapor);
            this.Name = "YilanRapor";
            this.Text = "YilanRapor";
            this.Load += new System.EventHandler(this.YilanRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvYilanRapor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvYilanRapor;
    }
}