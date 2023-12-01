namespace Exercicio17
{
    partial class FrmCadastroArtistas
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
            this.CboRitmos = new System.Windows.Forms.ComboBox();
            this.TxtIntegrantes = new System.Windows.Forms.TextBox();
            this.TxtArtistas = new System.Windows.Forms.TextBox();
            this.LblRitmos = new System.Windows.Forms.Label();
            this.LblIntegrantes = new System.Windows.Forms.Label();
            this.LblArtistas = new System.Windows.Forms.Label();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CboRitmos);
            this.groupBox1.Controls.Add(this.TxtIntegrantes);
            this.groupBox1.Controls.Add(this.TxtArtistas);
            this.groupBox1.Controls.Add(this.LblRitmos);
            this.groupBox1.Controls.Add(this.LblIntegrantes);
            this.groupBox1.Controls.Add(this.LblArtistas);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(978, 62);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // CboRitmos
            // 
            this.CboRitmos.FormattingEnabled = true;
            this.CboRitmos.Location = new System.Drawing.Point(813, 19);
            this.CboRitmos.Name = "CboRitmos";
            this.CboRitmos.Size = new System.Drawing.Size(153, 28);
            this.CboRitmos.TabIndex = 5;
            // 
            // TxtIntegrantes
            // 
            this.TxtIntegrantes.Location = new System.Drawing.Point(682, 19);
            this.TxtIntegrantes.MaxLength = 150;
            this.TxtIntegrantes.Name = "TxtIntegrantes";
            this.TxtIntegrantes.Size = new System.Drawing.Size(57, 27);
            this.TxtIntegrantes.TabIndex = 4;
            this.TxtIntegrantes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIntegrantes_KeyPress);
            // 
            // TxtArtistas
            // 
            this.TxtArtistas.Location = new System.Drawing.Point(141, 19);
            this.TxtArtistas.MaxLength = 150;
            this.TxtArtistas.Name = "TxtArtistas";
            this.TxtArtistas.Size = new System.Drawing.Size(439, 27);
            this.TxtArtistas.TabIndex = 3;
            // 
            // LblRitmos
            // 
            this.LblRitmos.AutoSize = true;
            this.LblRitmos.Location = new System.Drawing.Point(745, 22);
            this.LblRitmos.Name = "LblRitmos";
            this.LblRitmos.Size = new System.Drawing.Size(62, 20);
            this.LblRitmos.TabIndex = 2;
            this.LblRitmos.Text = "Ritmos :";
            // 
            // LblIntegrantes
            // 
            this.LblIntegrantes.AutoSize = true;
            this.LblIntegrantes.Location = new System.Drawing.Point(586, 22);
            this.LblIntegrantes.Name = "LblIntegrantes";
            this.LblIntegrantes.Size = new System.Drawing.Size(90, 20);
            this.LblIntegrantes.TabIndex = 1;
            this.LblIntegrantes.Text = "Integrantes :";
            // 
            // LblArtistas
            // 
            this.LblArtistas.AutoSize = true;
            this.LblArtistas.Location = new System.Drawing.Point(6, 22);
            this.LblArtistas.Name = "LblArtistas";
            this.LblArtistas.Size = new System.Drawing.Size(129, 20);
            this.LblArtistas.TabIndex = 0;
            this.LblArtistas.Text = "Artistas e Bandas :";
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(787, 80);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(94, 29);
            this.BtnSalvar.TabIndex = 1;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(887, 80);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(94, 29);
            this.BtnCancelar.TabIndex = 2;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmCadastroArtistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 126);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastroArtistas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro artista e bandas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox CboRitmos;
        private TextBox TxtIntegrantes;
        private TextBox TxtArtistas;
        private Label LblRitmos;
        private Label LblIntegrantes;
        private Label LblArtistas;
        private Button BtnSalvar;
        private Button BtnCancelar;
    }
}