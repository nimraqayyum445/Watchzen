using Microsoft.EntityFrameworkCore;
using Watchzen.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Configure services
var services = new ServiceCollection();
services.AddDbContext<WatchesDbContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("DevConnection")));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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
