using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class Bitacora
    {
        public uint ID_usuario { get; set; }
        public string Nombre_usuario { get; set; }
        public string Tipo_de_movimiento { get; set; }  ///BACKUP o RESTAURACION
        public DateTime Fecha { get; set; }
        public string Nombre_de_archivo { get; set; }
        public string Ruta { get; set; }

        public Bitacora(uint pID_usuario, string pNombre_usuario, string pMovimiento)
        {
            ID_usuario = pID_usuario;
            Nombre_usuario = pNombre_usuario;
            Tipo_de_movimiento = pMovimiento;
            Fecha = DateTime.Now;
        }
        public Bitacora() { Fecha = DateTime.Now; }

    }
}
