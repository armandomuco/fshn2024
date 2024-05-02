using Microsoft.EntityFrameworkCore;
using BankApi;
using BankApi.Services;
using System.Security.Cryptography;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connString = "Data Source=DESKTOP-DJAH8K8\\MSSQLSERVER03;Initial Catalog=bank-db;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True";

builder.Services
    .AddDbContext<AppDbContext>(o => o.UseSqlServer(connString));

builder.Services.AddScoped<IBankService, BankService>();
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
