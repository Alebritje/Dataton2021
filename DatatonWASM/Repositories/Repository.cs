using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace DatatonWASM.Repositories
{
    public class Repository : IRepository
    {
        private readonly HttpClient httpClient;

        public Repository(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        private JsonSerializerOptions OpcionesPorDefectoJSON =>
            new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };

        public Task ObtenerUsuario()
        {
            throw new NotImplementedException();
        }

        public async Task<HttpResponseWrapper<T>> Get<T>(string url)
        {
            var responseHTTP = await httpClient.GetAsync(url);

            if (responseHTTP.IsSuccessStatusCode)
            {
                var response = await DeserializarRespuesta<T>(responseHTTP, OpcionesPorDefectoJSON);
                return new HttpResponseWrapper<T>(response, false, responseHTTP);
            }
            else
            {
                return new HttpResponseWrapper<T>(default, true, responseHTTP);
            }
        }

        private async Task<T> DeserializarRespuesta<T>(HttpResponseMessage httpResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            var responseString = await httpResponse.Content.ReadAsStringAsync();
            var respuesta = JsonSerializer.Deserialize<T>(responseString, jsonSerializerOptions);
            return respuesta;
        }

    }
}
