using clientSwagger;
using Microsoft.JSInterop;
using Servicios.Utils;
using System.Net.Http.Headers;

namespace Blazor.Services {
    public class ConnectionService {
        private readonly HttpClient _httpClient;
        private clientSwagger.clientSwagger _client;

        public ConnectionService() {
            _httpClient = new HttpClient();
            SetClient();
        }

        public clientSwagger.clientSwagger Client() {
            return _client;
        }

        private void SetClient() {
            _client = new clientSwagger.clientSwagger("https://localhost:7039/", _httpClient);
        }

        public void SetBearerToken(string token) {
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            SetClient();
        }

        public void RemoveBearerToken() {
            _httpClient.DefaultRequestHeaders.Authorization = null;
            SetClient();
        }
    }
}