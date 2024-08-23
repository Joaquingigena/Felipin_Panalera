using AutoMapper;
using FelipinPa�alera.Data;
using FelipinPa�alera.Models;
using FelipinPa�alera.Repository;
using FelipinPa�alera.Repository.Interfaces;
using FelipinPa�alera.Services;
using FelipinPa�alera.Services.Interfaces;
using FelipinPa�alera.Utility;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer("name=FelipinConnection"));

//Repositorios
builder.Services.AddScoped<ICategoriaRepository,CategoriaRepository>();
builder.Services.AddScoped<IMarcaRepository, MarcaRepository>();
builder.Services.AddScoped<IUsuarioRepository,UsuarioRepository>();

//Services
builder.Services.AddScoped<ICategoriaService,CategoriaService>();
builder.Services.AddScoped<IMarcaService,MarcaService>();
builder.Services.AddScoped<IUsuarioService,UsuarioService>();

//AutoMapper
var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AllowNullCollections = true;
    mc.ShouldMapMethod = (m => false);//this is solution
    mc.AddProfile(new AutoMapperProfiles());
});

builder.Services.AddAutoMapper(typeof(Program));

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
