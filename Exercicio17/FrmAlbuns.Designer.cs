namespace Exercicio17
{
    partial class FrmAlbuns
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DgvAlbuns = new System.Windows.Forms.DataGridView();
            this.Album = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ritmo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtArtista = new System.Windows.Forms.TextBox();
            this.LblArtista = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnRemoverAlbum = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnAdicionar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAlbuns)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DgvAlbuns);
            this.groupBox1.Controls.Add(this.TxtArtista);
            this.groupBox1.Controls.Add(this.LblArtista);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(686, 398);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // DgvAlbuns
            // 
            this.DgvAlbuns.AllowUserToAddRows = false;
            this.DgvAlbuns.AllowUserToDeleteRows = false;
            this.DgvAlbuns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAlbuns.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Album,
            this.Ritmo});
            this.DgvAlbuns.Location = new System.Drawing.Point(6, 53);
            this.DgvAlbuns.Name = "DgvAlbuns";
            this.DgvAlbuns.ReadOnly = true;
            this.DgvAlbuns.RowHeadersVisible = false;
            this.DgvAlbuns.RowHeadersWidth = 51;
            this.DgvAlbuns.RowTemplate.Height = 29;
            this.DgvAlbuns.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvAlbuns.Size = new System.Drawing.Size(665, 339);
            this.DgvAlbuns.TabIndex = 2;
            // 
            // Album
            // 
            this.Album.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Album.DataPropertyName = "Album";
            this.Album.HeaderText = "Album";
            this.Album.MinimumWidth = 6;
            this.Album.Name = "Album";
            this.Album.ReadOnly = true;
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
            // TxtArtista
            // 
            this.TxtArtista.Location = new System.Drawing.Point(71, 20);
            this.TxtArtista.Name = "TxtArtista";
            this.TxtArtista.ReadOnly = true;
            this.TxtArtista.Size = new System.Drawing.Size(600, 27);
            this.TxtArtista.TabIndex = 1;
            // 
            // LblArtista
            // 
            this.LblArtista.AutoSize = true;
            this.LblArtista.Location = new System.Drawing.Point(6, 23);
            this.LblArtista.Name = "LblArtista";
            this.LblArtista.Size = new System.Drawing.Size(59, 20);
            this.LblArtista.TabIndex = 0;
            this.LblArtista.Text = "Artista :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnRemoverAlbum);
            this.groupBox3.Controls.Add(this.BtnAlterar);
            this.groupBox3.Controls.Add(this.BtnAdicionar);
            this.groupBox3.Location = new System.Drawing.Point(704, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(109, 398);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // BtnRemoverAlbum
            // 
            this.BtnRemoverAlbum.Location = new System.Drawing.Point(7, 90);
            this.BtnRemoverAlbum.Name = "BtnRemoverAlbum";
            this.BtnRemoverAlbum.Size = new System.Drawing.Size(94, 53);
            this.BtnRemoverAlbum.TabIndex = 3;
            this.BtnRemoverAlbum.Text = "Remover album";
            this.BtnRemoverAlbum.UseVisualStyleBackColor = true;
            this.BtnRemoverAlbum.Click += new System.EventHandler(this.BtnRemoverAlbum_Click);
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
            // FrmAlbuns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 422);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAlbuns";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Albuns";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAlbuns)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView DgvAlbuns;
        private TextBox TxtArtista;
        private Label LblArtista;
        private GroupBox groupBox3;
        private Button BtnRemoverAlbum;
        private Button BtnAlterar;
        private Button BtnAdicionar;
        private DataGridViewTextBoxColumn Album;
        private DataGridViewTextBoxColumn Ritmo;
    }
}