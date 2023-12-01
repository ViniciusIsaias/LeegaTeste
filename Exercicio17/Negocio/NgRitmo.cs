using Exercicio17.Classe;
using Exercicio17.Repositorio;

namespace Exercicio17.Negocio
{
    public class NgRitmo
    {
        public NgRitmo()
        {
        }

        public List<Ritmos> ListarRitmos()
        {
            RitmoRepo repo = new RitmoRepo();
            return repo.ListarRitmos();
        }
    }
}
