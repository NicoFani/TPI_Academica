using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using Datos;
using Datos.Models;

namespace Servicios
{
    public class PlaneService: Connection
    {
        public int AddPlan(string planDescription, int idSpeciality)
        {
            int idPlan = 0;
            SqlConnection conn = Connect();
            using (conn)
            {
                conn.Open();
                SqlCommand comm = new SqlCommand();
                using (comm)
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = "INSERT INTO Plane (PlanDescription, IdSpeciality) VALUES (@PlanDescription, @IdSpeciality); SELECT SCOPE_IDENTITY()";

                    comm.Parameters.AddWithValue("@IdPlan", idPlan);
                    comm.Parameters.AddWithValue("@PlanDescription", planDescription);
                    comm.Parameters.AddWithValue("@IdSpeciality", idSpeciality);
                    return comm.ExecuteNonQuery();
                }
            }
        }
        public void UpdatePlan(int idPlan, string planDescription, int idSpeciality)
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

                    comm.Parameters.AddWithValue("@IdPlan", idPlan);
                    comm.Parameters.AddWithValue("@PlanDescription", planDescription);
                    comm.Parameters.AddWithValue("@IdSpeciality", idSpeciality);
                    comm.ExecuteNonQuery();
                }
            }
        }
        public void DeletePlan(int idPlan)
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
                    comm.CommandText = "DELETE FROM Plane WHERE IdPlan = @IdPlan";

                    comm.Parameters.AddWithValue("@IdPlan", idPlan);
                    comm.ExecuteNonQuery();
                }
            }
        }
        public List<Plane> GetAllPlane()
        {
            List<Plane> plane = new List<Plane>();
            SqlConnection conn = Connect();
            using (conn)
            {
                conn.Open();
                SqlCommand comm = new SqlCommand();
                using (comm)
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = "SELECT * FROM Plane";
                    SqlDataReader dr = comm.ExecuteReader();
                    while (dr.Read())
                    {
                        Plane plan = new Plane { IdPlan = (int)dr["IdPlan"], DescPlan = dr["PlanDescription"].ToString(), IdEspecialidad = (int)dr["IdSpeciality"] };
                        plane.Add(plan);
                    }
                    return plane;
                }
            }
        }
    }
}
