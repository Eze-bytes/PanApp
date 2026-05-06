using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace Servicios
{
    public class Permiso : Componente
    {
        public List<Componente> pe = new List<Componente>();

        public Permiso(string Nombre, string pID) : base(Nombre)
        {
            ID = pID;
        }
        
        public Permiso() { }


        public override void Agregar(Componente c)
        {

        }
        public override void Remover(Componente c)
        {

        }

        public override List<Componente> obtener_lista() { return this.pe; }
        public override string Obtener_ID() { return this.ID; }
        public override void grabar_ID(string pID) { this.ID = pID; }
    }
}
