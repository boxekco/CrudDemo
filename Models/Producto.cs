using System.ComponentModel.DataAnnotations;

namespace cruddemo.Models
{
    public class Producto
    {
        public int Id { get; set; }

        public string? Nombre { get; set; }

        public Decimal Precio { get; set; }


    }
}
