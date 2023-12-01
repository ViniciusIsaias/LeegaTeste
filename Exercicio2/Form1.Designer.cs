namespace Exercicio2
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
            this.txtInicial = new System.Windows.Forms.TextBox();
            this.txtInvertida = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGerarLista = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtInicial
            // 
            this.txtInicial.Location = new System.Drawing.Point(45, 84);
            this.txtInicial.Name = "txtInicial";
            this.txtInicial.ReadOnly = true;
            this.txtInicial.Size = new System.Drawing.Size(697, 27);
            this.txtInicial.TabIndex = 0;
            // 
            // txtInvertida
            // 
            this.txtInvertida.Location = new System.Drawing.Point(45, 212);
            this.txtInvertida.Name = "txtInvertida";
            this.txtInvertida.ReadOnly = true;
            this.txtInvertida.Size = new System.Drawing.Size(697, 27);
            this.txtInvertida.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lista inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lista invertida";
            // 
            // btnGerarLista
            // 
            this.btnGerarLista.Location = new System.Drawing.Point(648, 258);
            this.btnGerarLista.Name = "btnGerarLista";
            this.btnGerarLista.Size = new System.Drawing.Size(94, 29);
            this.btnGerarLista.TabIndex = 4;
            this.btnGerarLista.Text = "Gerar lista";
            this.btnGerarLista.UseVisualStyleBackColor = true;
            this.btnGerarLista.Click += new System.EventHandler(this.btnGerarLista_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantidade de números :";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(227, 24);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(69, 27);
            this.txtQuantidade.TabIndex = 6;
            this.txtQuantidade.Text = "10";
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGerarLista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInvertida);
            this.Controls.Add(this.txtInicial);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtInicial;
        private TextBox txtInvertida;
        private Label label1;
        private Label label2;
        private Button btnGerarLista;
        private Label label3;
        private TextBox txtQuantidade;
    }
}