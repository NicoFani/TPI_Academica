using Datos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Azure;


namespace UI.Desktop.Clients
{
    public class MateriasApiClient
    {
        private static HttpClient client = ConnectionApiClient.Instance.Client;

        public static async Task<IEnumerable<Materia>> GetMateriasAsync()
        {
            IEnumerable<Materia> materias = null;
            HttpResponseMessage response = await client.GetAsync("materias");

            if (response.IsSuccessStatusCode)
            {
                materias = await response.Content.ReadFromJsonAsync<IEnumerable<Materia>>();
            }
            return materias;
        }

        public static async Task<Materia> GetMateriaAsync(int id)
        {
            Materia materia = null;
            HttpResponseMessage response = await client.GetAsync($"materias/{id}");

            if (response.IsSuccessStatusCode)
            {
                materia = await response.Content.ReadFromJsonAsync<Materia>();
            }
            return materia;
        }
        public static async Task AddAsync(Materia materia)
        {
            try
            {
                HttpResponseMessage response = await client.PostAsJsonAsync("materias", materia);
                if (!response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error al agregar la materia: {response.StatusCode} - {responseBody}");
                    throw new HttpRequestException($"Request failed with status code {response.StatusCode}: {responseBody}");
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
        public static async Task UpdateAsync(Materia materia)
        {
            try
            {
                MessageBox.Show($"Id de entrada: {materia.IdMateria}");
                HttpResponseMessage response = await client.PutAsJsonAsync($"materias/{materia.IdMateria}", materia);
                if (!response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error al actualizar la materia: {response.StatusCode} - {responseBody}");
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
        public static async Task DeleteAsync (int id)
        {
            HttpResponseMessage response = await client.DeleteAsync($"materias/{id}");
            response.EnsureSuccessStatusCode();
        }
    }
}
