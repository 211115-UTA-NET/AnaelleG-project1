using Farmer.Api.App.UI;
using Farmer.Api.Repository;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

string connectionString = await File.ReadAllTextAsync("C:/Users/15612/Revature-files/Project1ConnectionString/Project1SQLConnectionString.txt");


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<ICustomer>(sp => new CustomerAsyncAwait(connectionString));
//builder.Services.AddSingleton<IOrder>(sp => new CustomerAsyncAwait(connectionString));

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