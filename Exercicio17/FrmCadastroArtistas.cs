using Exercicio17.Classe;
using Exercicio17.Negocio;

namespace Exercicio17
{
    public partial class FrmCadastroArtistas : Form
    {
        private Artistas? artista;

        public FrmCadastroArtistas()
        {
            try
            {
                InitializeComponent();
                this.ListarRitmos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Iniciar(Artistas artista)
        {
            try
            {
                this.artista = artista;
                this.TxtArtistas.Text = this.artista.Artista;
                this.TxtIntegrantes.Text = this.artista.Integrantes.ToString();
                this.CboRitmos.SelectedValue = this.artista.IdRitmo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtIntegrantes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidaCampos())
                {
                    var ritmo = (Ritmos)this.CboRitmos.SelectedItem;
                    if (this.artista == null)
                    {
                        Artistas artista = new() { Artista = TxtArtistas.Text, Integrantes = Convert.ToInt32(this.TxtIntegrantes.Text), IdRitmo = ritmo.IdRitmo };

                        this.SalvarArtista(artista);
                        this.LimparTela();
                    }
                    else
                    {
                        this.artista.Artista = TxtArtistas.Text;
                        this.artista.Integrantes = Convert.ToInt32(this.TxtIntegrantes.Text);
                        this.artista.IdRitmo = ritmo.IdRitmo;

                        this.AlterarArtista(artista);
                    }

                    MessageBox.Show("Artista salvo com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidaCampos()
        {
            if (string.IsNullOrEmpty(this.TxtArtistas.Text))
            {
                MessageBox.Show("Digite o nome do Artista ou Banda.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (Convert.ToInt32(this.TxtIntegrantes.Text) == 0)
            {
                MessageBox.Show("Coloque pelo menos 1 integrante.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (this.CboRitmos.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um ritmo musical.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void SalvarArtista(Artistas artista)
        {
            NgArtistas ngArtista = new NgArtistas();
            ngArtista.AdicionarArtista(artista);
        }

        private void AlterarArtista(Artistas artista)
        {
            NgArtistas ngArtista = new NgArtistas();
            ngArtista.AlterarArtista(artista);
        }

        private void ListarRitmos()
        {
            NgRitmo ngRitmo = new NgRitmo();
            var ritmos = ngRitmo.ListarRitmos();

            this.CboRitmos.DataSource = ritmos;
            this.CboRitmos.DisplayMember = "Ritmo";
            this.CboRitmos.ValueMember = "IdRitmo";
            this.CboRitmos.SelectedIndex = 0;
        }

        private void LimparTela()
        {
            this.TxtArtistas.Text = String.Empty;
            this.TxtIntegrantes.Text = String.Empty;
            this.CboRitmos.SelectedIndex = 0;
        }
    }
}
