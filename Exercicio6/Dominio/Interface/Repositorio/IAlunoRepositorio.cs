using Dominio.Dto;
using Dominio.Entidade;

namespace Dominio.Interface.Repositorio
{
    public interface IAlunoRepositorio
    {
        Task<Aluno> GetByIdAsync(int id);
        Task<Aluno> CreateAsync(Aluno alunoCreate);
        Task<Aluno> UpdateAsync(Aluno alunoUpdate);

        Task<bool> ExisteAluno(int matricula);
    }
}
