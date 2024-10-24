using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpLogging(O => { });
builder.Services.AddControllers(); // Add this line to register controllers
builder.Services.AddScoped<Servicios.SpecialitiesService>();
builder.Services.AddScoped<Servicios.PlansService>();
builder.Services.AddScoped<Servicios.ComissionsService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => { 
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
    c.RoutePrefix = string.Empty;
});
}


app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
