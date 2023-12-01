using Dominio.Dto;
using Dominio.Entidade;

namespace Dominio.Interface.Service
{
    public interface IAlunoService
    {
        Task<Aluno> GetAlunoByIdAsync(int matricula);
        Task<Aluno> CreateAsync(Aluno alunoCreate);
        Task<Aluno> UpdateAsync(Aluno alunoUpdate);
        Task<bool> ExisteAluno(int matricula);
    }
}
