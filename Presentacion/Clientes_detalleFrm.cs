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
using BLL;
using BE;

namespace Presentacion
{

    public partial class Clientes_detalleFrm : Form
    {
        public Clientes_detalleFrm(Cliente C)             /// MODIFICACION DE CLIENTE
        {
            InitializeComponent();

            Altabtn.Hide();

            nombretxt.Text = C.Nombre;
            apellidotxt.Text = C.Apellido;
            emailtxt.Text = C.Email;
            calletxt.Text = C.Calle;
            nrocalletxt.Text = Convert.ToString(C.Nro_casa);
            localidadtxt.Text = C.Localidad;
            telefonotxt.Text = Convert.ToString(C.Telefono_particular);
            DNItxt.Text = Convert.ToString(C.DNI);
            DNItxt.ReadOnly = true;

        }

        public Clientes_detalleFrm()                 ///   ALTA DE CLIENTE
        {

            InitializeComponent();
            Modbtn.Hide();
        }



        private void Clientes_detalle_Load(object sender, EventArgs e)
        {

        }

        private void Modbtn_Click(object sender, EventArgs e)               //MODIFICAR CLIENTE
        {

            try
            {

                Cliente C = new Cliente(nombretxt.Text, apellidotxt.Text, emailtxt.Text,
                calletxt.Text, Convert.ToInt32(nrocalletxt.Text), localidadtxt.Text, Convert.ToInt32(telefonotxt.Text),
                Convert.ToUInt32(DNItxt.Text));

                ClienteBLL CliBLL = new ClienteBLL();
                CliBLL.Modificar_cliente(C);


                MessageBox.Show("Cliente modificado exitosamente");

                this.Close();
            }
            catch { MessageBox.Show("Error al modificar cliente, revise los datos ingresados"); }
        }

        private void Altabtn_Click(object sender, EventArgs e)                  ///ALTA DE CLIENTE
        {
            try
            {
                ClienteBLL Cli = new ClienteBLL();

                if (Cli.Buscar_DNI(Convert.ToUInt32(DNItxt.Text)) == true)
                {
                    MessageBox.Show("Error: el DNI ingresado ya existe en la base de datos, checkee el numero e intente nuevamente");
                }
                else
                {
                    Cliente C = new Cliente();
                    C.Nombre = nombretxt.Text;
                    C.Apellido = apellidotxt.Text;
                    C.Email = emailtxt.Text;
                    C.Calle = calletxt.Text;
                    C.Nro_casa = Convert.ToInt32(nrocalletxt.Text);
                    C.Localidad = localidadtxt.Text;
                    C.Telefono_particular = Convert.ToInt32(telefonotxt.Text);
                    C.DNI = Convert.ToUInt32(DNItxt.Text);

                    Cli.Alta_clienteBLL(C);
                    MessageBox.Show("Cliente guardado correctamente");
                    this.Close();
                }
            }
            catch { MessageBox.Show("Error al guardar cliente, revise los datos ingresados"); }

        }
    }
}
