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
using System.Globalization;

namespace Presentacion
{
    public partial class Precios_detalleFRM : Form
    {
        public Precios_detalleFRM(bool nueva)       /// lista nueva
        {
            InitializeComponent();
            this.Text = "Nueva lista de precios";
            modprecios.Hide();
            guardarcambiosbtn.Hide();
            labelfech.Hide();
            fechatxt.Hide();
        }
        PreciosBLL pBLL = new PreciosBLL();

        public void Limpiartxt()
        {

            hamctxt.Clear();
            hammtxt.Clear();
            lactctxt.Clear();
            lactgtxt.Clear();
            pancctxt.Clear();
            pancmtxt.Clear();
        }



        public void Recuperar_lista()
        {

            Limpiartxt();

            Lista_precios L = pBLL.Recuperar_lista_pre();
            hamctxt.Text = (L.PHC.Leer_precio()).ToString();
            hammtxt.Text = (L.PHM.Leer_precio()).ToString();
            lactctxt.Text = (L.PLC.Leer_precio()).ToString();
            lactgtxt.Text = (L.PLG.Leer_precio()).ToString();
            pancctxt.Text = (L.PPC.Leer_precio()).ToString();
            pancmtxt.Text = (L.PPM.Leer_precio()).ToString();
            hamctxt.ReadOnly = true;
            hammtxt.ReadOnly = true;
            lactctxt.ReadOnly = true;
            lactgtxt.ReadOnly = true;
            pancctxt.ReadOnly = true;
            pancmtxt.ReadOnly = true;
            fechatxt.Text = L.Fecha_de_ultima_actualizacion.ToShortDateString();

            guardarnuevabtn.Hide();
            modprecios.Enabled = true;
            guardarcambiosbtn.Show();
            labelfech.Show();
            fechatxt.Show();
        
        }


        public Precios_detalleFRM()     /// modificar o consultar
        {
            InitializeComponent();

            Recuperar_lista();
        }

        public void actualizar_lista() { }

        private void PreciosFRM_Load(object sender, EventArgs e)
        {
            this.Owner.Enabled = false;
        }

        private void modprecios_Click(object sender, EventArgs e)
        {
            hamctxt.ReadOnly = false;
            hammtxt.ReadOnly = false;
            lactctxt.ReadOnly = false;
            lactgtxt.ReadOnly = false;
            pancctxt.ReadOnly = false;
            pancmtxt.ReadOnly = false;
            modprecios.Enabled = false;
        }

        public void modificar_lista(bool mod)
        {
            Lista_precios Li = new Lista_precios();
            Li.PHC = new Pan_hamburguesa_comun();
            Li.PHC.Grabar_precio(decimal.Parse(hamctxt.Text));
            Li.PHM = new Pan_hamburguesa_maxi();
            Li.PHM.Grabar_precio(decimal.Parse(hammtxt.Text));
            Li.PLC = new Pan_lactal_chico();
            Li.PLC.Grabar_precio(decimal.Parse(lactctxt.Text));
            Li.PLG = new Pan_lactal_grande();
            Li.PLG.Grabar_precio(decimal.Parse(lactgtxt.Text));
            Li.PPC = new Pan_pancho_chico();
            Li.PPC.Grabar_precio(decimal.Parse(pancctxt.Text));
            Li.PPM = new Pan_pancho_maxi();
            Li.PPM.Grabar_precio(decimal.Parse(pancmtxt.Text));
            pBLL.Modificar_lista_pre(Li, mod);
        }


        private void guardarbtn_Click(object sender, EventArgs e)
        {
            try
            {
                modificar_lista(false);
                MessageBox.Show("Lista nueva de precios guardada correctamente");
                Recuperar_lista();

            }
            catch { MessageBox.Show("Error al guardar lista de precios"); }
        }

        private void guardarcambiosbtn_Click(object sender, EventArgs e)
        {
            try
            {
                modificar_lista(true);
                MessageBox.Show("Lista de precios modificada correctamente");
                guardarcambiosbtn.Enabled = false;
                modprecios.Enabled = true;
                Recuperar_lista();
            }
            catch { MessageBox.Show("Error al modificar lista de precios"); }
        }

        private void Precios_detalleFRM_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Enabled = true;
        }
    }
}
