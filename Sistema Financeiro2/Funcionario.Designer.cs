namespace Sistema_Financeiro
{
    partial class Funcionario
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
            System.Windows.Forms.Label dataCadastroLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label dataNascimentoLabel;
            System.Windows.Forms.Label cPFLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label generoLabel;
            System.Windows.Forms.Label numeroCarteiraTrabalhoLabel;
            this.dataBaseDataSet = new Sistema_Financeiro.DataBaseDataSet();
            this.funcionarioTableAdapter = new Sistema_Financeiro.DataBaseDataSetTableAdapters.FuncionarioTableAdapter();
            this.tableAdapterManager = new Sistema_Financeiro.DataBaseDataSetTableAdapters.TableAdapterManager();
            this.panel1 = new System.Windows.Forms.Panel();
            this.telefoneTextBox = new System.Windows.Forms.MaskedTextBox();
            this.numeroCarteiraTrabalhoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.generoComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.enderecoLabel = new System.Windows.Forms.Label();
            this.cPFTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cEPTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cidadeTextBox = new System.Windows.Forms.TextBox();
            this.complementoTextBox = new System.Windows.Forms.TextBox();
            this.bairroTextBox = new System.Windows.Forms.TextBox();
            this.numeroTextBox = new System.Windows.Forms.TextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btSalvarFuncionario = new System.Windows.Forms.Button();
            this.dataCadastroDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataNascimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.funcionarioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pesquisaComboBox = new System.Windows.Forms.ComboBox();
            this.pesquisaTextBox = new System.Windows.Forms.TextBox();
            this.paneTable = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            dataCadastroLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            dataNascimentoLabel = new System.Windows.Forms.Label();
            cPFLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            generoLabel = new System.Windows.Forms.Label();
            numeroCarteiraTrabalhoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.paneTable.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataCadastroLabel
            // 
            dataCadastroLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataCadastroLabel.AutoSize = true;
            dataCadastroLabel.Location = new System.Drawing.Point(32, 358);
            dataCadastroLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dataCadastroLabel.Name = "dataCadastroLabel";
            dataCadastroLabel.Size = new System.Drawing.Size(97, 16);
            dataCadastroLabel.TabIndex = 15;
            dataCadastroLabel.Text = "Data Cadastro:";
            // 
            // nomeLabel
            // 
            nomeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(25, 73);
            nomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(44, 16);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "Nome";
            // 
            // dataNascimentoLabel
            // 
            dataNascimentoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataNascimentoLabel.AutoSize = true;
            dataNascimentoLabel.Location = new System.Drawing.Point(309, 137);
            dataNascimentoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dataNascimentoLabel.Name = "dataNascimentoLabel";
            dataNascimentoLabel.Size = new System.Drawing.Size(111, 16);
            dataNascimentoLabel.TabIndex = 13;
            dataNascimentoLabel.Text = "Data Nascimento";
            // 
            // cPFLabel
            // 
            cPFLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            cPFLabel.AutoSize = true;
            cPFLabel.Location = new System.Drawing.Point(25, 105);
            cPFLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new System.Drawing.Size(33, 16);
            cPFLabel.TabIndex = 5;
            cPFLabel.Text = "CPF";
            // 
            // telefoneLabel
            // 
            telefoneLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(25, 137);
            telefoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(61, 16);
            telefoneLabel.TabIndex = 11;
            telefoneLabel.Text = "Telefone";
            // 
            // generoLabel
            // 
            generoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            generoLabel.AutoSize = true;
            generoLabel.Location = new System.Drawing.Point(348, 105);
            generoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            generoLabel.Name = "generoLabel";
            generoLabel.Size = new System.Drawing.Size(52, 16);
            generoLabel.TabIndex = 7;
            generoLabel.Text = "Genero";
            // 
            // numeroCarteiraTrabalhoLabel
            // 
            numeroCarteiraTrabalhoLabel.AutoSize = true;
            numeroCarteiraTrabalhoLabel.Location = new System.Drawing.Point(293, 169);
            numeroCarteiraTrabalhoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            numeroCarteiraTrabalhoLabel.Name = "numeroCarteiraTrabalhoLabel";
            numeroCarteiraTrabalhoLabel.Size = new System.Drawing.Size(163, 16);
            numeroCarteiraTrabalhoLabel.TabIndex = 31;
            numeroCarteiraTrabalhoLabel.Text = "Numero Carteira Trabalho";
            // 
            // dataBaseDataSet
            // 
            this.dataBaseDataSet.DataSetName = "DataBaseDataSet";
            this.dataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // funcionarioTableAdapter
            // 
            this.funcionarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteServicoEscolhidoTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.DebitoTableAdapter = null;
            this.tableAdapterManager.DescricaoTableAdapter = null;
            this.tableAdapterManager.FuncionarioTableAdapter = this.funcionarioTableAdapter;
            this.tableAdapterManager.OrcamentoTableAdapter = null;
            this.tableAdapterManager.OrdemDeServicoTableAdapter = null;
            this.tableAdapterManager.PagamentoTableAdapter = null;
            this.tableAdapterManager.ServicoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Sistema_Financeiro.DataBaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(numeroCarteiraTrabalhoLabel);
            this.panel1.Controls.Add(this.telefoneTextBox);
            this.panel1.Controls.Add(this.numeroCarteiraTrabalhoMaskedTextBox);
            this.panel1.Controls.Add(this.generoComboBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.enderecoLabel);
            this.panel1.Controls.Add(this.cPFTextBox);
            this.panel1.Controls.Add(this.cEPTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cidadeTextBox);
            this.panel1.Controls.Add(this.complementoTextBox);
            this.panel1.Controls.Add(this.bairroTextBox);
            this.panel1.Controls.Add(this.numeroTextBox);
            this.panel1.Controls.Add(this.enderecoTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btSalvarFuncionario);
            this.panel1.Controls.Add(this.dataCadastroDateTimePicker);
            this.panel1.Controls.Add(dataCadastroLabel);
            this.panel1.Controls.Add(nomeLabel);
            this.panel1.Controls.Add(this.dataNascimentoDateTimePicker);
            this.panel1.Controls.Add(this.nomeTextBox);
            this.panel1.Controls.Add(dataNascimentoLabel);
            this.panel1.Controls.Add(cPFLabel);
            this.panel1.Controls.Add(telefoneLabel);
            this.panel1.Controls.Add(generoLabel);
            this.panel1.Location = new System.Drawing.Point(5, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 495);
            this.panel1.TabIndex = 19;
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.Location = new System.Drawing.Point(99, 133);
            this.telefoneTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.telefoneTextBox.Mask = "(00)00000-0000";
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(192, 22);
            this.telefoneTextBox.TabIndex = 7;
            // 
            // numeroCarteiraTrabalhoMaskedTextBox
            // 
            this.numeroCarteiraTrabalhoMaskedTextBox.Location = new System.Drawing.Point(476, 165);
            this.numeroCarteiraTrabalhoMaskedTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numeroCarteiraTrabalhoMaskedTextBox.Mask = "0000000\\/0000";
            this.numeroCarteiraTrabalhoMaskedTextBox.Name = "numeroCarteiraTrabalhoMaskedTextBox";
            this.numeroCarteiraTrabalhoMaskedTextBox.Size = new System.Drawing.Size(136, 22);
            this.numeroCarteiraTrabalhoMaskedTextBox.TabIndex = 8;
            // 
            // generoComboBox
            // 
            this.generoComboBox.DisplayMember = "Masculino";
            this.generoComboBox.FormattingEnabled = true;
            this.generoComboBox.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outro",
            "Prefiro não dizer"});
            this.generoComboBox.Location = new System.Drawing.Point(412, 102);
            this.generoComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.generoComboBox.Name = "generoComboBox";
            this.generoComboBox.Size = new System.Drawing.Size(200, 24);
            this.generoComboBox.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(333, 267);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 16);
            this.label8.TabIndex = 31;
            this.label8.Text = "Complemento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 267);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "Cidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(383, 235);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "Bairro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 235);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Nº";
            // 
            // enderecoLabel
            // 
            this.enderecoLabel.AutoSize = true;
            this.enderecoLabel.Location = new System.Drawing.Point(25, 235);
            this.enderecoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.enderecoLabel.Name = "enderecoLabel";
            this.enderecoLabel.Size = new System.Drawing.Size(66, 16);
            this.enderecoLabel.TabIndex = 27;
            this.enderecoLabel.Text = "Endereco";
            // 
            // cPFTextBox
            // 
            this.cPFTextBox.Location = new System.Drawing.Point(99, 101);
            this.cPFTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cPFTextBox.Mask = "000\\.000\\.000-00";
            this.cPFTextBox.Name = "cPFTextBox";
            this.cPFTextBox.Size = new System.Drawing.Size(227, 22);
            this.cPFTextBox.TabIndex = 5;
            // 
            // cEPTextBox
            // 
            this.cEPTextBox.Location = new System.Drawing.Point(99, 199);
            this.cEPTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cEPTextBox.Mask = "00000-000";
            this.cEPTextBox.Name = "cEPTextBox";
            this.cEPTextBox.Size = new System.Drawing.Size(111, 22);
            this.cEPTextBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 203);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "CEP";
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cidadeTextBox.Location = new System.Drawing.Point(99, 263);
            this.cidadeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(216, 22);
            this.cidadeTextBox.TabIndex = 13;
            // 
            // complementoTextBox
            // 
            this.complementoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.complementoTextBox.Location = new System.Drawing.Point(436, 263);
            this.complementoTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.complementoTextBox.Name = "complementoTextBox";
            this.complementoTextBox.Size = new System.Drawing.Size(176, 22);
            this.complementoTextBox.TabIndex = 14;
            // 
            // bairroTextBox
            // 
            this.bairroTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bairroTextBox.Location = new System.Drawing.Point(436, 231);
            this.bairroTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bairroTextBox.Name = "bairroTextBox";
            this.bairroTextBox.Size = new System.Drawing.Size(176, 22);
            this.bairroTextBox.TabIndex = 12;
            // 
            // numeroTextBox
            // 
            this.numeroTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numeroTextBox.Location = new System.Drawing.Point(303, 231);
            this.numeroTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numeroTextBox.Name = "numeroTextBox";
            this.numeroTextBox.Size = new System.Drawing.Size(57, 22);
            this.numeroTextBox.TabIndex = 11;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.enderecoTextBox.Location = new System.Drawing.Point(99, 231);
            this.enderecoTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(149, 22);
            this.enderecoTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 46);
            this.label1.TabIndex = 18;
            this.label1.Text = "Cadastro ";
            // 
            // btSalvarFuncionario
            // 
            this.btSalvarFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSalvarFuncionario.Location = new System.Drawing.Point(481, 446);
            this.btSalvarFuncionario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSalvarFuncionario.Name = "btSalvarFuncionario";
            this.btSalvarFuncionario.Size = new System.Drawing.Size(132, 28);
            this.btSalvarFuncionario.TabIndex = 15;
            this.btSalvarFuncionario.Text = "Salvar";
            this.btSalvarFuncionario.UseVisualStyleBackColor = true;
            this.btSalvarFuncionario.Click += new System.EventHandler(this.btSalvarFuncionario_Click);
            // 
            // dataCadastroDateTimePicker
            // 
            this.dataCadastroDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataCadastroDateTimePicker.Location = new System.Drawing.Point(144, 358);
            this.dataCadastroDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataCadastroDateTimePicker.Name = "dataCadastroDateTimePicker";
            this.dataCadastroDateTimePicker.Size = new System.Drawing.Size(468, 22);
            this.dataCadastroDateTimePicker.TabIndex = 16;
            // 
            // dataNascimentoDateTimePicker
            // 
            this.dataNascimentoDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataNascimentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataNascimentoDateTimePicker.Location = new System.Drawing.Point(436, 133);
            this.dataNascimentoDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataNascimentoDateTimePicker.MaxDate = new System.DateTime(2024, 5, 9, 20, 24, 6, 0);
            this.dataNascimentoDateTimePicker.Name = "dataNascimentoDateTimePicker";
            this.dataNascimentoDateTimePicker.Size = new System.Drawing.Size(176, 22);
            this.dataNascimentoDateTimePicker.TabIndex = 8;
            this.dataNascimentoDateTimePicker.Value = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nomeTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.nomeTextBox.Location = new System.Drawing.Point(99, 69);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(513, 22);
            this.nomeTextBox.TabIndex = 4;
            // 
            // funcionarioDataGridView
            // 
            this.funcionarioDataGridView.AutoGenerateColumns = false;
            this.funcionarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.funcionarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.funcionarioDataGridView.DataSource = this.funcionarioBindingSource;
            this.funcionarioDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.funcionarioDataGridView.Location = new System.Drawing.Point(0, 0);
            this.funcionarioDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.funcionarioDataGridView.Name = "funcionarioDataGridView";
            this.funcionarioDataGridView.RowHeadersWidth = 51;
            this.funcionarioDataGridView.Size = new System.Drawing.Size(1289, 921);
            this.funcionarioDataGridView.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CPF";
            this.dataGridViewTextBoxColumn2.HeaderText = "CPF";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Genero";
            this.dataGridViewTextBoxColumn4.HeaderText = "Genero";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Endereco";
            this.dataGridViewTextBoxColumn5.HeaderText = "Endereco";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Telefone";
            this.dataGridViewTextBoxColumn6.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "DataNascimento";
            this.dataGridViewTextBoxColumn7.HeaderText = "DataNascimento";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "NumeroCarteiraTrabalho";
            this.dataGridViewTextBoxColumn8.HeaderText = "NumeroCarteiraTrabalho";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "DataCadastro";
            this.dataGridViewTextBoxColumn9.HeaderText = "DataCadastro";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataMember = "Funcionario";
            this.funcionarioBindingSource.DataSource = this.dataBaseDataSet;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.AutoScroll = true;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.pesquisaComboBox);
            this.panel3.Controls.Add(this.pesquisaTextBox);
            this.panel3.Location = new System.Drawing.Point(5, 507);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(651, 414);
            this.panel3.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 21;
            this.label4.Text = "Categoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 46);
            this.label3.TabIndex = 19;
            this.label3.Text = "Pesquisa";
            // 
            // pesquisaComboBox
            // 
            this.pesquisaComboBox.FormattingEnabled = true;
            this.pesquisaComboBox.Items.AddRange(new object[] {
            "Nome",
            "CPF",
            "Genero",
            "Endereco",
            "Telefone",
            "NumeroCarteiraTrabalho",
            "DataNascimento",
            "DataCadastro"});
            this.pesquisaComboBox.Location = new System.Drawing.Point(144, 84);
            this.pesquisaComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pesquisaComboBox.Name = "pesquisaComboBox";
            this.pesquisaComboBox.Size = new System.Drawing.Size(463, 24);
            this.pesquisaComboBox.TabIndex = 20;
            this.pesquisaComboBox.Text = "Selecione uma categoria para filtrar";
            // 
            // pesquisaTextBox
            // 
            this.pesquisaTextBox.Location = new System.Drawing.Point(44, 117);
            this.pesquisaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pesquisaTextBox.Name = "pesquisaTextBox";
            this.pesquisaTextBox.Size = new System.Drawing.Size(563, 22);
            this.pesquisaTextBox.TabIndex = 19;
            this.pesquisaTextBox.TextChanged += new System.EventHandler(this.pesquisaTextBox_TextChanged);
            // 
            // paneTable
            // 
            this.paneTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paneTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.paneTable.Controls.Add(this.funcionarioDataGridView);
            this.paneTable.Location = new System.Drawing.Point(676, 15);
            this.paneTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.paneTable.Name = "paneTable";
            this.paneTable.Size = new System.Drawing.Size(1293, 925);
            this.paneTable.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(7, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(661, 926);
            this.panel2.TabIndex = 20;
            // 
            // Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1924, 955);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.paneTable);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Funcionario";
            this.Text = "Gerenciamento Funcionários";
            this.Load += new System.EventHandler(this.Funcionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.paneTable.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataBaseDataSet dataBaseDataSet;
        private DataBaseDataSetTableAdapters.FuncionarioTableAdapter funcionarioTableAdapter;
        private DataBaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox telefoneTextBox;
        private System.Windows.Forms.ComboBox generoComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label enderecoLabel;
        private System.Windows.Forms.MaskedTextBox cPFTextBox;
        private System.Windows.Forms.MaskedTextBox cEPTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cidadeTextBox;
        private System.Windows.Forms.TextBox complementoTextBox;
        private System.Windows.Forms.TextBox bairroTextBox;
        private System.Windows.Forms.TextBox numeroTextBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSalvarFuncionario;
        private System.Windows.Forms.DateTimePicker dataCadastroDateTimePicker;
        private System.Windows.Forms.DateTimePicker dataNascimentoDateTimePicker;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.DataGridView funcionarioDataGridView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox pesquisaComboBox;
        private System.Windows.Forms.TextBox pesquisaTextBox;
        private System.Windows.Forms.MaskedTextBox numeroCarteiraTrabalhoMaskedTextBox;
        private System.Windows.Forms.Panel paneTable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
    }
}