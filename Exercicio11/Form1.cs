using Exercicio11.Classe;

namespace Exercicio11
{
    public partial class Form1 : Form
    {
        List<Vendedor> vendedores = new();
        public Form1()
        {
            try
            {
                InitializeComponent();
                this.GeraLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GeraLista()
        {
            vendedores = new()
            {
                new Vendedor { Nome = "Ancihol", Orcado = 100, Realizado = 100 },
                new Vendedor { Nome = "Seygur", Orcado = 800, Realizado = 200 },
                new Vendedor { Nome = "Orakgaoth", Orcado = 500, Realizado = 400},
                new Vendedor { Nome = "Liniezog", Orcado = 2000, Realizado = 50 },
                new Vendedor { Nome = "Snatag", Orcado = 1000, Realizado = 980 },
                new Vendedor { Nome = "Rabikul", Orcado = 1399, Realizado = 750 },
                new Vendedor { Nome = "Gadbla", Orcado = 900, Realizado = 850 },
                new Vendedor { Nome = "Mok", Orcado = 1500, Realizado = 1500 },
                new Vendedor { Nome = "Uzgaimph", Orcado = 300, Realizado = 200 },
                new Vendedor { Nome = "Maknbul", Orcado = 700, Realizado = 1500 }
            };
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidaCampos())
                {
                    CalcularPercentual();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalcularPercentual()
        {
            vendedores.ForEach(vendedor =>
            {
                if (vendedor.Orcado != 0)
                {
                    vendedor.Atingimento = Math.Round((vendedor.Realizado / vendedor.Orcado) * 100, 2);
                }
                else
                {
                    vendedor.Atingimento = Math.Round(vendedor.Realizado, 2);
                }
                
            });

            this.dgvVendedores.DataSource = vendedores;
        }

        private bool ValidaCampos()
        {
            if (!vendedores.Any())
            {
                MessageBox.Show("A lista está vazia, por favor verificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (vendedores.Any(x => x.Nome == String.Empty))
            {
                MessageBox.Show("Algum nome da lista está em branco, por favor verificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }
    }
}