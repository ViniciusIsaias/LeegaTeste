using Exercicio10.Classe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio10
{
    public partial class TesteClasse : Form
    {
        public TesteClasse()
        {
            try
            {
                InitializeComponent();
                this.CarregaClasse();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregaClasse()
        {
            Ingresso ingresso = new() { Valor = 100 };

            IngressoVip ingressoVip = new() { Valor = 100, ValorAdicional = 50 };

            this.txtIngresso.Text = ingresso.ToString();
            this.txtIngressoVip.Text = ingressoVip.ToString();
        }
    }
}
