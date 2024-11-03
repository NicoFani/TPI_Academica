using System.Data;
using Microsoft.Data.SqlClient;
using Datos.Models;

namespace Servicios
{
    public class PlaneService(string connectionString)
    {
        public void AddPlan(Plane plan)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Planes (desc_plan, id_especialidad) VALUES (@PlanDescription, @IdSpeciality)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@PlanDescription", plan.DescPlan);
                cmd.Parameters.AddWithValue("@IdSpeciality", plan.IdEspecialidad);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void UpdatePlan(Plane plan)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                using (conn)
                {
                    string query = "UPDATE Planes SET desc_plan = @PlanDescription, id_especialidad = @IdSpeciality WHERE id_plan = @IdPlan";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@PlanDescription", plan.DescPlan);
                    cmd.Parameters.AddWithValue("@IdSpeciality", plan.IdEspecialidad);
                    cmd.Parameters.AddWithValue("@IdPlan", plan.IdPlan);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    conn.Close();

                    if (rowsAffected == 0)
                    {
                        // No rows were updated, log or handle this case
                        Console.WriteLine("No se actualizó ninguna fila. Verifica que el IdPlan exista.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                Console.WriteLine($"Error al actualizar el plan: {ex.Message}");
            }
        }

        public void DeletePlan(int id_plan)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Planes WHERE id_plan = @IdPlan";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@IdPlan", id_plan);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        public List<Plane> GetAllPlane()
        {
            List<Plane> plane = new List<Plane>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = "SELECT * FROM Planes";
                    using (SqlDataReader dr = comm.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Plane plan = new Plane { IdPlan = (int)dr["id_plan"], DescPlan = dr["desc_plan"].ToString(), IdEspecialidad = (int)dr["id_especialidad"] };
                            plane.Add(plan);
                        }
                    }
                }
            }
            return plane;
        }

        public Plane? GetPlanById(int id) {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            using (conn) {
                SqlCommand comm = new SqlCommand();
                using (comm) {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = "SELECT * FROM Planes WHERE id_plan = @IdPlan";
                    comm.Parameters.AddWithValue("@IdPlan", id);
                    SqlDataReader dr = comm.ExecuteReader();
                    while (dr.Read()) {
                        Plane plan = new Plane { IdPlan = (int)dr["id_plan"], DescPlan = dr["desc_plan"].ToString(), IdEspecialidad = (int)dr["id_especialidad"] };
                        return plan;
                    }
                    return null;
                }
            }
        }
    }
}
