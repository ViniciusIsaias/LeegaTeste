using System.Data.SqlClient;
using System.Configuration;
using Exercicio17.Classe;
using Dapper;
using System.Data;

namespace Exercicio17.Repositorio
{
    public class ArtistaRepo
    {
        private readonly string connectionString;
        public ArtistaRepo()
        {
            this.connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
        }

        public Artistas AdicionarArtista(Artistas artista)
        {
            using var connection = new SqlConnection
            {
                ConnectionString = connectionString,
            };

            DynamicParameters parameters = new();
            parameters.Add("@artista", artista.Artista, DbType.String);
            parameters.Add("@integrantes", artista.Integrantes, DbType.Int32);
            parameters.Add("@idritmo", artista.IdRitmo, DbType.Int32);

            var sql = "INSERT INTO ARTISTAS (ARTISTA, INTEGRANTES, IDRITMO) " +
                "VALUES (@artista, @integrantes, @idritmo) " +
                "SELECT SCOPE_IDENTITY()";

            var idArtista = connection.QueryFirstOrDefault<int>(sql, parameters);

            artista.IdArtista = idArtista;

            return artista;
        }

        public Artistas AlterarArtista(Artistas artista)
        {
            using var connection = new SqlConnection
            {
                ConnectionString = connectionString,
            };

            DynamicParameters parameters = new();
            parameters.Add("@idartista", artista.IdArtista, DbType.Int32);
            parameters.Add("@artista", artista.Artista, DbType.String);
            parameters.Add("@integrantes", artista.Integrantes, DbType.Int32);
            parameters.Add("@idritmo", artista.IdRitmo, DbType.Int32);

            var sql = "UPDATE ARTISTAS SET ARTISTA = @artista, INTEGRANTES = @integrantes, IDRITMO = @idritmo " +
                "WHERE IDARTISTA = @idartista";

            connection.Query(sql, parameters);

            return artista;
        }

        public List<Artistas> ListarArtistas()
        {
            using var connection = new SqlConnection
            {
                ConnectionString = connectionString,
            };

            var sql = "SELECT A.IDARTISTA, A.ARTISTA, A.INTEGRANTES, A.IDRITMO, B.RITMO " +
                "FROM ARTISTAS AS A " +
                "INNER JOIN RITMOS AS B ON A.IDRITMO = B.IDRITMO";

            var artistas = connection.Query<Artistas>(sql).ToList();

            return artistas;
        }

        public void RemoverArtista(Artistas artista)
        {
            using var connection = new SqlConnection
            {
                ConnectionString = connectionString,
            };

            DynamicParameters parameters = new();
            parameters.Add("@idartista", artista.IdArtista, DbType.Int32);

            var sql = "DELETE ARTISTAS WHERE IDARTISTA = @idartista ";

            connection.Query(sql, parameters);            
        }
    }
}
