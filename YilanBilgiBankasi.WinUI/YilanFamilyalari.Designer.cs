namespace YilanBilgiBankasi.WinUI
{
    partial class YilanFamilyalari
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
            this.dgvYilanFamilyalar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYilanFamilyalar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvYilanFamilyalar
            // 
            this.dgvYilanFamilyalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYilanFamilyalar.Location = new System.Drawing.Point(25, 29);
            this.dgvYilanFamilyalar.Name = "dgvYilanFamilyalar";
            this.dgvYilanFamilyalar.Size = new System.Drawing.Size(483, 392);
            this.dgvYilanFamilyalar.TabIndex = 0;
            // 
            // YilanFamilyalari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 452);
            this.Controls.Add(this.dgvYilanFamilyalar);
            this.Name = "YilanFamilyalari";
            this.Text = "YilanFamilyalari";
            this.Load += new System.EventHandler(this.YilanFamilyalari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvYilanFamilyalar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvYilanFamilyalar;
    }
}