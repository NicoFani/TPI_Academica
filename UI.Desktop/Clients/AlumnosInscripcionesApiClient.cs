using Datos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace UI.Desktop.Clients
{
    public class AlumnosInscripcionesApiClient
    {
        private static HttpClient client = ConnectionApiClient.Instance.Client;

        public static async Task<IEnumerable<AlumnosInscripcione>> GetAlumnosInscripcionesAsync()
        {
            IEnumerable<AlumnosInscripcione> inscripciones = null;
            HttpResponseMessage response = await client.GetAsync("alumnosInscripciones");

            if (response.IsSuccessStatusCode)
            {
                inscripciones = await response.Content.ReadFromJsonAsync<IEnumerable<AlumnosInscripcione>>();
            }
            return inscripciones;
        }

        public static async Task<IEnumerable<AlumnosInscripcione>> GetAlumnosInscripcionesByCursoAsync(int idCurso) {
            IEnumerable<AlumnosInscripcione> inscripciones = null;
            HttpResponseMessage response = await client.GetAsync($"alumnosInscripciones/curso/{idCurso}");

            if (response.IsSuccessStatusCode) {
                inscripciones = await response.Content.ReadFromJsonAsync<IEnumerable<AlumnosInscripcione>>();
            }
            return inscripciones;
        }

        public static async Task<AlumnosInscripcione> GetAlumnosInscripcionesAsync(int id)
        {
            AlumnosInscripcione alumnosInscripcione = null;
            HttpResponseMessage response = await client.GetAsync($"alumnosInscripciones/{id}");

            if (response.IsSuccessStatusCode)
            {
                alumnosInscripcione = await response.Content.ReadFromJsonAsync<AlumnosInscripcione>();
            }
            return alumnosInscripcione;
        }
        public static async Task AddAsync(AlumnosInscripcione alumnosInscripcione)
        {
            try
            {
                HttpResponseMessage response = await client.PostAsJsonAsync("alumnosInscripciones", alumnosInscripcione);
                if (!response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error al agregar la inscripcion: {response.StatusCode} - {responseBody}");
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
        public static async Task UpdateAsync(AlumnosInscripcione alumnosInscripcione)
        {
            try
            {
                HttpResponseMessage response = await client.PutAsJsonAsync($"alumnosInscripciones/{alumnosInscripcione.IdInscripcion}", alumnosInscripcione);
                if (!response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error al actualizar la inscripcion: {response.StatusCode} - {responseBody}");
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
        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync($"alumnosInscripciones/{id}");
            response.EnsureSuccessStatusCode();
        }
    }
}
