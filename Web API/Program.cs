using Datos;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using System.Text.Json.Serialization;

string jwtSecret = Environment.GetEnvironmentVariable("JWT_SECRET")!;

var builder = WebApplication.CreateBuilder(args);

// implement local settings
if (builder.Environment.IsDevelopment()) {
    // Cargar configuración de appsettings.Local.json si existe
    builder.Configuration.AddJsonFile("appsettings.Local.json", optional: true, reloadOnChange: true);
}

string connectionString = builder.Configuration.GetConnectionString("DefaultConnection")!;

builder.Services.AddDbContext<Context>(
    options => options.UseSqlServer(connectionString)
);

// exclude repeated references that cause a loop
builder.Services.AddControllers()
    .AddJsonOptions(options => {
        options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
        options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
    });

builder.Services.AddHttpLogging(o => { });
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerGen(c => {
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "API Academica", Version = "v1" });
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme {
        In = ParameterLocation.Header,
        Description = "Por favor ingrese el token JWT con el prefijo 'Bearer '",
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] {}
        }
    });
});

#region auth
builder.Services.AddAuthorization(options => {
    options.AddPolicy("Admin", policy =>
        policy.RequireClaim("TipoPersona", "Admin"));
    options.AddPolicy("Profesor", policy =>
        policy.RequireClaim("TipoPersona", "Profesor"));
    options.AddPolicy("Alumno", policy =>
        policy.RequireClaim("TipoPersona", "Alumno"));
});
builder.Services.AddAuthentication("Bearer").AddJwtBearer(opt => {
    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSecret));
    var keyCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);
    opt.RequireHttpsMetadata = false;
    opt.TokenValidationParameters = new TokenValidationParameters {
        ValidateIssuer = false,
        ValidateAudience = false,
        IssuerSigningKey = key
    };
});
#endregion

var app = builder.Build();

if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI(c => {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "API Academica");
    });
    app.UseHttpLogging();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();