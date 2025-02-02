using Microsoft.EntityFrameworkCore;
using BaseApi.Models;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

string? cadena = builder.Configuration.GetConnectionString("MySqlConnection") ?? "otracadena" ;
builder.Services.AddControllers();
builder.Services.AddDbContext<Conexiones>(opt => opt.UseMySQL(cadena));

builder.Services.AddEndpointsApiExplorer();
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
