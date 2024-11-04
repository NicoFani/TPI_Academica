using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.IdentityModel.Tokens;
using Servicios.Utils;

namespace UI.Desktop.Clients {
    public class PersonasApiClient {
        private static HttpClient _client = ConnectionApiClient.Instance.Client;

        public static async Task<bool> SignIn(string user, string password) {
            var response = await _client.PostAsync($"personas/signIn?nombreUsuario={user}&clave={password}", null);
            if (response.IsSuccessStatusCode) {
                string token = await response.Content.ReadAsStringAsync();
                token = token.Replace("\"", "");
                var decoToken = JWTService.DecodeToken(token);
                if (decoToken["valid"] == "true" && decoToken["TipoPersona"] == "Admin") {
                    ConnectionApiClient.Instance.SetBearerToken(token);
                    return true;
                } else {
                    return false;
                }
            } else {
                return false;
            }
        }

        public static async Task<IEnumerable<Persona>> GetPersonasByTipoAsync(string tipoPersona) {
            IEnumerable<Persona> personas = null;
            HttpResponseMessage response = await _client.GetAsync($"personas/tipo/{tipoPersona}");

            if (response.IsSuccessStatusCode) {
                personas = await response.Content.ReadFromJsonAsync<IEnumerable<Persona>>();
            }
            return personas;
        }

        public static async Task<Persona?> GetPersonaAsync(int id) {
            Persona? persona = null;
            HttpResponseMessage response = await _client.GetAsync($"personas/{id}");

            if (response.IsSuccessStatusCode) {
                persona = await response.Content.ReadFromJsonAsync<Persona>();
            }
            return persona;
        }

        public static async Task AddAsync(Persona persona) {
            HttpResponseMessage response = await _client.PostAsJsonAsync("personas", persona);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(int id, Persona persona) {
            HttpResponseMessage response = await _client.PutAsJsonAsync($"personas/{id}", persona);
            response.EnsureSuccessStatusCode();
        }

        public static async Task DeleteAsync(int id) {
            HttpResponseMessage response = await _client.DeleteAsync($"personas/{id}");
            response.EnsureSuccessStatusCode();
        }
    }
}
