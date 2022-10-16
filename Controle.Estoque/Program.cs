using Controle.Estoque.Config;
using Controle.Estoque.Models.Context;
using Controle.Estoque.Repositorys.CategoriaRepo;
using Controle.Estoque.Repositorys.CidadeRepo;
using Controle.Estoque.Repositorys.FornecedorRepo;
using Controle.Estoque.Repositorys.ProdutoRepo;
using Controle.Estoque.Repositorys.TransportadoraRepo;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Banco de Dados 
builder.Services.AddDbContext<MySQLContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("DbConnectionString")));

//Implementacao Mapper
var mapper = MappingConfig.RegisterMaps().CreateMapper();
builder.Services.AddSingleton(mapper);
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
//Fim Mapper

//Repository
builder.Services.AddScoped<ICategoriaRepository, CategoriaRepository>();
builder.Services.AddScoped<ICidadeRepository, CidadeRepository>();
builder.Services.AddScoped<IFornecedorRepository, FornecedorRepository>();
builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();
builder.Services.AddScoped<ITransportadoraRepository, TransportadoraRepository>();



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
