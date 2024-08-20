using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Financeiro
{
    public partial class Compra2 : Form
    {
        public Compra2(DataBaseDataSet.OrdemDeServicoRow OrdemDeServico)
        {
            InitializeComponent();
            DataBaseDataSet.OrcamentoRow novaLinha = dataBaseDataSet.Orcamento.NewOrcamentoRow();
        }

        private void Compra_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataBaseDataSet.Servico'. Você pode movê-la ou removê-la conforme necessário.
            this.servicoTableAdapter.Fill(this.dataBaseDataSet.Servico);

        }

        private void AtualizaSubtotal()
        {
            if (cbxProduto.SelectedValue != null)
            {
                double quantidade = (double)numQuantidade.Value;
                double valorProduto = (double)((decimal)cbxProduto.SelectedValue);
                double desconto = Convert.ToDouble(txtDesconto.Text);
                double subtotal = 0;
                if (rbtPercentil.Checked == true)
                {
                    subtotal = valorProduto * quantidade * (1 - (desconto / 100));
                }
                else
                {
                    subtotal = valorProduto * quantidade - desconto;
                }
                txtSubtotal.Text = subtotal.ToString("N2", CultureInfo.GetCultureInfo("pt-BR"));
            }
        }


        private void cbxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizaSubtotal();
            
        }
        
        private void numQuantidade_ValueChanged(object sender, EventArgs e)
        {
            AtualizaSubtotal();
        }
        
        private void rbtPercentil_CheckedChanged(object sender, EventArgs e)
        {
            AtualizaSubtotal();
        }

        private void txtDesconto_TextChanged(object sender, EventArgs e)
        {
            Utils.Moeda(ref txtDesconto);
            AtualizaSubtotal();
        }

        private void cbxParcelas_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizaSubtotal();
        }

        private void cbxFormaPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cbxFormaPagamento.SelectedItem.ToString());
            if (cbxFormaPagamento.SelectedItem.ToString() == "CARTÃO CRÉDITO - PARCELADO")
            {

                gbxParcelas.Visible = true;
                if (decimal.TryParse(txtSubtotal.Text, out decimal valorPagamento))
                {
                    var opcoesParcelamento = Utils.Pagamento.GerarOpcoesParcelamento(valorPagamento);
                    cbxParcelas.Items.Clear();
                    foreach (var parcela in opcoesParcelamento)
                    {
                        cbxParcelas.Items.Add(parcela);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, insira um valor de pagamento válido.");
                }

            }
        }
    }
}
