using Dapper;
using Exercicio17.Classe;
using System.Configuration;
using System.Data.SqlClient;

namespace Exercicio17.Repositorio
{
    public class RitmoRepo
    {
        private readonly string connectionString;

        public RitmoRepo()
        {
            this.connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
        }

        public List<Ritmos> ListarRitmos()
        {
            using var connection = new SqlConnection
            {
                ConnectionString = connectionString,
            };

            var sql = "SELECT IDRITMO, RITMO FROM RITMOS";

            var ritmos = connection.Query<Ritmos>(sql).ToList();

            return ritmos;
        }
    }
}
