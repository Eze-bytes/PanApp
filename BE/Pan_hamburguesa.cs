using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Pan_hamburguesa_comun : Panificados
    {
        public Pan_hamburguesa_comun(uint pUnidades)
        {
            Peso = 200;
            Unidades = pUnidades;
            agregar_descripcion();
            ID_producto = "PHC";
        }

        public Pan_hamburguesa_comun() { agregar_descripcion(); Peso = 200; }

        public Pan_hamburguesa_comun(int pNro_lote, uint pUnidades)
        {
            Nro_lote = pNro_lote;
            Peso = 200;
            Unidades = pUnidades;
            ID_producto = "PHC";
            agregar_descripcion();
        }


        public override void agregar_descripcion() { this.Descripcion = "Pan hamburguesa chico"; ID_producto = "PHC"; }
    }

    public class Pan_hamburguesa_maxi : Panificados
    {

        public Pan_hamburguesa_maxi(int pNro_lote, uint pUnidades)
        {
            Nro_lote = pNro_lote;
            Peso = 320;
            Unidades = pUnidades;
            ID_producto = "PHM";
            agregar_descripcion();
        }

        public Pan_hamburguesa_maxi(uint pUnidades)
        {
            Peso = 320;
            Unidades = pUnidades;
            agregar_descripcion();
        }
        public Pan_hamburguesa_maxi() { agregar_descripcion(); Peso = 320; ID_producto = "PHM"; }

        public override void agregar_descripcion() { this.Descripcion = "Pan hamburguesa maxi"; ID_producto = "PHM"; }
    }

}