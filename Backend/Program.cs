using Backend.DataContext;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// =======================
// DB CONTEXT (AZURE OK)
// =======================
string? cadenaConexion = builder.Configuration.GetConnectionString("mysqlRemote");

builder.Services.AddDbContext<MusicCoreContext>(options =>
    options.UseMySql(
        cadenaConexion,
        ServerVersion.AutoDetect(cadenaConexion),
        mysqlOptions => mysqlOptions.EnableRetryOnFailure(
            maxRetryCount: 5,
            maxRetryDelay: TimeSpan.FromSeconds(30),
            errorNumbersToAdd: null)
    )
);

// =======================
// CONTROLLERS + JSON
// =======================
builder.Services.AddControllers()
    .AddJsonOptions(x =>
        x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

// =======================
// SWAGGER
// =======================
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// =======================
// CORS
// =======================
builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy", policy =>
    {
        policy
            .WithOrigins(
                "https://webmusicore.azurewebsites.net",
                "https://localhost:8000"
            )
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

var app = builder.Build();

// =======================
// PIPELINE (ORDEN CLAVE)
// =======================

app.UseHttpsRedirection();

app.UseCors("CorsPolicy");

app.UseAuthorization();

app.MapControllers();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.Run();




//using Backend.DataContext;
//using Microsoft.EntityFrameworkCore;
//using System.Text.Json.Serialization;


//var builder = WebApplication.CreateBuilder(args);

//var configuration = new ConfigurationBuilder()
//.AddJsonFile("appsettings.json")
//.Build();
//string? cadenaConexion = configuration.GetConnectionString("mysqlRemote");

////configuración de inyección de dependencias del DBContextdotnet dev-certs https --trust

//builder.Services.AddDbContext<MusicCoreContext>(
//    options => options.UseMySql(cadenaConexion,
//                                ServerVersion.AutoDetect(cadenaConexion),
//                    options => options.EnableRetryOnFailure(
//                                        maxRetryCount: 5,
//                                        maxRetryDelay: System.TimeSpan.FromSeconds(30),
//                                       errorNumbersToAdd: null)
//                                ));

//// Add services to the container.

//builder.Services.AddControllers()
//    .AddJsonOptions(x =>
//        x.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles);
//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

//// Configurar una política de CORS
//builder.Services.AddCors(options =>
//{
//    options.AddPolicy("AllowSpecificOrigins",
//        builder => builder
//            .WithOrigins("https://localhost:8000", "https://webmusicore.azurewebsites.net")
//            .AllowAnyHeader()
//            .AllowAnyMethod());
//});

//var app = builder.Build();

//app.UseCors("AllowSpecificOrigins");

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();

//app.Run();
