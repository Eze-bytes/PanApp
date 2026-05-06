using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using Mapper;

namespace BLL
{
    public class VentaBLL
    {
        VentaMP Vmp = new VentaMP();
        public void Agregar_venta(Venta Ve) { Vmp.Agregar_venta(Ve); }
        public decimal[] Graficar_x_intervalo(DateTime inicio, DateTime fin, bool porcentaje) { return Vmp.Graficar_x_intervalo(inicio, fin, porcentaje); }
        public decimal[] Graficar_x_intervalo_unidades(DateTime inicio, DateTime fin, bool porcentaje) { return Vmp.Graficar_x_intervalo_unidades(inicio, fin, porcentaje); }

    }
}
