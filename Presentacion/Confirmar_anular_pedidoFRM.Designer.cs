
namespace Presentacion
{
    partial class Confirmar_anular_pedidoFRM
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
            this.confirmarbtn = new System.Windows.Forms.Button();
            this.anularbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_pedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaclientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(662, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pedidos";
            // 
            // grilla_pedidos
            // 
            this.grilla_pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_pedidos.Location = new System.Drawing.Point(529, 104);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Clientes";
            // 
            // grillaclientes
            // 
            this.grillaclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaclientes.Location = new System.Drawing.Point(36, 104);
            this.grillaclientes.MultiSelect = false;
            this.grillaclientes.Name = "grillaclientes";
            this.grillaclientes.ReadOnly = true;
            this.grillaclientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaclientes.Size = new System.Drawing.Size(394, 207);
            this.grillaclientes.TabIndex = 5;
            this.grillaclientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaclientes_CellClick);
            // 
            // confirmarbtn
            // 
            this.confirmarbtn.Location = new System.Drawing.Point(381, 359);
            this.confirmarbtn.Name = "confirmarbtn";
            this.confirmarbtn.Size = new System.Drawing.Size(134, 23);
            this.confirmarbtn.TabIndex = 9;
            this.confirmarbtn.Text = "CONFIRMAR PEDIDO";
            this.confirmarbtn.UseVisualStyleBackColor = true;
            this.confirmarbtn.Click += new System.EventHandler(this.confirmarbtn_Click);
            // 
            // anularbtn
            // 
            this.anularbtn.Location = new System.Drawing.Point(381, 408);
            this.anularbtn.Name = "anularbtn";
            this.anularbtn.Size = new System.Drawing.Size(134, 23);
            this.anularbtn.TabIndex = 10;
            this.anularbtn.Text = "ANULAR PEDIDO";
            this.anularbtn.UseVisualStyleBackColor = true;
            this.anularbtn.Click += new System.EventHandler(this.anularbtn_Click);
            // 
            // Confirmar_anular_pedidoFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 502);
            this.Controls.Add(this.anularbtn);
            this.Controls.Add(this.confirmarbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grilla_pedidos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grillaclientes);
            this.Name = "Confirmar_anular_pedidoFRM";
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.Confirmar_anular_pedidoFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla_pedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaclientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grilla_pedidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grillaclientes;
        private System.Windows.Forms.Button confirmarbtn;
        private System.Windows.Forms.Button anularbtn;
    }
}