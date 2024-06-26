using Microsoft.EntityFrameworkCore;
using StudentAPI.Application.Repositories;
using StudentAPI.Infrascture;
using StudentAPI.Infrascture.Repositories;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<StudentDbContext>(
    op=> op.UseNpgsql(
        configuration.GetConnectionString("DefaultConnection"),
        b=>b.MigrationsAssembly(typeof(StudentDbContext).Assembly.GetName().Name)));


builder.Services.AddScoped<IStudentRepository, StudentRepository>();
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