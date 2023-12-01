namespace Exercicio7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnAbrirArquivo = new System.Windows.Forms.Button();
            this.dgvVendedores = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Regiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vendas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedores)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAbrirArquivo
            // 
            this.BtnAbrirArquivo.Location = new System.Drawing.Point(17, 22);
            this.BtnAbrirArquivo.Name = "BtnAbrirArquivo";
            this.BtnAbrirArquivo.Size = new System.Drawing.Size(94, 29);
            this.BtnAbrirArquivo.TabIndex = 0;
            this.BtnAbrirArquivo.Text = "Arquivo";
            this.BtnAbrirArquivo.UseVisualStyleBackColor = true;
            this.BtnAbrirArquivo.Click += new System.EventHandler(this.BtnAbrirArquivo_Click);
            // 
            // dgvVendedores
            // 
            this.dgvVendedores.AllowUserToAddRows = false;
            this.dgvVendedores.AllowUserToDeleteRows = false;
            this.dgvVendedores.AllowUserToResizeColumns = false;
            this.dgvVendedores.AllowUserToResizeRows = false;
            this.dgvVendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Regiao,
            this.Vendas});
            this.dgvVendedores.Location = new System.Drawing.Point(17, 57);
            this.dgvVendedores.Name = "dgvVendedores";
            this.dgvVendedores.ReadOnly = true;
            this.dgvVendedores.RowHeadersVisible = false;
            this.dgvVendedores.RowHeadersWidth = 51;
            this.dgvVendedores.RowTemplate.Height = 29;
            this.dgvVendedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVendedores.Size = new System.Drawing.Size(608, 365);
            this.dgvVendedores.TabIndex = 1;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Vendedor";
            this.Nome.MinimumWidth = 6;
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Regiao
            // 
            this.Regiao.DataPropertyName = "Regiao";
            this.Regiao.HeaderText = "Região";
            this.Regiao.MinimumWidth = 6;
            this.Regiao.Name = "Regiao";
            this.Regiao.ReadOnly = true;
            this.Regiao.Width = 125;
            // 
            // Vendas
            // 
            this.Vendas.DataPropertyName = "Vendas";
            this.Vendas.HeaderText = "Vendas";
            this.Vendas.MinimumWidth = 6;
            this.Vendas.Name = "Vendas";
            this.Vendas.ReadOnly = true;
            this.Vendas.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 450);
            this.Controls.Add(this.dgvVendedores);
            this.Controls.Add(this.BtnAbrirArquivo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnAbrirArquivo;
        private DataGridView dgvVendedores;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Regiao;
        private DataGridViewTextBoxColumn Vendas;
    }
}