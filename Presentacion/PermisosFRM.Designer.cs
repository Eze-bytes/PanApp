
namespace Presentacion
{
    partial class PermisosFRM
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
            this.arbol_permisos = new System.Windows.Forms.TreeView();
            this.agregarrolbtn = new System.Windows.Forms.Button();
            this.desctxt = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.combo_permisos = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.combo_roles = new System.Windows.Forms.ComboBox();
            this.modrolbtn = new System.Windows.Forms.Button();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.borrar_permisobtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.combo_usuarios = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.eliminar_rolbtn = new System.Windows.Forms.Button();
            this.grilla_roles = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.borrardeusubtn = new System.Windows.Forms.Button();
            this.agregarusubtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_roles)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // arbol_permisos
            // 
            this.arbol_permisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.arbol_permisos.Location = new System.Drawing.Point(360, 37);
            this.arbol_permisos.Name = "arbol_permisos";
            this.arbol_permisos.Size = new System.Drawing.Size(574, 280);
            this.arbol_permisos.TabIndex = 0;
            // 
            // agregarrolbtn
            // 
            this.agregarrolbtn.Location = new System.Drawing.Point(97, 81);
            this.agregarrolbtn.Name = "agregarrolbtn";
            this.agregarrolbtn.Size = new System.Drawing.Size(75, 23);
            this.agregarrolbtn.TabIndex = 1;
            this.agregarrolbtn.Text = "Nuevo Rol";
            this.agregarrolbtn.UseVisualStyleBackColor = true;
            this.agregarrolbtn.Click += new System.EventHandler(this.agregarrolbtn_Click);
            // 
            // desctxt
            // 
            this.desctxt.Location = new System.Drawing.Point(26, 43);
            this.desctxt.Name = "desctxt";
            this.desctxt.Size = new System.Drawing.Size(100, 21);
            this.desctxt.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Agregar permiso al rol";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // combo_permisos
            // 
            this.combo_permisos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_permisos.FormattingEnabled = true;
            this.combo_permisos.Location = new System.Drawing.Point(184, 34);
            this.combo_permisos.Name = "combo_permisos";
            this.combo_permisos.Size = new System.Drawing.Size(377, 23);
            this.combo_permisos.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.combo_roles);
            this.groupBox1.Controls.Add(this.modrolbtn);
            this.groupBox1.Controls.Add(this.idtxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.desctxt);
            this.groupBox1.Controls.Add(this.agregarrolbtn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox1.Location = new System.Drawing.Point(42, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 252);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Roles";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(81, 129);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(80, 15);
            this.label22.TabIndex = 22;
            this.label22.Text = "Lista de roles";
            // 
            // combo_roles
            // 
            this.combo_roles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_roles.FormattingEnabled = true;
            this.combo_roles.Location = new System.Drawing.Point(42, 161);
            this.combo_roles.Name = "combo_roles";
            this.combo_roles.Size = new System.Drawing.Size(162, 23);
            this.combo_roles.TabIndex = 21;
            // 
            // modrolbtn
            // 
            this.modrolbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.modrolbtn.Location = new System.Drawing.Point(42, 203);
            this.modrolbtn.Name = "modrolbtn";
            this.modrolbtn.Size = new System.Drawing.Size(162, 23);
            this.modrolbtn.TabIndex = 20;
            this.modrolbtn.Text = "Modificar nombre de rol";
            this.modrolbtn.UseVisualStyleBackColor = true;
            this.modrolbtn.Click += new System.EventHandler(this.modrolbtn_Click);
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(135, 43);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(100, 21);
            this.idtxt.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.combo_permisos);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox2.Location = new System.Drawing.Point(41, 354);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(574, 79);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Permisos";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(296, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 15);
            this.label10.TabIndex = 6;
            this.label10.Text = "Nombre de permiso";
            // 
            // borrar_permisobtn
            // 
            this.borrar_permisobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.borrar_permisobtn.Location = new System.Drawing.Point(444, 323);
            this.borrar_permisobtn.Name = "borrar_permisobtn";
            this.borrar_permisobtn.Size = new System.Drawing.Size(192, 23);
            this.borrar_permisobtn.TabIndex = 9;
            this.borrar_permisobtn.Text = "Eliminar permiso del rol";
            this.borrar_permisobtn.UseVisualStyleBackColor = true;
            this.borrar_permisobtn.Click += new System.EventHandler(this.borrar_permisobtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(596, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Roles y permisos";
            // 
            // combo_usuarios
            // 
            this.combo_usuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_usuarios.FormattingEnabled = true;
            this.combo_usuarios.Location = new System.Drawing.Point(84, 75);
            this.combo_usuarios.Name = "combo_usuarios";
            this.combo_usuarios.Size = new System.Drawing.Size(233, 23);
            this.combo_usuarios.TabIndex = 12;
            this.combo_usuarios.SelectionChangeCommitted += new System.EventHandler(this.combo_usuarios_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Usuarios";
            // 
            // eliminar_rolbtn
            // 
            this.eliminar_rolbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.eliminar_rolbtn.Location = new System.Drawing.Point(662, 323);
            this.eliminar_rolbtn.Name = "eliminar_rolbtn";
            this.eliminar_rolbtn.Size = new System.Drawing.Size(162, 23);
            this.eliminar_rolbtn.TabIndex = 16;
            this.eliminar_rolbtn.Text = "Eliminar Rol";
            this.eliminar_rolbtn.UseVisualStyleBackColor = true;
            this.eliminar_rolbtn.Click += new System.EventHandler(this.eliminar_rolbtn_Click);
            // 
            // grilla_roles
            // 
            this.grilla_roles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_roles.Location = new System.Drawing.Point(381, 57);
            this.grilla_roles.MultiSelect = false;
            this.grilla_roles.Name = "grilla_roles";
            this.grilla_roles.ReadOnly = true;
            this.grilla_roles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grilla_roles.Size = new System.Drawing.Size(417, 188);
            this.grilla_roles.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(533, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Roles del usuario";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.borrardeusubtn);
            this.groupBox3.Controls.Add(this.agregarusubtn);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.grilla_roles);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.combo_usuarios);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox3.Location = new System.Drawing.Point(42, 447);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(892, 277);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Usuarios";
            // 
            // borrardeusubtn
            // 
            this.borrardeusubtn.Location = new System.Drawing.Point(84, 191);
            this.borrardeusubtn.Name = "borrardeusubtn";
            this.borrardeusubtn.Size = new System.Drawing.Size(235, 23);
            this.borrardeusubtn.TabIndex = 21;
            this.borrardeusubtn.Text = "Borrar rol a usuario";
            this.borrardeusubtn.UseVisualStyleBackColor = true;
            this.borrardeusubtn.Click += new System.EventHandler(this.borrardeusubtn_Click);
            // 
            // agregarusubtn
            // 
            this.agregarusubtn.Location = new System.Drawing.Point(82, 132);
            this.agregarusubtn.Name = "agregarusubtn";
            this.agregarusubtn.Size = new System.Drawing.Size(235, 23);
            this.agregarusubtn.TabIndex = 20;
            this.agregarusubtn.Text = "Agregar rol seleccionado a usuario";
            this.agregarusubtn.UseVisualStyleBackColor = true;
            this.agregarusubtn.Click += new System.EventHandler(this.agregarusubtn_Click);
            // 
            // PermisosFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 734);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.eliminar_rolbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.borrar_permisobtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.arbol_permisos);
            this.Name = "PermisosFRM";
            this.Text = " Permisos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PermisosFRM_FormClosed);
            this.Load += new System.EventHandler(this.UsuariosFRM_Load);
            this.EnabledChanged += new System.EventHandler(this.PermisosFRM_EnabledChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_roles)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView arbol_permisos;
        private System.Windows.Forms.Button agregarrolbtn;
        private System.Windows.Forms.TextBox desctxt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox combo_permisos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button borrar_permisobtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combo_usuarios;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button eliminar_rolbtn;
        private System.Windows.Forms.DataGridView grilla_roles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button borrardeusubtn;
        private System.Windows.Forms.Button agregarusubtn;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button modrolbtn;
        private System.Windows.Forms.ComboBox combo_roles;
        private System.Windows.Forms.Label label22;
    }
}