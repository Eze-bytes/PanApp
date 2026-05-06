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
    public partial class Lote_detalleFRM : Form
    {
        public Lote_detalleFRM()
        {
            InitializeComponent();

        }
        public LotesBLL Lb = new LotesBLL();

        public List<Lote> Lista_lotes = new List<Lote>();


        public void mostrar_lotes()                 /// muestra lista de lotes
        {
            grilla_lotes.DataSource = null;
            grilla_lotes.DataSource = Lb.Retorna_listado_de_lotes();
        }



        private void LoteModFRM_Load(object sender, EventArgs e)
        {
            mostrar_lotes();
            cargar_detalle();
            this.Owner.Enabled = false;
        }


        public void cargar_detalle()
        {
            try
            {
                Lote L = (Lote)grilla_lotes.CurrentRow.DataBoundItem;
                grilla_detalle.DataSource = null;
                Lb.Detalle_de_lote(L);
                grilla_detalle.DataSource = L.retorna_panificados();
                grilla_detalle.Columns["Precio"].Visible = false;
            }
            catch { MessageBox.Show("Error al cargar detalle lote"); }

        }



        private void grilla_lotes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cargar_detalle();
        }

        private void modstockbtn_Click(object sender, EventArgs e)               /// modifico stock de lote seleccionado
        {

            Lote L = (Lote)grilla_lotes.CurrentRow.DataBoundItem;

            Modificar_stockFRM S = new Modificar_stockFRM(L);

            S.ShowDialog();
            mostrar_lotes();
            cargar_detalle();
        }

        private void borrarprodbtn_Click(object sender, EventArgs e)      /// eliminar totalidad de producto de lote
        {
            try
            {
                Lb.borrar_productos_lote((Panificados)grilla_detalle.CurrentRow.DataBoundItem);
                MessageBox.Show("Producto borrado correctamente");
                mostrar_lotes();
                cargar_detalle();
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void agregaprodbtn_Click(object sender, EventArgs e)         /// agrego mas productos a lote 
        {

            Lote L = (Lote)grilla_lotes.CurrentRow.DataBoundItem;
            if (L.retorna_panificados().Count() == 6)
            { MessageBox.Show("Error: Ya estan cargados todos los productos posibles para el lote"); }

            else
            {
                Agrega_prodFRM A = new Agrega_prodFRM(L);

                A.ShowDialog();
                mostrar_lotes();
                cargar_detalle();
            }



        }

        private void Lote_detalleFRM_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Enabled = true;
        }

        private void stockbtn_Click(object sender, EventArgs e)
        {
            Lote L= (Lote)grilla_lotes.CurrentRow.DataBoundItem;
            Control_stockFRM C = new Control_stockFRM(L);

            C.Show();
        
        
        }
    }
}