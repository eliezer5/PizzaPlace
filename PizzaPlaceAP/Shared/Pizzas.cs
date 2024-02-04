namespace PizzaPlaceAP.Shared
{
    public class Pizzas
    {
        public Pizzas(int id, string Nombre, decimal precio, Picantes picantes)
        {
            Id = id;
            nombre = Nombre;
            this.precio = precio;
            Picantes = picantes;
        }

        public int Id { get; }
        public string nombre { get; }
        public decimal precio { get; }
        public Picantes Picantes { get; }



    }
}
