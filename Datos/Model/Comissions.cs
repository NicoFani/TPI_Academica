using System.ComponentModel.DataAnnotations.Schema;

namespace Datos.Model
{
    public class Comissions
    {
        int _idCommission;
        string _commissionDescription;
        int _specialityYear;
        int _idPlan;

        [Column("id_comision")]
        public int IdCommission { get { return _idCommission; } set { _idCommission = value; } }

        [Column("desc_comision")]
        public string CommissionDescription { get { return _commissionDescription; } set { _commissionDescription = value; } }

        [Column("anio_especialidad")]
        public int SpecialityYear { get { return _specialityYear; } set { _specialityYear = value; } }

        [Column("id_plan")]
        public int IdPlan { get { return _idPlan; } set { _idPlan = value; } }

        public Comissions(int idCommission, string commissionDescription, int specialityYear, int idPlan)
        {
            this._idCommission = idCommission;
            this._commissionDescription = commissionDescription;
            this._specialityYear = specialityYear;
            this._idPlan = idPlan;
        }
    }
}

