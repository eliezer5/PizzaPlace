namespace PizzaPlaceAP.Shared
{
    public class Menus
    {
        public List<Pizzas> Pizzas { get; set; } = new List<Pizzas>();

        public void Agregar(Pizzas pizza) => Pizzas.Add(pizza);
        public Pizzas? GetPizza (int id) => Pizzas.FirstOrDefault(pizza => pizza.Id == id);
    }
}
