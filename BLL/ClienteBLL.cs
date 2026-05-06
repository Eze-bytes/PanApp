using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mapper;
using BE;


namespace BLL
{
    public class ClienteBLL
    {
        ClienteMP Cmp = new ClienteMP();

        public void Alta_clienteBLL(Cliente C)
        {
            Cmp.Alta_clienteMpp(C);
        }

        public List<Cliente> Lista_clientesBLL() { return Cmp.Listado_clientes(); }

        public void Borrar_cliente(uint D) { Cmp.Borrar_clienteMpp(D); }
    
        public void Modificar_cliente(Cliente C) { Cmp.Modificar_clienteMpp(C); }

        public bool Buscar_DNI(uint pDNI) { return Cmp.BuscarDNI(pDNI); }

        public bool Checkear_cliente_para_borrar(uint DNI) { return Cmp.Checkear_cliente_para_borrar(DNI); }
    }
}
