global using MagicVilla_VillaAPI.Models;
global using MagicVilla_VillaAPI.Models.Dto;
global using Microsoft.AspNetCore.Mvc;
global using MagicVilla_VillaAPI.Data;
global using System.ComponentModel.DataAnnotations;
global using Microsoft.AspNetCore.JsonPatch;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddNewtonsoftJson(); ;
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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
