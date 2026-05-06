using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;

namespace Presentacion
{
    public partial class Listar_pedidoFRM : Form
    {
        public Listar_pedidoFRM()
        {
            InitializeComponent();
        }
        List<Cliente> Lista_cliente = new List<Cliente>();
        PedidoBLL PedBLL = new PedidoBLL();
      
        List<Pedido> Lista_pedidos = new List<Pedido>();

        public void mostrar_clientes()
        {
            grilla_clientes.DataSource = null;
           
            grilla_clientes.DataSource = Lista_cliente;
        }

        public void mostrar_pedidos_detalle()
        {

            //Cliente Cl = (Cliente)grilla_clientes.SelectedRows[0].DataBoundItem;
            ////grilla_pedidos_detalle.DataSource = null;

            ////grilla_pedidos_detalle.DataSource = PedBLL.obtener_pedidos(Cl);
            //grilla_pedidos.DataSource = null;
            //grilla_pedidos.DataSource = PedBLL.obtener_pedidos_cli(Cl);

        }

       



        private void Listar_pedidoFRM_Load(object sender, EventArgs e)
        {

            mostrar_clientes();

        }

        private void grilla_clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grilla_pedidos.DataSource = null;
            grilla_pedidos_detalle.DataSource = null;
            Cliente Cl = (Cliente)grilla_clientes.SelectedRows[0].DataBoundItem;
            mostrar_pedidos_detalle();
        }

        private void grilla_pedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Pedido Pe = (Pedido)grilla_pedidos.SelectedRows[0].DataBoundItem;
            cargar_grilla_detalle(Pe);
        }
        public void cargar_grilla_detalle(Pedido Pe)
        {

            //grilla_pedidos_detalle.DataSource = null;
            //grilla_pedidos_detalle.DataSource = PedBLL.obtener_pedido_detalle(Pe);


        }

        private void modbtn_Click(object sender, EventArgs e)
        {

        }
    }

}

