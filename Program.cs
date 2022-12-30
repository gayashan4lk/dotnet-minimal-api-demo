using PizzaPie.Models;
using PizzaPie.Persistance;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
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

app.MapGet("/products", () => DataStore.GetPizzas());
app.MapGet("/products/{id}", (int id) => DataStore.GetPizza(id));
app.MapPost("/product", (Pizza pizza) => DataStore.CreatePizza(pizza));
app.MapPut("/product", (Pizza pizza) => DataStore.UpdatePizza(pizza));
app.MapDelete("/products/{id}",(int id) => DataStore.DeletePizza(id));

app.Run();