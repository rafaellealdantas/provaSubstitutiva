using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API. Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDataContext>();
var app = builder.Build();

app.MapGet("/", () => "Prova Substitutiva com consulta");
// cadastrar aluno
app.MapPost("pages/aluno/cadastrar",  ([FromBody]Aluno aluno, [FromServices] AppDataContext ctx) =>
{    
    ctx.Alunos.Add(aluno);    
    ctx.SaveChanges();
    return Results.Created($"/produto/{aluno.AlunoId}", aluno);
});
// cadastrar imc
app.MapPost("pages/imc/cadastrar",  ([FromBody]Imc imc, [FromServices] AppDataContext ctx) =>
{
    imc.CalcularImc();
    ctx.Imcs.Add(imc);    
    ctx.SaveChanges();
    return Results.Created($"/produto/{imc.ImcId}", imc);
});
// listar imc
app.MapGet("pages/imc/listar",([FromServices] AppDataContext ctx) =>
{    
    return Results.Ok(ctx.Imcs.ToList());
});

app.Run();
