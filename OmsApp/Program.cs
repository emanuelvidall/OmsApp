using Microsoft.EntityFrameworkCore;
using OmsApp.Repositories.OrderRepository;
using OmsApp.Services;
using OmsApp.Services.OrderService;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"), 
        new MySqlServerVersion(new Version(9, 1, 0))));
builder.Services.AddControllers();

builder.Services.AddScoped<IOrderStatusService, OrderStatusService>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IOrderService, OrderService>();

var app = builder.Build();

app.MapControllers();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();