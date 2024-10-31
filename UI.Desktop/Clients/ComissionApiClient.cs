using Datos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;


namespace UI.Desktop.Clients
{
    public class ComissionApiClient
    {
        private static HttpClient client = new HttpClient();
        static ComissionApiClient()
        {
            client.BaseAddress = new Uri("http://localhost:5127");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public static async Task<IEnumerable<Comissions>> GetComissionsAsync()
        {
            IEnumerable<Comissions> comissions = null;
            HttpResponseMessage response = await client.GetAsync("comissions");

            if (response.IsSuccessStatusCode)
            {
                comissions = await response.Content.ReadFromJsonAsync<IEnumerable<Comissions>>();
            }
            return comissions;
        }


        public static async Task<Comissions> GetComissionAsync(int id)
        {
            Comissions comission = null;
            HttpResponseMessage response = await client.GetAsync($"comissions/{id}");

            if (response.IsSuccessStatusCode)
            {
                comission = await response.Content.ReadFromJsonAsync<Comissions>();
            }
            return comission;
        }
        public static async Task AddAsync(Comissions comission)
        {
            try
            {
                HttpResponseMessage response = await client.PostAsJsonAsync("comissions", comission);
                if (!response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error al agregar la comisión: {response.StatusCode} - {responseBody}");
                }
                response.EnsureSuccessStatusCode();
            }
            catch (HttpRequestException e)
            {
                // Log the exception details
                Console.WriteLine($"Request error: {e.Message}");
                throw;
            }
        }

        public static async Task UpdateAsync(Comissions comission)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync($"Comissions", comission);
            response.EnsureSuccessStatusCode();
        }
        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync($"Comissions/{id}");
            response.EnsureSuccessStatusCode();
        }
    }
}
