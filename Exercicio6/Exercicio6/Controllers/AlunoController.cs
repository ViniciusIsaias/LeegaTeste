using AutoMapper;
using Dominio.Dto;
using Dominio.Entidade;
using Dominio.Interface.Service;
using Microsoft.AspNetCore.Mvc;

namespace Exercicio6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoService _alunoService;
        private readonly IMapper _mapper;

        public AlunoController(IAlunoService alunoService, IMapper mapper)
        {            
            _mapper = mapper;
            _alunoService = alunoService;
        }

        [HttpGet]
        [Route("RetornaAluno/{matricula}")]
        public async Task<IActionResult> RetornaAluno(int matricula)
        {
            try
            {
                var aluno = _mapper.Map<AlunoDto>(await _alunoService.GetAlunoByIdAsync(matricula));

                return this.Ok(aluno);
            }
            catch (Exception)
            {
                return this.StatusCode(500);
            }
        }

        [HttpPost]
        [Route("AdicionarAluno")]
        public async Task<IActionResult> AdicionarAluno([FromBody] AlunoCreateDto alunoCreateDto)
        {
            try
            {
                var alunoDto = _mapper.Map<Aluno>(alunoCreateDto);

                var aluno = await _alunoService.CreateAsync(alunoDto);

                return this.Ok(aluno);
            }
            catch (Exception ex)
            {                
                return this.StatusCode(500);
            }
        }

        [HttpPut]
        [Route("AlterarAluno")]
        public async Task<IActionResult> AlterarAluno([FromBody] AlunoUpdateDto alunoUpdateDto)
        {
            try
            {
                var alunoDto = _mapper.Map<Aluno>(alunoUpdateDto);

                if (await _alunoService.ExisteAluno(alunoDto.Matricula))
                {
                    var aluno = await _alunoService.UpdateAsync(alunoDto);

                    return this.Ok(aluno);
                }
                else
                {
                    return this.NotFound("Aluno não encontrado.");
                }
            }
            catch (Exception)
            {
                return this.StatusCode(500);
            }
        }
    }
}
