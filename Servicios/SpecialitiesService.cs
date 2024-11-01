using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Data.SqlClient;
using Datos;
using Datos.Models;


namespace Servicios
{
    public class EspecialidadeService: Connection
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
        public List<Especialidade> GetAllEspecialidade()
        {
            List<Especialidade> Especialidade = new List<Especialidade>();
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
                        Especialidade speciality = new Especialidade { IdEspecialidad = (int)dr["id_especialidad"], DescEspecialidad = dr["desc_especialidad"].ToString() };
                        Especialidade.Add(speciality);
                    }
                    return Especialidade;
                }
            }
        }   
    }
}
