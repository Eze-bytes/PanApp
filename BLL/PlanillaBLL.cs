using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using Mapper;

namespace BLL
{
    public class PlanillaBLL
    {
        PlanillaMP pMP = new PlanillaMP();

        public bool Checkear_planilla() { return pMP.Checkear_planilla(); }

        public void Guardar_planilla(Planilla_produccion pl, bool modifica)
        {
            pMP.Guardar_planilla(pl, modifica);
        }

        public Planilla_produccion Retorna_planilla() { return pMP.Retorna_planilla(); }

    }
}
