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
    public partial class AutenticacionFRM : Form
    {
        public AutenticacionFRM()
        {
            InitializeComponent();
        }
        UsuarioMP usMP = new UsuarioMP();
        Crypto Cp = new Crypto();
        List<Usuario> Lista_usuarios = new List<Usuario>();

        private void ingresobtn_Click(object sender, EventArgs e)
        {

            try
            {
                string pascheck = Lista_usuarios[combo_usuarios.SelectedIndex].Obtener_pass();
                if (pascheck == Cp.Encriptar(passtxt.Text))

                {
                    this.Hide();
                    Menu_principal M = new Menu_principal(Lista_usuarios[combo_usuarios.SelectedIndex]);
                    M.Show();
                }

                else
                {
                    MessageBox.Show("Error= contraseña incorrecta, por favor intente nuevamente");
                }
            }
            catch { MessageBox.Show("Error al iniciar sesion"); }
        }

        private void Autenticacion_Load(object sender, EventArgs e)
        {
            Lista_usuarios = usMP.Mostrar_usuarios_roles();
            foreach (Usuario U in Lista_usuarios)
            {
                combo_usuarios.Items.Add(U.Nombre);
            }

        }

        private void AutenticacionFRM_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
