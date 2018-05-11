using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace iTextSharp2.Controllers
{
    public class ReportsController : Controller
    {
        // GET: Reports
        public ActionResult Products()
        {
            var model = new { Nome = "Penihel" };

            ViewBag.Teste = "Teste";
            string htmlText = RenderViewToString("Products", model);


            byte[] buffer = RenderPDF(htmlText);



            Stream arquivo = null;
            StreamWriter escritor = null;
            try
            {
                if (System.IO.File.Exists(@"C:\Users\luan\source\repos\iTextSharp\arquivo.txt"))
                {
                    using (arquivo = System.IO.File.Open(@"C:\Users\luan\source\repos\iTextSharp\arquivo.txt", FileMode.Open))
                    using (escritor = new StreamWriter(arquivo))
                    {
                        //escritor.WriteLine(txtEscrita.Text);
                    }
                }
                else
                {
                    using (arquivo = System.IO.File.Open(@"C:\Users\luan\source\repos\iTextSharp\arquivo.txt", FileMode.Create))
                    using (escritor = new StreamWriter(arquivo))
                    {
                        //escritor.WriteLine(txtEscrita.Text);
                    }
                    using (arquivo = System.IO.File.Open(@"C:\Users\luan\source\repos\iTextSharp\arquivo.pdf", FileMode.Create))
                    {
                        //byte[] buffer = new byte[3];
                        foreach (byte b in buffer)
                        {
                            arquivo.WriteByte(b);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Executa o tratamento do erro que aconteceu
            }
            finally
            {
                // fecha o arquivo e o leitor

                // antes de fecharmos, precisamos verificar que o arquivo e o leitor foram
                // realmente criados com sucesso
                if (escritor != null)
                {
                    escritor.Close();
                }
                if (arquivo != null)
                {
                    arquivo.Close();
                }
            }




            return File(buffer, "application/PDF");
        }

        private string RenderViewToString(string viewName, object viewData)
        {
            var renderedView = new StringBuilder();

            var controller = this;


            using (var responseWriter = new StringWriter(renderedView))
            {
                var fakeResponse = new HttpResponse(responseWriter);

                var fakeContext = new HttpContext(System.Web.HttpContext.Current.Request, fakeResponse);

                var fakeControllerContext = new ControllerContext(new HttpContextWrapper(fakeContext), controller.ControllerContext.RouteData,
                    controller.ControllerContext.Controller);

                var oldContext = System.Web.HttpContext.Current;
                System.Web.HttpContext.Current = fakeContext;

                using (var viewPage = new ViewPage())
                {
                    var viewContext = new ViewContext(fakeControllerContext, new FakeView(), new ViewDataDictionary(), new TempDataDictionary(), responseWriter);

                    var html = new HtmlHelper(viewContext, viewPage);
                    html.RenderPartial(viewName, viewData);
                    System.Web.HttpContext.Current = oldContext;
                }
            }

            return renderedView.ToString();
        }

        private byte[] RenderPDF(string htmlText)
        {
            byte[] renderedBuffer;

            const int HorizontalMargin = 40;
            const int VerticalMargin = 40;

            using (var outputMemoryStream = new MemoryStream())
            {
                using (var pdfDocument = new Document(PageSize.A4, HorizontalMargin, HorizontalMargin, VerticalMargin, VerticalMargin))
                {
                    iTextSharp.text.pdf.PdfWriter pdfWriter = PdfWriter.GetInstance(pdfDocument, outputMemoryStream);
                    pdfWriter.CloseStream = false;

                    pdfDocument.Open();
                    using (var htmlViewReader = new StringReader(htmlText))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(pdfWriter, pdfDocument, htmlViewReader);
                    }

                }

                renderedBuffer = new byte[outputMemoryStream.Position];
                outputMemoryStream.Position = 0;
                outputMemoryStream.Read(renderedBuffer, 0, renderedBuffer.Length);
            }

            return renderedBuffer;
        }
    }
}
