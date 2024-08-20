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
    partial class Form1 : Form
    {
        private DataGridView dataGridView;
        private Button payButton;
        private TextBox paymentTextBox;
        private DatabaseHelper dbHelper;
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DataBase.mdf;Integrated Security=True;Connect Timeout=30";

        public Form1()
        {
            dbHelper = new DatabaseHelper(connectionString);
            InitializeComponent();
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string query = @"
            SELECT 
                d.DataVencimento,
                d.ValorParcela,
                c.Nome,
                c.CPF
            FROM 
                [dbo].[Debito] d
            JOIN 
                [dbo].[Orcamento] o ON d.ID_Orcamento = o.ID
            JOIN 
                [dbo].[Cliente] c ON o.ID_Cliente = c.ID
            WHERE 
                d.DataVencimento < GETDATE()
                AND NOT EXISTS (
                    SELECT 1
                    FROM [dbo].[Pagamento] p
                    WHERE p.ID_Debito = d.ID
                );
            ";
            Console.WriteLine(query);
            DataTable dataTable = dbHelper.ExecuteQuery(query);
            dataGridView.DataSource = dataTable;
        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView.SelectedRows[0];
                var servicoId = (int)selectedRow.Cells["ID"].Value;
                var clienteId = (int)selectedRow.Cells["ID_Cliente"].Value;
                var paymentValue = Convert.ToDecimal(paymentTextBox.Text);

                var valorTotal = Convert.ToDecimal(selectedRow.Cells["ValorTotal"].Value);

                if (paymentValue == valorTotal)
                {
                    string insertQuery = $"INSERT INTO Pagamento (ID_Cliente, Valor, DataPagamento, ID_Funcionario) " +
                                         $"VALUES ({clienteId}, {paymentValue}, '{DateTime.Now}', 1)";

                    try
                    {
                        dbHelper.ExecuteQuery(insertQuery);
                        MessageBox.Show("Payment successful!");
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid payment amount.");
                }
            }
        }
    }

}
