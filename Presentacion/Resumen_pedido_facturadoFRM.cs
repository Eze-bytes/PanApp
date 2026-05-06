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

namespace Presentacion
{
    public partial class Resumen_pedido_facturadoFRM : Form
    {
        Venta Ve;
        public Resumen_pedido_facturadoFRM(Venta V)
        {
            InitializeComponent();
            Ve = V;
        }

        private void Resumen_pedido_facturadoFRM_Load(object sender, EventArgs e)
        {
            this.Owner.Enabled = false;
            totaltxt.Text = Ve.Importe_total.ToString();
            fechatxt.Text = (Ve.Fecha_venta).ToShortDateString();
            grilla_fac.DataSource = Ve.pr.retorna_lista_panificados();
            nropedidotxt.Text=Convert.ToString(Ve.pr.Nro_pedido);
        }

        private void cerrarbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Resumen_pedido_facturadoFRM_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Enabled = true;
        }
    }
}
