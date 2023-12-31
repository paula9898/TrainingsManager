using Microsoft.EntityFrameworkCore;
using TrainingsManager.Backend.Application.HashingPasswordService;
using TrainingsManager.Backend.EntityFramework.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("TrainingsManagerDbConnectionString");
builder.Services.AddDbContext<TrainingsManagerDbContext>(options =>
{
    options.UseSqlServer(connectionString);
});

builder.Services.AddScoped<IHashPasswordService, HashPasswordService>();//obiket tej klasy b?dzie utworzony, a po lewej to co w ko struktorze
builder.Services.AddScoped<ITrainingsManagerDbContext, TrainingsManagerDbContext>();

builder.Services.AddControllers();
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
