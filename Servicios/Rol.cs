using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class Rol : Componente
    {

        public List<Componente> lista_permisos = new List<Componente>();

        public Rol(string Nombre) : base(Nombre)
        {

        }
        public Rol() { }


        public override List<Componente> obtener_lista() { return this.lista_permisos; }

        public override void Agregar(Componente c)
        {
            lista_permisos.Add(c);
        }

        public override void Remover(Componente c)
        {
            foreach (Componente co in lista_permisos)
            {
                if (co.Descripcion == c.Descripcion)
                { lista_permisos.Remove(co); break; }

            }

        }
        public override string Obtener_ID() { return this.ID; }
        public override void grabar_ID(string pID)
        {
            this.ID = pID;
        }

    }
}
