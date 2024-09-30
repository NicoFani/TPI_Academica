using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Plans
    {
        public int AddPlan(string planDescription, int idSpeciality)
        {
            Datos.Plans plans = new Datos.Plans();
            return plans.AddPlan(planDescription, idSpeciality);
        }
        public void UpdatePlan(int idPlan, string planDescription, int idSpeciality)
        {
            Datos.Plans plans = new Datos.Plans();
            plans.UpdatePlan(idPlan, planDescription, idSpeciality);
        }
        public void DeletePlan(int idPlan)
        {
            Datos.Plans plans = new Datos.Plans();
            plans.DeletePlan(idPlan);
        }
    }
}
