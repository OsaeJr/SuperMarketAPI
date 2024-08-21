using Microsoft.EntityFrameworkCore;
using SupermarketAPI.Persistence.Contexts;
using SupermarketAPI.Persistence.Repositories;
using SupermarketAPI.Domain.Repositories;
using SupermarketAPI.Domain.Services;
using SupermarketAPI.Services;
using SupermarketAPI.Mapping;
using AutoMapper;




var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

builder.Services.AddAutoMapper(typeof(ModelToResourceProfile));
// Configure DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Register repositories
builder.Services.AddScoped<ICategoryRespository, CategoryRepository>();

builder.Services.AddScoped<ICategoryService, CategoryService>();

// Add other services
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