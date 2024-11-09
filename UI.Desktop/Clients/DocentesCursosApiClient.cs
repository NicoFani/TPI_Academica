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
    public class DocentesCursosApiClient
    {
        private static HttpClient client = ConnectionApiClient.Instance.Client;

        public static async Task<IEnumerable<DocentesCurso>> GetDocentesCursosAsync()
        {
            IEnumerable<DocentesCurso> docentesCursos = null;
            HttpResponseMessage response = await client.GetAsync("docentesCursos");

            if (response.IsSuccessStatusCode)
            {
                docentesCursos = await response.Content.ReadFromJsonAsync<IEnumerable<DocentesCurso>>();
            }
            return docentesCursos;
        }
        public static async Task<DocentesCurso> GetDocenteCursoAsync(int id)
        {
            DocentesCurso docenteCurso = null;
            HttpResponseMessage response = await client.GetAsync($"docentesCursos/{id}");

            if (response.IsSuccessStatusCode)
            {
                docenteCurso = await response.Content.ReadFromJsonAsync<DocentesCurso>();
            }
            return docenteCurso;
        }
        public static async Task AddAsync(DocentesCurso docenteCurso)
        {
            try
            {
                HttpResponseMessage response = await client.PostAsJsonAsync("docentesCursos", docenteCurso);
                if (!response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error al agregar el docente y el curso: {response.StatusCode} - {responseBody}");
                    throw new HttpRequestException($"Request failed with status code {response.StatusCode}: {responseBody}");
                }

                response.EnsureSuccessStatusCode();
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Request error: {e.Message}");
            }
        }
        public static async Task UpdateAsync(DocentesCurso docenteCurso)
        {
            try
            {
                HttpResponseMessage response = await client.PutAsJsonAsync($"docentesCursos/{docenteCurso.IdCurso}", docenteCurso);
                if (!response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error al actualizar el docente y el curso: {response.StatusCode} - {responseBody}");
                    throw new HttpRequestException($"Request failed with status code {response.StatusCode}: {responseBody}");
                }

                response.EnsureSuccessStatusCode();
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Request error: {e.Message}");
            }
        }
        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync($"docentesCursos/{id}");
            response.EnsureSuccessStatusCode();
        }
    }
}

