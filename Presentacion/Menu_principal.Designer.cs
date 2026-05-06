
namespace Presentacion
{
    partial class Menu_principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NuevoPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditarPedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Anular_ConfirmarPedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditarPreciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDePreciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReporteDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FacturacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturarPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdministradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarPermisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GestionDeBackupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Cambiar_contrasenaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PlanillasDeProduccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CrearPlanillaDeProduccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModificarPlanillaDeProduccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CrearLoteNuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VerYModificarStockDeLoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SalirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClientesToolStripMenuItem,
            this.pedidosToolStripMenuItem,
            this.EditarPreciosToolStripMenuItem,
            this.UsuarioToolStripMenuItem,
            this.ReporteDeVentasToolStripMenuItem,
            this.FacturacionToolStripMenuItem,
            this.AdministradorToolStripMenuItem,
            this.GestionDeBackupsToolStripMenuItem,
            this.Cambiar_contrasenaToolStripMenuItem,
            this.PlanillasDeProduccionToolStripMenuItem,
            this.lotesToolStripMenuItem,
            this.CerrarSesionToolStripMenuItem,
            this.SalirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2564, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // ClientesToolStripMenuItem
            // 
            this.ClientesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem";
            this.ClientesToolStripMenuItem.Size = new System.Drawing.Size(96, 32);
            this.ClientesToolStripMenuItem.Text = "Clientes";
            this.ClientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NuevoPedidoToolStripMenuItem,
            this.EditarPedidosToolStripMenuItem,
            this.Anular_ConfirmarPedidosToolStripMenuItem});
            this.pedidosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(97, 32);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            this.pedidosToolStripMenuItem.Click += new System.EventHandler(this.pedidosToolStripMenuItem_Click);
            // 
            // NuevoPedidoToolStripMenuItem
            // 
            this.NuevoPedidoToolStripMenuItem.Name = "NuevoPedidoToolStripMenuItem";
            this.NuevoPedidoToolStripMenuItem.Size = new System.Drawing.Size(351, 36);
            this.NuevoPedidoToolStripMenuItem.Text = "Nuevo pedido";
            this.NuevoPedidoToolStripMenuItem.Click += new System.EventHandler(this.nuevoPedidoToolStripMenuItem_Click);
            // 
            // EditarPedidosToolStripMenuItem
            // 
            this.EditarPedidosToolStripMenuItem.Name = "EditarPedidosToolStripMenuItem";
            this.EditarPedidosToolStripMenuItem.Size = new System.Drawing.Size(351, 36);
            this.EditarPedidosToolStripMenuItem.Text = "Editar pedidos";
            this.EditarPedidosToolStripMenuItem.Click += new System.EventHandler(this.editarPedidosToolStripMenuItem_Click);
            // 
            // Anular_ConfirmarPedidosToolStripMenuItem
            // 
            this.Anular_ConfirmarPedidosToolStripMenuItem.Name = "Anular_ConfirmarPedidosToolStripMenuItem";
            this.Anular_ConfirmarPedidosToolStripMenuItem.Size = new System.Drawing.Size(351, 36);
            this.Anular_ConfirmarPedidosToolStripMenuItem.Text = "Anular y confirmar pedidos";
            this.Anular_ConfirmarPedidosToolStripMenuItem.Click += new System.EventHandler(this.anular_ConfirmarPedidosToolStripMenuItem_Click);
            // 
            // EditarPreciosToolStripMenuItem
            // 
            this.EditarPreciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDePreciosToolStripMenuItem});
            this.EditarPreciosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.EditarPreciosToolStripMenuItem.Name = "EditarPreciosToolStripMenuItem";
            this.EditarPreciosToolStripMenuItem.Size = new System.Drawing.Size(90, 32);
            this.EditarPreciosToolStripMenuItem.Text = "Precios";
            this.EditarPreciosToolStripMenuItem.Click += new System.EventHandler(this.editarPreciosToolStripMenuItem_Click);
            // 
            // listaDePreciosToolStripMenuItem
            // 
            this.listaDePreciosToolStripMenuItem.Name = "listaDePreciosToolStripMenuItem";
            this.listaDePreciosToolStripMenuItem.Size = new System.Drawing.Size(248, 36);
            this.listaDePreciosToolStripMenuItem.Text = "Lista de precios";
            this.listaDePreciosToolStripMenuItem.Click += new System.EventHandler(this.listaDePreciosToolStripMenuItem_Click);
            // 
            // UsuarioToolStripMenuItem
            // 
            this.UsuarioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem";
            this.UsuarioToolStripMenuItem.Size = new System.Drawing.Size(103, 32);
            this.UsuarioToolStripMenuItem.Text = "Usuarios";
            this.UsuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // ReporteDeVentasToolStripMenuItem
            // 
            this.ReporteDeVentasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ReporteDeVentasToolStripMenuItem.Name = "ReporteDeVentasToolStripMenuItem";
            this.ReporteDeVentasToolStripMenuItem.Size = new System.Drawing.Size(185, 32);
            this.ReporteDeVentasToolStripMenuItem.Text = "Reporte de ventas";
            this.ReporteDeVentasToolStripMenuItem.Click += new System.EventHandler(this.reporteDeVentasToolStripMenuItem_Click);
            // 
            // FacturacionToolStripMenuItem
            // 
            this.FacturacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturarPedidoToolStripMenuItem});
            this.FacturacionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FacturacionToolStripMenuItem.Name = "FacturacionToolStripMenuItem";
            this.FacturacionToolStripMenuItem.Size = new System.Drawing.Size(128, 32);
            this.FacturacionToolStripMenuItem.Text = "Facturacion";
            // 
            // facturarPedidoToolStripMenuItem
            // 
            this.facturarPedidoToolStripMenuItem.Name = "facturarPedidoToolStripMenuItem";
            this.facturarPedidoToolStripMenuItem.Size = new System.Drawing.Size(252, 36);
            this.facturarPedidoToolStripMenuItem.Text = "Facturar pedido";
            this.facturarPedidoToolStripMenuItem.Click += new System.EventHandler(this.facturarPedidoToolStripMenuItem_Click);
            // 
            // AdministradorToolStripMenuItem
            // 
            this.AdministradorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarPermisosToolStripMenuItem});
            this.AdministradorToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.AdministradorToolStripMenuItem.Name = "AdministradorToolStripMenuItem";
            this.AdministradorToolStripMenuItem.Size = new System.Drawing.Size(154, 32);
            this.AdministradorToolStripMenuItem.Text = "Administrador";
            // 
            // modificarPermisosToolStripMenuItem
            // 
            this.modificarPermisosToolStripMenuItem.Name = "modificarPermisosToolStripMenuItem";
            this.modificarPermisosToolStripMenuItem.Size = new System.Drawing.Size(344, 36);
            this.modificarPermisosToolStripMenuItem.Text = "Modificar roles y permisos";
            this.modificarPermisosToolStripMenuItem.Click += new System.EventHandler(this.modificarPermisosToolStripMenuItem_Click);
            // 
            // GestionDeBackupsToolStripMenuItem
            // 
            this.GestionDeBackupsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.GestionDeBackupsToolStripMenuItem.Name = "GestionDeBackupsToolStripMenuItem";
            this.GestionDeBackupsToolStripMenuItem.Size = new System.Drawing.Size(199, 32);
            this.GestionDeBackupsToolStripMenuItem.Text = "Gestion de backups";
            this.GestionDeBackupsToolStripMenuItem.Click += new System.EventHandler(this.gestionDeBackupsToolStripMenuItem_Click);
            // 
            // Cambiar_contrasenaToolStripMenuItem
            // 
            this.Cambiar_contrasenaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Cambiar_contrasenaToolStripMenuItem.Name = "Cambiar_contrasenaToolStripMenuItem";
            this.Cambiar_contrasenaToolStripMenuItem.Size = new System.Drawing.Size(201, 32);
            this.Cambiar_contrasenaToolStripMenuItem.Text = "Cambiar contraseña";
            this.Cambiar_contrasenaToolStripMenuItem.Click += new System.EventHandler(this.cambiarcontToolStripMenuItem_Click);
            // 
            // PlanillasDeProduccionToolStripMenuItem
            // 
            this.PlanillasDeProduccionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CrearPlanillaDeProduccionToolStripMenuItem,
            this.ModificarPlanillaDeProduccionToolStripMenuItem,
            this.ImprimirToolStripMenuItem});
            this.PlanillasDeProduccionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.PlanillasDeProduccionToolStripMenuItem.Name = "PlanillasDeProduccionToolStripMenuItem";
            this.PlanillasDeProduccionToolStripMenuItem.Size = new System.Drawing.Size(235, 32);
            this.PlanillasDeProduccionToolStripMenuItem.Text = "Planillas de produccion ";
            // 
            // CrearPlanillaDeProduccionToolStripMenuItem
            // 
            this.CrearPlanillaDeProduccionToolStripMenuItem.Name = "CrearPlanillaDeProduccionToolStripMenuItem";
            this.CrearPlanillaDeProduccionToolStripMenuItem.Size = new System.Drawing.Size(398, 36);
            this.CrearPlanillaDeProduccionToolStripMenuItem.Text = "Crear planilla de produccion";
            this.CrearPlanillaDeProduccionToolStripMenuItem.Click += new System.EventHandler(this.crearPlanillaDeProduccionToolStripMenuItem_Click);
            // 
            // ModificarPlanillaDeProduccionToolStripMenuItem
            // 
            this.ModificarPlanillaDeProduccionToolStripMenuItem.Name = "ModificarPlanillaDeProduccionToolStripMenuItem";
            this.ModificarPlanillaDeProduccionToolStripMenuItem.Size = new System.Drawing.Size(398, 36);
            this.ModificarPlanillaDeProduccionToolStripMenuItem.Text = "Modificar planilla de produccion";
            this.ModificarPlanillaDeProduccionToolStripMenuItem.Click += new System.EventHandler(this.modificarPlanillaDeProduccionToolStripMenuItem_Click);
            // 
            // ImprimirToolStripMenuItem
            // 
            this.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem";
            this.ImprimirToolStripMenuItem.Size = new System.Drawing.Size(398, 36);
            this.ImprimirToolStripMenuItem.Text = "Imprimir planilla de produccion";
            this.ImprimirToolStripMenuItem.Click += new System.EventHandler(this.ImprimirToolStripMenuItem_Click);
            // 
            // lotesToolStripMenuItem
            // 
            this.lotesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CrearLoteNuevoToolStripMenuItem,
            this.VerYModificarStockDeLoteToolStripMenuItem});
            this.lotesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lotesToolStripMenuItem.Name = "lotesToolStripMenuItem";
            this.lotesToolStripMenuItem.Size = new System.Drawing.Size(74, 32);
            this.lotesToolStripMenuItem.Text = "Lotes";
            // 
            // CrearLoteNuevoToolStripMenuItem
            // 
            this.CrearLoteNuevoToolStripMenuItem.Name = "CrearLoteNuevoToolStripMenuItem";
            this.CrearLoteNuevoToolStripMenuItem.Size = new System.Drawing.Size(362, 36);
            this.CrearLoteNuevoToolStripMenuItem.Text = "Crear lote nuevo";
            this.CrearLoteNuevoToolStripMenuItem.Click += new System.EventHandler(this.crearLoteNuevoToolStripMenuItem1_Click);
            // 
            // VerYModificarStockDeLoteToolStripMenuItem
            // 
            this.VerYModificarStockDeLoteToolStripMenuItem.Name = "VerYModificarStockDeLoteToolStripMenuItem";
            this.VerYModificarStockDeLoteToolStripMenuItem.Size = new System.Drawing.Size(362, 36);
            this.VerYModificarStockDeLoteToolStripMenuItem.Text = "Ver y modificar stock de lote";
            this.VerYModificarStockDeLoteToolStripMenuItem.Click += new System.EventHandler(this.verYModificarStockDeLoteToolStripMenuItem_Click);
            // 
            // CerrarSesionToolStripMenuItem
            // 
            this.CerrarSesionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CerrarSesionToolStripMenuItem.Name = "CerrarSesionToolStripMenuItem";
            this.CerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(140, 32);
            this.CerrarSesionToolStripMenuItem.Text = "Cerrar sesion";
            this.CerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click_1);
            // 
            // SalirToolStripMenuItem
            // 
            this.SalirToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem";
            this.SalirToolStripMenuItem.Size = new System.Drawing.Size(66, 32);
            this.SalirToolStripMenuItem.Text = "Salir";
            this.SalirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Menu_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2564, 985);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Menu_principal";
            this.Text = "PanApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_principal_FormClosing);
            this.Load += new System.EventHandler(this.Menu_principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SalirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NuevoPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditarPedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Anular_ConfirmarPedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditarPreciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDePreciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReporteDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FacturacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturarPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AdministradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarPermisosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GestionDeBackupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Cambiar_contrasenaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PlanillasDeProduccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CrearLoteNuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VerYModificarStockDeLoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CrearPlanillaDeProduccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ModificarPlanillaDeProduccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ImprimirToolStripMenuItem;
    }
}

