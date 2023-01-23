using System.ComponentModel.DataAnnotations;

namespace cruddemo.Models
{
    public class Factura
    {
        public int Id { get; set; } 

        //public Cliente Cliente { get; set; }

        public DateTime FechaFactura { get; set; }


    }
}
