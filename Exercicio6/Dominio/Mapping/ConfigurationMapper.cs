using AutoMapper;
using Dominio.Dto;
using Dominio.Entidade;

namespace Dominio.Mapping
{
    public class ConfigurationMapper : Profile
    {
        public ConfigurationMapper()
        {
            CreateMap<Aluno, AlunoDto>().ReverseMap();
            CreateMap<Aluno, AlunoCreateDto>().ReverseMap();
            CreateMap<Aluno, AlunoUpdateDto>().ReverseMap();
        }
    }
}
