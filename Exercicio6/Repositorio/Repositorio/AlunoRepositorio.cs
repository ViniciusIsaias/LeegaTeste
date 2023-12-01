using Dapper;
using Dominio.Dto;
using Dominio.Entidade;
using Dominio.Interface.Repositorio;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Repositorio.Repositorio
{
    public class AlunoRepositorio : IAlunoRepositorio
    {
        private readonly IConfiguration _configuration;
        private readonly string connectionString;
        public AlunoRepositorio(IConfiguration configuration)
        {
            this._configuration = configuration;
            connectionString = _configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<Aluno> CreateAsync(Aluno alunoCreate)
        {
            using var connection = new SqlConnection(connectionString);

            DynamicParameters parameters = new();
            parameters.Add("@nome", alunoCreate.Nome, DbType.String);
            parameters.Add("@idade", alunoCreate.Idade, DbType.Int32);

            var sql = "INSERT INTO ALUNOS (NOME, IDADE, ESTADO) " +
                "VALUES (@nome, @idade, '') " +
                "SELECT SCOPE_IDENTITY()";

            var matricula = await connection.QueryFirstOrDefaultAsync<int>(sql, parameters);

            alunoCreate.Matricula = matricula;

            return alunoCreate;
        }

        public async Task<Aluno> GetByIdAsync(int id)
        {
            using var connection = new SqlConnection(connectionString);

            DynamicParameters parameters = new();
            parameters.Add("@matricula", id, DbType.Int32);

            var aluno = await connection.QueryFirstOrDefaultAsync<Aluno>("SELECT MATRICULA, NOME, IDADE FROM ALUNOS WHERE MATRICULA = @matricula", parameters);

            return aluno;
        }

        public async Task<Aluno> UpdateAsync(Aluno alunoUpdate)
        {
            using var connection = new SqlConnection(connectionString);

            DynamicParameters parameters = new();
            parameters.Add("@matricula", alunoUpdate.Matricula, DbType.Int32);
            parameters.Add("@nome", alunoUpdate.Nome, DbType.String);
            parameters.Add("@idade", alunoUpdate.Idade, DbType.Int32);

            var sql = "UPDATE ALUNOS SET NOME = @nome, IDADE = @idade " +
                "WHERE MATRICULA = @matricula";

            var matricula = await connection.QueryAsync(sql, parameters);

            return alunoUpdate;
        }

        public async Task<bool> ExisteAluno(int matricula)
        {
            using var connection = new SqlConnection(connectionString);

            DynamicParameters parameters = new();
            parameters.Add("@matricula", matricula, DbType.Int32);

            var sql = "SELECT MATRICULA FROM ALUNOS WHERE MATRICULA = @matricula";

            var existe = await connection.QueryFirstOrDefaultAsync<bool>(sql, parameters);

            return existe;
        }
    }
}
