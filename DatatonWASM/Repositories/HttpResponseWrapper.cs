using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace DatatonWASM.Repositories
{
    public class HttpResponseWrapper<T>
    {
        private object response;
        private bool v;
        private HttpResponseMessage responseHttp;

        public HttpResponseWrapper(T response, bool error, HttpResponseMessage httpResponseMessage)
        {
            Error = error;
            Response = response;
            HttpResponseMessage = httpResponseMessage;
        }

        public HttpResponseWrapper(object response, bool v, HttpResponseMessage responseHttp)
        {
            this.response = response;
            this.v = v;
            this.responseHttp = responseHttp;
        }

        public bool Error { get; set; }
        public T Response { get; set; }
        public HttpResponseMessage HttpResponseMessage { get; set; }

        public async Task<string> GetBody()
        {
            return await HttpResponseMessage.Content.ReadAsStringAsync();
        }
    }
}
