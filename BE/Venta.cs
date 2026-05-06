using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Venta
    {
        public decimal Importe_total { get; set; }
        public DateTime Fecha_venta { get; set; }
        public Pedido pr { get; set; }

        public Venta()
        {
            Fecha_venta = DateTime.Now;
        }

        public void Calcular_total(List<Panificados> lista_productos)
        {
            foreach (Panificados p in lista_productos)
            {
                this.Importe_total += (p.Leer_precio() * p.Unidades);
            }
        }

    }
}
