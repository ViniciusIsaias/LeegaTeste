using Exercicio3.Classe;

namespace Exercicio3
{
    public partial class Form1 : Form
    {
        List<Aluno> alunos = new();

        public Form1()
        {
            try
            {
                InitializeComponent();
                this.dgvAlunos.AutoGenerateColumns = false;
                this.GeraLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GeraLista()
        {
            Random rnd = new();

            alunos = new()
            {
                new Aluno { Nome = "Ancihol", Matricula = rnd.Next(1000, 2000), Idade = rnd.Next(18, 50) },
                new Aluno { Nome = "Seygur", Matricula = rnd.Next(1000, 2000), Idade = rnd.Next(18, 50) },
                new Aluno { Nome = "Orakgaoth", Matricula = rnd.Next(1000, 2000), Idade = rnd.Next(18, 50) },
                new Aluno { Nome = "Liniezog", Matricula = rnd.Next(1000, 2000), Idade = rnd.Next(18, 50) },
                new Aluno { Nome = "Snatag", Matricula = rnd.Next(1000, 2000), Idade = rnd.Next(18, 50) },
                new Aluno { Nome = "Rabikul", Matricula = rnd.Next(1000, 2000), Idade = rnd.Next(18, 50) },
                new Aluno { Nome = "Gadbla", Matricula = rnd.Next(1000, 2000), Idade = rnd.Next(18, 50) },
                new Aluno { Nome = "Mok", Matricula = rnd.Next(1000, 2000), Idade = rnd.Next(18, 50) },
                new Aluno { Nome = "Uzgaimph", Matricula = rnd.Next(1000, 2000), Idade = rnd.Next(18, 50) },
                new Aluno { Nome = "Maknbul", Matricula = rnd.Next(1000, 2000), Idade = rnd.Next(18, 50) }
            };
        }

        private bool ValidaCampos()
        {
            if (alunos.Any())
            {
                if (alunos.Any(x => x.Nome == String.Empty))
                {
                    MessageBox.Show("Existe aluno sem nome, por favor verificar a lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                if (alunos.Any(x => x.Matricula == 0))
                {
                    MessageBox.Show("Existe aluno sem matricula, por favor verificar a lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }

                return true;
            }
            else
            {
                MessageBox.Show("Não existem dados para exibição, por favor verificar a lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        private void CarregaGrid()
        {
            this.dgvAlunos.DataSource = alunos.OrderBy(x => x.Matricula).ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidaCampos())
                {
                    this.CarregaGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}