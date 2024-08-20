using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Sistema_Financeiro
{
    public partial class Funcionario : Form
    {
        Panel panelDateTimePickers = new Panel();

        static Random random = new Random(123);
        public Funcionario()
        {
            InitializeComponent();
        }

        private void Funcionario_Load(object sender, EventArgs e)
        {
           
            this.funcionarioTableAdapter.Fill(this.dataBaseDataSet.Funcionario);

        }

        private void funcionarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.funcionarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataBaseDataSet);

        }

        private string geraEndereco()
        {
            string endereco = enderecoTextBox.Text + ", " + numeroTextBox.Text + ", " + complementoTextBox.Text + " - " + bairroTextBox.Text + " \nCEP: " + cEPTextBox.Text
                + ". " + cidadeTextBox.Text;

            return endereco;
        }

        private void btSalvarFuncionario_Click(object sender, EventArgs e)
        {
            DataBaseDataSet.FuncionarioRow newRow = dataBaseDataSet.Funcionario.NewFuncionarioRow();

            try
            {
                newRow.Nome = nomeTextBox.Text;
                newRow.CPF = cPFTextBox.Text;
                newRow.Genero = generoComboBox.SelectedItem.ToString();
                newRow.Endereco = geraEndereco();
                newRow.Telefone = telefoneTextBox.Text;
                newRow.NumeroCarteiraTrabalho = numeroCarteiraTrabalhoMaskedTextBox.Text;
                newRow.DataNascimento = dataNascimentoDateTimePicker.Value;
                newRow.DataCadastro = dataCadastroDateTimePicker.Value;

                dataBaseDataSet.Funcionario.AddFuncionarioRow(newRow);
                funcionarioTableAdapter.Update(dataBaseDataSet.Funcionario);
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
            funcionarioTableAdapter.Fill(dataBaseDataSet.Funcionario);
            funcionarioDataGridView.ClearSelection();
            Utils.LimparCampos(panel1);
            nomeTextBox.Focus();
        }
        private void RealizarPesquisa()
        {
            string filter = pesquisaComboBox.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(filter))
            {
                if (filter == "DataNascimento" || filter == "DataCadastro")
                {
                    // Remove os controles anteriores, se houver

                    // Cria um Panel para os DateTimePickers
                    panelDateTimePickers.Location = new Point(pesquisaTextBox.Location.X, pesquisaTextBox.Location.Y + pesquisaTextBox.Height + 5);
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

        private void AplicarFiltroData(DateTimePicker datePickerInicio, DateTimePicker datePickerFim)
        {
            // Aplica o filtro para valores entre as duas datas selecionadas
            dataBaseDataSet.Funcionario.DefaultView.RowFilter = string.Format("[{0}] >= #{1}# AND [{0}] <= #{2}#", pesquisaComboBox.Text, datePickerInicio.Value.ToString("yyyy-MM-dd"), datePickerFim.Value.ToString("yyyy-MM-dd"));

            // Atualiza o DataGridView com os dados filtrados
            funcionarioDataGridView.DataSource = dataBaseDataSet.Funcionario.DefaultView;
        }

        private void AplicarFiltroPadrao()
        {
            // Aplica o filtro padrão
            dataBaseDataSet.Funcionario.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", pesquisaComboBox.Text, pesquisaTextBox.Text);

            // Atualiza o DataGridView com os dados filtrados
            funcionarioDataGridView.DataSource = dataBaseDataSet.Funcionario.DefaultView;
        }

        private void pesquisaTextBox_TextChanged(object sender, EventArgs e)
        {
            RealizarPesquisa();
        }


        private void AdicionarFuncionario(DataBaseDataSet.FuncionarioRow novoFuncionario)
        {
            try
            {
                dataBaseDataSet.Funcionario.AddFuncionarioRow(novoFuncionario);
                funcionarioTableAdapter.Update(dataBaseDataSet.Funcionario);
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
        }

        static DateTime GerarDataHoraAleatoria()
        {
            // Gerar valores aleatórios para o ano, mês, dia, hora, minuto, segundo e milissegundo
            int ano = random.Next(1970, 2004); // Entre 1900 e 2100
            int mes = random.Next(1, 13); // Entre 1 e 12
            int dia = random.Next(1, DateTime.DaysInMonth(ano, mes) + 1); // Entre 1 e o número de dias no mês
            // Criar um objeto DateTime com os valores aleatórios
            DateTime dataHoraAleatoria = new DateTime(ano, mes, dia);

            return dataHoraAleatoria;
        }
    }

}
