namespace eteczl.recuperacao
{
    partial class FrmPesquisaCar
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
            this.DtCarros = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DtCarros)).BeginInit();
            this.SuspendLayout();
            // 
            // DtCarros
            // 
            this.DtCarros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtCarros.Location = new System.Drawing.Point(12, 12);
            this.DtCarros.Name = "DtCarros";
            this.DtCarros.Size = new System.Drawing.Size(415, 210);
            this.DtCarros.TabIndex = 0;
            // 
            // FrmPesquisaCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(439, 234);
            this.Controls.Add(this.DtCarros);
            this.Name = "FrmPesquisaCar";
            this.Text = "Pesquisa de Carros";
            this.Load += new System.EventHandler(this.FrmPesquisaCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtCarros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DtCarros;
    }
}