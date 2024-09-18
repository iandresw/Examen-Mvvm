using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Mvvm.Models
{
    public class DescuentoModel
    {
        public decimal Producto1 { get; set; }
        public decimal Producto2 { get; set; }
        public decimal Producto3 { get; set; }
        public decimal Subtotal => Producto1 + Producto2 + Producto3;
        public decimal Descuento => CalcularDescuento(Subtotal);
        public decimal Total => Subtotal - Descuento;

        private decimal CalcularDescuento(decimal subtotal)
        {
            if (subtotal >= 10000)
                return subtotal * 0.30m;
            if (subtotal >= 5000)
                return subtotal * 0.20m;
            if (subtotal >= 1000)
                return subtotal * 0.10m;
            return 0;
        }
    }

}
