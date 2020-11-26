using Newtonsoft.Json;
using Sirius.Domain.Models;
using Sirius.Mobile.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace Sirius.Mobile.Services
{
    public static class ContractSignedService
    {
        public static IEnumerable<ContractSignedView> GetContractSigneds()
        {
            HttpClient httpClient = new HttpClient();
            HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, "http://www.orion.br.asp.hostazul.com.br/api/ContractSigned");

            httpRequestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", App.CurrentUser.AccessToken);

            var resp = httpClient.SendAsync(httpRequestMessage).Result;

            if (resp.IsSuccessStatusCode)
            {
                var content = resp.Content.ReadAsStringAsync().Result;
                var apiResponse = JsonConvert.DeserializeObject<List<ContractSignedView>>(content);

                return apiResponse;
            }
            else
                return null;
        }

        public static SmartContractSignedModel SignContract(long idCompany, long idCustomer, long idContract)
        {
            var body = JsonConvert.SerializeObject(new
            {
                smartContractId = idContract,
                companyId = idCompany,
                customerId = idCustomer
            });

            HttpClient httpClient = new HttpClient();
            HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, "http://www.orion.br.asp.hostazul.com.br/api/ContractSigned");
            httpRequestMessage.Content = new StringContent(body,
                                    Encoding.UTF8,
                                    "application/json");

            httpRequestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", App.CurrentUser.AccessToken);

            var resp = httpClient.SendAsync(httpRequestMessage).Result;

            if (resp.IsSuccessStatusCode)
            {
                var content = resp.Content.ReadAsStringAsync().Result;
                var apiResponse = JsonConvert.DeserializeObject<SmartContractSignedModel>(content);

                return apiResponse;
            }
            else
                return null;
        }

        public static SmartContractSignedModel CancelSignContract(long idContractSigned)
        {
            HttpClient httpClient = new HttpClient();
            HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Delete, $"http://www.orion.br.asp.hostazul.com.br/api/ContractSigned/{idContractSigned}");

            httpRequestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", App.CurrentUser.AccessToken);

            var resp = httpClient.SendAsync(httpRequestMessage).Result;

            if (resp.IsSuccessStatusCode)
            {
                var content = resp.Content.ReadAsStringAsync().Result;
                var apiResponse = JsonConvert.DeserializeObject<SmartContractSignedModel>(content);

                return apiResponse;
            }
            else
                return null;
        }
    }
}
