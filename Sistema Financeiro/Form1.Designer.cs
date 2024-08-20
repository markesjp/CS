using System.Windows.Forms;

namespace Sistema_Financeiro
{
    partial class Form1
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
            this.dataGridView = new DataGridView();
            this.payButton = new Button();
            this.paymentTextBox = new TextBox();

            // DataGridView
            this.dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(776, 150);
            this.dataGridView.TabIndex = 0;

            // TextBox
            this.paymentTextBox.Location = new System.Drawing.Point(12, 180);
            this.paymentTextBox.Name = "paymentTextBox";
            this.paymentTextBox.Size = new System.Drawing.Size(100, 20);
            this.paymentTextBox.TabIndex = 1;

            // Button
            this.payButton.Location = new System.Drawing.Point(130, 180);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(75, 23);
            this.payButton.TabIndex = 2;
            this.payButton.Text = "Pay";
            this.payButton.UseVisualStyleBackColor = true;
            this.payButton.Click += new System.EventHandler(this.PayButton_Click);

            // Form
            this.ClientSize = new System.Drawing.Size(800, 250);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.paymentTextBox);
            this.Controls.Add(this.payButton);
            this.Text = "Payment Form";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
        }

        #endregion
    }
}