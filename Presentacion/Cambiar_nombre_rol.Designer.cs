
namespace Presentacion
{
    partial class Cambiar_nombre_rolFRM
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
            this.guardarbtn = new System.Windows.Forms.Button();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guardarbtn
            // 
            this.guardarbtn.Location = new System.Drawing.Point(87, 108);
            this.guardarbtn.Name = "guardarbtn";
            this.guardarbtn.Size = new System.Drawing.Size(136, 27);
            this.guardarbtn.TabIndex = 0;
            this.guardarbtn.Text = "Guardar";
            this.guardarbtn.UseVisualStyleBackColor = true;
            this.guardarbtn.Click += new System.EventHandler(this.guardarbtn_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(87, 57);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(136, 28);
            this.txtnombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(39, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Escriba el nuevo nombre de rol";
            // 
            // Cambiar_nombre_rolFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 174);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.guardarbtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Name = "Cambiar_nombre_rolFRM";
            this.Text = "Cambiar nombre de rol";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Cambiar_nombre_rolFRM_FormClosed);
            this.Load += new System.EventHandler(this.Cambiar_nombre_rol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button guardarbtn;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label1;
    }
}