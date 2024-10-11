using miminal .Infraestrutura.Db;
using miminal.DTOs;
using Microsoft.EntityFrameworkCore;
using miminal.Dominio.Interfaces;
using miminal.Dominio.Servicos;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IAdministradorServico, AdministradorServico>();

builder.Services.AddDbContext<DbContexto>(options => {
    options.UseMySql(
        builder.Configuration.GetConnectionString("mysql"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("mysql"))
    );
});


var app = builder.Build();

app.MapGet("/", () => "Olá Pessoal");

app.MapPost("/login", ([FromBody] LoginDTO loginDTO, IAdministradorServico administradorServico) => {
    if(administradorServico.Login(loginDTO) != null){
        return Results.Ok("Login com Sucesso");
    }
    else{
        return Results.Unauthorized();
    }
});

app.Run();


