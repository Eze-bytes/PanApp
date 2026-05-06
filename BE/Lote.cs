using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace BE
{
    public class Lote
    {
        private DateTime VFecha_de_vencimiento;

        private Pan_hamburguesa_comun Phc { get; set; }
        private Pan_hamburguesa_maxi Pmm { get; set; }
        private Pan_lactal_chico Plc { get; set; }
        private Pan_lactal_grande Plg { get; set; }
        private Pan_pancho_chico Ppc { get; set; }
        private Pan_pancho_maxi Ppm { get; set; }

        public Pan_hamburguesa_comun retorna_Phc() { return Phc; }
        public Pan_hamburguesa_maxi retorna_Pmm() { return Pmm; }
        public Pan_lactal_chico retorna_Plc() { return Plc; }
        public Pan_lactal_grande retorna_Plg() { return Plg; }
        public Pan_pancho_chico retorna_Ppc() { return Ppc; }
        public Pan_pancho_maxi retorna_Ppm() { return Ppm; }

        #region Propiedades
        public int Nro_lote { get; set; }
        public DateTime Fecha_de_vencimiento { get { return VFecha_de_vencimiento; } set { VFecha_de_vencimiento = value; } }

        #endregion


        #region Constructores

        public Lote()
        {
            Nro_lote = DateTime.Now.DayOfYear;                  //genera el nro de lote con el numero del dia
            Fecha_de_vencimiento = DateTime.Now.AddDays(15);   ///genera el vencimiento al lote 

        }
        #endregion

        public List<Panificados> retorna_panificados() // retorna lista de productos del lote
        {

            List<Panificados> Lista_panificados = new List<Panificados>();

            if (this.Phc != null) { Lista_panificados.Add(this.Phc); }
            if (this.Pmm != null) { Lista_panificados.Add(this.Pmm); }
            if (this.Plc != null) { Lista_panificados.Add(this.Plc); }
            if (this.Plg != null) { Lista_panificados.Add(this.Plg); }
            if (this.Ppc != null) { Lista_panificados.Add(this.Ppc); }
            if (this.Ppm != null) { Lista_panificados.Add(this.Ppm); }

            return Lista_panificados;
        }



        public void agregar_a_lote(Panificados p)
        {

            p.Nro_lote = Nro_lote;

            switch (p.Peso)
            {
                case 200:
                    this.Phc = (Pan_hamburguesa_comun)p;
                    break;

                case 320:
                    this.Pmm = (Pan_hamburguesa_maxi)p;
                    break;

                case 300:
                    this.Plc = (Pan_lactal_chico)p;
                    break;

                case 600:
                    this.Plg = (Pan_lactal_grande)p;
                    break;

                case 230:
                    this.Ppc = (Pan_pancho_chico)p;
                    break;

                case 350:
                    this.Ppm = (Pan_pancho_maxi)p;
                    break;
            }

        }




        public void modificar_stock_lote(Panificados p)
        {
            p.Nro_lote = this.Nro_lote;

            foreach (Panificados pa in this.retorna_panificados())
            {

                if (pa.GetType() == p.GetType())
                {
                    if (p.Unidades > 0)
                    {
                        pa.Unidades = p.Unidades;
                        break;
                    }

                }
            }
        }
    }
}
