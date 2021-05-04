using LeandroExRate.Common.Exceptions;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Text;
using System.Threading.Tasks;

namespace LeandroExRate.Common.Middleware
{
    public class HttpRequester<T> where T : class
    {
        readonly HttpMethod _httpMethod;
        readonly string _url;

        public HttpRequester(ERestCall method, string url)
        {
            _url = url;
            _httpMethod = Fatory(method);
        }

        public async Task<T> SendAsync(T payload = null)
        {
            T result = null;
            using (var httpClient = new HttpClient())
            {
                var request = new HttpRequestMessage(_httpMethod, new Uri(_url));
                var stringPayload = JsonConvert.SerializeObject(payload);
                request.Content = new StringContent(stringPayload, Encoding.UTF8, "application/json");

                var response = await httpClient.SendAsync(request); 

                response.EnsureSuccessStatusCode();
                await response.Content.ReadAsStringAsync().ContinueWith((Task<string> x) =>
                {
                    if (x.IsFaulted)
                        throw x.Exception;

                    result = JsonConvert.DeserializeObject<T>(x.Result);
                });
            }

            return result;
        }

        private HttpMethod Fatory(ERestCall method)
        {
            switch (method)
            {
                case ERestCall.Get:
                    return HttpMethod.Get;
                case ERestCall.Post:
                    return HttpMethod.Post;
                default:
                    throw new AppBaseException("Invalid Operation!");
            }
        }
    }
}
