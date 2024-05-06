using Application;
using Application.Contracts.Interfaces;
using Infrastructure;
using Infrastructure.Contracts.Implementations;
using Microsoft.EntityFrameworkCore;
using Persistence;
using Persistence.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddApplication();
builder.Services.AddInfrastructure();
builder.Services.AddPersistence();
builder.Services.AddDbContext<ApplicationDbContext>(option=> option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
