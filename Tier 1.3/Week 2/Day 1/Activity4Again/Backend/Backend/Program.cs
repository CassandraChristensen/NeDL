using Backend;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configure the database context service.
builder.Services.AddDbContext<ShoppingDatabase>(options =>
    options.UseSqlServer("Server=(local); Integrated Security=true; Database=Shopping"));

builder.Services.AddCors();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(x =>
x.AllowAnyMethod()
.AllowAnyOrigin()
.AllowAnyHeader()
.SetIsOriginAllowed(origin => true));

app.UseAuthorization();

app.MapControllers();

app.Run();
