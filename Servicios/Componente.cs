using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Servicios
{
    public abstract class Componente
    {
        public  string Descripcion { get; set; }        
        public  string ID { get; set; }
        public Componente(string pNombre)
        {
            this.Descripcion = pNombre;
        }

        public Componente() { }

        public abstract List<Componente> obtener_lista();
        public abstract void grabar_ID(string pID);
        public abstract void Agregar(Componente c);
        public abstract void Remover(Componente c);
        public abstract string Obtener_ID();

    }
}
