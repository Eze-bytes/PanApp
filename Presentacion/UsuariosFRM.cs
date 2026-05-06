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
using Servicios;

namespace Presentacion
{
    public partial class UsuariosFRM : Form
    {
        public UsuariosFRM()
        {
            InitializeComponent();
        }

        List<Usuario> Lista_usuarios = new List<Usuario>();
        public UsuarioMP UsuB = new UsuarioMP();

        private void altabtn_Click(object sender, EventArgs e)
        {
            Usuario_detalleFRM U = new Usuario_detalleFRM();
            U.ShowDialog();
            Cargar_grilla();
        }

        public void Cargar_grilla()
        {
            try
            {
                Lista_usuarios = UsuB.Mostrar_usuarios();
                grilla_usuarios.DataSource = null;
                grilla_usuarios.DataSource = Lista_usuarios;
            }
            catch { }
        }

        private void UsuariosFRM_Load(object sender, EventArgs e)
        {
            this.Owner.Enabled = false;
            Cargar_grilla();
            
        }

        private void modbtn_Click(object sender, EventArgs e)
        {
            Usuario usu = ((Usuario)grilla_usuarios.SelectedRows[0].DataBoundItem);
            Usuario_detalleFRM U = new Usuario_detalleFRM(usu);
            U.ShowDialog();
            Cargar_grilla();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Usuario usu = ((Usuario)grilla_usuarios.SelectedRows[0].DataBoundItem);

            var resultado = MessageBox.Show("¿Confirma la baja del Usuario: " + usu.Nombre + ", ID:" + usu.ID_usuario + " ?", "Baja",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes) { UsuB.Eliminar_usuario(usu); Cargar_grilla(); }
          

        }

        private void UsuariosFRM_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Enabled = true;
        }
    }
}
