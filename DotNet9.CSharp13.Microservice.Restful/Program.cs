/**
 *  Program.cs
 * 
 *  Author   Hume Cristian
 *  Version  1.0.0
 *  Created  2024-11-18
 *  Modified 2024-11-18
 */
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();

