using BE;
using BLL;
using System;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class LoteNuevoFrm : Form
    {
        public LoteNuevoFrm()
        {
            InitializeComponent();
        }

        private void LoteNuevoFrm_Load(object sender, EventArgs e)
        {
            this.Owner.Enabled = false;
            hamctxt.Text = "0";
            hammtxt.Text = "0";
            lactctxt.Text = "0";
            lactgtxt.Text = "0";
            pancctxt.Text = "0";
            pancmtxt.Text = "0";
        }
        public void Limpiartxt()
        {
            hamctxt.Clear();
            hammtxt.Clear();
            lactctxt.Clear();
            lactgtxt.Clear();
            pancctxt.Clear();
            pancmtxt.Clear();

        }
        private void generalotebtn_Click(object sender, EventArgs e)
        {

            try
            {
                Lote L = new Lote();
                LotesBLL Nl = new LotesBLL();

                if (Convert.ToInt32(hamctxt.Text) > 0)
                {
                    Pan_hamburguesa_comun Phc = new Pan_hamburguesa_comun(Convert.ToUInt32(hamctxt.Text));
                    L.agregar_a_lote(Phc);
                }

                if (Convert.ToInt32(hammtxt.Text) > 0)
                {
                    Pan_hamburguesa_maxi Phg = new Pan_hamburguesa_maxi(Convert.ToUInt32(hammtxt.Text));
                    L.agregar_a_lote(Phg);
                }


                if (Convert.ToInt32(lactctxt.Text) > 0)
                {
                    Pan_lactal_chico Plc = new Pan_lactal_chico(Convert.ToUInt32(lactctxt.Text));
                    L.agregar_a_lote(Plc);
                }

                if (Convert.ToInt32(lactgtxt.Text) > 0)

                {
                    Pan_lactal_grande Plg = new Pan_lactal_grande(Convert.ToUInt32(lactgtxt.Text));
                    L.agregar_a_lote(Plg);
                }

                if (Convert.ToInt32(pancctxt.Text) > 0)
                {
                    Pan_pancho_chico Ppc = new Pan_pancho_chico(Convert.ToUInt32(pancctxt.Text));
                    L.agregar_a_lote(Ppc);
                }

                if (Convert.ToInt32(pancmtxt.Text) > 0)
                {
                    Pan_pancho_maxi Ppm = new Pan_pancho_maxi(Convert.ToUInt32(pancmtxt.Text));
                    L.agregar_a_lote(Ppm);
                }



                Nl.graba_lote(L);
                MessageBox.Show("Lote grabado correctamente");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Error al cargar los datos, intente nuevamente");

                Limpiartxt();

            }

        }

        private void LoteNuevoFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Enabled = true;
        }
    }
}
