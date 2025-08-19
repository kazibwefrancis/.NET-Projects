using GameStore.Api.Endpoints;
using GameStore.Api.Data; // databse
using Microsoft.EntityFrameworkCore; // MariaDB connection

var builder = WebApplication.CreateBuilder(args);


// Getting my mariadb connection string from appsettings.json
var connString = builder.Configuration.GetConnectionString("DefaultConnection");

// Registering the DbContext with MariaDB
builder.Services.AddDbContext<GameStoreContext>(options =>
    options.UseMySql(connString, ServerVersion.AutoDetect(connString)));

var app = builder.Build();

app.MapGamesEndpoints();
app.MapGenresEndpoints();

await app.MigrateDbAsync();

app.Run();
