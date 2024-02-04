namespace PizzaPlaceAP.Shared
{
    public class CarritoCompras
    {
        public Clientes Clientes { get; set; } = new Clientes();
        public List<int> Ordenes { get; set; } = new List<int>();

        public bool HasPagado { get; set; }

        public void Agregar(int pizzaId)=> Ordenes.Add(pizzaId);

        public void EliminarAt(int pos) => Ordenes.RemoveAt(pos);
    }
}
