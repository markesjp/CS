using Sistema_Financeiro.DataBaseDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Financeiro
{
    public partial class Compra1 : Form
    {
        public Compra1()
        {
            InitializeComponent();
        }

        private void Compra1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataBaseDataSet.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.dataBaseDataSet.Cliente);

        }

        private void btConfirmaCompra1_Click(object sender, EventArgs e)
        {
            int row = dataGridViewCompra.CurrentCell.RowIndex;
            MessageBox.Show(dataGridViewCompra.CurrentCell.RowIndex.ToString());
            MessageBox.Show(dataGridViewCompra.Rows[row].Cells[0].Value.ToString());
            DataBaseDataSet.OrdemDeServicoRow novaLinha = dataBaseDataSet.OrdemDeServico.NewOrdemDeServicoRow();
            
            novaLinha.ID_Cliente = (int)dataGridViewCompra.Rows[row].Cells[0].Value;
            novaLinha.DataCriacao = DateTime.Now;

            Panel parentPanel = this.Parent as Panel;
            Utils.OpenForm(parentPanel, new Compra2(novaLinha));
   
            

        }

    }
}
    