using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Sistema_Financeiro
{
    public partial class Menu : Form
    {
        private DatabaseHelper dbHelper;
        public Menu()
        {
            InitializeComponent();
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jhon_\OneDrive\Documentos\GitHub\Visual Studio\Sistema Financeiro\DataBase.mdf;Integrated Security=True;Connect Timeout=30";
            dbHelper = new DatabaseHelper(connectionString);
        }

        private void DisplayQueryResult(string query)
        {
            try
            {
                DataTable result = dbHelper.ExecuteQuery(query);

                if (result != null)
                {
                    dataGridViewMenu.DataSource = result;

                    // Supondo que você tenha um Panel chamado panelMenu
                    if (panelMenu.Controls.Count > 0)
                        panelMenu.Controls.RemoveAt(0);

                    panelMenu.Controls.Add(dataGridViewMenu);
                }
                else
                {
                    MessageBox.Show("Nenhum dado encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao executar consulta SQL: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Utils.OpenForm(panelMenu, new Cliente());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Utils.OpenForm(panelMenu, new Servicos());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Utils.OpenForm(panelMenu, new Funcionario());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = @"
            SELECT 
                d.DataVencimento,
                d.ValorParcela,
                c.Nome,
                c.CPF,
                CASE 
                    WHEN EXISTS (
                        SELECT 1
                        FROM [dbo].[Pagamento] p
                        WHERE p.ID_Debito = d.ID
                    ) THEN 'Paga'
                    ELSE 'Não paga'
                END AS StatusPagamento
            FROM
                [dbo].[Debito] d
            JOIN
                [dbo].[Orcamento] o ON d.ID_Orcamento = o.ID
            JOIN
                [dbo].[Cliente] c ON o.ID_Cliente = c.ID;
            ";

            DisplayQueryResult(query);
        }

        private void button5_Click(object sender, EventArgs e)
        {
           Utils.OpenForm(panelMenu, new Form1());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string query = @"
            SELECT
                c.ID,
                c.Nome,
                c.CPF,
                SUM(d.ValorParcela) AS ValorDebito,
                'Inadimplente' AS Status
            FROM 
                [dbo].[Cliente] c
            JOIN 
                [dbo].[Orcamento] o ON c.ID = o.ID_Cliente
            JOIN 
                [dbo].[Debito] d ON o.ID = d.ID_Orcamento
            WHERE 
                d.DataVencimento < GETDATE()
                AND d.ID NOT IN (SELECT ID_Debito FROM [dbo].[Pagamento])
            GROUP BY
                c.ID, c.Nome, c.CPF;
            ";
            DisplayQueryResult(query );
        }
        private void DataGridViewMenu_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            // Obtém a linha atual
            DataGridViewRow row = dataGridViewMenu.Rows[e.RowIndex];

            // Obtém o valor da coluna desejada (substitua pelo índice da sua coluna)
            string status = row.Cells["Status"].Value.ToString();

            // Define a cor da linha com base no valor da coluna
            if (status == "Paga")
            {
                row.DefaultCellStyle.BackColor = Color.LightGreen; // Cor verde para status 'Paga'
            }
            else if (status == "Não paga")
            {
                row.DefaultCellStyle.BackColor = Color.LightSalmon; // Cor salmão para status 'Não paga'
            }
            else
            {
                // Cor padrão para outras situações
                row.DefaultCellStyle.BackColor = Color.White;
            }
        }

        private void btCompra_Click(object sender, EventArgs e)
        {
            Utils.OpenForm(panelMenu, new Compra1());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }
    }
    
}
