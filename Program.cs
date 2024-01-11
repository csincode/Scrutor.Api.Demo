using Microsoft.AspNetCore.Mvc;
using Scrutor.Api.Demo;
using Scrutor.Api.Demo.Models;
using Scrutor.Api.Demo.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddRepositories();
var app = builder.Build();

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapGet("/houses/{id:int}", async (int id, [FromServices] IRepository<House> repository) => 
{
    var house = await repository.GetByIdAsync(id);
    return house is null ? Results.NotFound() : Results.Ok(house);
});

app.MapGet("/people/{id:int}", async (int id, [FromServices] IRepository<Person> repository) => 
{
    var person = await repository.GetByIdAsync(id);
    return person is null ? Results.NotFound() : Results.Ok(person);
});

app.MapGet("/cars/{id:int}", async (int id, [FromServices] IRepository<Car> repository) => 
{
    var car = await repository.GetByIdAsync(id);
    return car is null ? Results.NotFound() : Results.Ok(car);
});

app.Run();