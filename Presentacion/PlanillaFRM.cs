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

namespace Presentacion
{
    public partial class PlanillaFRM : Form
    {
        public PlanillaFRM()
        {

            InitializeComponent();

            txt_cero();
            modbtn.Visible = false;


        }
        public PlanillaFRM(Planilla_produccion pr)
        {
            InitializeComponent();

            Llenar_txt(pr);
            genera_pbtn.Visible = false;

        }

        public void txt_cero()
        {
            hamctxt.Text = "0";
            hammtxt.Text = "0";
            lactctxt.Text = "0";
            lactgtxt.Text = "0";
            pancctxt.Text = "0";
            pancmtxt.Text = "0";
        }


        public void Llenar_txt(Planilla_produccion pr)
        {

            foreach (Panificados p in pr.retorna_panificados())
            {
                switch (p.ID_producto)

                {
                    case "PHC":
                        hamctxt.Text = Convert.ToString(p.Unidades);
                        break;

                    case "PHM":
                        hammtxt.Text = Convert.ToString(p.Unidades);
                        break;

                    case "PLC":
                        lactctxt.Text = Convert.ToString(p.Unidades);
                        break;

                    case "PLG":
                        lactgtxt.Text = Convert.ToString(p.Unidades);
                        break;

                    case "PPC":
                        pancctxt.Text = Convert.ToString(p.Unidades);
                        break;

                    case "PPM":
                        pancmtxt.Text = Convert.ToString(p.Unidades);
                        break;


                }
            }



        }
        public void generar_planilla(bool modifica)
        {
            Planilla_produccion Pl = new Planilla_produccion();
            PlanillaBLL pBLL = new PlanillaBLL();
            Lote Lo = new Lote();

            Pl.Nro_lote = Lo.Nro_lote;
            if (Convert.ToUInt32(hamctxt.Text) >= 0)
            {
                Pan_hamburguesa_comun Phc = new Pan_hamburguesa_comun(Convert.ToUInt32(hamctxt.Text));
                Pl.Agregar_a_planilla(Phc);
            }

            if (Convert.ToUInt32(hammtxt.Text) >= 0)
            {
                Pan_hamburguesa_maxi Phg = new Pan_hamburguesa_maxi(Convert.ToUInt32(hammtxt.Text));
                Pl.Agregar_a_planilla(Phg);
            }


            if (Convert.ToUInt32(lactctxt.Text) >= 0)
            {
                Pan_lactal_chico Plc = new Pan_lactal_chico(Convert.ToUInt32(lactctxt.Text));
                Pl.Agregar_a_planilla(Plc);
            }

            if (Convert.ToUInt32(lactgtxt.Text) >= 0)

            {
                Pan_lactal_grande Plg = new Pan_lactal_grande(Convert.ToUInt32(lactgtxt.Text));
                Pl.Agregar_a_planilla(Plg);
            }

            if (Convert.ToUInt32(pancctxt.Text) >= 0)
            {
                Pan_pancho_chico Ppc = new Pan_pancho_chico(Convert.ToUInt32(pancctxt.Text));
                Pl.Agregar_a_planilla(Ppc);
            }

            if (Convert.ToUInt32(pancmtxt.Text) >= 0)
            {
                Pan_pancho_maxi Ppm = new Pan_pancho_maxi(Convert.ToUInt32(pancmtxt.Text));
                Pl.Agregar_a_planilla(Ppm);
            }
            pBLL.Guardar_planilla(Pl, modifica);

        }

        private void genera_pbtn_Click(object sender, EventArgs e)
        {
            try
            {
                generar_planilla(false);
                MessageBox.Show("Planilla creada corectamente");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Error al cargar los datos, intente nuevamente");
            }
        }

        private void Crear_planillaFRM_Load(object sender, EventArgs e)
        {

        }

        private void modbtn_Click(object sender, EventArgs e)
        {
            try
            {
                generar_planilla(true);
                MessageBox.Show("Planilla modificada corectamente");
                this.Close();
            }
            catch
            { MessageBox.Show("Error al modificar planilla"); }


        }
    }
}
