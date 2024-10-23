using Datos.Model;
using Servicios;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpLogging(O => { });


var app = builder.Build();

app.MapGet("/specialities", () =>
{
    Servicios.SpecialitiesService specialitiesService = new Servicios.SpecialitiesService();
    return specialitiesService.GetAllSpecialities();
});

app.Run();