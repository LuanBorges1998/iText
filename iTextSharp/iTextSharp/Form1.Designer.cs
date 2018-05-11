namespace iTextSharp
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
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.btnGerarPDF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(12, 12);
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(260, 205);
            this.txtTexto.TabIndex = 0;
            // 
            // btnGerarPDF
            // 
            this.btnGerarPDF.Location = new System.Drawing.Point(197, 227);
            this.btnGerarPDF.Name = "btnGerarPDF";
            this.btnGerarPDF.Size = new System.Drawing.Size(75, 23);
            this.btnGerarPDF.TabIndex = 1;
            this.btnGerarPDF.Text = "Gerar PDF";
            this.btnGerarPDF.UseVisualStyleBackColor = true;
            this.btnGerarPDF.Click += new System.EventHandler(this.btnGerarPDF_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnGerarPDF);
            this.Controls.Add(this.txtTexto);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Button btnGerarPDF;
    }
}

