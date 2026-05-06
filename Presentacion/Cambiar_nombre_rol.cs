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
using Servicios;

namespace Presentacion
{
    public partial class Cambiar_nombre_rolFRM : Form
    {
        public Cambiar_nombre_rolFRM(List<Componente> lista, int ind)
        {
            InitializeComponent();
            Lista_roles = lista;
            indice = ind;

        }
        List<Componente> Lista_roles;
        int indice;
        private void Cambiar_nombre_rol_Load(object sender, EventArgs e)
        {
            this.Owner.Enabled = false; ;
        }

        private void guardarbtn_Click(object sender, EventArgs e)
        {
            RolMP rMP = new RolMP();
            Regex rx = new Regex("[a-zA-Z0-9]");

            if (rx.IsMatch(txtnombre.Text))

            {
                bool check = false;

                for (int I = 0; I < Lista_roles.Count(); I++)
                {
                    if (I != indice & Lista_roles[I].Descripcion == txtnombre.Text & Lista_roles[I].Descripcion.ToUpper() == txtnombre.Text.ToUpper())
                    {
                        check = true;
                        break;
                    }
                }

                if (check == false)
                {

                    rMP.Modificar_nombre_rol(txtnombre.Text, Lista_roles[indice].ID);

                    MessageBox.Show("Nombre de rol modificado correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ya existe una descripcion igual de otro rol");
                }
            }
            else
            {
                MessageBox.Show("El nuevo nombre de rol debe poseer caracteres alfanumericos solamente");
            }


        }

        private void Cambiar_nombre_rolFRM_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Enabled = true;
        }
    }
}
