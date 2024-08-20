using System;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Colors;
using iText.Kernel.Geom;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using System.Diagnostics;
using iText.Layout.Borders;

namespace GeradorRecibos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GerarRecibo(string filePath, bool modeloTermico)
        {
            string cnpj = txtCnpj.Text;
            string nomePagador = txtNomePagador.Text;
            string cpf = "###.###.###-##"; // Censurado
            string nomeAtendente = txtNomeAtendente.Text;
            DateTime dataPagamento = dateTimePickerPagamento.Value;
            string valor = txtValor.Text;

            using (PdfWriter writer = new PdfWriter(filePath))
            {
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf, PageSize.A7); // Tamanho de papel adequado para impressora térmica
                document.SetMargins(10, 10, 10, 10);

                PdfFont font = PdfFontFactory.CreateFont(StandardFonts.COURIER);
                PdfFont boldFont = PdfFontFactory.CreateFont(StandardFonts.COURIER_BOLD);

                // Conteúdo específico para modelo térmico
                if (modeloTermico)
                {
                    // Reduzir a fonte para caber na largura do papel
                    font = PdfFontFactory.CreateFont(StandardFonts.COURIER);
                    boldFont = PdfFontFactory.CreateFont(StandardFonts.COURIER_BOLD);
                }

                // Conteúdo comum
                document.Add(new Paragraph($"RECIBO")
                    .SetFont(boldFont)
                    .SetFontSize(10)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetMarginBottom(5));

                document.Add(new Paragraph($"CNPJ: {cnpj}")
                    .SetFont(font)
                    .SetFontSize(8)
                    .SetMarginBottom(5));

                document.Add(new Paragraph($"Nome do Pagador: {nomePagador}")
                    .SetFont(font)
                    .SetFontSize(8)
                    .SetMarginBottom(5));

                document.Add(new Paragraph($"CPF: {cpf}")
                    .SetFont(font)
                    .SetFontSize(8)
                    .SetMarginBottom(5));

                document.Add(new Paragraph($"Nome do Atendente: {nomeAtendente}")
                    .SetFont(font)
                    .SetFontSize(8)
                    .SetMarginBottom(5));

                document.Add(new Paragraph($"Data de Pagamento: {dataPagamento:dd/MM/yyyy}")
                    .SetFont(font)
                    .SetFontSize(8)
                    .SetMarginBottom(5));

                document.Add(new Paragraph($"Valor: R$ {valor}")
                    .SetFont(font)
                    .SetFontSize(8)
                    .SetMarginBottom(5));

                // Rodapé
                document.Add(new Paragraph("Obrigado pela preferência!")
                    .SetFont(boldFont)
                    .SetFontSize(8)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetMarginTop(10));

                document.Close();
            }

            // Adicionar recibo à ListView
            ListViewItem item = new ListViewItem(new[] { cnpj, nomePagador, dataPagamento.ToString("dd/MM/yyyy"), valor, filePath });
            listViewRecibos.Items.Add(item);

            MessageBox.Show("Recibo gerado com sucesso!");
        }

        private void btnTermico_Click(object sender, EventArgs e)
        {
            GerarRecibo($"recibo_termico_{DateTime.Now:yyyyMMddHHmmss}.pdf", true);
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if (listViewRecibos.SelectedItems.Count > 0)
            {
                string filePath = listViewRecibos.SelectedItems[0].SubItems[4].Text;
                Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
            }
            else
            {
                MessageBox.Show("Por favor, selecione um recibo na lista.");
            }
        }

    }
}
