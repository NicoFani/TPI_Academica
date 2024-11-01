using Datos.Models;
using Datos;

namespace Servicios
{
    public class ComisionesService (Context context)
    {
        public void AddComission(Comisione Comission)
        {
            context.Comisiones.Add(Comission);
            context.SaveChanges();
        }
        public void DeleteComission(int id)
        {
            
            Comisione? comissionToDelete = context.Comisiones.Find(id);
            if (comissionToDelete == null)
            {
                throw new Exception("Comission not found");
            } else
            {
                context.Comisiones.Remove(comissionToDelete);
                context.SaveChanges();
            }
        }
        public void UpdateComission(Comisione Comission)
        {
            Comisione? comissionToUpdate = context.Comisiones.Find(Comission.IdComision);
            if (comissionToUpdate == null)
            {
                throw new Exception("Comission not found");
            }
            else
            {
                comissionToUpdate.DescComision = Comission.DescComision;
                comissionToUpdate.AnioEspecialidad = Comission.AnioEspecialidad;
                comissionToUpdate.IdPlan = Comission.IdPlan;
                context.SaveChanges();
            }
        }
        public Comisione? GetComissionById(int id) {
            Comisione? comission = context.Comisiones.Find(id);
            if (comission == null)
            {
                throw new Exception("Comission not found");
            }
            else
            {
                return comission;
            }
        }
        public IEnumerable<Comisione> GetAllComissions()
        {
            return context.Comisiones.ToList();
        }
    }
}

