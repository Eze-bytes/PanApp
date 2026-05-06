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
    public partial class Nuevo_pedidoFRM : Form
    {
        
        public Nuevo_pedidoFRM()
        {
            InitializeComponent();
        
        }
        ClienteBLL cli = new ClienteBLL();
        List<Cliente> Lista_clientes;
        

        private void nuevopedidoFRM_Load(object sender, EventArgs e)
        {
            Lista_clientes = cli.Lista_clientesBLL();
         

            foreach (Cliente C in Lista_clientes)
            {
                combocliente.Items.Add("DNI: " + Convert.ToString(C.DNI) + "; " + C.Apellido + "," + C.Nombre);
            }



        }

        private void npedidobtn_Click(object sender, EventArgs e)
        {
            int ind;
            ind = combocliente.SelectedIndex;

            Pedido_detalleFRM P = new Pedido_detalleFRM(Lista_clientes[ind]);

            P.Show();
            this.Close();
        }
    }
}
