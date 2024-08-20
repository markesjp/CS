using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Sistema_Financeiro
{
    public class Utils
    {
        public static Panel panelDateTimePickers = new Panel();
        public static void LimparCampos(Panel obj)
        {
            foreach (Control controle in obj.Controls)
            {
                // Verifica se o controle é um TextBox
                if (controle is TextBox)
                {
                    // Limpa o texto do TextBox
                    ((TextBox)controle).Clear();
                }
                if (controle is MaskedTextBox)
                {
                    ((MaskedTextBox)controle).Clear();
                }
            }
        }

        public static void ApenasNumeros(object sender, KeyPressEventArgs e)
        {
            // Verifica se a tecla pressionada é um número ou se é uma tecla de controle (como backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;

        }

        public static void Moeda(ref TextBox txt)
        {
            string n = string.Empty;
            double v = 0;
            try
            {
                n = txt.Text.Replace(",", "").Replace(".", "");
                n = n.PadLeft(3, '0');
                if ((n.Length > 3) & n.Substring(0, 1) == "0")
                {
                    n = n.Substring(1, n.Length - 1);
                }
                v = Convert.ToDouble(n) / 100;
                txt.Text = string.Format("{0:N}", v);
                txt.SelectionStart = txt.Text.Length;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: ", ex.ToString());
            }
        }

        public static void OpenForm(Panel panel, Form form)
        {
            if (panel.Controls.Count > 0)
                panel.Controls.RemoveAt(0);


            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            panel.Controls.Add(form);
            panel.Tag = form;
            form.Show();
        }

        public class Parcela
        {
            public int Numero { get; set; }
            public decimal Valor { get; set; }

            public override string ToString()
            {
                return $"{Numero}x de {Valor:C}";
            }
        }

        public static class Pagamento
        {
            public static List<Parcela> GerarOpcoesParcelamento(decimal valorPagamento, decimal taxaJurosMensal = 0.02m, int maxParcelas = 12)
            {
                var opcoesParcelamento = new List<Parcela>();

                for (int i = 1; i <= maxParcelas; i++)
                {
                    decimal valorParcela = CalcularValorParcela(valorPagamento, i, taxaJurosMensal);
                    opcoesParcelamento.Add(new Parcela { Numero = i, Valor = valorParcela });
                }

                return opcoesParcelamento;
            }

            private static decimal CalcularValorParcela(decimal valorTotal, int numParcelas, decimal taxaJurosMensal)
            {
                if (numParcelas == 1)
                {
                    return valorTotal;
                }
                else
                {
                    decimal valorParcela = valorTotal * (decimal)Math.Pow((double)(1 + taxaJurosMensal), numParcelas) * taxaJurosMensal /
                                            ((decimal)Math.Pow((double)(1 + taxaJurosMensal), numParcelas) - 1);
                    return Math.Round(valorParcela, 2);
                }
            }
        }
    }
}
