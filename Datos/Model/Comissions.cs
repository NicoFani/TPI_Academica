using System.ComponentModel.DataAnnotations.Schema;

namespace Datos.Model
{
    public class Comissions
    {
        public int id_comision { get; set; }

        public string desc_comision { get; set; }

        public int anio_especialidad { get; set; }

        public int id_plan { get; set; }

        //public Comissions(int idCommission, string commissionDescription, int specialityYear, int idPlan)
        //{
        //    this._idCommission = idCommission;
        //    this._commissionDescription = commissionDescription;
        //    this._specialityYear = specialityYear;
        //    this._idPlan = idPlan;
        //}
    }
}

