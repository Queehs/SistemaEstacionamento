namespace eteczl.recuperacao
{
    partial class FrmPesquisaFunc
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
            this.DtFunc = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DtFunc)).BeginInit();
            this.SuspendLayout();
            // 
            // DtFunc
            // 
            this.DtFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtFunc.Location = new System.Drawing.Point(12, 12);
            this.DtFunc.Name = "DtFunc";
            this.DtFunc.Size = new System.Drawing.Size(415, 210);
            this.DtFunc.TabIndex = 1;
            // 
            // FrmPesquisaFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 234);
            this.Controls.Add(this.DtFunc);
            this.Name = "FrmPesquisaFunc";
            this.Text = "FrmPesquisaFunc";
            this.Load += new System.EventHandler(this.FrmPesquisaFunc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtFunc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DtFunc;
    }
}