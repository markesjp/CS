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
    public partial class Pagamento : Form
    {
        public Pagamento()
        {
            InitializeComponent();
        }

        private void pagamentoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pagamentoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataBaseDataSet);

        }

        private void Pagamento_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataBaseDataSet.Pagamento'. Você pode movê-la ou removê-la conforme necessário.
            this.pagamentoTableAdapter.Fill(this.dataBaseDataSet.Pagamento);

        }
    }
}
