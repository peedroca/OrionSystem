using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Sirius.Web.Models;
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json.Serialization;

namespace Sirius.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Cadastrar(Customer customer)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.Timeout = new TimeSpan(0, 0, 10); // Define o tempo máximo de espera para 10 segundos.

            string body = JsonConvert.SerializeObject(customer);

            using (var requestMessage = new HttpRequestMessage(HttpMethod.Post, "http://www.orion.br.asp.hostazul.com.br/api/Customers"))
            {
                // Adiciona corpo do tipo Json. (Caso necessário)
                requestMessage.Content = new StringContent(body, Encoding.UTF8, "application/json");

                // Executa requisição
                var response = httpClient.SendAsync(requestMessage).Result;
            }

            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
