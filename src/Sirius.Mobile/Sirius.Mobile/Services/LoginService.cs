using Newtonsoft.Json;
using Sirius.Mobile.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Sirius.Mobile.Services
{
    public static class LoginService
    { 
        public static UserLogged Logar(string username, string password)
        {
            var body = JsonConvert.SerializeObject(new 
            {
                Username = username,
                Password = password
            });

            HttpClient httpClient = new HttpClient();
            HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, "http://www.orion.br.asp.hostazul.com.br/api/login");
            httpRequestMessage.Content = new StringContent(body,
                                    Encoding.UTF8,
                                    "application/json");

            var resp = httpClient.SendAsync(httpRequestMessage).Result;

            if (resp.IsSuccessStatusCode)
            {
                var content = resp.Content.ReadAsStringAsync().Result;
                var apiResponse = JsonConvert.DeserializeObject<UserLogged>(content);

                return apiResponse;
            }
            else
                return null;
        }
    }
}
