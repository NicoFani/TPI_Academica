using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
