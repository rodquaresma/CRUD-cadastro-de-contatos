using ControleDeContatos;
using Microsoft.AspNetCore.Hosting;

var builder = WebApplication.CreateBuilder(args);

var startup = new Startup(builder.Configuration);
startup.ConfigureServices(builder.Services);

builder.Services.AddControllersWithViews();

var app = builder.Build();

startup.Configure(app, app.Environment);
app.Run();
