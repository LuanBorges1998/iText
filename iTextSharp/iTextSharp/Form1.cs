using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iTextSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGerarPDF_Click(object sender, EventArgs e)
        {
            GerarPDF(@"C:\Users\luan\source\repos\iTextSharp\iTextSharp\PDFs\Teste.pdf");
        }

        private void GerarPDF(string pCaminhoArquivoPDF)
        {
            Document documento = new Document(PageSize.A4, 72, 72, 72, 72);

            PdfWriter.GetInstance(documento, new FileStream(pCaminhoArquivoPDF, FileMode.Create));

            try
            {
                Paragraph p = new Paragraph(txtTexto.Text);
                p.Alignment = Element.ALIGN_CENTER;

                documento.Open();
                documento.Add(p);
                documento.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace);
            }
        }
    }
}
