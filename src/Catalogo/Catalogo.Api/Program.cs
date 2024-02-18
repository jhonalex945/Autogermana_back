using Catalogo.Api.Data;
using Catalogo.Api.Services;
using Catalogo.Api.Services.DTOs;
using Catalogo.Services.EventHandlers;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var urlCors = builder.Configuration.GetSection("AppSettings:Cors").Value!;

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationDBContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionSQL")));
builder.Services.AddAutoMapper(typeof(AutoMapperProfiles));
builder.Services.AddTransient<IVehiculoQueryService, VehiculoQueryService>();
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(VehiculoCreateCommand).Assembly));
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngularOrigins", builder =>
    {
        builder.WithOrigins(urlCors).AllowAnyHeader().AllowAnyMethod();
    });
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.UseCors("AllowAngularOrigins");

app.Run();
