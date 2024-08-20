namespace Sistema_Financeiro
{
    partial class Pagamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iD_ClienteLabel;
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label dataPagamentoLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataBaseDataSet = new Sistema_Financeiro.DataBaseDataSet();
            this.pagamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pagamentoTableAdapter = new Sistema_Financeiro.DataBaseDataSetTableAdapters.PagamentoTableAdapter();
            this.tableAdapterManager = new Sistema_Financeiro.DataBaseDataSetTableAdapters.TableAdapterManager();
            this.pagamentoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iD_ClienteTextBox = new System.Windows.Forms.TextBox();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.dataPagamentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            iD_ClienteLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            dataPagamentoLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentoDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(iD_ClienteLabel);
            this.panel1.Controls.Add(this.iD_ClienteTextBox);
            this.panel1.Controls.Add(valorLabel);
            this.panel1.Controls.Add(this.valorTextBox);
            this.panel1.Controls.Add(dataPagamentoLabel);
            this.panel1.Controls.Add(this.dataPagamentoDateTimePicker);
            this.panel1.Location = new System.Drawing.Point(23, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 360);
            this.panel1.TabIndex = 0;
            // 
            // dataBaseDataSet
            // 
            this.dataBaseDataSet.DataSetName = "DataBaseDataSet";
            this.dataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pagamentoBindingSource
            // 
            this.pagamentoBindingSource.DataMember = "Pagamento";
            this.pagamentoBindingSource.DataSource = this.dataBaseDataSet;
            // 
            // pagamentoTableAdapter
            // 
            this.pagamentoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.DescricaoTableAdapter = null;
            this.tableAdapterManager.FuncionarioTableAdapter = null;
            this.tableAdapterManager.PagamentoTableAdapter = this.pagamentoTableAdapter;
            this.tableAdapterManager.ServicoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Sistema_Financeiro.DataBaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pagamentoDataGridView
            // 
            this.pagamentoDataGridView.AutoGenerateColumns = false;
            this.pagamentoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pagamentoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.pagamentoDataGridView.DataSource = this.pagamentoBindingSource;
            this.pagamentoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pagamentoDataGridView.Location = new System.Drawing.Point(0, 0);
            this.pagamentoDataGridView.Name = "pagamentoDataGridView";
            this.pagamentoDataGridView.Size = new System.Drawing.Size(639, 356);
            this.pagamentoDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_Cliente";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID_Cliente";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Valor";
            this.dataGridViewTextBoxColumn3.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DataPagamento";
            this.dataGridViewTextBoxColumn4.HeaderText = "DataPagamento";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FuncionarioRecebeu";
            this.dataGridViewTextBoxColumn5.HeaderText = "FuncionarioRecebeu";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.pagamentoDataGridView);
            this.panel2.Location = new System.Drawing.Point(464, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(643, 360);
            this.panel2.TabIndex = 1;
            // 
            // iD_ClienteLabel
            // 
            iD_ClienteLabel.AutoSize = true;
            iD_ClienteLabel.Location = new System.Drawing.Point(8, 32);
            iD_ClienteLabel.Name = "iD_ClienteLabel";
            iD_ClienteLabel.Size = new System.Drawing.Size(56, 13);
            iD_ClienteLabel.TabIndex = 2;
            iD_ClienteLabel.Text = "ID Cliente:";
            // 
            // iD_ClienteTextBox
            // 
            this.iD_ClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagamentoBindingSource, "ID_Cliente", true));
            this.iD_ClienteTextBox.Location = new System.Drawing.Point(126, 29);
            this.iD_ClienteTextBox.Name = "iD_ClienteTextBox";
            this.iD_ClienteTextBox.Size = new System.Drawing.Size(200, 20);
            this.iD_ClienteTextBox.TabIndex = 3;
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(8, 58);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(34, 13);
            valorLabel.TabIndex = 4;
            valorLabel.Text = "Valor:";
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagamentoBindingSource, "Valor", true));
            this.valorTextBox.Location = new System.Drawing.Point(126, 55);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(200, 20);
            this.valorTextBox.TabIndex = 5;
            // 
            // dataPagamentoLabel
            // 
            dataPagamentoLabel.AutoSize = true;
            dataPagamentoLabel.Location = new System.Drawing.Point(8, 85);
            dataPagamentoLabel.Name = "dataPagamentoLabel";
            dataPagamentoLabel.Size = new System.Drawing.Size(90, 13);
            dataPagamentoLabel.TabIndex = 6;
            dataPagamentoLabel.Text = "Data Pagamento:";
            // 
            // dataPagamentoDateTimePicker
            // 
            this.dataPagamentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pagamentoBindingSource, "DataPagamento", true));
            this.dataPagamentoDateTimePicker.Location = new System.Drawing.Point(126, 81);
            this.dataPagamentoDateTimePicker.Name = "dataPagamentoDateTimePicker";
            this.dataPagamentoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataPagamentoDateTimePicker.TabIndex = 7;
            // 
            // Pagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 746);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Pagamento";
            this.Text = "Pagamentos";
            this.Load += new System.EventHandler(this.Pagamento_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentoDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DataBaseDataSet dataBaseDataSet;
        private System.Windows.Forms.BindingSource pagamentoBindingSource;
        private DataBaseDataSetTableAdapters.PagamentoTableAdapter pagamentoTableAdapter;
        private DataBaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView pagamentoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox iD_ClienteTextBox;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.DateTimePicker dataPagamentoDateTimePicker;
    }
}