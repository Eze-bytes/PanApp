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
    public partial class Planilla_produccionFRM : Form
    {
        public Planilla_produccionFRM()
        {
            InitializeComponent();
        }
        //  public DataSet a = new DataSet();
        public PlanillaBLL pBLL = new PlanillaBLL();
        List<Panificados> Lista_produccion;
        public Sectores Sec = new Sectores();
        public void Cargar_lista()
        {
            Lista_produccion = pBLL.Retorna_planilla().retorna_panificados();
        }

        private void Reporte_stock_Load(object sender, EventArgs e)
        {
            combo_sectores.Items.Add("Todos los sectores");
            combo_sectores.Items.Add("Producción de lactal");
            combo_sectores.Items.Add("Produccion de hamburguesas");
            combo_sectores.Items.Add("Produccion de panchos");
            combo_sectores.SelectedIndex = 0;
            combo_sectores_SelectionChangeCommitted(null, null);

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {


        }

        private void Pan_lactal_grandeBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
       
        public void Filtrar_reporte()
        {
            Cargar_lista();

            switch (combo_sectores.SelectedIndex)
            {
                case 0:
                    Sec.sector = "PLANILLA DE PRODUCCION DE TODOS LOS SECTORES";


                    break;

                case 1:

                    Sec.sector = "PLANILLA DE PRODUCCION DEL SECTOR LACTAL";
                   
                    Lista_produccion.RemoveAll(condicion => condicion.ID_producto != "PLC"&condicion.ID_producto != "PLG");


                    

                    break;

                case 2:
                    Sec.sector = "PLANILLA DE PRODUCCION DEL SECTOR HAMBURGUESAS";
                    Lista_produccion.RemoveAll(condicion => condicion.ID_producto != "PHC" & condicion.ID_producto != "PHM");
                    break;

                case 3:
                    Sec.sector = "PLANILLA DE PRODUCCION DEL SECTOR PANCHOS";
                    Lista_produccion.RemoveAll(condicion => condicion.ID_producto != "PPC" & condicion.ID_producto != "PPM");

                    break;

            }

        }


        private void combo_sectores_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Filtrar_reporte();
            PanificadosBindingSource.DataSource = Lista_produccion;
            SectoresBindingSource.DataSource = Sec;   


            this.reportViewer1.RefreshReport();


        }
    }
}
