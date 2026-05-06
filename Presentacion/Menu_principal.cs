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
using Servicios;
using BE;

namespace Presentacion
{
    public partial class Menu_principal : Form
    {
        public uint ID_sesion;
        public UsuarioMP uMP = new UsuarioMP();
        Usuario usu;
        public Menu_principal(Usuario U)
        {
            InitializeComponent();
            uMP.Descargar_permisos(U);
            usu = U;

            ID_sesion = U.ID_usuario;
            Deshabilitar_menues();
            Habilitar_menues();

        }
        public void Deshabilitar_menues()
        {

            CrearLoteNuevoToolStripMenuItem.Visible = false;
            VerYModificarStockDeLoteToolStripMenuItem.Visible = false;
            ClientesToolStripMenuItem.Visible = false;
            CrearPlanillaDeProduccionToolStripMenuItem.Visible = false;
            ModificarPlanillaDeProduccionToolStripMenuItem.Visible = false;
            ImprimirToolStripMenuItem.Visible = false;
            EditarPedidosToolStripMenuItem.Visible = false;
            UsuarioToolStripMenuItem.Visible = false;
            ReporteDeVentasToolStripMenuItem.Visible = false;
            FacturacionToolStripMenuItem.Visible = false;
            AdministradorToolStripMenuItem.Visible = false;
            Anular_ConfirmarPedidosToolStripMenuItem.Visible = false;
            NuevoPedidoToolStripMenuItem.Visible = false;
            EditarPreciosToolStripMenuItem.Visible = false;
            GestionDeBackupsToolStripMenuItem.Visible = false;

        }

        public void Habilitar_menues()
        {
            foreach (Componente r in usu.Mostrar_lista())
            {
                foreach (Componente p in r.obtener_lista())
                {
                    switch (p.ID)
                    {
                        case "C1":
                            ClientesToolStripMenuItem.Visible = true;
                            break;

                        case "L1":
                            CrearLoteNuevoToolStripMenuItem.Visible = true;
                            break;

                        case "L2":
                            VerYModificarStockDeLoteToolStripMenuItem.Visible = true;
                            break;

                        case "PE2":
                            EditarPedidosToolStripMenuItem.Visible = true;
                            break;

                        case "U1":
                            UsuarioToolStripMenuItem.Visible = true;
                            break;

                        case "R1":
                            ReporteDeVentasToolStripMenuItem.Visible = true;
                            break;

                        case "F1":
                            FacturacionToolStripMenuItem.Visible = true;
                            break;

                        case "A1":
                            AdministradorToolStripMenuItem.Visible = true;
                            break;

                        case "PE3":
                            Anular_ConfirmarPedidosToolStripMenuItem.Visible = true;
                            break;

                        case "PE1":
                            NuevoPedidoToolStripMenuItem.Visible = true;
                            break;

                        case "PR":
                            EditarPreciosToolStripMenuItem.Visible = true;
                            break;

                        case "BK":
                            GestionDeBackupsToolStripMenuItem.Visible = true;
                            break;

                        case "PP1":
                            CrearPlanillaDeProduccionToolStripMenuItem.Visible = true;
                            break;

                        case "PP2":
                            ModificarPlanillaDeProduccionToolStripMenuItem.Visible = true;
                            break;

                        case "PP3":
                            ImprimirToolStripMenuItem.Visible = true;
                            break;

                    }

                }

            }

            if ((CrearPlanillaDeProduccionToolStripMenuItem.Available == false) & (ModificarPlanillaDeProduccionToolStripMenuItem.Available == false) & (ImprimirToolStripMenuItem.Available == false))
            {
                PlanillasDeProduccionToolStripMenuItem.Visible = false;
            }
            if ((CrearLoteNuevoToolStripMenuItem.Available == false) & (VerYModificarStockDeLoteToolStripMenuItem.Available == false))
            {
                lotesToolStripMenuItem.Visible = false;
            }

            if (NuevoPedidoToolStripMenuItem.Available == false & EditarPedidosToolStripMenuItem.Available == false & Anular_ConfirmarPedidosToolStripMenuItem.Available == false)
            {
                pedidosToolStripMenuItem.Visible = false;

            }



        }


        PreciosBLL pBLL = new PreciosBLL();
        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientesFrm C = new ClientesFrm();
            C.MdiParent = this;
            C.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void crearLoteNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            LotesBLL Nl = new LotesBLL();
            Lote L = new Lote();

            if (Nl.checkear_lote(L) == true)
            { MessageBox.Show("Ya existe un lote del dia creado"); }

            else
            {
                LoteNuevoFrm C = new LoteNuevoFrm();
                C.MdiParent = this;
                C.Show();
            }

        }

        private void verYModificarStock_Click(object sender, EventArgs e)
        {
            LotesBLL Nl = new LotesBLL();

            if (Nl.Lotes_cargados() == true)
            {
                Lote_detalleFRM L = new Lote_detalleFRM();
                L.MdiParent = this;
                L.Show();
            }

            else
            {
                MessageBox.Show("No existen lotes cargados en la base de datos.\nAgregue nuevos lotes seleccionando " +
                  '"' + "Crear nuevo Lote" + '"');
            }



        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Menu_principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevoPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteBLL cBLL = new ClienteBLL();
            LotesBLL lBLL = new LotesBLL();
            if (cBLL.Lista_clientesBLL().Count() == 0)
            { MessageBox.Show("Error: No hay clientes cargados para el nuevo pedido"); }
            else

            {
                if (lBLL.Lotes_cargados() == true)
                {
                    if (pBLL.Checkear_existencia_pr() == true)
                    {
                        Nuevo_pedidoFRM N = new Nuevo_pedidoFRM();
                        N.MdiParent = this;
                        N.Show();
                    }
                    else
                    {
                        MessageBox.Show("Error: Para poder crear pedidos nuevos debe cargar una lista de precios");

                    }
                }

                else { MessageBox.Show("Error: No existe lotes cargados para crear un pedido nuevo"); }

            }


        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void modificarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listar_pedidoFRM M = new Listar_pedidoFRM();
            M.MdiParent = this;
            M.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientesFrm C = new ClientesFrm();
            C.Owner = this;
            C.Show();

        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editarPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modificar_pedidoFRM N = new Modificar_pedidoFRM();
            N.MdiParent = this;
            N.Show();
        }

        private void anularYConfirmarPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Confirmar_anular_pedidoFRM N = new Confirmar_anular_pedidoFRM();
            N.MdiParent = this;
            N.Show();
        }

        
        private void modificarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PermisosFRM U = new PermisosFRM();
            U.Owner = this;
            U.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuariosFRM U = new UsuariosFRM();
            U.Owner = this;
            U.Show();
        }

        private void modificarPermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PermisosFRM U = new PermisosFRM();
            U.Owner = this;
            U.Show();
        }

        private void cerrarSesionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AutenticacionFRM F = new AutenticacionFRM();
            F.Show();
        }

        private void gestionDeBackupsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            BackupsFRM B = new BackupsFRM(usu);
            B.Owner = this;
            B.Show();
        }

        private void editarPreciosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listaDePreciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pBLL.Checkear_existencia_pr() == true)
            {
                Precios_detalleFRM F = new Precios_detalleFRM();
                F.Owner = this;
                F.Show();
            }

            else
            {
                var resultado = MessageBox.Show("No existe una lista de precios en la base de datos, desea crear una nueva ?", "Lista de precios",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    Precios_detalleFRM F = new Precios_detalleFRM(true);
                    F.Owner = this;
                    F.Show();
                }

            }
        }

        private void facturarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Facturar_pedidoFRM F = new Facturar_pedidoFRM();
            F.Owner = this;
            F.Show();
        }

        private void reporteDeVentasSemanalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte_ventasFRM R = new Reporte_ventasFRM();
            R.MdiParent = this;
            R.Show();
        }

        private void crearLoteNuevoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            LotesBLL Nl = new LotesBLL();
            Lote L = new Lote();

            if (Nl.checkear_lote(L) == true)
            { MessageBox.Show("Ya existe un lote del dia creado"); }

            else
            {
                LoteNuevoFrm Lo = new LoteNuevoFrm();
                Lo.MdiParent = this;
                Lo.Show();
            }
        }

        private void verYModificarStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LotesBLL Nl = new LotesBLL();

            if (Nl.Lotes_cargados() == true)
            {
                Lote_detalleFRM L = new Lote_detalleFRM();
                L.MdiParent = this;
                L.Show();
            }

            else
            {
                MessageBox.Show("No existen lotes cargados en la base de datos.\nAgregue nuevos lotes seleccionando " +
                  '"' + "Crear nuevo Lote" + '"');
            }
        }

        private void Menu_principal_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cambiarcontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cambiar_contrasenaFRM C = new Cambiar_contrasenaFRM(usu);
            C.MdiParent = this;
            C.Show();
        }

        private void reporteDeStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Planilla_produccionFRM R = new Planilla_produccionFRM();
            R.MdiParent = this;
            R.Show();
        }

        private void verYModificarStockDeLoteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            LotesBLL Nl = new LotesBLL();

            if (Nl.Lotes_cargados() == true)
            {
                Lote_detalleFRM L = new Lote_detalleFRM();
                L.Owner = this;
                L.Show();
            }

            else
            {
                MessageBox.Show("No existen lotes cargados en la base de datos.\nAgregue nuevos lotes seleccionando " +
                  '"' + "Crear nuevo Lote" + '"');
            }
        }

        private void crearLoteNuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LotesBLL Nl = new LotesBLL();
            Lote L = new Lote();

            if (Nl.checkear_lote(L) == true)
            { MessageBox.Show("Ya existe un lote del dia creado"); }

            else
            {
                LoteNuevoFrm Lo = new LoteNuevoFrm();
                Lo.Owner = this;
                Lo.Show();
            }
        }

        private void crearPlanillaDeProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlanillaBLL pBLL = new PlanillaBLL();

            if (pBLL.Checkear_planilla() == false)
            {
                PlanillaFRM P = new PlanillaFRM();
                P.MdiParent = this;
                P.Show();
            }
            else
            {
                MessageBox.Show("Ya existe una planilla creada del dia, para modificarla seleccione el menu Modificar planilla");
            }

        }

        private void modificarPlanillaDeProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlanillaBLL pBLL = new PlanillaBLL();


            if (pBLL.Checkear_planilla() == false)
            {
                MessageBox.Show("Todavia no fue creada la planilla de produccion, para crearla seleccione la opcion \"Crear planilla de produccion\" del menu");
            }
            else
            {
                Planilla_produccion pr;
                pr = pBLL.Retorna_planilla();
                PlanillaFRM P = new PlanillaFRM(pr);
                P.MdiParent = this;
                P.Show();
            }




        }

        private void ImprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlanillaBLL pBLL = new PlanillaBLL();


            if (pBLL.Checkear_planilla() == false)
            {
                MessageBox.Show("Todavia no fue creada la planilla de produccion, para crearla seleccione la opcion \"Crear planilla de produccion\" del menu");
            }
            else
            {
                Planilla_produccionFRM P = new Planilla_produccionFRM();
                P.MdiParent = this;
                P.Show();
            }
        }

        private void anular_ConfirmarPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Confirmar_anular_pedidoFRM N = new Confirmar_anular_pedidoFRM();
            N.MdiParent = this;
            N.Show();
        }

        private void reporteDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte_ventasFRM R = new Reporte_ventasFRM();
            R.Owner = this;
            R.Show();
        }
    }
}
