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

namespace UtilizandoFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttLer_Click(object sender, EventArgs e)
        {
            Stream arquivo = null;
            StreamReader leitor = null;
            try
            {
                if (File.Exists(@"C:\Users\luan\source\repos\iTextSharp\arquivo.txt"))
                {
                    using (arquivo = File.Open(@"C:\Users\luan\source\repos\iTextSharp\arquivo.txt", FileMode.Open))
                    using (leitor = new StreamReader(arquivo))
                    {
                        // aqui dentro você pode utilizar tanto o leitor quanto o arquivo
                        string linha = leitor.ReadLine();
                        while (linha != null)
                        {
                            //MessageBox.Show(linha);
                            txtLeitura.Text += linha;
                            linha = leitor.ReadLine();
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
                if (leitor != null)
                {
                    leitor.Close();
                }
                if (arquivo != null)
                {
                    arquivo.Close();
                }
            }
            //if (File.Exists("entrada.txt"))
            //{
            //    Stream entrada = File.Open("arquivo.txt", FileMode.Open);
            //    StreamReader leitor = new StreamReader(entrada);
            //    string linha = leitor.ReadLine();
            //    while (linha != null)
            //    {
            //        //MessageBox.Show(linha);
            //        txtLeitura.Text += linha;
            //        linha = leitor.ReadLine();
            //    }
            //    leitor.Close();
            //    entrada.Close();
            //}
        }

        private void bttEscrever_Click(object sender, EventArgs e)
        {
            Stream arquivo = null;
            StreamWriter escritor = null;
            try
            {
                if (File.Exists(@"C:\Users\luan\source\repos\iTextSharp\arquivo.txt"))
                {
                    using (arquivo = File.Open(@"C:\Users\luan\source\repos\iTextSharp\arquivo.txt", FileMode.Open))
                    using (escritor = new StreamWriter(arquivo))
                    {
                        escritor.WriteLine(txtEscrita.Text);
                    }
                }
                else
                {
                    using (arquivo = File.Open(@"C:\Users\luan\source\repos\iTextSharp\arquivo.txt", FileMode.Create))
                    using (escritor = new StreamWriter(arquivo))
                    {
                        escritor.WriteLine(txtEscrita.Text);
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


            //Stream saida = File.Open("arquivo.txt", FileMode.Create);
            //StreamWriter escritor = new StreamWriter(saida);
            //escritor.WriteLine(txtEscrita.Text);
            //escritor.Close();
            //saida.Close();
        }
    }
}
