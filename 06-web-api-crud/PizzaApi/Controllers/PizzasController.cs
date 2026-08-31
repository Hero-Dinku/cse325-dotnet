using Microsoft.AspNetCore.Mvc;
using PizzaApi.Models;

namespace PizzaApi.Controllers;

[ApiController]
[Route("[controller]")]
public class PizzasController : ControllerBase
{
    static List<Pizza> Pizzas { get; } = new()
    {
        new Pizza { Id = 1, Name = "Cheese", IsGlutenFree = false },
        new Pizza { Id = 2, Name = "Pepperoni", IsGlutenFree = false },
        new Pizza { Id = 3, Name = "Hawaiian", IsGlutenFree = true }
    };

    [HttpGet]
    public IEnumerable<Pizza> GetAll() => Pizzas;

    [HttpGet("{id}")]
    public ActionResult<Pizza> Get(int id)
    {
        var pizza = Pizzas.FirstOrDefault(p => p.Id == id);
        if (pizza is null) return NotFound();
        return pizza;
    }

    [HttpPost]
    public ActionResult<Pizza> Create(Pizza pizza)
    {
        pizza.Id = Pizzas.Count > 0 ? Pizzas.Max(p => p.Id) + 1 : 1;
        Pizzas.Add(pizza);
        return CreatedAtAction(nameof(Get), new { id = pizza.Id }, pizza);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, Pizza updatedPizza)
    {
        var pizza = Pizzas.FirstOrDefault(p => p.Id == id);
        if (pizza is null) return NotFound();

        pizza.Name = updatedPizza.Name;
        pizza.IsGlutenFree = updatedPizza.IsGlutenFree;
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var pizza = Pizzas.FirstOrDefault(p => p.Id == id);
        if (pizza is null) return NotFound();

        Pizzas.Remove(pizza);
        return NoContent();
    }
}
