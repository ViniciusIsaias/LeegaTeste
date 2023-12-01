using Dominio.Entidade;
using Dominio.Interface.Repositorio;
using Dominio.Interface.Service;

namespace Dominio.Service
{
    public class AlunoService : IAlunoService
    {
        private readonly IAlunoRepositorio _alunoRepositorio;

        public AlunoService(IAlunoRepositorio alunoRepositorio)
        {
            _alunoRepositorio = alunoRepositorio;
        }

        public async Task<Aluno> CreateAsync(Aluno alunoCreate)
        {
            return await _alunoRepositorio.CreateAsync(alunoCreate);
        }

        public async Task<bool> ExisteAluno(int matricula)
        {
            return await _alunoRepositorio.ExisteAluno(matricula);
        }

        public async Task<Aluno> GetAlunoByIdAsync(int matricula)
        {
            return await _alunoRepositorio.GetByIdAsync(matricula);
        }

        public async Task<Aluno> UpdateAsync(Aluno alunoUpdate)
        {
            return await _alunoRepositorio.UpdateAsync(alunoUpdate);
        }
    }
}
