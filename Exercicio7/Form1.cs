using Exercicio7.Classe;

namespace Exercicio7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.dgvVendedores.AutoGenerateColumns = false;
        }

        private void BtnAbrirArquivo_Click(object sender, EventArgs e)
        {
            try
            {
                this.SelecionarArquivo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void SelecionarArquivo()
        {
            OpenFileDialog openFileDialog = new();
            openFileDialog.Title = "Selecionar arquivo CSV";
            openFileDialog.InitialDirectory = @"C:";
            openFileDialog.Filter = "CSV Files(*.csv)| *.csv";

            DialogResult dr = openFileDialog.ShowDialog();

            if (dr == DialogResult.OK)
            {
                this.CarregarDados(openFileDialog.FileName);
            }
        }

        private void CarregarDados(string fileName)
        {
            List<Vendedor> vendedores = new List<Vendedor>();
            using (var reader = new StreamReader(fileName))
            {
                int count = 0;
                while (!reader.EndOfStream)
                {
                    var linha = reader.ReadLine();

                    if (linha != null)
                    {
                        var campos = linha.Split(';');

                        if (count > 0)
                        {
                            Vendedor vendedor = new Vendedor();
                            vendedor.Nome = campos[0];
                            vendedor.Regiao = campos[1];
                            vendedor.Vendas = Convert.ToInt32(campos[2]);
                            vendedores.Add(vendedor);
                        }

                        count++;
                    }
                }
            }

            if (vendedores.Count != 0)
            {
                this.dgvVendedores.DataSource = vendedores.OrderByDescending(x => x.Vendas).ThenBy(n => n.Regiao).ToList();
            }
            else
            {
                MessageBox.Show("O Arquivo está vázio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}