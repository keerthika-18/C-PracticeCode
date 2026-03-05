using APIPractice2.Data;
using APIPractice2.Repository;
using Microsoft.EntityFrameworkCore;
using APIPractice2.Interface;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IEmployee,EmployeeRepository>();
builder.Services.AddScoped<DataContext>();
builder.Services.AddScoped<IDepartment,DepartmentRepository>();
builder.Services.AddDbContext<DataContext>(
   Options=>Options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
    );
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
//builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipel
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
