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
using System.Text.RegularExpressions;

namespace Presentacion
{
    public partial class Modificar_stockFRM : Form
    {
        Lote L;
        LotesBLL Lb = new LotesBLL();

        public Modificar_stockFRM(Lote Lo)
        {
            InitializeComponent();

            lotetxt.Text = Convert.ToString(Lo.Nro_lote);
            hamctxt.Text = "0";
            hammtxt.Text = "0";
            lactctxt.Text = "0";
            lactgtxt.Text = "0";
            pancctxt.Text = "0";
            pancmtxt.Text = "0";
            L = Lo;


            foreach (Panificados P in L.retorna_panificados())
            {
                if (P.Descripcion == "Pan hamburguesa comun")
                { hamctxt.Text = Convert.ToString(P.Unidades); }

                if (P.Descripcion == "Pan hamburguesa maxi")
                { hammtxt.Text = Convert.ToString(P.Unidades); }

                if (P.Descripcion == "Pan lactal chico")
                { lactctxt.Text = Convert.ToString(P.Unidades); }

                if (P.Descripcion == "Pan lactal grande")
                { lactgtxt.Text = Convert.ToString(P.Unidades); }

                if (P.Descripcion == "Pan pancho chico")
                { pancctxt.Text = Convert.ToString(P.Unidades); }

                if (P.Descripcion == "Pan pancho maxi")
                { pancmtxt.Text = Convert.ToString(P.Unidades); }

            }

            if (hamctxt.Text == "0") { hamctxt.ReadOnly = true; }
            if (hammtxt.Text == "0") { hammtxt.ReadOnly = true; }
            if (lactctxt.Text == "0") { lactctxt.ReadOnly = true; }
            if (lactgtxt.Text == "0") { lactgtxt.ReadOnly = true; }
            if (pancctxt.Text == "0") { pancctxt.ReadOnly = true; }
            if (pancmtxt.Text == "0") { pancmtxt.ReadOnly = true; }



        }

        private void generalotebtn_Click(object sender, EventArgs e)
        {



        }

        private void grabalotebtn_Click(object sender, EventArgs e)    /// MODIFICACION DE LOTE
        {

            try
            {
                List<Panificados> lista_panificados = new List<Panificados>();

                if (Convert.ToUInt32(hamctxt.Text) > 0)

                {
                    Pan_hamburguesa_comun Phc = new Pan_hamburguesa_comun(L.Nro_lote,Convert.ToUInt32(hamctxt.Text));
                    lista_panificados.Add(Phc);

                }

                if (Convert.ToUInt32(hammtxt.Text) > 0)
                {
                    Pan_hamburguesa_maxi Phg = new Pan_hamburguesa_maxi(L.Nro_lote, Convert.ToUInt32(hammtxt.Text));
                    lista_panificados.Add(Phg);
                }


                if (Convert.ToInt32(lactctxt.Text) > 0)
                {
                    Pan_lactal_chico Plc = new Pan_lactal_chico(L.Nro_lote, Convert.ToUInt32(lactctxt.Text));
                    lista_panificados.Add(Plc);
                }


                if (Convert.ToInt32(lactgtxt.Text) > 0)
                {
                    Pan_lactal_grande Plg = new Pan_lactal_grande(L.Nro_lote, Convert.ToUInt32(lactgtxt.Text));
                    lista_panificados.Add(Plg);
                }

                if (Convert.ToInt32(pancctxt.Text) > 0)
                {
                    Pan_pancho_chico Ppc = new Pan_pancho_chico(L.Nro_lote, Convert.ToUInt32(pancctxt.Text));
                    lista_panificados.Add(Ppc);
                }

                if (Convert.ToInt32(pancmtxt.Text) > 0)
                {
                    Pan_pancho_maxi Ppm = new Pan_pancho_maxi(L.Nro_lote, Convert.ToUInt32(pancmtxt.Text));
                    lista_panificados.Add(Ppm);
                }


                Lb.modificar_stock(lista_panificados);
                MessageBox.Show("Stock de lote modificado correctamente");
                this.Close();
            }
            catch { MessageBox.Show("Error al modificar stock de lote"); }
        }

        private void Mod_stockFRM_Load(object sender, EventArgs e)
        {
        }
    }
}
