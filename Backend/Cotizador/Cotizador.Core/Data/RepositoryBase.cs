using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Cotizador.Core.Data
{
    public class RepositoryBase
    {
        private HttpClient client_;

        public async Task<T> RunAsync<T>(string urlApi, string token = null)
        {
            var urlBuilder = new StringBuilder();
            urlBuilder.Append(urlApi != null ? urlApi.TrimEnd('/') : "");

            var url = urlBuilder.ToString();

            client_ = new HttpClient();

            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.RequestUri = new Uri(url, System.UriKind.RelativeOrAbsolute);
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    if (!string.IsNullOrEmpty(token))
                        request_.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false);
                    var responseText_ = await response_.Content.ReadAsStringAsync().ConfigureAwait(false);

                    if (response_.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var responseBody_ = JsonConvert.DeserializeObject<T>(responseText_);

                        return responseBody_;
                    }
                    else
                    if (response_.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                    {
                        throw new Exception("401 Unauthorized. No se ha indicado o es incorrecto el Token JWT de acceso. " +
                            responseText_);
                    }
                    else
                    if (response_.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        throw new Exception("404 NotFound. No se ha encontrado el objeto solicitado. " +
                            responseText_);
                    }
                    else
                    if (response_.StatusCode != System.Net.HttpStatusCode.OK &&
                        response_.StatusCode != System.Net.HttpStatusCode.NoContent)
                    {
                        throw new Exception((int)response_.StatusCode + ". No se esperaba el código de estado HTTP de la respuesta. " +
                            responseText_);
                    }

                    return default(T);
                }
            }
            finally
            {
            }
        }
    }
}
