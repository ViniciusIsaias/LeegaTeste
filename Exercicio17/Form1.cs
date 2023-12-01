using Exercicio17.Classe;
using Exercicio17.Negocio;

namespace Exercicio17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            try
            {
                InitializeComponent();
                DgvArtistas.AutoGenerateColumns = false;
                this.CarregarListaArtistas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmCadastroArtistas frmCadastroArtistas = new();
                frmCadastroArtistas.ShowDialog();
                this.CarregarListaArtistas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                var linha = this.DgvArtistas.CurrentRow.Index;
                var artista = (Artistas)this.DgvArtistas.Rows[linha].DataBoundItem;
                FrmCadastroArtistas frmCadastroArtistas = new();
                frmCadastroArtistas.Iniciar(artista);
                frmCadastroArtistas.ShowDialog();
                this.CarregarListaArtistas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAlbuns_Click(object sender, EventArgs e)
        {
            try
            {
                var linha = this.DgvArtistas.CurrentRow.Index;
                var artista = (Artistas)this.DgvArtistas.Rows[linha].DataBoundItem;

                FrmAlbuns frmAlbuns = new();
                frmAlbuns.Iniciar(artista);
                frmAlbuns.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarListaArtistas()
        {
            this.DgvArtistas.DataSource = null;

            NgArtistas ngArtistas = new NgArtistas();
            var artistas = ngArtistas.ListarArtistas();

            this.DgvArtistas.DataSource = artistas;
        }

        private void BtnRemoverArtista_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Deseja remover o artista selecionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    RemoverArtista();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RemoverArtista()
        {
            var linha = this.DgvArtistas.CurrentRow.Index;
            var artista = (Artistas)this.DgvArtistas.Rows[linha].DataBoundItem;
            NgArtistas ngArtistas = new NgArtistas();
            ngArtistas.RemoverArtista(artista);
            this.CarregarListaArtistas();
        }
    }
}