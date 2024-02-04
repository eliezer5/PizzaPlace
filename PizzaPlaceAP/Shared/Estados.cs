namespace PizzaPlaceAP.Shared
{
    public class Estados
    {
        public Menus Menu { get; } = new Menus();
        public CarritoCompras CarritoCompras { get; } = new CarritoCompras();
        public UI UI { get; set; } = new UI();

        public decimal PrecioTotal => CarritoCompras.Ordenes.Sum(id => Menu.GetPizza(id)!.precio);
    }
}
