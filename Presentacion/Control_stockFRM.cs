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

namespace Presentacion
{
    public partial class Control_stockFRM : Form
    {
        public Control_stockFRM(Lote Lo)
        {
            InitializeComponent();
            L = Lo;
        }
        public Lote L;
        private void Control_stockFRM_Load(object sender, EventArgs e)
        {
            LoteBindingSource.DataSource = L;
            PanificadosBindingSource.DataSource = L.retorna_panificados();


            this.reportViewer1.RefreshReport();
        }
    }
}
