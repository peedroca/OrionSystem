using Newtonsoft.Json;
using Sirius.Mobile.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace Sirius.Mobile.Services
{
    public static class ContractService
    {
        public static List<Contract> GetContracts()
        {
            HttpClient httpClient = new HttpClient();
            HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, "http://www.orion.br.asp.hostazul.com.br/api/SmartContracts");

            httpRequestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", App.CurrentUser.AccessToken);

            var resp = httpClient.SendAsync(httpRequestMessage).Result;

            if (resp.IsSuccessStatusCode)
            {
                var content = resp.Content.ReadAsStringAsync().Result;
                var apiResponse = JsonConvert.DeserializeObject<List<Contract>>(content);

                return apiResponse;
            }
            else
                return null;
        }
    }
}
