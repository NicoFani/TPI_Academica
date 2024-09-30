using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Datos
{
    public class Specialities: Connection
    {
        public int AddSpeciality(string specialityDescription)
        {
            int idSpeciality = 0;
            SqlConnection conn = Connect();
            using (conn)
            {
                conn.Open();
                SqlCommand comm = new SqlCommand();
                using(comm)
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = "INSERT INTO Specialities (SpecialityDescription) VALUES (@SpecialityDescription); SELECT SCOPE_IDENTITY()";

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
                conn.Open();
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
                conn.Open();
                SqlCommand comm = new SqlCommand();
                using (comm)
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = "DELETE FROM Specialities WHERE IdSpeciality = @IdSpeciality";

                    comm.Parameters.AddWithValue("@IdSpeciality", idSpeciality);
                    comm.ExecuteNonQuery();
                }
            }
        }
        public List<Entidades.Specialities> GetAllSpecialities()
        {
            List<Entidades.Specialities> specialities = new List<Entidades.Specialities>();
            SqlConnection conn = Connect();
            using (conn)
            {
                conn.Open();
                SqlCommand comm = new SqlCommand();
                using (comm)
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = "SELECT * FROM Specialities";

                    SqlDataReader dr = comm.ExecuteReader();
                    while (dr.Read())
                    {
                        Entidades.Specialities speciality = new Entidades.Specialities((int)dr["IdSpeciality"], dr["SpecialityDescription"].ToString());
                        specialities.Add(speciality);
                    }
                    return specialities;
                }
            }
        }   
    }
}
