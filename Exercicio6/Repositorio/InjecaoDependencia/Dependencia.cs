using Dominio.Interface.Repositorio;
using Dominio.Interface.Service;
using Dominio.Service;
using Microsoft.Extensions.DependencyInjection;
using Repositorio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.InjecaoDependencia
{
    public static class Dependencia
    {
        public static IServiceCollection AddMinhasDependencias(
this IServiceCollection services)
        {
            services.AddSingleton<IAlunoService, AlunoService>();
            services.AddSingleton<IAlunoRepositorio, AlunoRepositorio>();

            return services;
        }
    }
}
