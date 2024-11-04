using System;
using System.Net.Http.Headers;

namespace UI.Desktop.Clients {
    public class ConnectionApiClient : IDisposable {
        private ConnectionApiClient() {
            _client = new HttpClient();
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _client.BaseAddress = new Uri("https://localhost:7039/");
        }

        private static ConnectionApiClient? instance;
        private readonly HttpClient _client;

        public HttpClient Client {
            get {
                return _client;
            }
        }

        public static ConnectionApiClient Instance {
            get {
                if (instance == null) {
                    instance = new ConnectionApiClient();
                }
                return instance;
            }
        }

        public void SetBearerToken(string token) {
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }

        public void RemoveBearerToken() {
            _client.DefaultRequestHeaders.Authorization = null;
        }

        public void Dispose() {
            _client.Dispose();
        }
    }
}