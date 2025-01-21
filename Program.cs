using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore.Infrastructure;
using stock_app.Data;
using stock_app.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<StockRepository>();

builder.Services.AddDbContext<ApplicationDBContext>(options => {
    // options.UseSqlServer(builder.Configuration.GetConnectionString("dbConnectionString"));
    options.UseMySQL(builder.Configuration.GetConnectionString("DefaultConnection"));
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
