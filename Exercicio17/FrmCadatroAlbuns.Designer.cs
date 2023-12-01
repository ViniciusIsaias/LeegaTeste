namespace Exercicio17
{
    partial class FrmCadatroAlbuns
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
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CboArtistas = new System.Windows.Forms.ComboBox();
            this.CboRitmos = new System.Windows.Forms.ComboBox();
            this.TxtAlbum = new System.Windows.Forms.TextBox();
            this.LblRitmos = new System.Windows.Forms.Label();
            this.LblArtista = new System.Windows.Forms.Label();
            this.LblAlbum = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(549, 120);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(94, 29);
            this.BtnCancelar.TabIndex = 8;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(449, 120);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(94, 29);
            this.BtnSalvar.TabIndex = 7;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CboArtistas);
            this.groupBox1.Controls.Add(this.CboRitmos);
            this.groupBox1.Controls.Add(this.TxtAlbum);
            this.groupBox1.Controls.Add(this.LblRitmos);
            this.groupBox1.Controls.Add(this.LblArtista);
            this.groupBox1.Controls.Add(this.LblAlbum);
            this.groupBox1.Location = new System.Drawing.Point(14, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(629, 101);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // CboArtistas
            // 
            this.CboArtistas.FormattingEnabled = true;
            this.CboArtistas.Location = new System.Drawing.Point(127, 56);
            this.CboArtistas.Name = "CboArtistas";
            this.CboArtistas.Size = new System.Drawing.Size(259, 28);
            this.CboArtistas.TabIndex = 6;
            // 
            // CboRitmos
            // 
            this.CboRitmos.FormattingEnabled = true;
            this.CboRitmos.Location = new System.Drawing.Point(460, 56);
            this.CboRitmos.Name = "CboRitmos";
            this.CboRitmos.Size = new System.Drawing.Size(157, 28);
            this.CboRitmos.TabIndex = 5;
            // 
            // TxtAlbum
            // 
            this.TxtAlbum.Location = new System.Drawing.Point(72, 19);
            this.TxtAlbum.MaxLength = 150;
            this.TxtAlbum.Name = "TxtAlbum";
            this.TxtAlbum.Size = new System.Drawing.Size(545, 27);
            this.TxtAlbum.TabIndex = 3;
            // 
            // LblRitmos
            // 
            this.LblRitmos.AutoSize = true;
            this.LblRitmos.Location = new System.Drawing.Point(392, 59);
            this.LblRitmos.Name = "LblRitmos";
            this.LblRitmos.Size = new System.Drawing.Size(62, 20);
            this.LblRitmos.TabIndex = 2;
            this.LblRitmos.Text = "Ritmos :";
            // 
            // LblArtista
            // 
            this.LblArtista.AutoSize = true;
            this.LblArtista.Location = new System.Drawing.Point(6, 60);
            this.LblArtista.Name = "LblArtista";
            this.LblArtista.Size = new System.Drawing.Size(115, 20);
            this.LblArtista.TabIndex = 1;
            this.LblArtista.Text = "Artista / Banda :";
            // 
            // LblAlbum
            // 
            this.LblAlbum.AutoSize = true;
            this.LblAlbum.Location = new System.Drawing.Point(6, 22);
            this.LblAlbum.Name = "LblAlbum";
            this.LblAlbum.Size = new System.Drawing.Size(60, 20);
            this.LblAlbum.TabIndex = 0;
            this.LblAlbum.Text = "Album :";
            // 
            // FrmCadatroAlbuns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 161);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadatroAlbuns";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadatroAlbuns";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnCancelar;
        private Button BtnSalvar;
        private GroupBox groupBox1;
        private ComboBox CboArtistas;
        private ComboBox CboRitmos;
        private TextBox TxtAlbum;
        private Label LblRitmos;
        private Label LblArtista;
        private Label LblAlbum;
    }
}