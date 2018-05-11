namespace UtilizandoFile
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtLeitura = new System.Windows.Forms.TextBox();
            this.txtEscrita = new System.Windows.Forms.TextBox();
            this.bttEscrever = new System.Windows.Forms.Button();
            this.bttLer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLeitura
            // 
            this.txtLeitura.Location = new System.Drawing.Point(13, 13);
            this.txtLeitura.Multiline = true;
            this.txtLeitura.Name = "txtLeitura";
            this.txtLeitura.Size = new System.Drawing.Size(259, 99);
            this.txtLeitura.TabIndex = 0;
            // 
            // txtEscrita
            // 
            this.txtEscrita.Location = new System.Drawing.Point(12, 118);
            this.txtEscrita.Multiline = true;
            this.txtEscrita.Name = "txtEscrita";
            this.txtEscrita.Size = new System.Drawing.Size(259, 99);
            this.txtEscrita.TabIndex = 1;
            // 
            // bttEscrever
            // 
            this.bttEscrever.Location = new System.Drawing.Point(50, 223);
            this.bttEscrever.Name = "bttEscrever";
            this.bttEscrever.Size = new System.Drawing.Size(75, 23);
            this.bttEscrever.TabIndex = 2;
            this.bttEscrever.Text = "Escrever";
            this.bttEscrever.UseVisualStyleBackColor = true;
            this.bttEscrever.Click += new System.EventHandler(this.bttEscrever_Click);
            // 
            // bttLer
            // 
            this.bttLer.Location = new System.Drawing.Point(167, 223);
            this.bttLer.Name = "bttLer";
            this.bttLer.Size = new System.Drawing.Size(75, 23);
            this.bttLer.TabIndex = 3;
            this.bttLer.Text = "Ler";
            this.bttLer.UseVisualStyleBackColor = true;
            this.bttLer.Click += new System.EventHandler(this.bttLer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.bttLer);
            this.Controls.Add(this.bttEscrever);
            this.Controls.Add(this.txtEscrita);
            this.Controls.Add(this.txtLeitura);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLeitura;
        private System.Windows.Forms.TextBox txtEscrita;
        private System.Windows.Forms.Button bttEscrever;
        private System.Windows.Forms.Button bttLer;
    }
}

