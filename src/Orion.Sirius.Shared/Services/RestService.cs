using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Orion.Sirius.Shared.Services
{
    /// <summary>
    /// Serviço REST
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class RestService<T> where T : class
    {
        private readonly HttpClient httpClient;

        public RestService(string endPoint)
        {
            httpClient = new HttpClient(new HttpClientHandler());
            httpClient.Timeout = new TimeSpan(0, 0, 10);

            EndPoint = endPoint;
        }

        /// <summary>
        /// URL da API
        /// </summary>
        public string EndPoint { get; private set; }

        /// <summary>
        /// Última URI de requisição
        /// </summary>
        public string LastUriRequested { get; private set; }

        /// <summary>
        /// Último Body de requisição
        /// </summary>
        public string LastBodyResquested { get; private set; }

        public T Get(string url)
        {
            HttpResponseMessage response = null;
            Uri requestUri = new Uri($"{EndPoint}/{url}");

            try
            {
                using (var requestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri))
                {
                    LastUriRequested = requestUri.ToString();
                    response = this.httpClient.SendAsync(requestMessage).Result;
                }

                var content = response.Content.ReadAsStringAsync().Result;

                if (response.IsSuccessStatusCode)
                {
                    var apiResponse = JsonConvert.DeserializeObject<T>(content);
                    return apiResponse;
                }
                else
                    throw new Exception(content);
            }
            catch (ArgumentException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                response = null;
                requestUri = null;
            }
        }

        public IEnumerable<T> List(string url)
        {
            HttpResponseMessage response = null;
            Uri requestUri = new Uri($"{EndPoint}/{url}");

            try
            {
                using (var requestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri))
                {
                    LastUriRequested = requestUri.ToString();
                    response = this.httpClient.SendAsync(requestMessage).Result;
                }

                var content = response.Content.ReadAsStringAsync().Result;

                if (response.IsSuccessStatusCode)
                {
                    var apiResponse = JsonConvert.DeserializeObject<List<T>>(content);
                    return apiResponse;
                }
                else
                    throw new Exception(content);
            }
            catch (ArgumentException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                response = null;
                requestUri = null;
            }
        }

        /// <summary>
        /// Gravar
        /// </summary>
        /// <param name="url">Url para consulta.</param>
        /// <param name="body">Objeto de envio.</param>
        /// <returns></returns>
        public T Post(string url, object body)
        {
            HttpResponseMessage response = null;

            try
            {
                var bodyJson = JsonConvert.SerializeObject(body);
                this.LastBodyResquested = bodyJson;

                using (var requestMessage = new HttpRequestMessage(HttpMethod.Post, new Uri($"{this.EndPoint}/{url}")))
                {
                    LastUriRequested = requestMessage.RequestUri.ToString();
                    requestMessage.Content = new StringContent(bodyJson,
                                    Encoding.UTF8,
                                    "application/json");
                    response = this.httpClient.SendAsync(requestMessage).Result;
                }

                var content = response.Content.ReadAsStringAsync().Result;

                if (response.IsSuccessStatusCode)
                {
                    var apiResponse = JsonConvert.DeserializeObject<T>(content);
                    return apiResponse;
                }
                else
                    throw new Exception(content);
            }
            catch (ArgumentException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                response = null;
            }
        }
    }
}
