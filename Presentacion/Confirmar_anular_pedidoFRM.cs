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
    public partial class Confirmar_anular_pedidoFRM : Form
    {
        public Confirmar_anular_pedidoFRM()
        {
            InitializeComponent();
        }
        public List<Cliente> Lista_clientes = new List<Cliente>();
        public List<Pedido> Lista_pedidos = new List<Pedido>();


        ClienteBLL CliB = new ClienteBLL();
        PedidoBLL PeB = new PedidoBLL();
        LotesBLL LoB = new LotesBLL();
        public void cargar_pedidos(Cliente C)
        {
            try
            {
                Lista_pedidos = PeB.lista_pedidos_cliente(C);
                grilla_pedidos.DataSource = null;
                grilla_pedidos.DataSource = Lista_pedidos;
                Pedido Pe = (Pedido)grilla_pedidos.CurrentRow.DataBoundItem;

            }
            catch { }
        }
        public void cargar_clientes()
        {
            Lista_clientes = CliB.Lista_clientesBLL();
            grillaclientes.DataSource = null;
            grillaclientes.DataSource = Lista_clientes;
        }
        private void confirmarbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Pedido P = (Pedido)grilla_pedidos.CurrentRow.DataBoundItem;
                switch (P.Estado)
                {
                    case "Anulado":
                        { MessageBox.Show("El pedido no se puede confirmar, se encuentra anulado"); }
                        break;
                    case "Facturado":
                        { MessageBox.Show("El pedido no se puede confirmar, se encuentra facturado"); }
                        break;

                    case "No confirmado":
                        {
                            var resultado = MessageBox.Show("Se confirmara el pedido nro: " + P.Nro_pedido, "Pedido",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);

                            if (resultado == DialogResult.Yes)
                            {
                                PeB.Confirmar_pedido(P);
                                P.Estado = "Confirmado";
                                Confirmar_anular_pedidoFRM_Load(null, null);
                                MessageBox.Show("Pedido confirmado exitosamente");
                            }
                        }
                        break;
                }
            }


            catch { MessageBox.Show("Error al confirmar el pedido"); }
        }

        private void anularbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Pedido Ped = (Pedido)grilla_pedidos.CurrentRow.DataBoundItem;
                switch (Ped.Estado)
                {
                    case "Anulado":
                        { MessageBox.Show("El pedido ya se encuentra anulado"); }
                        break;

                    case "Facturado":
                        { MessageBox.Show("El pedido no se puede anular, se encuentra facturado"); }
                        break;

                    case "Confirmado":
                        {
                            anular_pedido(Ped);
                            break;
                        }

                    case "No confirmado":
                        {
                            anular_pedido(Ped);
                            break;
                        }
                        
                }
            }
            catch { MessageBox.Show("Error al anular el pedido"); }


        }

        private void Confirmar_anular_pedidoFRM_Load(object sender, EventArgs e)
        {
            cargar_clientes();
            grillaclientes_CellClick(null, null);
        }




        public void anular_pedido(Pedido Ped)
        {
            var resultado = MessageBox.Show("Se anulara el pedido nro: " + Ped.Nro_pedido, "Pedido",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)

            {
                LotesBLL Nl = new LotesBLL();
                List<Lote> Lista_lotes = new List<Lote>();
                Lista_lotes = Nl.Retorna_listado_de_lotes();
                foreach (Lote L in Lista_lotes)                            /// cargo el stock de cada lote
                {
                    Nl.Detalle_de_lote(L);
                }

                foreach (Lote L in Lista_lotes)                            // al anular el pedido vuelve el stock a la bd
                {
                    foreach (Panificados Pa in Ped.retorna_lista_panificados())
                    {
                        if (Pa.Nro_lote == L.Nro_lote)
                        {
                            foreach (Panificados Pa_stock in L.retorna_panificados())
                            {
                                if (Pa.GetType() == Pa_stock.GetType())
                                {
                                    Pa_stock.Unidades += Pa.Unidades;
                                }
                            }
                        }
                    }
                }

                foreach (Lote L in Lista_lotes)
                {
                    LoB.modificar_stock(L.retorna_panificados());
                }

                PeB.Anular_pedido(Ped);
                Confirmar_anular_pedidoFRM_Load(null, null);
                MessageBox.Show("Pedido anulado exitosamente");
            }

        }
        private void grillaclientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Cliente C = (Cliente)grillaclientes.CurrentRow.DataBoundItem;
            cargar_pedidos(C);
        }
    }
}
