using leilao.api.CasosDeUso.Ofertas.CriarOferta;
using leilao.api.Filtros;
using leilao.api.Security;
using leilao.api.Services;
using Microsoft.OpenApi.Models;
using System.Text;
using System.Xml.Linq;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using leilao.api.Interfaces;
using leilao.api.CasosDeUso.Leilao.Atualizar;
using leilao.api.CasosDeUso.Ofertas.GerenciarOfertas;
using leilao.api.CasosDeUso.Usuarios;
using leilao.api.Repositorios;
using leilao.api.Repositorios.AcessoDados;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = @"JWT Authorization header using the Bearer scheme.
                      Enter 'Bearer' [space] and then your token in the text input below;
                      Example: 'Bearer 12345abcdef'",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer",
        BearerFormat = "JWT"
    });

    options.AddSecurityRequirement(new OpenApiSecurityRequirement()
    {
        {
            new OpenApiSecurityScheme()
            {
                Reference = new OpenApiReference()
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] {}
        }
    });
});
var key = Encoding.ASCII.GetBytes(Key.Secret);

builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(x =>
{
    x.RequireHttpsMetadata = false;
    x.SaveToken = true;
    x.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(key),
        ValidateIssuer = false,
        ValidateAudience = false
    };
});

builder.Services.AddScoped<AutenticacaoGenericAtributos>();
builder.Services.AddScoped<AutenticacaoAdminAtributos>();
builder.Services.AddScoped<AuteticacaoUsuarioAtributos>();
builder.Services.AddScoped<UsuarioLogado>();
builder.Services.AddScoped<AtualizarLeilaoCasosDeUso>();
builder.Services.AddScoped<ILeilaoCasosDeUso, LeilaoRepositorio>();
builder.Services.AddScoped<IAtualizarGerenciarOfertasCasosDeUso, AtualizrGerenciarOfertasCasosDeUso>();
builder.Services.AddScoped<IAtualizarUsuariosCasosDeUso, AtualizarUsuariosCasosDeUso>();
builder.Services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();
builder.Services.AddScoped<IOfertas, CriarOfertaRepositorio>();
builder.Services.AddScoped<ICriarOfertaCasosDeUso, CriarOfertaCasosDeUso>();
builder.Services.AddHttpContextAccessor();
builder.Services.AddDbContext<LeilaoDbContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseAuthentication();
app.UseCors(x =>
x.AllowAnyOrigin()
.AllowAnyMethod()
.AllowAnyHeader()
.AllowAnyOrigin());

app.MapControllers();

app.Run();
