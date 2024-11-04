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


namespace UI.Desktop.Clients
{
    public class ComissionApiClient
    {
        private static HttpClient client = ConnectionApiClient.Instance.Client;

        public static async Task<IEnumerable<Comisione>> GetComissionsAsync()
        {
            IEnumerable<Comisione> comissions = null;
            HttpResponseMessage response = await client.GetAsync("comissions");

            if (response.IsSuccessStatusCode)
            {
                comissions = await response.Content.ReadFromJsonAsync<IEnumerable<Comisione>>();
            }
            return comissions;
        }


        public static async Task<Comisione> GetComissionAsync(int id)
        {
            Comisione comission = null;
            HttpResponseMessage response = await client.GetAsync($"comissions/{id}");

            if (response.IsSuccessStatusCode)
            {
                comission = await response.Content.ReadFromJsonAsync<Comisione>();
            }
            return comission;
        }
        public static async Task AddAsync(Comisione comission)
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


        public static async Task UpdateAsync(Comisione comission)
        {
            try
            {
                HttpResponseMessage response = await client.PutAsJsonAsync($"comissions/{comission.IdComision}", comission);
                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error al actualizar la comisión: {response.StatusCode} - {errorContent}");
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



        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync($"Comissions/{id}");
            response.EnsureSuccessStatusCode();
        }
    }
}
