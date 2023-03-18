using Microsoft.EntityFrameworkCore;
using TheatreAPI.BusinessLogic;
using TheatreAPI.IBusinessLogic;
using TheatreAPI.Models;
using TheatreAPI.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<AppDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IActorRepository, ActorRepository>();
builder.Services.AddScoped<IPlayTypeRepository, PlayTypeRepository>();
builder.Services.AddScoped<IPlayRepository, PlayRepository>();

builder.Services.AddScoped<IUserBL, UserBL>();
builder.Services.AddScoped<IActorBL, ActorBL>();
builder.Services.AddScoped<IPlayTypeBL, PlayTypeBL>();
builder.Services.AddScoped<IPlayBL, PlayBL>();
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
