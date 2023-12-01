using AutoMapper;
using Dominio.Interface.Repositorio;
using Dominio.Interface.Service;
using Dominio.Mapping;
using Dominio.Service;
using Repositorio.InjecaoDependencia;
using Repositorio.Repositorio;

var builder = WebApplication.CreateBuilder(args);   

// Add services to the container.

builder.Services.AddControllers();

builder.Services
    .AddMinhasDependencias();

builder.Services.AddRazorPages();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

var configuration = new MapperConfiguration(cfg =>
{
    cfg.AddProfile<ConfigurationMapper>();
});

IMapper mapper = configuration.CreateMapper();

builder.Services.AddSingleton(mapper);
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
