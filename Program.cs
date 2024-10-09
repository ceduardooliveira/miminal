var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Olá Pessoal");

app.MapPost("/login", (miminal.DTOs.LoginDTO loginDTO) => {
    if(loginDTO.Email == "adm@teste.com" && loginDTO.Senha == "123456"){
        return Results.Ok("Login com Sucesso");
    }
    else{
        return Results.Unauthorized();
    }
});

app.Run();


