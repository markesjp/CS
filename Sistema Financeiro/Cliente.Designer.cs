namespace Sistema_Financeiro
{
    partial class Cliente
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label cPFLabel;
            System.Windows.Forms.Label generoLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label dataNascimentoLabel;
            System.Windows.Forms.Label dataCadastroLabel;
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseDataSet = new Sistema_Financeiro.DataBaseDataSet();
            this.dataNascimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataCadastroDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btSalvarCliente = new System.Windows.Forms.Button();
            this.clienteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.telefoneTextBox = new System.Windows.Forms.MaskedTextBox();
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pesquisaClienteComboBox = new System.Windows.Forms.ComboBox();
            this.pesquisaClienteTextBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.clienteTableAdapter = new Sistema_Financeiro.DataBaseDataSetTableAdapters.ClienteTableAdapter();
            this.tableAdapterManager = new Sistema_Financeiro.DataBaseDataSetTableAdapters.TableAdapterManager();
            this.dataBaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descricaoTableAdapter = new Sistema_Financeiro.DataBaseDataSetTableAdapters.DescricaoTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            nomeLabel = new System.Windows.Forms.Label();
            cPFLabel = new System.Windows.Forms.Label();
            generoLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            dataNascimentoLabel = new System.Windows.Forms.Label();
            dataCadastroLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSetBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(19, 59);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(35, 13);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "Nome";
            // 
            // cPFLabel
            // 
            cPFLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            cPFLabel.AutoSize = true;
            cPFLabel.Location = new System.Drawing.Point(19, 85);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new System.Drawing.Size(27, 13);
            cPFLabel.TabIndex = 5;
            cPFLabel.Text = "CPF";
            // 
            // generoLabel
            // 
            generoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            generoLabel.AutoSize = true;
            generoLabel.Location = new System.Drawing.Point(260, 85);
            generoLabel.Name = "generoLabel";
            generoLabel.Size = new System.Drawing.Size(42, 13);
            generoLabel.TabIndex = 7;
            generoLabel.Text = "Genero";
            // 
            // telefoneLabel
            // 
            telefoneLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(19, 111);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(49, 13);
            telefoneLabel.TabIndex = 11;
            telefoneLabel.Text = "Telefone";
            // 
            // dataNascimentoLabel
            // 
            dataNascimentoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataNascimentoLabel.AutoSize = true;
            dataNascimentoLabel.Location = new System.Drawing.Point(225, 111);
            dataNascimentoLabel.Name = "dataNascimentoLabel";
            dataNascimentoLabel.Size = new System.Drawing.Size(92, 13);
            dataNascimentoLabel.TabIndex = 13;
            dataNascimentoLabel.Text = "Data Nascimento:";
            // 
            // dataCadastroLabel
            // 
            dataCadastroLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataCadastroLabel.AutoSize = true;
            dataCadastroLabel.Location = new System.Drawing.Point(24, 291);
            dataCadastroLabel.Name = "dataCadastroLabel";
            dataCadastroLabel.Size = new System.Drawing.Size(78, 13);
            dataCadastroLabel.TabIndex = 15;
            dataCadastroLabel.Text = "Data Cadastro:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nomeTextBox.Location = new System.Drawing.Point(74, 56);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(382, 20);
            this.nomeTextBox.TabIndex = 4;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.dataBaseDataSet;
            // 
            // dataBaseDataSet
            // 
            this.dataBaseDataSet.DataSetName = "DataBaseDataSet";
            this.dataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataNascimentoDateTimePicker
            // 
            this.dataNascimentoDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataNascimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clienteBindingSource, "DataNascimento", true));
            this.dataNascimentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataNascimentoDateTimePicker.Location = new System.Drawing.Point(327, 108);
            this.dataNascimentoDateTimePicker.MaxDate = new System.DateTime(2024, 5, 9, 20, 24, 6, 0);
            this.dataNascimentoDateTimePicker.Name = "dataNascimentoDateTimePicker";
            this.dataNascimentoDateTimePicker.Size = new System.Drawing.Size(129, 20);
            this.dataNascimentoDateTimePicker.TabIndex = 8;
            this.dataNascimentoDateTimePicker.Value = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            // 
            // dataCadastroDateTimePicker
            // 
            this.dataCadastroDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataCadastroDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clienteBindingSource, "DataCadastro", true));
            this.dataCadastroDateTimePicker.Location = new System.Drawing.Point(108, 291);
            this.dataCadastroDateTimePicker.Name = "dataCadastroDateTimePicker";
            this.dataCadastroDateTimePicker.Size = new System.Drawing.Size(229, 20);
            this.dataCadastroDateTimePicker.TabIndex = 16;
            // 
            // btSalvarCliente
            // 
            this.btSalvarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSalvarCliente.Location = new System.Drawing.Point(357, 356);
            this.btSalvarCliente.Name = "btSalvarCliente";
            this.btSalvarCliente.Size = new System.Drawing.Size(99, 23);
            this.btSalvarCliente.TabIndex = 15;
            this.btSalvarCliente.Text = "Salvar";
            this.btSalvarCliente.UseVisualStyleBackColor = true;
            this.btSalvarCliente.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // clienteDataGridView
            // 
            this.clienteDataGridView.AllowUserToAddRows = false;
            this.clienteDataGridView.AllowUserToOrderColumns = true;
            this.clienteDataGridView.AutoGenerateColumns = false;
            this.clienteDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.clienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.clienteDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clienteDataGridView.DataSource = this.clienteBindingSource;
            this.clienteDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clienteDataGridView.Location = new System.Drawing.Point(0, 0);
            this.clienteDataGridView.Name = "clienteDataGridView";
            this.clienteDataGridView.ReadOnly = true;
            this.clienteDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.clienteDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.clienteDataGridView.Size = new System.Drawing.Size(844, 686);
            this.clienteDataGridView.TabIndex = 17;
            this.clienteDataGridView.VirtualMode = true;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CPF";
            this.dataGridViewTextBoxColumn3.HeaderText = "CPF";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Genero";
            this.dataGridViewTextBoxColumn4.HeaderText = "Genero";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Endereco";
            this.dataGridViewTextBoxColumn5.HeaderText = "Endereco";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Telefone";
            this.dataGridViewTextBoxColumn6.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "DataNascimento";
            this.dataGridViewTextBoxColumn7.HeaderText = "DataNascimento";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "DataCadastro";
            this.dataGridViewTextBoxColumn8.HeaderText = "DataCadastro";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.telefoneTextBox);
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
            this.panel1.Controls.Add(this.btSalvarCliente);
            this.panel1.Controls.Add(this.dataCadastroDateTimePicker);
            this.panel1.Controls.Add(dataCadastroLabel);
            this.panel1.Controls.Add(nomeLabel);
            this.panel1.Controls.Add(this.dataNascimentoDateTimePicker);
            this.panel1.Controls.Add(this.nomeTextBox);
            this.panel1.Controls.Add(dataNascimentoLabel);
            this.panel1.Controls.Add(cPFLabel);
            this.panel1.Controls.Add(telefoneLabel);
            this.panel1.Controls.Add(generoLabel);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 397);
            this.panel1.TabIndex = 18;
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.Location = new System.Drawing.Point(74, 108);
            this.telefoneTextBox.Mask = "(00)00000-0000";
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(145, 20);
            this.telefoneTextBox.TabIndex = 7;
            // 
            // generoComboBox
            // 
            this.generoComboBox.FormattingEnabled = true;
            this.generoComboBox.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outro",
            "Prefiro não dizer"});
            this.generoComboBox.Location = new System.Drawing.Point(309, 83);
            this.generoComboBox.Name = "generoComboBox";
            this.generoComboBox.Size = new System.Drawing.Size(147, 21);
            this.generoComboBox.TabIndex = 6;
            this.generoComboBox.Tag = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(250, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Complemento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Cidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(287, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Bairro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Nº";
            // 
            // enderecoLabel
            // 
            this.enderecoLabel.AutoSize = true;
            this.enderecoLabel.Location = new System.Drawing.Point(19, 163);
            this.enderecoLabel.Name = "enderecoLabel";
            this.enderecoLabel.Size = new System.Drawing.Size(53, 13);
            this.enderecoLabel.TabIndex = 27;
            this.enderecoLabel.Text = "Endereco";
            // 
            // cPFTextBox
            // 
            this.cPFTextBox.Location = new System.Drawing.Point(74, 82);
            this.cPFTextBox.Mask = "000\\.000\\.000-00";
            this.cPFTextBox.Name = "cPFTextBox";
            this.cPFTextBox.Size = new System.Drawing.Size(171, 20);
            this.cPFTextBox.TabIndex = 5;
            // 
            // cEPTextBox
            // 
            this.cEPTextBox.Location = new System.Drawing.Point(74, 134);
            this.cEPTextBox.Mask = "00000-000";
            this.cEPTextBox.Name = "cEPTextBox";
            this.cEPTextBox.Size = new System.Drawing.Size(84, 20);
            this.cEPTextBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "CEP";
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cidadeTextBox.Location = new System.Drawing.Point(74, 186);
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(159, 20);
            this.cidadeTextBox.TabIndex = 13;
            // 
            // complementoTextBox
            // 
            this.complementoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.complementoTextBox.Location = new System.Drawing.Point(327, 186);
            this.complementoTextBox.Name = "complementoTextBox";
            this.complementoTextBox.Size = new System.Drawing.Size(129, 20);
            this.complementoTextBox.TabIndex = 14;
            // 
            // bairroTextBox
            // 
            this.bairroTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bairroTextBox.Location = new System.Drawing.Point(327, 160);
            this.bairroTextBox.Name = "bairroTextBox";
            this.bairroTextBox.Size = new System.Drawing.Size(129, 20);
            this.bairroTextBox.TabIndex = 12;
            // 
            // numeroTextBox
            // 
            this.numeroTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numeroTextBox.Location = new System.Drawing.Point(227, 160);
            this.numeroTextBox.Name = "numeroTextBox";
            this.numeroTextBox.Size = new System.Drawing.Size(40, 20);
            this.numeroTextBox.TabIndex = 11;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.enderecoTextBox.Location = new System.Drawing.Point(74, 160);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(109, 20);
            this.enderecoTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 37);
            this.label1.TabIndex = 18;
            this.label1.Text = "Cadastro ";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.pesquisaClienteComboBox);
            this.panel3.Controls.Add(this.pesquisaClienteTextBox);
            this.panel3.Location = new System.Drawing.Point(3, 406);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(485, 321);
            this.panel3.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "Categoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 37);
            this.label3.TabIndex = 19;
            this.label3.Text = "Pesquisa";
            // 
            // pesquisaClienteComboBox
            // 
            this.pesquisaClienteComboBox.FormattingEnabled = true;
            this.pesquisaClienteComboBox.Items.AddRange(new object[] {
            "Nome",
            "CPF",
            "Genero",
            "Endereco",
            "Telefone",
            "DataNascimento",
            "DataCadastro"});
            this.pesquisaClienteComboBox.Location = new System.Drawing.Point(108, 68);
            this.pesquisaClienteComboBox.Name = "pesquisaClienteComboBox";
            this.pesquisaClienteComboBox.Size = new System.Drawing.Size(348, 21);
            this.pesquisaClienteComboBox.TabIndex = 20;
            this.pesquisaClienteComboBox.Text = "Selecione uma categoria para filtrar";
            this.pesquisaClienteComboBox.SelectedIndexChanged += new System.EventHandler(this.pesquisaClienteComboBox_SelectedIndexChanged);
            // 
            // pesquisaClienteTextBox
            // 
            this.pesquisaClienteTextBox.Location = new System.Drawing.Point(33, 95);
            this.pesquisaClienteTextBox.Name = "pesquisaClienteTextBox";
            this.pesquisaClienteTextBox.Size = new System.Drawing.Size(423, 20);
            this.pesquisaClienteTextBox.TabIndex = 19;
            this.pesquisaClienteTextBox.TextChanged += new System.EventHandler(this.pesquisaClienteTextBox_TextChanged);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.clienteDataGridView);
            this.panel4.Location = new System.Drawing.Point(503, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(848, 690);
            this.panel4.TabIndex = 22;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = this.clienteTableAdapter;
            this.tableAdapterManager.DescricaoTableAdapter = null;
            this.tableAdapterManager.FuncionarioTableAdapter = null;
            this.tableAdapterManager.ServicoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Sistema_Financeiro.DataBaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataBaseDataSetBindingSource
            // 
            this.dataBaseDataSetBindingSource.DataSource = this.dataBaseDataSet;
            this.dataBaseDataSetBindingSource.Position = 0;
            // 
            // descricaoTableAdapter
            // 
            this.descricaoTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(5, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(492, 690);
            this.panel2.TabIndex = 18;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1385, 768);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Name = "Cliente";
            this.Text = "Gerenciamento Clientes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSetBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataBaseDataSet dataBaseDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private DataBaseDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private DataBaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.DateTimePicker dataNascimentoDateTimePicker;
        private System.Windows.Forms.DateTimePicker dataCadastroDateTimePicker;
        private System.Windows.Forms.Button btSalvarCliente;
        private System.Windows.Forms.DataGridView clienteDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.BindingSource dataBaseDataSetBindingSource;
        private System.Windows.Forms.Panel panel1;
        private DataBaseDataSetTableAdapters.DescricaoTableAdapter descricaoTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox pesquisaClienteComboBox;
        private System.Windows.Forms.TextBox pesquisaClienteTextBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox cidadeTextBox;
        private System.Windows.Forms.TextBox complementoTextBox;
        private System.Windows.Forms.TextBox bairroTextBox;
        private System.Windows.Forms.TextBox numeroTextBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.MaskedTextBox cEPTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label enderecoLabel;
        private System.Windows.Forms.MaskedTextBox cPFTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox generoComboBox;
        private System.Windows.Forms.MaskedTextBox telefoneTextBox;
        private System.Windows.Forms.Panel panel2;
    }
}

