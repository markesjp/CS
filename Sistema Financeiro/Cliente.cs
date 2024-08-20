using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Sistema_Financeiro
{
    public partial class Cliente : Form
    {
        Panel panelDateTimePickers = new Panel();

        public Cliente()
        {
            InitializeComponent();
            pesquisaClienteComboBox.SelectedIndex = 0;
            generoComboBox.SelectedIndex = 0;
            nomeTextBox.Focus();

        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataBaseDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataBaseDataSet.Descricao'. Você pode movê-la ou removê-la conforme necessário.
            this.descricaoTableAdapter.Fill(this.dataBaseDataSet.Descricao);
            // TODO: esta linha de código carrega dados na tabela 'dataBaseDataSet.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.dataBaseDataSet.Cliente);
        }

        private string geraEndereco()
        {
            string endereco = enderecoTextBox.Text + ", " + numeroTextBox.Text + ", " + complementoTextBox.Text + " - " + bairroTextBox.Text + " \nCEP: " + cEPTextBox.Text
                + ". " + cidadeTextBox.Text;

            return endereco;
        }


        private void btSalvar_Click(object sender, EventArgs e)
        {
            DataBaseDataSet.ClienteRow novaLinha = dataBaseDataSet.Cliente.NewClienteRow();

            try
            {
                novaLinha.Nome = nomeTextBox.Text;
                novaLinha.CPF = cPFTextBox.Text;
                novaLinha.Genero = generoComboBox.SelectedItem.ToString();
                novaLinha.Endereco = geraEndereco();
                novaLinha.Telefone = telefoneTextBox.Text;
                novaLinha.DataNascimento = dataNascimentoDateTimePicker.Value;
                novaLinha.DataCadastro = dataCadastroDateTimePicker.Value;

                dataBaseDataSet.Cliente.AddClienteRow(novaLinha);
                clienteTableAdapter.Update(dataBaseDataSet.Cliente);
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
            clienteTableAdapter.Fill(dataBaseDataSet.Cliente);
            clienteDataGridView.ClearSelection();
            Utils.LimparCampos(panel1);
            nomeTextBox.Focus();

        }
        

        private void RealizarPesquisa()
        {
            string filter = pesquisaClienteComboBox.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(filter))
            {
                if (filter == "DataNascimento" || filter == "DataCadastro")
                {
                    // Remove os controles anteriores, se houver

                    // Cria um Panel para os DateTimePickers
                    panelDateTimePickers.Location = new Point(pesquisaClienteTextBox.Location.X, pesquisaClienteTextBox.Location.Y + pesquisaClienteTextBox.Height + 5);
                    panelDateTimePickers.Size = new Size(400, 30); // Tamanho do painel

                    // Cria os DateTimePickers
                    DateTimePicker datePickerInicio = new DateTimePicker();
                    DateTimePicker datePickerFim = new DateTimePicker();

                    // Configurações dos DateTimePickers
                    datePickerInicio.Format = DateTimePickerFormat.Short;
                    datePickerFim.Format = DateTimePickerFormat.Short;

                    // Posiciona os DateTimePickers no Panel
                    datePickerInicio.Location = new Point(0, 0);
                    datePickerFim.Location = new Point(datePickerInicio.Width + 5, 0);

                    // Adiciona os DateTimePickers ao Panel
                    panelDateTimePickers.Controls.Add(datePickerInicio);
                    panelDateTimePickers.Controls.Add(datePickerFim);

                    // Adiciona o Panel ao formulário
                    panel3.Controls.Add(panelDateTimePickers);

                    // Garante que o Panel esteja na frente de outros controles
                    panelDateTimePickers.BringToFront();

                    // Aplica o filtro quando o valor do DateTimePicker for alterado
                    datePickerInicio.ValueChanged += (sender, args) => AplicarFiltroData(datePickerInicio, datePickerFim);
                    datePickerFim.ValueChanged += (sender, args) => AplicarFiltroData(datePickerInicio, datePickerFim);
                }
                else
                {
                    // Se a coluna selecionada não for uma data, remove os DateTimePickers e aplica o filtro padrão
                    AplicarFiltroPadrao();
                }
            }
        }

        private void pesquisaClienteTextBox_TextChanged(object sender, EventArgs e)
        {
            RealizarPesquisa();
        }

        private void AplicarFiltroData(DateTimePicker datePickerInicio, DateTimePicker datePickerFim)
        {
            // Aplica o filtro para valores entre as duas datas selecionadas
            dataBaseDataSet.Cliente.DefaultView.RowFilter = string.Format("[{0}] >= #{1}# AND [{0}] <= #{2}#", pesquisaClienteComboBox.Text, datePickerInicio.Value.ToString("yyyy-MM-dd"), datePickerFim.Value.ToString("yyyy-MM-dd"));

            // Atualiza o DataGridView com os dados filtrados
            clienteDataGridView.DataSource = dataBaseDataSet.Cliente.DefaultView;
        }

        private void AplicarFiltroPadrao()
        {
            // Aplica o filtro padrão
            dataBaseDataSet.Cliente.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", pesquisaClienteComboBox.Text, pesquisaClienteTextBox.Text);

            // Atualiza o DataGridView com os dados filtrados
            clienteDataGridView.DataSource = dataBaseDataSet.Cliente.DefaultView;
        }

        private void pesquisaClienteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            RealizarPesquisa();
        }

        private void enderecoTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
