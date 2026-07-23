using Dominio.Servicos;
using Infraestrutura;
using Infraestrutura.Repositorios;
using Microsoft.EntityFrameworkCore;
using Servico;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Registra os serviços e repositórios
builder.Services.AddScoped<IVendaServico, VendaServico>();
builder.Services.AddScoped<IVendaRepositorio, VendaRepositorio>();
builder.Services.AddScoped<IProdutoServico, ProdutoServico>();
builder.Services.AddScoped<IProdutoRepositorio, ProdutoRepositorio>();

// Registra o DbContext (necessário para o VendaRepositorio/ProdutoRepositorio funcionarem)
builder.Services.AddDbContext<AppDBContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.MapControllers();
app.Run();