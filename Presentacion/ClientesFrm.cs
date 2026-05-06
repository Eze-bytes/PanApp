using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;
using System.IO;
using BLL;
using BE;


namespace Presentacion
{
    public partial class ClientesFrm : Form
    {
        Cliente C = new Cliente();
        ClienteBLL CliBLL = new ClienteBLL();

        public ClientesFrm()
        {
            InitializeComponent();

        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            this.Owner.Enabled = false;
            cargar_grilla();
        }

        List<Cliente> Lista_clientes = new List<Cliente>();

        public void cargar_grilla()
        {
            try
            {
                grillaclientes.DataSource = null;
                grillaclientes.DataSource = CliBLL.Lista_clientesBLL();
            }
            catch { }
        }




        private void Bajabtn_Click(object sender, EventArgs e)                     ///BORRAR CLIENTE
        {


            try
            {
                int nrocliente = Convert.ToInt32(grillaclientes.Rows[grillaclientes.CurrentRow.Index].Cells[0].Value);
                var resultado = MessageBox.Show("¿Confirma la baja de cliente nro: " + nrocliente + " ?", "Baja",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)

                {
                    cargar_grilla();
                    MessageBox.Show("Cliente eliminado exitosamente");
                }

            }

            catch
            { MessageBox.Show("Error: Lista de clientes vacia"); }


        }

        private void Modificacionbtn_Click(object sender, EventArgs e)     /// MODIFICAR CLIENTE
        {

            try
            {

                Cliente C = ((Cliente)grillaclientes.SelectedRows[0].DataBoundItem);
                Clientes_detalleFrm Cli = new Clientes_detalleFrm(C);
                Cli.ShowDialog();
                cargar_grilla();
            }


            catch { MessageBox.Show("Error: Lista de clientes vacia"); }
        }

        private void ClientesFrm_Enter(object sender, EventArgs e)
        {

        }

        private void Altabtn_Click(object sender, EventArgs e)
        {

            try
            {
                Clientes_detalleFrm Cli = new Clientes_detalleFrm();
                Cli.ShowDialog();
                cargar_grilla();
            }

            catch { MessageBox.Show("Error al dar de alta a cliente"); }

        }

        private void userControlAlta1_Load(object sender, EventArgs e)
        {

        }

        private void Altabtn_Click_1(object sender, EventArgs e)
        {
            try
            {


                Clientes_detalleFrm Cli = new Clientes_detalleFrm();
                Cli.ShowDialog();
                cargar_grilla();
            }

            catch { MessageBox.Show("Error al dar de alta a cliente"); }
        }





        private void Bajabtn_Click_1(object sender, EventArgs e)
        {

            //try
            {
                uint nrodni = Convert.ToUInt32(grillaclientes.Rows[grillaclientes.CurrentRow.Index].Cells[0].Value);
                var resultado = MessageBox.Show("¿Confirma la baja de cliente DNI: " + nrodni + " ?", "Baja",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    if (CliBLL.Checkear_cliente_para_borrar(nrodni) == true)
                    {
                        CliBLL.Borrar_cliente(nrodni);

                        MessageBox.Show("Cliente eliminado exitosamente");
                        cargar_grilla();
                    }
                    else { MessageBox.Show("Error: el cliente no puede ser eliminado ya que tiene pedidos pendientes, anule o facture los mismos"); }

                }

            }

            //catch
            //{ MessageBox.Show("Error al eliminar cliente"); }
        }

        private void ClientesFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Enabled = true;
        }
    }
}
