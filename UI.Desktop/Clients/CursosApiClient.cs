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
    public class CursosApiClient
    {
        private static HttpClient client = ConnectionApiClient.Instance.Client;

        public static async Task<IEnumerable<Curso>> GetCursosAsync()
        {
            IEnumerable<Curso> cursos = null;
            HttpResponseMessage response = await client.GetAsync("cursos");

            if (response.IsSuccessStatusCode)
            {
                cursos = await response.Content.ReadFromJsonAsync<IEnumerable<Curso>>();
            }
            return cursos;
        }
        public static async Task<Curso> GetCursoAsync(int id)
        {
            Curso curso = null;
            HttpResponseMessage response = await client.GetAsync($"cursos/{id}");

            if (response.IsSuccessStatusCode)
            {
                curso = await response.Content.ReadFromJsonAsync<Curso>();
            }
            return curso;
        }
        public static async Task AddAsync(Curso curso)
        {
            try
            {
                HttpResponseMessage response = await client.PostAsJsonAsync("cursos", curso);
                if (!response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error al agregar el curso: {response.StatusCode} - {responseBody}");
                    throw new HttpRequestException($"Request failed with status code {response.StatusCode}: {responseBody}");
                }

                response.EnsureSuccessStatusCode();
            }
            catch (HttpRequestException e)
            {
                // Log the exception details
                Console.WriteLine($"Request error: {e.Message}");
            }
        }
        public static async Task UpdateAsync(Curso curso)
        {
            try
            {
                HttpResponseMessage response = await client.PutAsJsonAsync($"cursos/{curso.IdCurso}", curso);
                if (!response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error al actualizar el curso: {response.StatusCode} - {responseBody}");
                    throw new HttpRequestException($"Request failed with status code {response.StatusCode}: {responseBody}");
                }

                response.EnsureSuccessStatusCode();
            }
            catch (HttpRequestException e)
            {
                // Log the exception details
                Console.WriteLine($"Request error: {e.Message}");
            }
        }
        public static async Task DeleteAsync (int id)
        {
            HttpResponseMessage response = await client.DeleteAsync($"cursos/{id}");
            response.EnsureSuccessStatusCode();
        }
    }
}
