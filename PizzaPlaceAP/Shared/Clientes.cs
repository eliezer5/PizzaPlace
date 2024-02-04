using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace PizzaPlaceAP.Shared
{
    public class Clientes
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Por favor escribe un nombre")]

        public string Nombre { get; set; }
        [Required(ErrorMessage = "Proporcione una calle con el número de casa.")]
        public string Calle { get; set; }
        [Required(ErrorMessage = "Por favor proporcione una ciudad")]
        public string Ciudad { get; set;}
    }

    public static class DebuggingExtensions
    {
        private static JsonSerializerOptions options = new
JsonSerializerOptions
        { WriteIndented = true };
        public static string ToJson(this object obj)
        => JsonSerializer.Serialize(obj, options);
    }
}
