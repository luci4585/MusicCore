using Backend.DataContext;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;


var builder = WebApplication.CreateBuilder(args);

var configuration = new ConfigurationBuilder()
.AddJsonFile("appsettings.json")
.Build();
string? cadenaConexion = configuration.GetConnectionString("mysqlRemote");

//configuración de inyección de dependencias del DBContextdotnet dev-certs https --trust

builder.Services.AddDbContext<MusicCoreContext>(
    options => options.UseMySql(cadenaConexion,
                                ServerVersion.AutoDetect(cadenaConexion),
                    options => options.EnableRetryOnFailure(
                                        maxRetryCount: 5,
                                        maxRetryDelay: System.TimeSpan.FromSeconds(30),
                                       errorNumbersToAdd: null)
                                ));

// Add services to the container.

builder.Services.AddControllers()
    .AddJsonOptions(x =>
        x.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configurar una política de CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigins",
        builder => builder
            .WithOrigins("https://localhost:8000", "https://webmusiccore-b5hxg2d2ftere0a3.brazilsouth-01.azurewebsites.net")
            .AllowAnyHeader()
            .AllowAnyMethod());
});

var app = builder.Build();

app.UseCors("AllowSpecificOrigins");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseCors("AllowSpecificOrigins");

app.Run();
