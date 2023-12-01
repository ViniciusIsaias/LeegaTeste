using Exercicio17.Classe;
using Exercicio17.Negocio;

namespace Exercicio17
{
    public partial class FrmCadatroAlbuns : Form
    {
        private Albuns? album = null; 
        public FrmCadatroAlbuns()
        {
            try
            {
                InitializeComponent();
                this.ListarRitmos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AdicionarAlbum(Artistas artista)
        {
            this.CarregarListaArtistas(artista.IdArtista);
        }

        public void AlterarAlbum(Artistas artista, Albuns album)
        {
            this.album = album;
            this.TxtAlbum.Text = album.Album;
            this.CarregarListaArtistas(artista.IdArtista);
        }

        private void ListarRitmos()
        {
            NgRitmo ngRitmo = new();
            var ritmos = ngRitmo.ListarRitmos();

            this.CboRitmos.DataSource = ritmos;
            this.CboRitmos.DisplayMember = "Ritmo";
            this.CboRitmos.ValueMember = "IdRitmo";
            this.CboRitmos.SelectedIndex = 0;
        }

        private void CarregarListaArtistas(int idArtista)
        {           
            NgArtistas ngArtistas = new();
            var artistas = ngArtistas.ListarArtistas();

            this.CboArtistas.DataSource = artistas.Where(x => x.IdArtista == idArtista).ToList();
            this.CboArtistas.DisplayMember = "Artista";
            this.CboArtistas.ValueMember = "IdArtista";
            this.CboArtistas.SelectedValue = idArtista;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidaCampos())
                {
                    var ritmo = (Ritmos)this.CboRitmos.SelectedItem;
                    var artista = (Artistas)this.CboArtistas.SelectedItem;
                    if (this.album == null)
                    {
                        Albuns album = new() { Album = this.TxtAlbum.Text, IdArtista = artista.IdArtista, IdRitmo = ritmo.IdRitmo };

                        this.SalvarAlbum(album);
                        this.LimparTela();
                    }
                    else
                    {
                        this.album.Album = TxtAlbum.Text;
                        this.album.IdArtista = artista.IdArtista;
                        this.album.IdRitmo = ritmo.IdRitmo;

                        this.AlterarAlbum(this.album);
                    }

                    MessageBox.Show("Album salvo com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidaCampos()
        {
            if (string.IsNullOrEmpty(this.TxtAlbum.Text))
            {
                MessageBox.Show("Digite o nome do Album.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (this.CboArtistas.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione o artista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (this.CboRitmos.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um ritmo musical.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void SalvarAlbum(Albuns album)
        {
            NgAlbuns ngAlbuns = new();
            ngAlbuns.AdicionarAlbum(album);
        }

        private void AlterarAlbum(Albuns album)
        {
            NgAlbuns ngAlbuns = new();
            ngAlbuns.AlterarAlbum(album);
        }

        private void LimparTela()
        {
            this.TxtAlbum.Text = String.Empty;            
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
