using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Datos.Model;

namespace UI.Desktop.Clients
{
    public class SpecialityApiClient
    {
        private static HttpClient client = new HttpClient();
        static SpecialityApiClient()
        {
            client.BaseAddress = new Uri("http://localhost:5127");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<IEnumerable<Specialities>> GetSpecialitiesAsync()
        {
            IEnumerable<Specialities> specialities = null;
            HttpResponseMessage response = await client.GetAsync("specialities");

            if (response.IsSuccessStatusCode)
            {
                specialities = await response.Content.ReadFromJsonAsync<IEnumerable<Specialities>>();
            }
            return specialities;
        }
        public static async Task<Specialities> GetSpecialityAsync(int id)
        {
            Specialities speciality = null;
            HttpResponseMessage response = await client.GetAsync($"specialities/{id}");

            if (response.IsSuccessStatusCode)
            {
                speciality = await response.Content.ReadFromJsonAsync<Specialities>();
            }
            return speciality;
        }
        public static async Task AddAsync(Specialities speciality)
        {
            try
            {
                HttpResponseMessage response = await client.PostAsJsonAsync("specialities", speciality);
                if (!response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error al agregar la especialidad: {response.StatusCode} - {responseBody}");
                }
                response.EnsureSuccessStatusCode();
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Error al agregar la especialidad: {e.Message}");
            }
        }
        public static async Task UpdateAsync(Specialities speciality)
        {
            try
            {
                HttpResponseMessage response = await client.PutAsJsonAsync($"specialities/{speciality.IdSpeciality}", speciality);
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
