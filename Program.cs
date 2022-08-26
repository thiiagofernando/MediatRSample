using MediatR;
using MediatRSample.Application.Models;
using MediatRSample.Config;
using MediatRSample.Data;
using MediatRSample.Repositories;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors();
builder.Services.AddResponseCompression(
    opt =>
    {
        opt.Providers.Add<GzipCompressionProvider>();
        opt.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(new[] { "application/json" });
    }
 );
builder.Services.AddCors();

builder.Services.AddDbContext<AplicacaoDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
builder.Services.AddScoped<AplicacaoDbContext>();
builder.Services.AddScoped<IRepository<Pessoa>, PessoaRepository>();


//Gerar Documentação do Swagger
var swagger = new SwaggerConfig();
swagger.GerarDocumentacao(builder.Services);

var app = builder.Build();

using var scope = ((IApplicationBuilder)app).ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope();
scope.ServiceProvider.GetRequiredService<AplicacaoDbContext>().Database.Migrate();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();



app.Run();
