
namespace Presentacion
{
    partial class ClientesFrm
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
            this.Modificacionbtn = new System.Windows.Forms.Button();
            this.Altabtn = new System.Windows.Forms.Button();
            this.Bajabtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaclientes)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaclientes
            // 
            this.grillaclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaclientes.Location = new System.Drawing.Point(24, 25);
            this.grillaclientes.MultiSelect = false;
            this.grillaclientes.Name = "grillaclientes";
            this.grillaclientes.ReadOnly = true;
            this.grillaclientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaclientes.Size = new System.Drawing.Size(1033, 250);
            this.grillaclientes.TabIndex = 0;
            // 
            // Modificacionbtn
            // 
            this.Modificacionbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Modificacionbtn.Location = new System.Drawing.Point(1076, 125);
            this.Modificacionbtn.Name = "Modificacionbtn";
            this.Modificacionbtn.Size = new System.Drawing.Size(118, 27);
            this.Modificacionbtn.TabIndex = 4;
            this.Modificacionbtn.Text = "Modificar cliente";
            this.Modificacionbtn.UseVisualStyleBackColor = true;
            this.Modificacionbtn.Click += new System.EventHandler(this.Modificacionbtn_Click);
            // 
            // Altabtn
            // 
            this.Altabtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Altabtn.Location = new System.Drawing.Point(1076, 53);
            this.Altabtn.Name = "Altabtn";
            this.Altabtn.Size = new System.Drawing.Size(114, 27);
            this.Altabtn.TabIndex = 5;
            this.Altabtn.Text = "Alta de cliente";
            this.Altabtn.UseVisualStyleBackColor = true;
            this.Altabtn.Click += new System.EventHandler(this.Altabtn_Click_1);
            // 
            // Bajabtn
            // 
            this.Bajabtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Bajabtn.Location = new System.Drawing.Point(1076, 183);
            this.Bajabtn.Name = "Bajabtn";
            this.Bajabtn.Size = new System.Drawing.Size(118, 27);
            this.Bajabtn.TabIndex = 7;
            this.Bajabtn.Text = "Eliminar cliente";
            this.Bajabtn.UseVisualStyleBackColor = true;
            this.Bajabtn.Click += new System.EventHandler(this.Bajabtn_Click_1);
            // 
            // ClientesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 285);
            this.Controls.Add(this.Bajabtn);
            this.Controls.Add(this.Altabtn);
            this.Controls.Add(this.Modificacionbtn);
            this.Controls.Add(this.grillaclientes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Name = "ClientesFrm";
            this.Text = "Clientes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClientesFrm_FormClosed);
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.Enter += new System.EventHandler(this.ClientesFrm_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.grillaclientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaclientes;
        private System.Windows.Forms.Button Modificacionbtn;
        private System.Windows.Forms.Button Altabtn;
        private System.Windows.Forms.Button Bajabtn;
    }
}