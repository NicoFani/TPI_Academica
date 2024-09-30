using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Specialities
    {
        public int AddSpeciality(string specialityDescription)
        {
            Datos.Specialities specialities = new Datos.Specialities();
            return specialities.AddSpeciality(specialityDescription);
        }
        public void UpdateSpeciality(int idSpeciality, string specialityDescription)
        {
            Datos.Specialities specialities = new Datos.Specialities();
            specialities.UpdateSpeciality(idSpeciality, specialityDescription);
        }
        public void DeleteSpeciality(int idSpeciality)
        {
            Datos.Specialities specialities = new Datos.Specialities();
            specialities.DeleteSpeciality(idSpeciality);
        }
    }
}
