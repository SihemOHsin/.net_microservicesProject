using MassTransit;
using Microsoft.CodeAnalysis.FlowAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProductsApi.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ProductsApiContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ProductsApiContext") ?? throw new InvalidOperationException("Connection string 'ProductsApiContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMassTransit(options =>
{
    options.UsingRabbitMq((context, cfg) =>
{
    cfg.Host(new Uri("rabbitmq://localhost:4001"), h =>
    {
        h.Username("guest");
        h.Password("guest");
    });
});

});

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
