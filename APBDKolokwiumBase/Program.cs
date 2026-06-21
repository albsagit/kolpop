using APBDKolokwiumBase.Data;
using APBDKolokwiumBase.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<DatabaseContext>(options =>
{
    var connectionString =
        builder.Configuration.GetConnectionString("Default")
        ?? throw new InvalidOperationException("Missing connection string: Default");

    options.UseSqlite(connectionString);
});

builder.Services.AddScoped<IDbService, DbService>();

var app = builder.Build();

app.MapControllers();

app.Run();
