
namespace Presentacion
{
    partial class Resumen_pedido_facturadoFRM
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
            this.fechatxt = new System.Windows.Forms.TextBox();
            this.grilla_fac = new System.Windows.Forms.DataGridView();
            this.totaltxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cerrarbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nropedidotxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_fac)).BeginInit();
            this.SuspendLayout();
            // 
            // fechatxt
            // 
            this.fechatxt.Location = new System.Drawing.Point(804, 47);
            this.fechatxt.Name = "fechatxt";
            this.fechatxt.ReadOnly = true;
            this.fechatxt.Size = new System.Drawing.Size(116, 21);
            this.fechatxt.TabIndex = 0;
            this.fechatxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grilla_fac
            // 
            this.grilla_fac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_fac.Location = new System.Drawing.Point(69, 65);
            this.grilla_fac.Name = "grilla_fac";
            this.grilla_fac.Size = new System.Drawing.Size(697, 309);
            this.grilla_fac.TabIndex = 1;
            // 
            // totaltxt
            // 
            this.totaltxt.Location = new System.Drawing.Point(820, 410);
            this.totaltxt.Name = "totaltxt";
            this.totaltxt.Size = new System.Drawing.Size(116, 21);
            this.totaltxt.TabIndex = 2;
            this.totaltxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(839, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha";
            // 
            // cerrarbtn
            // 
            this.cerrarbtn.Location = new System.Drawing.Point(321, 410);
            this.cerrarbtn.Name = "cerrarbtn";
            this.cerrarbtn.Size = new System.Drawing.Size(190, 38);
            this.cerrarbtn.TabIndex = 4;
            this.cerrarbtn.Text = "CERRAR";
            this.cerrarbtn.UseVisualStyleBackColor = true;
            this.cerrarbtn.Click += new System.EventHandler(this.cerrarbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(854, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "TOTAL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(793, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "$";
            // 
            // nropedidotxt
            // 
            this.nropedidotxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nropedidotxt.Location = new System.Drawing.Point(411, 26);
            this.nropedidotxt.Name = "nropedidotxt";
            this.nropedidotxt.ReadOnly = true;
            this.nropedidotxt.Size = new System.Drawing.Size(100, 23);
            this.nropedidotxt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(280, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "PEDIDO NUMERO";
            // 
            // Resumen_pedido_facturadoFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 470);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nropedidotxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cerrarbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totaltxt);
            this.Controls.Add(this.grilla_fac);
            this.Controls.Add(this.fechatxt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Name = "Resumen_pedido_facturadoFRM";
            this.Text = "Pedido facturado";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Resumen_pedido_facturadoFRM_FormClosed);
            this.Load += new System.EventHandler(this.Resumen_pedido_facturadoFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla_fac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fechatxt;
        private System.Windows.Forms.DataGridView grilla_fac;
        private System.Windows.Forms.TextBox totaltxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cerrarbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nropedidotxt;
        private System.Windows.Forms.Label label4;
    }
}