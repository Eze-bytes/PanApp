
namespace Presentacion
{
    partial class Listar_pedidoFRM
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
            this.grilla_pedidos_detalle = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.grilla_clientes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grilla_pedidos = new System.Windows.Forms.DataGridView();
            this.modbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_pedidos_detalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_pedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // grilla_pedidos_detalle
            // 
            this.grilla_pedidos_detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_pedidos_detalle.Location = new System.Drawing.Point(697, 105);
            this.grilla_pedidos_detalle.MultiSelect = false;
            this.grilla_pedidos_detalle.Name = "grilla_pedidos_detalle";
            this.grilla_pedidos_detalle.ReadOnly = true;
            this.grilla_pedidos_detalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grilla_pedidos_detalle.Size = new System.Drawing.Size(299, 222);
            this.grilla_pedidos_detalle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(785, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Detalle Pedidos";
            // 
            // grilla_clientes
            // 
            this.grilla_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_clientes.Location = new System.Drawing.Point(33, 105);
            this.grilla_clientes.MultiSelect = false;
            this.grilla_clientes.Name = "grilla_clientes";
            this.grilla_clientes.ReadOnly = true;
            this.grilla_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grilla_clientes.Size = new System.Drawing.Size(299, 222);
            this.grilla_clientes.TabIndex = 2;
            this.grilla_clientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grilla_clientes_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Clientes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(478, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pedido";
            // 
            // grilla_pedidos
            // 
            this.grilla_pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_pedidos.Location = new System.Drawing.Point(356, 105);
            this.grilla_pedidos.MultiSelect = false;
            this.grilla_pedidos.Name = "grilla_pedidos";
            this.grilla_pedidos.ReadOnly = true;
            this.grilla_pedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grilla_pedidos.Size = new System.Drawing.Size(299, 222);
            this.grilla_pedidos.TabIndex = 5;
            this.grilla_pedidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grilla_pedidos_CellClick);
            // 
            // modbtn
            // 
            this.modbtn.Location = new System.Drawing.Point(697, 367);
            this.modbtn.Name = "modbtn";
            this.modbtn.Size = new System.Drawing.Size(127, 38);
            this.modbtn.TabIndex = 6;
            this.modbtn.Text = "Modificar pedido";
            this.modbtn.UseVisualStyleBackColor = true;
            this.modbtn.Click += new System.EventHandler(this.modbtn_Click);
            // 
            // Listar_pedidoFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 530);
            this.Controls.Add(this.modbtn);
            this.Controls.Add(this.grilla_pedidos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grilla_clientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grilla_pedidos_detalle);
            this.Name = "Listar_pedidoFRM";
            this.Text = "Listar pedidos";
            this.Load += new System.EventHandler(this.Listar_pedidoFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla_pedidos_detalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_pedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grilla_pedidos_detalle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grilla_clientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView grilla_pedidos;
        private System.Windows.Forms.Button modbtn;
    }
}