using System;

namespace Sistema_Financeiro
{
    partial class Menu
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
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btCompra = new System.Windows.Forms.Button();
            this.btPagar = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.dataGridViewMenu = new System.Windows.Forms.DataGridView();
            this.dataBaseDataSet = new Sistema_Financeiro.DataBaseDataSet();
            this.ordemDeServicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordemDeServicoTableAdapter = new Sistema_Financeiro.DataBaseDataSetTableAdapters.OrdemDeServicoTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCriacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel2.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordemDeServicoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel2.Controls.Add(this.button1);
            this.flowLayoutPanel2.Controls.Add(this.button2);
            this.flowLayoutPanel2.Controls.Add(this.button3);
            this.flowLayoutPanel2.Controls.Add(this.button4);
            this.flowLayoutPanel2.Controls.Add(this.button5);
            this.flowLayoutPanel2.Controls.Add(this.button6);
            this.flowLayoutPanel2.Controls.Add(this.btCompra);
            this.flowLayoutPanel2.Controls.Add(this.btPagar);
            this.flowLayoutPanel2.Controls.Add(this.button9);
            this.flowLayoutPanel2.Controls.Add(this.button10);
            this.flowLayoutPanel2.Controls.Add(this.button11);
            this.flowLayoutPanel2.Controls.Add(this.button12);
            this.flowLayoutPanel2.Controls.Add(this.button13);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(31, 78);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(380, 746);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Image = global::Sistema_Financeiro.Properties.Resources.home_263115;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(4, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(376, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cliente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(4, 51);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(376, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "Serviços";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(4, 98);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(376, 39);
            this.button3.TabIndex = 2;
            this.button3.Text = "Funcionarios";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(4, 145);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(376, 39);
            this.button4.TabIndex = 3;
            this.button4.Text = "Todas as Parcelas";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(4, 192);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(376, 39);
            this.button5.TabIndex = 4;
            this.button5.Text = "Parcelas atrasadas";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(4, 239);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(376, 39);
            this.button6.TabIndex = 5;
            this.button6.Text = "Inadimplente";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btCompra
            // 
            this.btCompra.Location = new System.Drawing.Point(4, 286);
            this.btCompra.Margin = new System.Windows.Forms.Padding(4);
            this.btCompra.Name = "btCompra";
            this.btCompra.Size = new System.Drawing.Size(376, 39);
            this.btCompra.TabIndex = 6;
            this.btCompra.Text = "Compra";
            this.btCompra.UseVisualStyleBackColor = true;
            this.btCompra.Click += new System.EventHandler(this.btCompra_Click);
            // 
            // btPagar
            // 
            this.btPagar.Location = new System.Drawing.Point(4, 333);
            this.btPagar.Margin = new System.Windows.Forms.Padding(4);
            this.btPagar.Name = "btPagar";
            this.btPagar.Size = new System.Drawing.Size(376, 39);
            this.btPagar.TabIndex = 7;
            this.btPagar.Text = "Pagamento";
            this.btPagar.UseVisualStyleBackColor = true;
            this.btPagar.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(4, 380);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(376, 39);
            this.button9.TabIndex = 8;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(4, 427);
            this.button10.Margin = new System.Windows.Forms.Padding(4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(376, 39);
            this.button10.TabIndex = 9;
            this.button10.Text = "button10";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(4, 474);
            this.button11.Margin = new System.Windows.Forms.Padding(4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(376, 39);
            this.button11.TabIndex = 10;
            this.button11.Text = "button11";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(4, 521);
            this.button12.Margin = new System.Windows.Forms.Padding(4);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(376, 39);
            this.button12.TabIndex = 11;
            this.button12.Text = "button12";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(4, 568);
            this.button13.Margin = new System.Windows.Forms.Padding(4);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(376, 39);
            this.button13.TabIndex = 12;
            this.button13.Text = "button13";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.AutoSize = true;
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMenu.Controls.Add(this.dataGridViewMenu);
            this.panelMenu.Location = new System.Drawing.Point(419, 78);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1500, 745);
            this.panelMenu.TabIndex = 2;
            // 
            // dataGridViewMenu
            // 
            this.dataGridViewMenu.AutoGenerateColumns = false;
            this.dataGridViewMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.iDClienteDataGridViewTextBoxColumn,
            this.dataCriacaoDataGridViewTextBoxColumn});
            this.dataGridViewMenu.DataSource = this.ordemDeServicoBindingSource;
            this.dataGridViewMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMenu.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMenu.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewMenu.Name = "dataGridViewMenu";
            this.dataGridViewMenu.RowHeadersWidth = 51;
            this.dataGridViewMenu.Size = new System.Drawing.Size(1496, 741);
            this.dataGridViewMenu.TabIndex = 0;
            // 
            // dataBaseDataSet
            // 
            this.dataBaseDataSet.DataSetName = "DataBaseDataSet";
            this.dataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordemDeServicoBindingSource
            // 
            this.ordemDeServicoBindingSource.DataMember = "OrdemDeServico";
            this.ordemDeServicoBindingSource.DataSource = this.dataBaseDataSet;
            // 
            // ordemDeServicoTableAdapter
            // 
            this.ordemDeServicoTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDClienteDataGridViewTextBoxColumn
            // 
            this.iDClienteDataGridViewTextBoxColumn.DataPropertyName = "ID_Cliente";
            this.iDClienteDataGridViewTextBoxColumn.HeaderText = "ID_Cliente";
            this.iDClienteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDClienteDataGridViewTextBoxColumn.Name = "iDClienteDataGridViewTextBoxColumn";
            this.iDClienteDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataCriacaoDataGridViewTextBoxColumn
            // 
            this.dataCriacaoDataGridViewTextBoxColumn.DataPropertyName = "DataCriacao";
            this.dataCriacaoDataGridViewTextBoxColumn.HeaderText = "DataCriacao";
            this.dataCriacaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataCriacaoDataGridViewTextBoxColumn.Name = "dataCriacaoDataGridViewTextBoxColumn";
            this.dataCriacaoDataGridViewTextBoxColumn.Width = 125;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImage = global::Sistema_Financeiro.Properties.Resources.home_263115;
            this.ClientSize = new System.Drawing.Size(1924, 852);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordemDeServicoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Menu_Load(object sender, EventArgs e)
        {
        }

        #endregion
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btCompra;
        private System.Windows.Forms.Button btPagar;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.DataGridView dataGridViewMenu;
        private DataBaseDataSet dataBaseDataSet;
        private System.Windows.Forms.BindingSource ordemDeServicoBindingSource;
        private DataBaseDataSetTableAdapters.OrdemDeServicoTableAdapter ordemDeServicoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCriacaoDataGridViewTextBoxColumn;
    }
}