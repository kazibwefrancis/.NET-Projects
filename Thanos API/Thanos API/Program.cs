

using Thanos_API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Register SmartlifeDbContext (replace UseSqlServer with UseOracle if using Oracle)
builder.Services.AddDbContext<SmartlifeDbContext>(options =>
    options.UseOracle(builder.Configuration.GetConnectionString("SmartlifeDb"))
);

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
