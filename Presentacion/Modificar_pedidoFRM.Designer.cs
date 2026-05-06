
namespace Presentacion
{
    partial class Modificar_pedidoFRM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grillaclientes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.grilla_pedidos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.grilla_pedidos_detalle = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.modpedidobtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaclientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_pedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_pedidos_detalle)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaclientes
            // 
            this.grillaclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaclientes.Location = new System.Drawing.Point(33, 56);
            this.grillaclientes.MultiSelect = false;
            this.grillaclientes.Name = "grillaclientes";
            this.grillaclientes.ReadOnly = true;
            this.grillaclientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaclientes.Size = new System.Drawing.Size(394, 207);
            this.grillaclientes.TabIndex = 1;
            this.grillaclientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaclientes_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Clientes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // grilla_pedidos
            // 
            this.grilla_pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_pedidos.Location = new System.Drawing.Point(510, 56);
            this.grilla_pedidos.MultiSelect = false;
            this.grilla_pedidos.Name = "grilla_pedidos";
            this.grilla_pedidos.ReadOnly = true;
            this.grilla_pedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grilla_pedidos.Size = new System.Drawing.Size(317, 207);
            this.grilla_pedidos.TabIndex = 3;
            this.grilla_pedidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grilla_pedidos_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(639, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pedidos";
            // 
            // grilla_pedidos_detalle
            // 
            this.grilla_pedidos_detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_pedidos_detalle.Location = new System.Drawing.Point(951, 56);
            this.grilla_pedidos_detalle.MultiSelect = false;
            this.grilla_pedidos_detalle.Name = "grilla_pedidos_detalle";
            this.grilla_pedidos_detalle.ReadOnly = true;
            this.grilla_pedidos_detalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grilla_pedidos_detalle.Size = new System.Drawing.Size(317, 207);
            this.grilla_pedidos_detalle.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1051, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Detalle de pedido";
            // 
            // modpedidobtn
            // 
            this.modpedidobtn.Location = new System.Drawing.Point(568, 297);
            this.modpedidobtn.Name = "modpedidobtn";
            this.modpedidobtn.Size = new System.Drawing.Size(202, 23);
            this.modpedidobtn.TabIndex = 8;
            this.modpedidobtn.Text = "Modificar pedido seleccionado";
            this.modpedidobtn.UseVisualStyleBackColor = true;
            this.modpedidobtn.Click += new System.EventHandler(this.modpedidobtn_Click);
            // 
            // Modificar_pedidoFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 354);
            this.Controls.Add(this.modpedidobtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grilla_pedidos_detalle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grilla_pedidos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grillaclientes);
            this.Name = "Modificar_pedidoFRM";
            this.Text = "Modificar pedidos";
            this.Load += new System.EventHandler(this.ModificarpedidoFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaclientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_pedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_pedidos_detalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaclientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grilla_pedidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grilla_pedidos_detalle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button modpedidobtn;
    }
}