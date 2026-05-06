using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Planilla_produccion
    {

        public DateTime Fecha_de_produccion { get; set; }
        public int Nro_lote { get; set; }
        private Pan_hamburguesa_comun Phc { get; set; }
        private Pan_hamburguesa_maxi Pmm { get; set; }
        private Pan_lactal_chico Plc { get; set; }
        private Pan_lactal_grande Plg { get; set; }
        private Pan_pancho_chico Ppc { get; set; }
        private Pan_pancho_maxi Ppm { get; set; }

        public Planilla_produccion()
        {
            Fecha_de_produccion = DateTime.Now.Date;
        }

        public List<Panificados> retorna_panificados()
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



        public void Agregar_a_planilla(Panificados p)
        {
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

    }
}
