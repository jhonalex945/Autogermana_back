using Cliente.Api.Data;
using Cliente.Api.Services;
using Cliente.Services.EventHandlers;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationDBContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionSQL")));
builder.Services.AddTransient<IClienteQueryService, ClienteQueryService>();
builder.Services.AddAutoMapper(typeof(AutoMapperProfiles));
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(ClienteCreateCommand).Assembly));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
