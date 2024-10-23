using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Data.SqlClient;
using Datos;
using Datos.Model;


namespace Servicios
{
    public class SpecialitiesService: Connection
    {
        public int AddSpeciality(string specialityDescription)
        {
            int idSpeciality = 0;
            SqlConnection conn = Connect();
            using (conn)
            {
                SqlCommand comm = new SqlCommand();
                using(comm)
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = "INSERT INTO especialidades (desc_especialidad) VALUES (@SpecialityDescription); SELECT SCOPE_IDENTITY()";

                    comm.Parameters.AddWithValue("@IdSpeciality", idSpeciality);
                    comm.Parameters.AddWithValue("@SpecialityDescription", specialityDescription);
                    return comm.ExecuteNonQuery();
                }
            }
        }
        public void UpdateSpeciality(int idSpeciality, string specialityDescription)
        {
            SqlConnection conn = Connect();
            using (conn)
            {
                SqlCommand comm = new SqlCommand();
                using (comm)
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    // VER
                    comm.CommandText = "VER";

                    comm.Parameters.AddWithValue("@IdSpeciality", idSpeciality);
                    comm.Parameters.AddWithValue("@SpecialityDescription", specialityDescription);
                    comm.ExecuteNonQuery();
                }
            }
        }
        public void DeleteSpeciality(int idSpeciality)
        {
            SqlConnection conn = Connect();
            using (conn)
            {
                SqlCommand comm = new SqlCommand();
                using (comm)
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = "DELETE FROM especialidades WHERE id_especialidad = @IdSpeciality";

                    comm.Parameters.AddWithValue("@IdSpeciality", idSpeciality);
                    comm.ExecuteNonQuery();
                }
            }
        }
        public List<Datos.Model.Specialities> GetAllSpecialities()
        {
            List<Datos.Model.Specialities> specialities = new List<Datos.Model.Specialities>();
            SqlConnection conn = Connect();
            using (conn)
            {
                SqlCommand comm = new SqlCommand();
                using (comm)
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = "SELECT * FROM especialidades";

                    SqlDataReader dr = comm.ExecuteReader();
                    while (dr.Read())
                    {
                        Datos.Model.Specialities speciality = new Datos.Model.Specialities((int)dr["id_especialidad"], dr["desc_especialidad"].ToString());
                        specialities.Add(speciality);
                    }
                    return specialities;
                }
            }
        }
        public Specialities? GetSpecialityById(int id)
        {
            SqlConnection conn = Connect();
            using (conn) {
                SqlCommand comm = new SqlCommand();
                using (comm) {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = "SELECT * FROM especialidades WHERE id_especialidad = @IdSpeciality";
                    SqlDataReader dr = comm.ExecuteReader();
                    while (dr.Read()) {
                        Datos.Model.Specialities speciality = new Datos.Model.Specialities((int)dr["id_especialidad"], dr["desc_especialidad"].ToString());
                        return speciality;
                    }
                    return null;
                }
            }
        }
    }
}
