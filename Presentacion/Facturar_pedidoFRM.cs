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
    public partial class Facturar_pedidoFRM : Form
    {
        public Facturar_pedidoFRM()
        {
            InitializeComponent();
        }
        public List<Cliente> Lista_clientes = new List<Cliente>();
        public List<Pedido> Lista_pedidos = new List<Pedido>();
        ClienteBLL CliB = new ClienteBLL();
        PedidoBLL PeB = new PedidoBLL();
        LotesBLL LoB = new LotesBLL();
        VentaBLL vBLL = new VentaBLL();
        PreciosBLL pBLL = new PreciosBLL();
        public void cargar_clientes()
        {
            Lista_clientes = CliB.Lista_clientesBLL();
            grillaclientes.DataSource = null;
            grillaclientes.DataSource = Lista_clientes;
        }

        public void cargar_pedidos(Cliente C)
        {
            try
            {
                Lista_pedidos = PeB.lista_pedidos_cliente(C);
                grilla_pedidos.DataSource = null;
                grilla_pedidos.DataSource = Lista_pedidos;

            }
            catch { }
        }

        private void grillaclientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                Cliente C = (Cliente)grillaclientes.CurrentRow.DataBoundItem;
                cargar_pedidos(C);

            }

            catch { }
        }

        private void Facturar_pedidoFRM_Load(object sender, EventArgs e)
        {
            this.Owner.Enabled = false; 
            cargar_clientes();
            grillaclientes_CellClick(null, null);
        }

        private void facturarbtn_Click(object sender, EventArgs e)
        {
          try  {
                Pedido Pe = (Pedido)grilla_pedidos.CurrentRow.DataBoundItem;
                var resultado = MessageBox.Show("Se facturara el pedido nro:" + Pe.Nro_pedido, "Facturar",
                                           MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    if (Pe.Estado == "Confirmado")
                    {

                        List<Panificados> Lista_productos_pedido = Pe.retorna_lista_panificados();
                        pBLL.Asignar_precios(Pe.retorna_lista_panificados());

                        PeB.Facturar_pedido(Pe);
                        Venta V = new Venta();
                        V.pr = Pe;
                        V.Calcular_total(Pe.retorna_lista_panificados());
                        vBLL.Agregar_venta(V);
                        MessageBox.Show("Pedido facturado correctamente, se imprime a continuacion el resumen del mismo");
                        
                        Resumen_pedido_facturadoFRM f = new Resumen_pedido_facturadoFRM(V);
                        f.Owner = this;

                        f.Show();
                    }
                    else
                    {
                        MessageBox.Show("Error: solo se pueden facturar pedidos que esten en estado confirmado");

                    }

                }
            }
            catch{ }
        }

        private void Facturar_pedidoFRM_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Enabled = true;
        }
    }
}
