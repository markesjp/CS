using Sistema_Financeiro.DataBaseDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Financeiro
{
    public partial class Servicos : Form
    {
        public Servicos()
        {
            InitializeComponent();
        }

        private void servicoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.servicoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataBaseDataSet);

        }

        private void servicoBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.servicoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataBaseDataSet);

        }

        private void Serviços_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataBaseDataSet.Servico'. Você pode movê-la ou removê-la conforme necessário.
            this.servicoTableAdapter.Fill(this.dataBaseDataSet.Servico);

        }


        private void valorTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            Utils.ApenasNumeros(sender, e);
        }

        private void valorTextBox_TextChanged(object sender, EventArgs e)
        {
                Utils.Moeda(ref valorTextBox);
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            DataBaseDataSet.ServicoRow novaLinha = dataBaseDataSet.Servico.NewServicoRow();

            try
            {
                novaLinha.Descricao = descricaoTextBox.Text;
                novaLinha.Valor = decimal.Parse(valorTextBox.Text);

                dataBaseDataSet.Servico.AddServicoRow(novaLinha);
                servicoTableAdapter.Update(dataBaseDataSet.Servico);
            }
            catch (SqlException ex)
            {
                string errorMessage = "Erro ao atualizar o banco de dados.";
                errorMessage += "\n\nClique em 'OK' para mais detalhes do erro:\n" + ex.Message;
                DialogResult result = MessageBox.Show(errorMessage, "Erro", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Detalhes adicionais do erro:\n\n" + ex.ToString(), "Detalhes do Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            servicoTableAdapter.Fill(dataBaseDataSet.Servico);
            servicoDataGridView.ClearSelection();
            Utils.LimparCampos(panel1);
            descricaoTextBox.Focus();
        }
    }
}
