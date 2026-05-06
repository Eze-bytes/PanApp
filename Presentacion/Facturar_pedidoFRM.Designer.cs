
namespace Presentacion
{
    partial class Facturar_pedidoFRM
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
            this.label2 = new System.Windows.Forms.Label();
            this.grilla_pedidos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.grillaclientes = new System.Windows.Forms.DataGridView();
            this.facturarbtn = new System.Windows.Forms.Button();
            this.dataSet1 = new System.Data.DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_pedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaclientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(634, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pedidos";
            // 
            // grilla_pedidos
            // 
            this.grilla_pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_pedidos.Location = new System.Drawing.Point(505, 74);
            this.grilla_pedidos.MultiSelect = false;
            this.grilla_pedidos.Name = "grilla_pedidos";
            this.grilla_pedidos.ReadOnly = true;
            this.grilla_pedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grilla_pedidos.Size = new System.Drawing.Size(317, 207);
            this.grilla_pedidos.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(197, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Clientes";
            // 
            // grillaclientes
            // 
            this.grillaclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaclientes.Location = new System.Drawing.Point(56, 74);
            this.grillaclientes.MultiSelect = false;
            this.grillaclientes.Name = "grillaclientes";
            this.grillaclientes.ReadOnly = true;
            this.grillaclientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaclientes.Size = new System.Drawing.Size(394, 207);
            this.grillaclientes.TabIndex = 5;
            this.grillaclientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaclientes_CellClick);
            // 
            // facturarbtn
            // 
            this.facturarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.facturarbtn.Location = new System.Drawing.Point(595, 302);
            this.facturarbtn.Name = "facturarbtn";
            this.facturarbtn.Size = new System.Drawing.Size(129, 28);
            this.facturarbtn.TabIndex = 9;
            this.facturarbtn.Text = "Facturar pedido";
            this.facturarbtn.UseVisualStyleBackColor = true;
            this.facturarbtn.Click += new System.EventHandler(this.facturarbtn_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // Facturar_pedidoFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 360);
            this.Controls.Add(this.facturarbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grilla_pedidos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grillaclientes);
            this.Name = "Facturar_pedidoFRM";
            this.Text = "Facturar pedido";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Facturar_pedidoFRM_FormClosed);
            this.Load += new System.EventHandler(this.Facturar_pedidoFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla_pedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaclientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grilla_pedidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grillaclientes;
        private System.Windows.Forms.Button facturarbtn;
        private System.Data.DataSet dataSet1;
    }
}