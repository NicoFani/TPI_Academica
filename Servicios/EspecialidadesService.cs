using System.Data;
using Microsoft.Data.SqlClient;
using Datos;
using Datos.Models;


namespace Servicios
{
    public class EspecialidadesService(string connectionString)
    {
        public int AddSpeciality(string specialityDescription)
        {
            int idSpeciality = 0;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
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
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            using (conn)
            {
                SqlCommand comm = new SqlCommand();
                using (comm)
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = "UPDATE Especialidades SET desc_especialidad = @SpecialityDescription WHERE id_especialidad = @IdSpeciality";

                    comm.Parameters.AddWithValue("@IdSpeciality", idSpeciality);
                    comm.Parameters.AddWithValue("@SpecialityDescription", specialityDescription);
                    comm.ExecuteNonQuery();
                }
            }
        }
        public void DeleteSpeciality(int idSpeciality)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
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
            List<Especialidade> especialidades = new List<Especialidade>();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
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
                        especialidades.Add(speciality);
                    }
                    return especialidades;
                }
            }
        }
        public Especialidade? GetSpecialityById(int id)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            using (conn) {
                SqlCommand comm = new SqlCommand();
                using (comm) {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = "SELECT * FROM especialidades WHERE id_especialidad = @IdSpeciality";
                    SqlDataReader dr = comm.ExecuteReader();
                    while (dr.Read()) {
                        Especialidade speciality = new Especialidade { IdEspecialidad = (int)dr["id_especialidad"], DescEspecialidad = dr["desc_especialidad"].ToString() };
                        return speciality;
                    }
                    return null;
                }
            }
        }
    }
}
