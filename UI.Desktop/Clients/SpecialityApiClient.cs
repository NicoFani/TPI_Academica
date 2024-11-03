using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;

namespace UI.Desktop.Clients
{
    public class SpecialityApiClient
    {
        private static HttpClient client = new HttpClient();
        static SpecialityApiClient()
        {
            client.BaseAddress = new Uri("https://localhost:7039");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<IEnumerable<Especialidade>> GetSpecialitiesAsync()
        {
            IEnumerable<Especialidade> specialities = null;
            HttpResponseMessage response = await client.GetAsync("specialities");

            if (response.IsSuccessStatusCode)
            {
                specialities = await response.Content.ReadFromJsonAsync<IEnumerable<Especialidade>>();
            }
            return specialities;
        }
        public static async Task<Especialidade> GetSpecialityAsync(int id)
        {
            Especialidade speciality = null;
            HttpResponseMessage response = await client.GetAsync($"specialities/{id}");

            if (response.IsSuccessStatusCode)
            {
                speciality = await response.Content.ReadFromJsonAsync<Especialidade>();
            }
            return speciality;
        }
        public static async Task AddAsync(Especialidade speciality)
        {
                HttpResponseMessage response = await client.PostAsJsonAsync("specialities", speciality);

                response.EnsureSuccessStatusCode();

        }
        public static async Task UpdateAsync(Especialidade speciality)
        {
            try
            {
                HttpResponseMessage response = await client.PutAsJsonAsync($"specialities/{speciality.IdEspecialidad}", speciality);
                if (!response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error al actualizar la especialidad: {response.StatusCode} - {responseBody}");
                }
                response.EnsureSuccessStatusCode();
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Error al actualizar la especialidad: {e.Message}");
            }
        }
        public static async Task DeleteAsync(int id)
        {
            try
            {
                HttpResponseMessage response = await client.DeleteAsync($"specialities/{id}");
                if (!response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error al eliminar la especialidad: {response.StatusCode} - {responseBody}");
                }
                response.EnsureSuccessStatusCode();
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Error al eliminar la especialidad: {e.Message}");
            }
        }
    }
}
