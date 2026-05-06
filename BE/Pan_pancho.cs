using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Pan_pancho_chico : Panificados
    {
        public Pan_pancho_chico(uint pUnidades)
        {
            Peso = 230;
            Unidades = pUnidades;
            ID_producto = "PPC";
            agregar_descripcion();
        }

        public Pan_pancho_chico(int pNro_lote, uint pUnidades)
        {
            Nro_lote = pNro_lote;
            Peso = 230;
            ID_producto = "PPC";
            Unidades = pUnidades;
            agregar_descripcion();
        }

        public Pan_pancho_chico() { agregar_descripcion(); Peso = 230; ID_producto = "PPC"; }
        public override void agregar_descripcion() { this.Descripcion = "Pan pancho chico"; ID_producto = "PPC"; }

    }


    public class Pan_pancho_maxi : Panificados
    {
        public Pan_pancho_maxi(uint pUnidades)
        {
            Peso = 350;
            Unidades = pUnidades;
            agregar_descripcion();
            ID_producto = "PPM";
        }

        public Pan_pancho_maxi(int pNro_lote, uint pUnidades)
        {
            Nro_lote = pNro_lote;
            Peso = 350;
            ID_producto = "PPM";
            Unidades = pUnidades;
            agregar_descripcion();
        }

        public Pan_pancho_maxi() { agregar_descripcion(); Peso = 350; ID_producto = "PPM"; }

        public override void agregar_descripcion() { this.Descripcion = "Pan pancho maxi"; ID_producto = "PPM"; }

    }

}