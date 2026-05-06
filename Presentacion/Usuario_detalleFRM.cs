using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using BE;
using Servicios;
using BLL;

namespace Presentacion
{
    public partial class Usuario_detalleFRM : Form
    {
        public Usuario_detalleFRM()         ///Alta
        {
            InitializeComponent();
            modificarbtn.Visible = false;
        }
        public Crypto Cp = new Crypto();
        public UsuarioMP UsuB = new UsuarioMP();
        public Usuario Us = new Usuario();
        public Usuario_detalleFRM(Usuario usu)    ///Modificacion
        {
            InitializeComponent();
            altabtn.Visible = false;
            nombretxt.Text = usu.Nombre;
            idtxt.Text = Convert.ToString(usu.ID_usuario);
            idtxt.ReadOnly = true;
            Us = usu;
        }


        private void altabtn_Click(object sender, EventArgs e)
        {
            try
            {
                Regex rxnombre = new Regex("^[a-zA-Z]+$");
                Regex rxid = new Regex("^[0-9]+$");

                if (rxnombre.IsMatch(nombretxt.Text) == true)
                {
                    if (rxid.IsMatch(idtxt.Text) == true)
                    {
                        if (Convert.ToUInt32(idtxt.Text) > 0)
                        {
                            Usuario usu = new Usuario();
                            usu.ID_usuario = Convert.ToUInt32(idtxt.Text);

                            if (UsuB.Checkear_usuario(usu) == false)
                            {
                                usu.Nombre = nombretxt.Text;
                                usu.Guardar_pass(Cp.Encriptar(passtxt.Text));
                                UsuB.Agregar_usuario(usu, false);
                                MessageBox.Show("El usuario se guardo correctamente");
                                this.Close();

                            }
                            else { MessageBox.Show("Error: ya existe ese id de usuario"); }
                        }
                        else
                        {
                            MessageBox.Show("El id de usuario tiene que ser mayor a cero ");

                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: el id de usuario solo puede ser numérico");
                    }
                }

                else
                {
                    MessageBox.Show("Error: el nombre de usuario solo puede contener letras");
                }

            }
            catch { MessageBox.Show("Error al guardar nuevo usuario"); }
        }

        private void modificarbtn_Click(object sender, EventArgs e)
        {
            Usuario usu = new Usuario();
            usu.Nombre = nombretxt.Text;
            usu.Guardar_pass(Cp.Encriptar(passtxt.Text));
            usu.ID_usuario = Convert.ToUInt32(idtxt.Text);
            UsuB.Modificar_usuario(usu);
            MessageBox.Show("El usuario se modifico correctamente");
            this.Close();
        }
    }
}
