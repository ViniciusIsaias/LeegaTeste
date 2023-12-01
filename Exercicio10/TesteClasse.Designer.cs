namespace Exercicio10
{
    partial class TesteClasse
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
            this.txtIngresso = new System.Windows.Forms.TextBox();
            this.txtIngressoVip = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtIngresso
            // 
            this.txtIngresso.Location = new System.Drawing.Point(63, 48);
            this.txtIngresso.Name = "txtIngresso";
            this.txtIngresso.Size = new System.Drawing.Size(125, 27);
            this.txtIngresso.TabIndex = 0;
            // 
            // txtIngressoVip
            // 
            this.txtIngressoVip.Location = new System.Drawing.Point(63, 81);
            this.txtIngressoVip.Name = "txtIngressoVip";
            this.txtIngressoVip.Size = new System.Drawing.Size(125, 27);
            this.txtIngressoVip.TabIndex = 1;
            // 
            // TesteClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIngressoVip);
            this.Controls.Add(this.txtIngresso);
            this.Name = "TesteClasse";
            this.Text = "TesteClasse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtIngresso;
        private TextBox txtIngressoVip;
    }
}