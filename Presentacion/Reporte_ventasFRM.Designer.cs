
namespace Presentacion
{
    partial class Reporte_ventasFRM
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.fechapic = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pickerinicio = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.pickerfin = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.graficarbtn = new System.Windows.Forms.Button();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label9 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pickerfinuni = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.pickeriniciouni = new System.Windows.Forms.DateTimePicker();
            this.graficarbtn2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // fechapic
            // 
            this.fechapic.Location = new System.Drawing.Point(754, 1179);
            this.fechapic.Name = "fechapic";
            this.fechapic.Size = new System.Drawing.Size(200, 20);
            this.fechapic.TabIndex = 1;
            this.fechapic.ValueChanged += new System.EventHandler(this.fechapic_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(587, 476);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reporte de ventas totales por intervalo de cada producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(751, 1143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seleccione la fecha correspondiente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(700, 507);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "por unidades";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(322, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "en pesos";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(199, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(369, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Reporte de ventas totales por intervalo de cada producto";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(102, 65);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(594, 252);
            this.chart2.TabIndex = 5;
            this.chart2.Text = "chart2";
            // 
            // pickerinicio
            // 
            this.pickerinicio.Location = new System.Drawing.Point(171, 380);
            this.pickerinicio.Name = "pickerinicio";
            this.pickerinicio.Size = new System.Drawing.Size(200, 20);
            this.pickerinicio.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.Location = new System.Drawing.Point(250, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(280, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Seleccione el intervalo de tiempo correspondiente";
            // 
            // pickerfin
            // 
            this.pickerfin.Location = new System.Drawing.Point(393, 380);
            this.pickerfin.Name = "pickerfin";
            this.pickerfin.Size = new System.Drawing.Size(200, 20);
            this.pickerfin.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label7.Location = new System.Drawing.Point(250, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Desde";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label8.Location = new System.Drawing.Point(474, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Hasta";
            // 
            // graficarbtn
            // 
            this.graficarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.graficarbtn.Location = new System.Drawing.Point(351, 422);
            this.graficarbtn.Name = "graficarbtn";
            this.graficarbtn.Size = new System.Drawing.Size(75, 23);
            this.graficarbtn.TabIndex = 13;
            this.graficarbtn.Text = "Graficar";
            this.graficarbtn.UseVisualStyleBackColor = true;
            this.graficarbtn.Click += new System.EventHandler(this.graficarbtn_Click);
            // 
            // chart3
            // 
            chartArea2.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart3.Legends.Add(legend2);
            this.chart3.Location = new System.Drawing.Point(869, 65);
            this.chart3.Name = "chart3";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart3.Series.Add(series2);
            this.chart3.Size = new System.Drawing.Size(406, 257);
            this.chart3.TabIndex = 14;
            this.chart3.Text = "chart3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(1025, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "En porcentaje";
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(408, 536);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(760, 240);
            this.chart1.TabIndex = 16;
            this.chart1.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button1.Location = new System.Drawing.Point(315, 1060);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Graficar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label10.Location = new System.Drawing.Point(878, 822);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "Hasta";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label11.Location = new System.Drawing.Point(658, 822);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 15);
            this.label11.TabIndex = 20;
            this.label11.Text = "Desde";
            // 
            // pickerfinuni
            // 
            this.pickerfinuni.Location = new System.Drawing.Point(801, 840);
            this.pickerfinuni.Name = "pickerfinuni";
            this.pickerfinuni.Size = new System.Drawing.Size(200, 20);
            this.pickerfinuni.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label12.Location = new System.Drawing.Point(658, 790);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(280, 15);
            this.label12.TabIndex = 18;
            this.label12.Text = "Seleccione el intervalo de tiempo correspondiente";
            // 
            // pickeriniciouni
            // 
            this.pickeriniciouni.Location = new System.Drawing.Point(579, 840);
            this.pickeriniciouni.Name = "pickeriniciouni";
            this.pickeriniciouni.Size = new System.Drawing.Size(200, 20);
            this.pickeriniciouni.TabIndex = 17;
            // 
            // graficarbtn2
            // 
            this.graficarbtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.graficarbtn2.Location = new System.Drawing.Point(751, 875);
            this.graficarbtn2.Name = "graficarbtn2";
            this.graficarbtn2.Size = new System.Drawing.Size(75, 23);
            this.graficarbtn2.TabIndex = 23;
            this.graficarbtn2.Text = "Graficar";
            this.graficarbtn2.UseVisualStyleBackColor = true;
            this.graficarbtn2.Click += new System.EventHandler(this.graficarbtn2_Click);
            // 
            // Reporte_ventasFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 905);
            this.Controls.Add(this.graficarbtn2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pickerfinuni);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pickeriniciouni);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.graficarbtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pickerfin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pickerinicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fechapic);
            this.Name = "Reporte_ventasFRM";
            this.Text = "Reporte de ventas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Reporte_ventasFRM_FormClosed);
            this.Load += new System.EventHandler(this.Reporte_diarioFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker fechapic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DateTimePicker pickerinicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker pickerfin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button graficarbtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker pickerfinuni;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker pickeriniciouni;
        private System.Windows.Forms.Button graficarbtn2;
    }
}