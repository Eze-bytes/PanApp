using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BE;

namespace Presentacion
{
    public partial class Pedido_detalleFRM : Form
    {
        public PedidoBLL PeB = new PedidoBLL();
        public LotesBLL Nl = new LotesBLL();

        public List<Lote> Lista_lotes = new List<Lote>();         ///lista stock
        public Pedido Pe = new Pedido();                          ///pedido
        public Cliente C;



        public Pedido_detalleFRM(Cliente Cli)    ///Nuevo pedido
        {
            InitializeComponent();
            C = Cli;
            label6.Hide();
            nropedidotxt.Hide();
            modpedidobtn.Hide();
        }

        public Pedido_detalleFRM(Pedido Ped)      ///Modificar pedido
        {
            InitializeComponent();
            Pe = Ped;
            grabarpedidobtn.Hide();
            nropedidotxt.Text = Convert.ToString(Pe.Nro_pedido);
            grilla_pedido.DataSource = null;
            grilla_pedido.DataSource = Pe.retorna_lista_panificados();
        }



        private void Pedido_detalleFRM_Load(object sender, EventArgs e)
        {


            Lista_lotes = Nl.Retorna_listado_de_lotes();


            foreach (Lote L in Lista_lotes)                            /// cargo el stock de cada lote
            {
                combolotes.Items.Add(Convert.ToString(L.Nro_lote));
                Nl.Detalle_de_lote(L);
            }

            combolotes.SelectedIndex = 0;
            combolotes_SelectionChangeCommitted(null, null);
        }

        private void combolotes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            foreach (Lote L in Lista_lotes)
            {
                if (L.Nro_lote == Convert.ToInt32(combolotes.SelectedItem))
                {
                    actualizar_grilla_lote(L);
                    break;
                }
            }
        }

        public void actualizar_grilla_lote(Lote L)
        {
            grilla_lote.DataSource = null;
            grilla_lote.DataSource = L.retorna_panificados();
        }
        public void actualizar_pedido()
        {
            grilla_pedido.DataSource = null;
            grilla_pedido.DataSource = Pe.retorna_lista_panificados();
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void agregarbtn_Click(object sender, EventArgs e) /// agregar productos  y unidades al pedido
        {
          try  {
                {
                    int nrolote = Convert.ToInt32(combolotes.SelectedItem);

                    if (Convert.ToInt32(grilla_lote.Rows[grilla_lote.CurrentRow.Index].Cells[2].Value) == 0)

                    { MessageBox.Show("No hay stock del producto seleccionado"); }  //stock cero del producto seleccionado

                    else
                    {
                        if (Convert.ToInt32(unitxt.Text) <= Convert.ToInt32(grilla_lote.Rows[grilla_lote.CurrentRow.Index].Cells[2].Value))
                        {
                            bool flag = false;
                            Panificados P = (Panificados)grilla_lote.SelectedRows[0].DataBoundItem;
                            P.Unidades -= Convert.ToUInt32(unitxt.Text);
                            foreach (Panificados Pa in Pe.retorna_lista_panificados())
                            {
                                if ((Pa.GetType() == P.GetType()) & Pa.Nro_lote == P.Nro_lote)    /// si el prod esta en el pedido y es el mismo lote
                                {
                                    Pa.Unidades += Convert.ToUInt32(unitxt.Text);       ///  le inserto las unidades del prod para el pedido
                                    flag = true;
                                    break;
                                }
                            }

                            if (flag == false)                   /// si no estaba ese producto en el pedido
                            {
                                Panificados Pn;
                                Pn = (Panificados)P.Clone();     ///clono el obj al pedido
                                Pn.Unidades = Convert.ToUInt32(unitxt.Text);
                                Pe.agregar(Pn);                                 //finalmente agrego al pedido
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error: Las unidades para el pedido son mayores que el stock disponible");
                        }

                    }
                    combolotes_SelectionChangeCommitted(null, null);
                    actualizar_pedido();

                }


            }

            catch{ }
        }

        private void modbtn_Click(object sender, EventArgs e)   /// eliminar unidades del pedido
        {
            try
            {
                Panificados P = (Panificados)grilla_pedido.SelectedRows[0].DataBoundItem;
                if (Convert.ToInt32(borrartxt.Text) > P.Unidades)

                { MessageBox.Show("No se puede elimnar mas cantidad de la cargada en el pedido"); }

                else

                {
                    P.Unidades -= Convert.ToUInt32(borrartxt.Text);

                    foreach (Lote L in Lista_lotes)
                    {
                        if (L.Nro_lote == P.Nro_lote)
                        {
                            foreach (Panificados Pa in L.retorna_panificados())
                            {
                                if ((P.GetType() == Pa.GetType()) & P.Nro_lote == Pa.Nro_lote)
                                {
                                    Pa.Unidades += Convert.ToUInt32(borrartxt.Text);

                                    break;
                                }
                            }
                            break;
                        }
                    }
                    combolotes_SelectionChangeCommitted(null, null);
                    actualizar_pedido();
                }
            }
            catch { MessageBox.Show("Error al eliminar productos del pedido"); }

        }



        private void grabarpedidobtn_Click(object sender, EventArgs e)
        {
            try
            {
                Pe.Grabar_DNI(C.DNI);

                PeB.grabar_pedido(Pe);

                foreach (Lote Lo in Lista_lotes)                   /// actualizo el stock
                {
                    Nl.modificar_stock(Lo.retorna_panificados());
                }

                MessageBox.Show("Se grabo el pedido correctamente");
                this.Close();
            }
            catch { MessageBox.Show("Error al grabar pedido"); }
        }

        private void modpedidobtn_Click(object sender, EventArgs e)
        {
            PeB.modificar_pedido(Pe);
            foreach (Lote Lo in Lista_lotes)                   /// actualizo el stock
            {
                Nl.modificar_stock(Lo.retorna_panificados());
            }
            MessageBox.Show("Se modifico el pedido nro: " + Convert.ToString(Pe.Nro_pedido) + " correctamente");
            this.Close();

        }
    }

}