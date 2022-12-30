using PizzaPie.Models;

namespace PizzaPie.Persistance
{
    public class DataStore
    {
        private static List<Pizza> Pizzas = Enumerable.Range(0, 5).Select(i => new Pizza
        {
            Id = i,
            Name = $"Delicious Pizza No: {i}",
            Price = i * 50 + 250,
        }).ToList();

        public static List<Pizza> GetPizzas()
        {
            return Pizzas;
        }

        public static Pizza ? GetPizza(int id)
        {
            return Pizzas.SingleOrDefault(p => p.Id == id);
        }

        public static Pizza CreatePizza(Pizza pizza)
        {
            Pizzas.Add(pizza);
            return pizza;
        }

        public static Pizza UpdatePizza(Pizza pizza)
        {
            Pizzas = Pizzas.Select(p =>
            {
                if ( p.Id == pizza.Id)
                {
                    p.Name = pizza.Name;
                    p.Price = pizza.Price;
                }
                return p;
            }).ToList();
            return pizza;
        }

        public static void DeletePizza(int id)
        {
            Pizzas = Pizzas.FindAll(p => p.Id != id).ToList();
        }
    }
}
