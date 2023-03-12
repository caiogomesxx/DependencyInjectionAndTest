using DependencyInjenction.API.Context;
using DependencyInjenction.API.Interfaces;
using DependencyInjenction.API.Repository;
using DependencyInjenction.API.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IClienteRepository,ClienteRepository>();
builder.Services.AddTransient<IPedidoRepository,PedidoRepository>();
builder.Services.AddTransient<IPedidoService, PedidoService>();
builder.Services.AddDbContext<ContextApi>(options =>
        options.UseInMemoryDatabase(databaseName: "MyInMemoryDatabase"));
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
