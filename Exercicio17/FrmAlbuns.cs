using Exercicio17.Classe;
using Exercicio17.Negocio;

namespace Exercicio17
{
    public partial class FrmAlbuns : Form
    {
        private Artistas artista = new ();
        public FrmAlbuns()
        {
            InitializeComponent();
            this.DgvAlbuns.AutoGenerateColumns = false;
        }

        public void Iniciar(Artistas artista)
        {
            try
            {
                this.artista = artista;
                this.TxtArtista.Text = artista.Artista;
                this.CarregarAlbunsArtista();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarAlbunsArtista()
        {
            this.DgvAlbuns.DataSource = null;

            NgAlbuns ngAlbuns = new NgAlbuns();
            var albuns = ngAlbuns.ListarAlbunsArtista(this.artista.IdArtista);

            this.DgvAlbuns.DataSource = albuns;
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmCadatroAlbuns frmCadatroAlbuns = new FrmCadatroAlbuns();
                frmCadatroAlbuns.AdicionarAlbum(this.artista);
                frmCadatroAlbuns.ShowDialog();

                this.CarregarAlbunsArtista();
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
                var linha = this.DgvAlbuns.CurrentRow.Index;
                var albuns = (Albuns)this.DgvAlbuns.Rows[linha].DataBoundItem;
                FrmCadatroAlbuns frmCadatroAlbuns = new FrmCadatroAlbuns();
                frmCadatroAlbuns.AlterarAlbum(this.artista, albuns);
                frmCadatroAlbuns.ShowDialog();

                this.CarregarAlbunsArtista();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRemoverAlbum_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Deseja remover o album selecionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    RemoverAlbum();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RemoverAlbum()
        {
            var linha = this.DgvAlbuns.CurrentRow.Index;
            var album = (Albuns)this.DgvAlbuns.Rows[linha].DataBoundItem;
            NgAlbuns ngAlbuns = new NgAlbuns();
            ngAlbuns.RemoverAlbum(album);
            this.CarregarAlbunsArtista();
        }
    }
}
