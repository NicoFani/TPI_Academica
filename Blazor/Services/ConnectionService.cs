using Azure;
using clientSwagger;
using Microsoft.AspNetCore.Mvc;
using Microsoft.JSInterop;
using Servicios.Utils;
using System.Net.Http.Headers;

namespace Blazor.Services {
    public class ConnectionService {
        private readonly HttpClient _httpClient;
        private clientSwagger.clientSwagger _client;
        private IDictionary<string, string>? _currentUser;

        public ConnectionService() {
            _httpClient = new HttpClient();
            SetClient();
        }

        public clientSwagger.clientSwagger Client() {
            return _client;
        }

        public IDictionary<string, string>? GetCurrentUser() {
            return _currentUser;
        }

        private void SetClient() {
            _client = new clientSwagger.clientSwagger("https://localhost:7039/", _httpClient);
        }

        private void SetBearerToken(string token) {
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            SetClient();
        }

        public void RemoveBearerToken() {
            _currentUser = null;
            _httpClient.DefaultRequestHeaders.Authorization = null;
            SetClient();
        }

        public async Task<IDictionary<string, string>> SignIn(string username, string password) {
            var badSignIn = new Dictionary<string, string> {
                { "valid", "false" }
            };
            try {
                string token = await _client.SignInAsync(username, password);
                token = token.Replace("\'", "");
                var decoToken = JWTService.DecodeToken(token);
                if (decoToken["valid"] == "true" && (decoToken["TipoPersona"] == "Alumno" || decoToken["TipoPersona"] == "Profesor")) {
                    SetBearerToken(token);
                    _currentUser = decoToken;
                    return decoToken;
                } else {
                    return badSignIn;
                }
            } catch (Exception ex) {
                return badSignIn;
            }
        }
    }
}
