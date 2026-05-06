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
    public partial class Agrega_prodFRM : Form
    {

        Lote L;
        LotesBLL Lb = new LotesBLL();

        public Agrega_prodFRM(Lote Lo)
        {
            InitializeComponent();
            L = Lo;
            lotetxt.Text = Convert.ToString(L.Nro_lote);
            hamctxt.Text = "0";
            hammtxt.Text = "0";
            lactctxt.Text = "0";
            lactgtxt.Text = "0";
            pancctxt.Text = "0";
            pancmtxt.Text = "0";

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
            if (hamctxt.Text != "0") { hamctxt.ReadOnly = true; }
            if (hammtxt.Text != "0") { hammtxt.ReadOnly = true; }
            if (lactctxt.Text != "0") { lactctxt.ReadOnly = true; }
            if (lactgtxt.Text != "0") { lactgtxt.ReadOnly = true; }
            if (pancctxt.Text != "0") { pancctxt.ReadOnly = true; }
            if (pancmtxt.Text != "0") { pancmtxt.ReadOnly = true; }


        }

        private void grabalotebtn_Click(object sender, EventArgs e)
        {
            Regex re = new Regex("^([0]+[1-9]|[1-9])");
            Lote Lm = new Lote();
            Lm.Nro_lote = L.Nro_lote;
            Lm.Fecha_de_vencimiento = L.Fecha_de_vencimiento;
            List<Panificados> lista_agregar = new List<Panificados>();

            try
            {
                if (hamctxt.ReadOnly == false)
                {
                    if (Convert.ToInt32(hamctxt.Text) > 0)
                    {
                        Pan_hamburguesa_comun Phc = new Pan_hamburguesa_comun(L.Nro_lote, Convert.ToUInt32(hamctxt.Text));
                        lista_agregar.Add(Phc);
                    }
                }

                if (hammtxt.ReadOnly == false)
                {
                    if (Convert.ToInt32(hammtxt.Text) > 0)
                    {
                        Pan_hamburguesa_maxi Phg = new Pan_hamburguesa_maxi(L.Nro_lote, Convert.ToUInt32(hammtxt.Text));
                        lista_agregar.Add(Phg);
                    }
                }

                if (lactctxt.ReadOnly == false)
                {
                    if (Convert.ToInt32(lactctxt.Text) > 0)
                    {
                        Pan_lactal_chico Plc = new Pan_lactal_chico(L.Nro_lote, Convert.ToUInt32(lactctxt.Text));
                        lista_agregar.Add(Plc);
                    }
                }

                if (lactgtxt.ReadOnly == false)
                {
                    if (Convert.ToInt32(lactgtxt.Text) > 0)
                    {
                        Pan_lactal_grande Plg = new Pan_lactal_grande(L.Nro_lote, Convert.ToUInt32(lactgtxt.Text));
                        lista_agregar.Add(Plg);
                    }
                }

                if (pancctxt.ReadOnly == false)
                {
                    if (Convert.ToUInt32(pancctxt.Text) > 0)
                    {
                        Pan_pancho_chico Ppc = new Pan_pancho_chico(L.Nro_lote, Convert.ToUInt32(pancctxt.Text));
                        lista_agregar.Add(Ppc);
                    }
                }

                if (pancmtxt.ReadOnly == false)
                {
                    if (Convert.ToUInt32(pancmtxt.Text) > 0)
                    {
                        Pan_pancho_maxi Ppm = new Pan_pancho_maxi(L.Nro_lote, Convert.ToUInt32(pancmtxt.Text));
                        lista_agregar.Add(Ppm);
                    }
                }
                Lb.agregar_productos_lote(lista_agregar);


                MessageBox.Show("Productos agregados correctamente al lote");
                this.Close();
            }

            catch { }





        }
    }
}
