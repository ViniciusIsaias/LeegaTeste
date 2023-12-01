using Exercicio17.Classe;
using Exercicio17.Repositorio;

namespace Exercicio17.Negocio
{
    public class NgAlbuns
    {
        public NgAlbuns()
        {
        }

        public List<Albuns> ListarAlbunsArtista(int idArtista)
        {
            AlbumRepo albumRepo = new AlbumRepo();
            return albumRepo.ListarAlbumArtista(idArtista);
        }

        public Albuns AdicionarAlbum(Albuns album )
        {
            AlbumRepo albumRepo = new AlbumRepo();
            return albumRepo.AdicionarAlbum(album);
        }

        public Albuns AlterarAlbum(Albuns album)
        {
            AlbumRepo albumRepo = new AlbumRepo();
            return albumRepo.AlterarAlbum(album);
        }

        public void RemoverAlbum(Albuns album)
        {
            AlbumRepo albumRepo = new AlbumRepo();
            albumRepo.RemoverAlbum(album);
        }
    }
}
