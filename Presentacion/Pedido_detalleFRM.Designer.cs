
namespace Presentacion
{
    partial class Pedido_detalleFRM
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
            this.grabarpedidobtn = new System.Windows.Forms.Button();
            this.grilla_lote = new System.Windows.Forms.DataGridView();
            this.combolotes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.unitxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grilla_pedido = new System.Windows.Forms.DataGridView();
            this.agregarbtn = new System.Windows.Forms.Button();
            this.modbtn = new System.Windows.Forms.Button();
            this.borrartxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nropedidotxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.modpedidobtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_lote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_pedido)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grabarpedidobtn
            // 
            this.grabarpedidobtn.Location = new System.Drawing.Point(1105, 270);
            this.grabarpedidobtn.Name = "grabarpedidobtn";
            this.grabarpedidobtn.Size = new System.Drawing.Size(182, 70);
            this.grabarpedidobtn.TabIndex = 0;
            this.grabarpedidobtn.Text = "guardar pedido";
            this.grabarpedidobtn.UseVisualStyleBackColor = true;
            this.grabarpedidobtn.Click += new System.EventHandler(this.grabarpedidobtn_Click);
            // 
            // grilla_lote
            // 
            this.grilla_lote.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grilla_lote.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grilla_lote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_lote.Location = new System.Drawing.Point(205, 52);
            this.grilla_lote.MultiSelect = false;
            this.grilla_lote.Name = "grilla_lote";
            this.grilla_lote.ReadOnly = true;
            this.grilla_lote.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grilla_lote.Size = new System.Drawing.Size(668, 257);
            this.grilla_lote.TabIndex = 1;
            // 
            // combolotes
            // 
            this.combolotes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combolotes.FormattingEnabled = true;
            this.combolotes.Location = new System.Drawing.Point(21, 83);
            this.combolotes.Name = "combolotes";
            this.combolotes.Size = new System.Drawing.Size(140, 23);
            this.combolotes.TabIndex = 6;
            this.combolotes.SelectionChangeCommitted += new System.EventHandler(this.combolotes_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lote Nro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Productos del lote";
            // 
            // unitxt
            // 
            this.unitxt.Location = new System.Drawing.Point(255, 57);
            this.unitxt.Name = "unitxt";
            this.unitxt.Size = new System.Drawing.Size(111, 21);
            this.unitxt.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Unidades";
            // 
            // grilla_pedido
            // 
            this.grilla_pedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grilla_pedido.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grilla_pedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_pedido.Location = new System.Drawing.Point(205, 401);
            this.grilla_pedido.MultiSelect = false;
            this.grilla_pedido.Name = "grilla_pedido";
            this.grilla_pedido.ReadOnly = true;
            this.grilla_pedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grilla_pedido.Size = new System.Drawing.Size(668, 257);
            this.grilla_pedido.TabIndex = 14;
            // 
            // agregarbtn
            // 
            this.agregarbtn.Location = new System.Drawing.Point(33, 31);
            this.agregarbtn.Name = "agregarbtn";
            this.agregarbtn.Size = new System.Drawing.Size(184, 47);
            this.agregarbtn.TabIndex = 15;
            this.agregarbtn.Text = "Agregar producto";
            this.agregarbtn.UseVisualStyleBackColor = true;
            this.agregarbtn.Click += new System.EventHandler(this.agregarbtn_Click);
            // 
            // modbtn
            // 
            this.modbtn.Location = new System.Drawing.Point(28, 31);
            this.modbtn.Name = "modbtn";
            this.modbtn.Size = new System.Drawing.Size(186, 51);
            this.modbtn.TabIndex = 16;
            this.modbtn.Text = "Eliminar";
            this.modbtn.UseVisualStyleBackColor = true;
            this.modbtn.Click += new System.EventHandler(this.modbtn_Click);
            // 
            // borrartxt
            // 
            this.borrartxt.Location = new System.Drawing.Point(252, 49);
            this.borrartxt.Name = "borrartxt";
            this.borrartxt.Size = new System.Drawing.Size(111, 21);
            this.borrartxt.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(483, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Pedido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Unidades";
            // 
            // nropedidotxt
            // 
            this.nropedidotxt.Location = new System.Drawing.Point(1125, 25);
            this.nropedidotxt.Name = "nropedidotxt";
            this.nropedidotxt.ReadOnly = true;
            this.nropedidotxt.Size = new System.Drawing.Size(116, 21);
            this.nropedidotxt.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1147, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Nro Pedido";
            // 
            // modpedidobtn
            // 
            this.modpedidobtn.Location = new System.Drawing.Point(1105, 401);
            this.modpedidobtn.Name = "modpedidobtn";
            this.modpedidobtn.Size = new System.Drawing.Size(182, 70);
            this.modpedidobtn.TabIndex = 22;
            this.modpedidobtn.Text = "guardar modificacion de pedido";
            this.modpedidobtn.UseVisualStyleBackColor = true;
            this.modpedidobtn.Click += new System.EventHandler(this.modpedidobtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.modbtn);
            this.groupBox1.Controls.Add(this.borrartxt);
            this.groupBox1.Location = new System.Drawing.Point(924, 566);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 90);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eliminar unidades";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.agregarbtn);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.unitxt);
            this.groupBox2.Location = new System.Drawing.Point(921, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 104);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregar";
            // 
            // Pedido_detalleFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 694);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.modpedidobtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nropedidotxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grilla_pedido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combolotes);
            this.Controls.Add(this.grilla_lote);
            this.Controls.Add(this.grabarpedidobtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Name = "Pedido_detalleFRM";
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.Pedido_detalleFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla_lote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_pedido)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button grabarpedidobtn;
        private System.Windows.Forms.DataGridView grilla_lote;
        private System.Windows.Forms.ComboBox combolotes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox unitxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView grilla_pedido;
        private System.Windows.Forms.Button agregarbtn;
        private System.Windows.Forms.Button modbtn;
        private System.Windows.Forms.TextBox borrartxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nropedidotxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button modpedidobtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}