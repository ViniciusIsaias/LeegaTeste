namespace Exercicio11
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvVendedores = new System.Windows.Forms.DataGridView();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.Vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Orcado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Realizado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Atingimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVendedores
            // 
            this.dgvVendedores.AllowUserToAddRows = false;
            this.dgvVendedores.AllowUserToDeleteRows = false;
            this.dgvVendedores.AllowUserToResizeColumns = false;
            this.dgvVendedores.AllowUserToResizeRows = false;
            this.dgvVendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Vendedor,
            this.Orcado,
            this.Realizado,
            this.Atingimento});
            this.dgvVendedores.Location = new System.Drawing.Point(17, 47);
            this.dgvVendedores.Name = "dgvVendedores";
            this.dgvVendedores.ReadOnly = true;
            this.dgvVendedores.RowHeadersVisible = false;
            this.dgvVendedores.RowHeadersWidth = 51;
            this.dgvVendedores.RowTemplate.Height = 29;
            this.dgvVendedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVendedores.Size = new System.Drawing.Size(771, 391);
            this.dgvVendedores.TabIndex = 0;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(694, 12);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(94, 29);
            this.BtnCalcular.TabIndex = 1;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // Vendedor
            // 
            this.Vendedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Vendedor.DataPropertyName = "Nome";
            this.Vendedor.HeaderText = "Vendedor";
            this.Vendedor.MinimumWidth = 6;
            this.Vendedor.Name = "Vendedor";
            this.Vendedor.ReadOnly = true;
            // 
            // Orcado
            // 
            this.Orcado.DataPropertyName = "Orcado";
            this.Orcado.HeaderText = "Orçado";
            this.Orcado.MinimumWidth = 6;
            this.Orcado.Name = "Orcado";
            this.Orcado.ReadOnly = true;
            this.Orcado.Width = 125;
            // 
            // Realizado
            // 
            this.Realizado.DataPropertyName = "Realizado";
            this.Realizado.HeaderText = "Realizado";
            this.Realizado.MinimumWidth = 6;
            this.Realizado.Name = "Realizado";
            this.Realizado.ReadOnly = true;
            this.Realizado.Width = 125;
            // 
            // Atingimento
            // 
            this.Atingimento.DataPropertyName = "Atingimento";
            dataGridViewCellStyle1.Format = "0.00\\%";
            this.Atingimento.DefaultCellStyle = dataGridViewCellStyle1;
            this.Atingimento.HeaderText = "Atingimento";
            this.Atingimento.MinimumWidth = 6;
            this.Atingimento.Name = "Atingimento";
            this.Atingimento.ReadOnly = true;
            this.Atingimento.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.dgvVendedores);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvVendedores;
        private Button BtnCalcular;
        private DataGridViewTextBoxColumn Vendedor;
        private DataGridViewTextBoxColumn Orcado;
        private DataGridViewTextBoxColumn Realizado;
        private DataGridViewTextBoxColumn Atingimento;
    }
}