namespace GeradorRecibos
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.TextBox txtNomePagador;
        private System.Windows.Forms.TextBox txtNomeAtendente;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.DateTimePicker dateTimePickerPagamento;
        private System.Windows.Forms.Button btnTermico;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.ListView listViewRecibos;
        private System.Windows.Forms.ColumnHeader columnHeaderCnpj;
        private System.Windows.Forms.ColumnHeader columnHeaderNomePagador;
        private System.Windows.Forms.ColumnHeader columnHeaderDataPagamento;
        private System.Windows.Forms.ColumnHeader columnHeaderValor;
        private System.Windows.Forms.ColumnHeader columnHeaderFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.txtNomePagador = new System.Windows.Forms.TextBox();
            this.txtNomeAtendente = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.dateTimePickerPagamento = new System.Windows.Forms.DateTimePicker();
            this.btnTermico = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.listViewRecibos = new System.Windows.Forms.ListView();
            this.columnHeaderCnpj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNomePagador = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDataPagamento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderValor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFilePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(158, 22);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(235, 20);
            this.txtCnpj.TabIndex = 0;
            // 
            // txtNomePagador
            // 
            this.txtNomePagador.Location = new System.Drawing.Point(158, 57);
            this.txtNomePagador.Name = "txtNomePagador";
            this.txtNomePagador.Size = new System.Drawing.Size(235, 20);
            this.txtNomePagador.TabIndex = 1;
            // 
            // txtNomeAtendente
            // 
            this.txtNomeAtendente.Location = new System.Drawing.Point(158, 92);
            this.txtNomeAtendente.Name = "txtNomeAtendente";
            this.txtNomeAtendente.Size = new System.Drawing.Size(235, 20);
            this.txtNomeAtendente.TabIndex = 2;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(158, 162);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(235, 20);
            this.txtValor.TabIndex = 3;
            // 
            // dateTimePickerPagamento
            // 
            this.dateTimePickerPagamento.Location = new System.Drawing.Point(158, 127);
            this.dateTimePickerPagamento.Name = "dateTimePickerPagamento";
            this.dateTimePickerPagamento.Size = new System.Drawing.Size(235, 20);
            this.dateTimePickerPagamento.TabIndex = 4;
            // 
            // btnTermico
            // 
            this.btnTermico.Location = new System.Drawing.Point(53, 214);
            this.btnTermico.Name = "btnTermico";
            this.btnTermico.Size = new System.Drawing.Size(120, 30);
            this.btnTermico.TabIndex = 6;
            this.btnTermico.Text = "Gerar Recibo";
            this.btnTermico.UseVisualStyleBackColor = true;
            this.btnTermico.Click += new System.EventHandler(this.btnTermico_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(50, 400);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(120, 30);
            this.btnVisualizar.TabIndex = 7;
            this.btnVisualizar.Text = "Visualizar Recibo";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // listViewRecibos
            // 
            this.listViewRecibos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderCnpj,
            this.columnHeaderNomePagador,
            this.columnHeaderDataPagamento,
            this.columnHeaderValor,
            this.columnHeaderFilePath});
            this.listViewRecibos.FullRowSelect = true;
            this.listViewRecibos.GridLines = true;
            this.listViewRecibos.HideSelection = false;
            this.listViewRecibos.Location = new System.Drawing.Point(50, 250);
            this.listViewRecibos.Name = "listViewRecibos";
            this.listViewRecibos.Size = new System.Drawing.Size(343, 130);
            this.listViewRecibos.TabIndex = 8;
            this.listViewRecibos.UseCompatibleStateImageBehavior = false;
            this.listViewRecibos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderCnpj
            // 
            this.columnHeaderCnpj.Text = "CNPJ";
            this.columnHeaderCnpj.Width = 80;
            // 
            // columnHeaderNomePagador
            // 
            this.columnHeaderNomePagador.Text = "Nome do Pagador";
            this.columnHeaderNomePagador.Width = 100;
            // 
            // columnHeaderDataPagamento
            // 
            this.columnHeaderDataPagamento.Text = "Data de Pagamento";
            this.columnHeaderDataPagamento.Width = 100;
            // 
            // columnHeaderValor
            // 
            this.columnHeaderValor.Text = "Valor";
            // 
            // columnHeaderFilePath
            // 
            this.columnHeaderFilePath.Text = "Caminho do Arquivo";
            this.columnHeaderFilePath.Width = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "CNPJ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nome do Pagador";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nome do Atendente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Data de Pagamento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Valor";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(532, 472);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.listViewRecibos);
            this.Controls.Add(this.btnTermico);
            this.Controls.Add(this.dateTimePickerPagamento);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtNomeAtendente);
            this.Controls.Add(this.txtNomePagador);
            this.Controls.Add(this.txtCnpj);
            this.Name = "Form1";
            this.Text = "Gerador de Recibos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
