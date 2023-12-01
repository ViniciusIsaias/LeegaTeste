using Exercicio17.Classe;
using Exercicio17.Repositorio;

namespace Exercicio17.Negocio
{
    public class NgArtistas
    {
        public NgArtistas()
        {
        }

        public Artistas AdicionarArtista(Artistas artista)
        {
            ArtistaRepo repo = new();
            return repo.AdicionarArtista(artista);
        }

        public Artistas AlterarArtista(Artistas artista)
        {
            ArtistaRepo repo = new();
            return repo.AlterarArtista(artista);
        }

        public List<Artistas> ListarArtistas()
        {
            ArtistaRepo repo = new();
            return repo.ListarArtistas();
        }

        public void RemoverArtista(Artistas artista)
        {
            ArtistaRepo repo = new();
            repo.RemoverArtista(artista);
        }
    }
}
