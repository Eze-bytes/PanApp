using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servicios;

namespace Presentacion
{
    public partial class Cambiar_contrasenaFRM : Form
    {
        Usuario usu;
        public Cambiar_contrasenaFRM(Usuario u)
        {
            InitializeComponent();
            usu = u;
        }
        UsuarioMP uMP = new UsuarioMP();
        Crypto cr = new Crypto();
        private void cambiarbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string a = cr.Encriptar(actualtxt.Text);

                if (cr.Encriptar(actualtxt.Text) == usu.Obtener_pass())
                {
                    usu.Guardar_pass(cr.Encriptar(nuevatxt.Text));
                    uMP.Modificar_usuario(usu);
                    MessageBox.Show("Contraseña modificada correctamente");
                    this.Close();
                }
                else { MessageBox.Show("Error: contraseña actual incorrecta, intente nuevamente"); }
            }
            catch { }

        }
    }
}
