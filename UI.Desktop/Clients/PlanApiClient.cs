﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;

namespace UI.Desktop.Clients
{
    public class PlanApiClient
    {
        private static HttpClient client = ConnectionApiClient.Instance.Client;

        public static async Task<IEnumerable<Plane>> GetPlansAsync()
        {
            IEnumerable<Plane> plans = null;
            HttpResponseMessage response = await client.GetAsync("plans");

            if (response.IsSuccessStatusCode)
            {
                plans = await response.Content.ReadFromJsonAsync<IEnumerable<Plane>>();
            }
            return plans;
        }
        public static async Task<Plane?> GetPlanAsync(int id)
        {
            HttpResponseMessage response = await client.GetAsync($"plans/{id}");

            if (response.IsSuccessStatusCode)
            {
                var plan = await response.Content.ReadFromJsonAsync<Plane>();
                return plan;
            }
            else
            {
                Console.WriteLine($"Error al obtener el plan: {response.StatusCode} - {await response.Content.ReadAsStringAsync()}");
                return null;
            }
        }

        public static async Task AddAsync(Plane plan)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("plans", plan);
            if (!response.IsSuccessStatusCode)
            {
                string responseContent = await response.Content.ReadAsStringAsync();
                throw new HttpRequestException($"Request failed with status code {response.StatusCode}: {responseContent}");
            }
        }

        public static async Task UpdateAsync(int id, Plane plan)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync($"plans/{plan.IdPlan}", plan);
            response.EnsureSuccessStatusCode();
        }

        public static async Task DeleteAsync(int id)
        {
            try
            {
                HttpResponseMessage response = await client.DeleteAsync($"plans/{id}");
                if (!response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error al eliminar el plan: {response.StatusCode} - {responseBody}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar el plan: {ex.Message}");
            }
        }   
    }
}
