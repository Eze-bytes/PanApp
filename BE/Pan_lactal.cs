using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Pan_lactal_chico : Panificados
    {

        public Pan_lactal_chico(uint pUnidades)
        {
            Peso = 300;
            Unidades = pUnidades;
            agregar_descripcion();
        }

        public Pan_lactal_chico(int pNro_lote, uint pUnidades)
        {
            Nro_lote = pNro_lote;
            Peso = 300;
            Unidades = pUnidades;
            ID_producto = "PLC";
            agregar_descripcion();
        }
        public Pan_lactal_chico() { agregar_descripcion(); Peso = 300; ID_producto = "PLC"; }

        public override void agregar_descripcion() { this.Descripcion = "Pan lactal chico"; ID_producto = "PLC"; }
    }

    public class Pan_lactal_grande : Panificados
    {

        public Pan_lactal_grande(uint pUnidades)
        {
            Peso = 600;
            ID_producto = "PLG";
            Unidades = pUnidades;
            agregar_descripcion();
        }

        public Pan_lactal_grande(int pNro_lote, uint pUnidades)
        {
            Nro_lote = pNro_lote;
            Peso = 600;
            Unidades = pUnidades;
            agregar_descripcion();
        }
        public Pan_lactal_grande() { agregar_descripcion(); Peso = 600; ID_producto = "PLG"; }
        public override void agregar_descripcion() { this.Descripcion = "Pan lactal grande"; ID_producto = "PLG"; }

    }

}
