namespace eteczl.recuperacao
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
            this.btnCadCarro = new System.Windows.Forms.Button();
            this.btnCadCli = new System.Windows.Forms.Button();
            this.btnCadFunc = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.labelPlease = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCadCarro
            // 
            this.btnCadCarro.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCadCarro.Location = new System.Drawing.Point(33, 135);
            this.btnCadCarro.Name = "btnCadCarro";
            this.btnCadCarro.Size = new System.Drawing.Size(204, 23);
            this.btnCadCarro.TabIndex = 0;
            this.btnCadCarro.Text = "Cadastro de Carros";
            this.btnCadCarro.UseVisualStyleBackColor = false;
            this.btnCadCarro.Click += new System.EventHandler(this.btnCadCarro_Click);
            // 
            // btnCadCli
            // 
            this.btnCadCli.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCadCli.Location = new System.Drawing.Point(33, 188);
            this.btnCadCli.Name = "btnCadCli";
            this.btnCadCli.Size = new System.Drawing.Size(204, 23);
            this.btnCadCli.TabIndex = 1;
            this.btnCadCli.Text = "Cadastro de Clientes";
            this.btnCadCli.UseVisualStyleBackColor = false;
            this.btnCadCli.Click += new System.EventHandler(this.btnCadCli_Click);
            // 
            // btnCadFunc
            // 
            this.btnCadFunc.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCadFunc.Location = new System.Drawing.Point(33, 238);
            this.btnCadFunc.Name = "btnCadFunc";
            this.btnCadFunc.Size = new System.Drawing.Size(204, 23);
            this.btnCadFunc.TabIndex = 2;
            this.btnCadFunc.Text = "Cadastro de Funcionários";
            this.btnCadFunc.UseVisualStyleBackColor = false;
            this.btnCadFunc.Click += new System.EventHandler(this.btnCadFunc_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(34, 31);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(203, 29);
            this.lblWelcome.TabIndex = 3;
            this.lblWelcome.Text = "Seja Bem-Vindo!";
            // 
            // labelPlease
            // 
            this.labelPlease.AutoSize = true;
            this.labelPlease.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlease.Location = new System.Drawing.Point(53, 77);
            this.labelPlease.Name = "labelPlease";
            this.labelPlease.Size = new System.Drawing.Size(166, 13);
            this.labelPlease.TabIndex = 4;
            this.labelPlease.Text = "Por favor, selecione uma opção...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(278, 299);
            this.Controls.Add(this.labelPlease);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnCadFunc);
            this.Controls.Add(this.btnCadCli);
            this.Controls.Add(this.btnCadCarro);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estacionamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadCarro;
        private System.Windows.Forms.Button btnCadCli;
        private System.Windows.Forms.Button btnCadFunc;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label labelPlease;
    }
}

