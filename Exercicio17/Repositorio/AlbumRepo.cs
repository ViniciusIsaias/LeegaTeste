using Dapper;
using Exercicio17.Classe;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Exercicio17.Repositorio
{
    public class AlbumRepo
    {
        private readonly string connectionString;

        public AlbumRepo()
        {
            this.connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
        }

        public List<Albuns> ListarAlbumArtista(int idArtista)
        {
            using var connection = new SqlConnection
            {
                ConnectionString = connectionString,
            };

            DynamicParameters parameters = new();
            parameters.Add("@idartista", idArtista, DbType.Int32);

            var sql = "SELECT A.IDALBUM, A.ALBUM, A.IDARTISTA, A.IDRITMO, B.RITMO " +
                "FROM ALBUNS AS A " +
                "INNER JOIN RITMOS AS B ON A.IDRITMO = B.IDRITMO " +
                "WHERE A.IDARTISTA = @idartista";

            var ritmos = connection.Query<Albuns>(sql, parameters).ToList();

            return ritmos;
        }

        public Albuns AdicionarAlbum(Albuns album)
        {
            using var connection = new SqlConnection
            {
                ConnectionString = connectionString,
            };

            DynamicParameters parameters = new();
            parameters.Add("@album", album.Album, DbType.String);
            parameters.Add("@idartista", album.IdArtista, DbType.Int32);
            parameters.Add("@idritmo", album.IdRitmo, DbType.Int32);

            var sql = "INSERT INTO ALBUNS (ALBUM, IDARTISTA, IDRITMO) " +
                "VALUES (@album, @idartista, @idritmo) " +
                "SELECT SCOPE_IDENTITY()";

            var idAlbum = connection.QueryFirstOrDefault<int>(sql, parameters);

            album.IdAlbum = idAlbum;

            return album;
        }

        public Albuns AlterarAlbum(Albuns album)
        {
            using var connection = new SqlConnection
            {
                ConnectionString = connectionString,
            };

            DynamicParameters parameters = new();
            parameters.Add("@idalbum", album.IdAlbum, DbType.Int32);
            parameters.Add("@album", album.Album, DbType.String);
            parameters.Add("@idartista", album.IdArtista, DbType.Int32);
            parameters.Add("@idritmo", album.IdRitmo, DbType.Int32);

            var sql = "UPDATE ALBUNS SET ALBUM = @album, IDARTISTA = @idartista, IDRITMO = @idritmo " +
                "WHERE IDALBUM = @idalbum";

            connection.Query(sql, parameters);

            return album;
        }

        public void RemoverAlbum(Albuns album)
        {
            using var connection = new SqlConnection
            {
                ConnectionString = connectionString,
            };

            DynamicParameters parameters = new();
            parameters.Add("@idalbum", album.IdAlbum, DbType.Int32);

            var sql = "DELETE ALBUNS WHERE IDALBUM = @idalbum";

            connection.Query(sql, parameters);
        }
    }
}
