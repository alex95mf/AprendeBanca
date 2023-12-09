using Banca_APP.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Net.Http.Headers;

namespace Banca_APP.Controllers
{
    public class ServiciosController : Controller
    {
        private readonly ILogger<ServiciosController> _logger;
        private readonly string contentType = "application/json";

        // DEV
        private static readonly string serverName = "localhost";
        private static readonly string portNumber = "7033";
        private readonly string apiUrl = $"https://{serverName}:{portNumber}/";

        //private readonly string pagineo = "&Pagina=1&RecordsPorPagina=100000";
        //private bool esLista = true;
        private string command;
        private StringContent stringContent;

        public ServiciosController(ILogger<ServiciosController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult>  ObtenerPlanesDeCuenta()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Clear();

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));

                command = $"api/PlanCuentas/ObtenerPlanesDeCuenta";

                HttpResponseMessage res = await client.GetAsync(command);
                if (res.IsSuccessStatusCode)
                {
                    var response = res.Content.ReadAsStringAsync().Result;
                    List<ConCuentaPlanModel> planesCuenta = JsonConvert.DeserializeObject<List<ConCuentaPlanModel>>(response);
                    return Ok(planesCuenta);
                }
                else
                {
                    return BadRequest(res.Content.ReadAsStringAsync().Result);
                }
            }

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}