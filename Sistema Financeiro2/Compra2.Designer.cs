namespace Sistema_Financeiro
{
    partial class Compra2
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
            this.cbxProduto = new System.Windows.Forms.ComboBox();
            this.servicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseDataSet = new Sistema_Financeiro.DataBaseDataSet();
            this.servicoTableAdapter = new Sistema_Financeiro.DataBaseDataSetTableAdapters.ServicoTableAdapter();
            this.btConfirma = new System.Windows.Forms.Button();
            this.btCancela = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numQuantidade = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.rbtPercentil = new System.Windows.Forms.RadioButton();
            this.rbtValorAbsoluto = new System.Windows.Forms.RadioButton();
            this.gpDesconto = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.cbxFormaPagamento = new System.Windows.Forms.ComboBox();
            this.cbxParcelas = new System.Windows.Forms.ComboBox();
            this.gbxParcelas = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).BeginInit();
            this.gpDesconto.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbxParcelas.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxProduto
            // 
            this.cbxProduto.DataSource = this.servicoBindingSource;
            this.cbxProduto.DisplayMember = "Descricao";
            this.cbxProduto.FormattingEnabled = true;
            this.cbxProduto.Location = new System.Drawing.Point(92, 22);
            this.cbxProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxProduto.Name = "cbxProduto";
            this.cbxProduto.Size = new System.Drawing.Size(355, 24);
            this.cbxProduto.TabIndex = 0;
            this.cbxProduto.ValueMember = "Valor";
            this.cbxProduto.SelectedIndexChanged += new System.EventHandler(this.cbxProduto_SelectedIndexChanged);
            // 
            // servicoBindingSource
            // 
            this.servicoBindingSource.DataMember = "Servico";
            this.servicoBindingSource.DataSource = this.dataBaseDataSet;
            // 
            // dataBaseDataSet
            // 
            this.dataBaseDataSet.DataSetName = "DataBaseDataSet";
            this.dataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // servicoTableAdapter
            // 
            this.servicoTableAdapter.ClearBeforeFill = true;
            // 
            // btConfirma
            // 
            this.btConfirma.Location = new System.Drawing.Point(743, 513);
            this.btConfirma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btConfirma.Name = "btConfirma";
            this.btConfirma.Size = new System.Drawing.Size(91, 46);
            this.btConfirma.TabIndex = 1;
            this.btConfirma.Text = "Confirmar";
            this.btConfirma.UseVisualStyleBackColor = true;
            // 
            // btCancela
            // 
            this.btCancela.Location = new System.Drawing.Point(603, 513);
            this.btCancela.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCancela.Name = "btCancela";
            this.btCancela.Size = new System.Drawing.Size(91, 46);
            this.btCancela.TabIndex = 6;
            this.btCancela.Text = "Cancelar";
            this.btCancela.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Produto";
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(140, 73);
            this.txtDesconto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(100, 22);
            this.txtDesconto.TabIndex = 9;
            this.txtDesconto.Text = "0";
            this.txtDesconto.TextChanged += new System.EventHandler(this.txtDesconto_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(670, 486);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Subtotal";
            // 
            // numQuantidade
            // 
            this.numQuantidade.Location = new System.Drawing.Point(381, 68);
            this.numQuantidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numQuantidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantidade.Name = "numQuantidade";
            this.numQuantidade.Size = new System.Drawing.Size(67, 22);
            this.numQuantidade.TabIndex = 14;
            this.numQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantidade.ValueChanged += new System.EventHandler(this.numQuantidade_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Quantidade";
            // 
            // rbtPercentil
            // 
            this.rbtPercentil.AutoSize = true;
            this.rbtPercentil.Location = new System.Drawing.Point(3, 2);
            this.rbtPercentil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtPercentil.Name = "rbtPercentil";
            this.rbtPercentil.Size = new System.Drawing.Size(80, 20);
            this.rbtPercentil.TabIndex = 10;
            this.rbtPercentil.Text = "Percentil";
            this.rbtPercentil.UseVisualStyleBackColor = true;
            this.rbtPercentil.CheckedChanged += new System.EventHandler(this.rbtPercentil_CheckedChanged);
            // 
            // rbtValorAbsoluto
            // 
            this.rbtValorAbsoluto.AutoSize = true;
            this.rbtValorAbsoluto.Checked = true;
            this.rbtValorAbsoluto.Location = new System.Drawing.Point(111, 2);
            this.rbtValorAbsoluto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtValorAbsoluto.Name = "rbtValorAbsoluto";
            this.rbtValorAbsoluto.Size = new System.Drawing.Size(115, 20);
            this.rbtValorAbsoluto.TabIndex = 11;
            this.rbtValorAbsoluto.TabStop = true;
            this.rbtValorAbsoluto.Tag = "ra";
            this.rbtValorAbsoluto.Text = "Valor absoluto";
            this.rbtValorAbsoluto.UseVisualStyleBackColor = true;
            // 
            // gpDesconto
            // 
            this.gpDesconto.Controls.Add(this.panel1);
            this.gpDesconto.Controls.Add(this.lblValor);
            this.gpDesconto.Controls.Add(this.txtDesconto);
            this.gpDesconto.Location = new System.Drawing.Point(45, 336);
            this.gpDesconto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpDesconto.Name = "gpDesconto";
            this.gpDesconto.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpDesconto.Size = new System.Drawing.Size(256, 110);
            this.gpDesconto.TabIndex = 17;
            this.gpDesconto.TabStop = false;
            this.gpDesconto.Text = "Desconto";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtValorAbsoluto);
            this.panel1.Controls.Add(this.rbtPercentil);
            this.panel1.Location = new System.Drawing.Point(5, 21);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 28);
            this.panel1.TabIndex = 18;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(95, 76);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(39, 16);
            this.lblValor.TabIndex = 12;
            this.lblValor.Text = "Valor";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(733, 483);
            this.txtSubtotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 22);
            this.txtSubtotal.TabIndex = 11;
            // 
            // cbxFormaPagamento
            // 
            this.cbxFormaPagamento.FormattingEnabled = true;
            this.cbxFormaPagamento.Items.AddRange(new object[] {
            "PIX - À VISTA",
            "BOLETO - À VISTA",
            "CARTÃO DÉBITO - À VISTA",
            "CARTÃO CRÉDITO - À VISTA",
            "CARTÃO CRÉDITO - PARCELADO"});
            this.cbxFormaPagamento.Location = new System.Drawing.Point(538, 22);
            this.cbxFormaPagamento.Name = "cbxFormaPagamento";
            this.cbxFormaPagamento.Size = new System.Drawing.Size(296, 24);
            this.cbxFormaPagamento.TabIndex = 18;
            this.cbxFormaPagamento.SelectedIndexChanged += new System.EventHandler(this.cbxFormaPagamento_SelectedIndexChanged);
            // 
            // cbxParcelas
            // 
            this.cbxParcelas.FormattingEnabled = true;
            this.cbxParcelas.Location = new System.Drawing.Point(6, 21);
            this.cbxParcelas.Name = "cbxParcelas";
            this.cbxParcelas.Size = new System.Drawing.Size(295, 24);
            this.cbxParcelas.TabIndex = 19;
            this.cbxParcelas.SelectedIndexChanged += new System.EventHandler(this.cbxParcelas_SelectedIndexChanged);
            // 
            // gbxParcelas
            // 
            this.gbxParcelas.Controls.Add(this.cbxParcelas);
            this.gbxParcelas.Location = new System.Drawing.Point(538, 140);
            this.gbxParcelas.Name = "gbxParcelas";
            this.gbxParcelas.Size = new System.Drawing.Size(309, 100);
            this.gbxParcelas.TabIndex = 20;
            this.gbxParcelas.TabStop = false;
            this.gbxParcelas.Text = "Parcelas";
            this.gbxParcelas.Visible = false;
            // 
            // Compra2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 587);
            this.Controls.Add(this.gbxParcelas);
            this.Controls.Add(this.cbxFormaPagamento);
            this.Controls.Add(this.gpDesconto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numQuantidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCancela);
            this.Controls.Add(this.btConfirma);
            this.Controls.Add(this.cbxProduto);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Compra2";
            this.Text = "Compra";
            this.Load += new System.EventHandler(this.Compra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).EndInit();
            this.gpDesconto.ResumeLayout(false);
            this.gpDesconto.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbxParcelas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxProduto;
        private DataBaseDataSet dataBaseDataSet;
        private System.Windows.Forms.BindingSource servicoBindingSource;
        private DataBaseDataSetTableAdapters.ServicoTableAdapter servicoTableAdapter;
        private System.Windows.Forms.Button btConfirma;
        private System.Windows.Forms.Button btCancela;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numQuantidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbtValorAbsoluto;
        private System.Windows.Forms.RadioButton rbtPercentil;
        private System.Windows.Forms.GroupBox gpDesconto;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.ComboBox cbxFormaPagamento;
        private System.Windows.Forms.ComboBox cbxParcelas;
        private System.Windows.Forms.GroupBox gbxParcelas;
    }
}