namespace Exercicio17
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DgvArtistas = new System.Windows.Forms.DataGridView();
            this.Artista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Integrantes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ritmo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnAlbuns = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnAdicionar = new System.Windows.Forms.Button();
            this.BtnRemoverArtista = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvArtistas)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DgvArtistas);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(954, 426);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Artistas e bandas";
            // 
            // DgvArtistas
            // 
            this.DgvArtistas.AllowUserToAddRows = false;
            this.DgvArtistas.AllowUserToDeleteRows = false;
            this.DgvArtistas.AllowUserToResizeColumns = false;
            this.DgvArtistas.AllowUserToResizeRows = false;
            this.DgvArtistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvArtistas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Artista,
            this.Integrantes,
            this.Ritmo});
            this.DgvArtistas.Location = new System.Drawing.Point(6, 26);
            this.DgvArtistas.Name = "DgvArtistas";
            this.DgvArtistas.ReadOnly = true;
            this.DgvArtistas.RowHeadersVisible = false;
            this.DgvArtistas.RowHeadersWidth = 51;
            this.DgvArtistas.RowTemplate.Height = 29;
            this.DgvArtistas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvArtistas.Size = new System.Drawing.Size(942, 394);
            this.DgvArtistas.TabIndex = 0;
            // 
            // Artista
            // 
            this.Artista.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Artista.DataPropertyName = "Artista";
            this.Artista.HeaderText = "Artista / Banda";
            this.Artista.MinimumWidth = 6;
            this.Artista.Name = "Artista";
            this.Artista.ReadOnly = true;
            // 
            // Integrantes
            // 
            this.Integrantes.DataPropertyName = "Integrantes";
            this.Integrantes.HeaderText = "Integrantes";
            this.Integrantes.MinimumWidth = 6;
            this.Integrantes.Name = "Integrantes";
            this.Integrantes.ReadOnly = true;
            this.Integrantes.Width = 125;
            // 
            // Ritmo
            // 
            this.Ritmo.DataPropertyName = "Ritmo";
            this.Ritmo.HeaderText = "Ritmo";
            this.Ritmo.MinimumWidth = 6;
            this.Ritmo.Name = "Ritmo";
            this.Ritmo.ReadOnly = true;
            this.Ritmo.Width = 125;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnRemoverArtista);
            this.groupBox3.Controls.Add(this.BtnAlbuns);
            this.groupBox3.Controls.Add(this.BtnAlterar);
            this.groupBox3.Controls.Add(this.BtnAdicionar);
            this.groupBox3.Location = new System.Drawing.Point(976, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(109, 426);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // BtnAlbuns
            // 
            this.BtnAlbuns.Location = new System.Drawing.Point(7, 90);
            this.BtnAlbuns.Name = "BtnAlbuns";
            this.BtnAlbuns.Size = new System.Drawing.Size(94, 29);
            this.BtnAlbuns.TabIndex = 2;
            this.BtnAlbuns.Text = "Albuns";
            this.BtnAlbuns.UseVisualStyleBackColor = true;
            this.BtnAlbuns.Click += new System.EventHandler(this.BtnAlbuns_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Location = new System.Drawing.Point(7, 55);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(94, 29);
            this.BtnAlterar.TabIndex = 1;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.Location = new System.Drawing.Point(7, 20);
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.Size = new System.Drawing.Size(94, 29);
            this.BtnAdicionar.TabIndex = 0;
            this.BtnAdicionar.Text = "Adicionar";
            this.BtnAdicionar.UseVisualStyleBackColor = true;
            this.BtnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // BtnRemoverArtista
            // 
            this.BtnRemoverArtista.Location = new System.Drawing.Point(7, 125);
            this.BtnRemoverArtista.Name = "BtnRemoverArtista";
            this.BtnRemoverArtista.Size = new System.Drawing.Size(94, 53);
            this.BtnRemoverArtista.TabIndex = 3;
            this.BtnRemoverArtista.Text = "Remover artista";
            this.BtnRemoverArtista.UseVisualStyleBackColor = true;
            this.BtnRemoverArtista.Click += new System.EventHandler(this.BtnRemoverArtista_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Artistas";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvArtistas)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox groupBox2;
        private DataGridView DgvArtistas;
        private GroupBox groupBox3;
        private Button BtnAlbuns;
        private Button BtnAlterar;
        private Button BtnAdicionar;
        private DataGridViewTextBoxColumn Artista;
        private DataGridViewTextBoxColumn Integrantes;
        private DataGridViewTextBoxColumn Ritmo;
        private Button BtnRemoverArtista;
    }
}