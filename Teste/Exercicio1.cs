using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste
{
    public partial class Exercicio1 : Form
    {
        private List<Funcionario> funcionarios = new List<Funcionario>();
        public Exercicio1()
        {
            try
            {
                InitializeComponent();
                this.dgvFuncionario.AutoGenerateColumns = false;
                this.GerarLista();
                this.CarregaLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GerarLista()
        {
            funcionarios = new List<Funcionario>
            {
                new Funcionario { Nome = "Wyorond", Salario = 100 },
                new Funcionario { Nome = "Malion", Salario = 200 },
                new Funcionario { Nome = "Dagron", Salario = 300 },
                new Funcionario { Nome = "Isuil", Salario = 400 },
                new Funcionario { Nome = "Gilon", Salario = 500 },
                new Funcionario { Nome = "Alron", Salario = 600 },
                new Funcionario { Nome = "Gilkuibia", Salario = 700 },
                new Funcionario { Nome = "Raypen", Salario = 800 },
                new Funcionario { Nome = "Ellodir", Salario = 900 },
                new Funcionario { Nome = "Reulas", Salario = 1000.23M },
            };
        }
        private void CarregaLista()
        {
            this.dgvFuncionario.DataSource = null;

            this.dgvFuncionario.DataSource = funcionarios;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidaCampos())
                {
                    this.ReajustarSalario();
                    this.CarregaLista();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidaCampos()
        {
            if (funcionarios.Any(x => x.Nome == String.Empty))
            {
                MessageBox.Show("Algum nome da lista está em branco, por favor verificar.","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (funcionarios.Any(x => x.Salario <= 0))
            {
                MessageBox.Show("Algum funcionário da lista o salário está menor ou igual a zero, por favor verificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void ReajustarSalario()
        {
            int porcentagemReajuste = 0;

            foreach (var funcionario in funcionarios)
            {
                if (funcionario.Salario <= 300)
                {
                    porcentagemReajuste = 50;
                }
                else if (funcionario.Salario > 300)
                {
                    porcentagemReajuste = 30;
                }

                var reajuste = (funcionario.Salario * porcentagemReajuste) / 100;

                funcionario.Salario = Math.Round(funcionario.Salario + reajuste, 2);
            }
        }
    }
}
