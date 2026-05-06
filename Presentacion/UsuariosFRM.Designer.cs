
namespace Presentacion
{
    partial class UsuariosFRM
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
            this.grilla_usuarios = new System.Windows.Forms.DataGridView();
            this.altabtn = new System.Windows.Forms.Button();
            this.modbtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // grilla_usuarios
            // 
            this.grilla_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_usuarios.Location = new System.Drawing.Point(75, 46);
            this.grilla_usuarios.MultiSelect = false;
            this.grilla_usuarios.Name = "grilla_usuarios";
            this.grilla_usuarios.ReadOnly = true;
            this.grilla_usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grilla_usuarios.Size = new System.Drawing.Size(358, 213);
            this.grilla_usuarios.TabIndex = 0;
            // 
            // altabtn
            // 
            this.altabtn.Location = new System.Drawing.Point(520, 60);
            this.altabtn.Name = "altabtn";
            this.altabtn.Size = new System.Drawing.Size(139, 38);
            this.altabtn.TabIndex = 1;
            this.altabtn.Text = "Alta de usuario";
            this.altabtn.UseVisualStyleBackColor = true;
            this.altabtn.Click += new System.EventHandler(this.altabtn_Click);
            // 
            // modbtn
            // 
            this.modbtn.Location = new System.Drawing.Point(520, 129);
            this.modbtn.Name = "modbtn";
            this.modbtn.Size = new System.Drawing.Size(139, 36);
            this.modbtn.TabIndex = 2;
            this.modbtn.Text = "Modificar usuario";
            this.modbtn.UseVisualStyleBackColor = true;
            this.modbtn.Click += new System.EventHandler(this.modbtn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(520, 203);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 31);
            this.button3.TabIndex = 3;
            this.button3.Text = "Eliminar usuario";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // UsuariosFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 317);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.modbtn);
            this.Controls.Add(this.altabtn);
            this.Controls.Add(this.grilla_usuarios);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Name = "UsuariosFRM";
            this.Text = "Usuarios";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UsuariosFRM_FormClosed);
            this.Load += new System.EventHandler(this.UsuariosFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla_usuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grilla_usuarios;
        private System.Windows.Forms.Button altabtn;
        private System.Windows.Forms.Button modbtn;
        private System.Windows.Forms.Button button3;
    }
}