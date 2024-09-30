﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using Datos;

namespace Servicios
{
    public class Plans: Connection
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
                    comm.CommandText = "INSERT INTO Plans (PlanDescription, IdSpeciality) VALUES (@PlanDescription, @IdSpeciality); SELECT SCOPE_IDENTITY()";

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
                    comm.CommandText = "DELETE FROM Plans WHERE IdPlan = @IdPlan";

                    comm.Parameters.AddWithValue("@IdPlan", idPlan);
                    comm.ExecuteNonQuery();
                }
            }
        }
        public List<Entidades.Plans> GetAllPlans()
        {
            List<Entidades.Plans> plans = new List<Entidades.Plans>();
            SqlConnection conn = Connect();
            using (conn)
            {
                conn.Open();
                SqlCommand comm = new SqlCommand();
                using (comm)
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = "SELECT * FROM Plans";
                    SqlDataReader dr = comm.ExecuteReader();
                    while (dr.Read())
                    {
                        Entidades.Plans plan = new Entidades.Plans((int)dr["IdPlan"], dr["PlanDescription"].ToString(), (int)dr["IdSpeciality"]);
                        plans.Add(plan);
                    }
                    return plans;
                }
            }
        }
    }
}