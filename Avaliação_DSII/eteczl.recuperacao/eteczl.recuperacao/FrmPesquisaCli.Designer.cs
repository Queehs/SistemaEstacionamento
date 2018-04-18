namespace eteczl.recuperacao
{
    partial class FrmPesquisaCli
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
            this.DtCli = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DtCli)).BeginInit();
            this.SuspendLayout();
            // 
            // DtCli
            // 
            this.DtCli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtCli.Location = new System.Drawing.Point(12, 12);
            this.DtCli.Name = "DtCli";
            this.DtCli.Size = new System.Drawing.Size(415, 210);
            this.DtCli.TabIndex = 1;
            // 
            // FrmPesquisaCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 234);
            this.Controls.Add(this.DtCli);
            this.Name = "FrmPesquisaCli";
            this.Text = "FrmPesquisaCli";
            this.Load += new System.EventHandler(this.FrmPesquisaCli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtCli)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DtCli;
    }
}