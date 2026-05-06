using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using Mapper;

namespace BLL
{
    public class PedidoBLL
    {
        PedidoMP PeM = new PedidoMP();
        public void grabar_pedido(Pedido Pe)
        {
            PeM.grabar_pedido(Pe, true);
        }

        public List<Pedido> lista_pedidos_cliente(Cliente C)
        {
            return PeM.Listar_pedidos_por_cliente(C);
        }
        public void modificar_pedido(Pedido Pe) { PeM.Modificar_pedido(Pe); }
        public void Confirmar_pedido(Pedido Pe) { PeM.Confirmar_pedido(Pe); }
        public void Anular_pedido(Pedido Pe) { PeM.Anular_pedido(Pe); }
        public void Facturar_pedido(Pedido Pe) { PeM.Facturar_pedido(Pe); }
    }
}
