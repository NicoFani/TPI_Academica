using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Model;
using Datos.Context;

namespace Servicios
{
    public class ComissionsService
    {
        public void AddComission(Comissions Comission)
        {
            using var context = new ComissionsContext();
            context.Comissions.Add(Comission);
            context.SaveChanges();
        }
        public void DeleteComission(int id)
        {
            using var context = new ComissionsContext();
            
            Comissions? comissionToDelete = context.Comissions.Find(id);
            if (comissionToDelete == null)
            {
                throw new Exception("Comission not found");
            } else
            {
                context.Comissions.Remove(comissionToDelete);
                context.SaveChanges();
            }
        }
        public void UpdateComission(Comissions Comission)
        {
            using var context = new ComissionsContext();
            Comissions? comissionToUpdate = context.Comissions.Find(Comission.IdCommission);
            if (comissionToUpdate == null)
            {
                throw new Exception("Comission not found");
            }
            else
            {
                comissionToUpdate.CommissionDescription = Comission.CommissionDescription;
                comissionToUpdate.SpecialityYear = Comission.SpecialityYear;
                comissionToUpdate.IdPlan = Comission.IdPlan;
                context.SaveChanges();
            }
        }
        public Comissions? GetComissionById(int id) {
            using var context = new ComissionsContext();
            Comissions? comission = context.Comissions.Find(id);
            if (comission == null)
            {
                throw new Exception("Comission not found");
            }
            else
            {
                return comission;
            }
        }
        public IEnumerable<Comissions> GetAllComissions()
        {
            using var context = new ComissionsContext();
            return context.Comissions.ToList();
        }
    }
}

