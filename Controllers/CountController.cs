using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dashboard.Models;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Net;
using Nancy.Json;
using System.Text;
using System.ComponentModel;

namespace Dashboard.Controllers
{
    public class CountController : Controller
    {
        private readonly ILogger<CountController> _logger;

        public CountController(ILogger<CountController> logger)
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost("[controller]/HomeAsync")]
        public async Task<string> HomeAsync([FromBody] CountModel req)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    var baseUrl = "http://localhost/ELO_WS/api/json/reply/CountMRequest";
                    client.Headers.Clear();
                    client.Headers.Add("Content-Type", "application/json");

                    var str = new JavaScriptSerializer().Serialize(req);
                    var datacredential = Encoding.UTF8.GetBytes(str);
                    var response = Encoding.UTF8.GetString(client.UploadData(baseUrl, "POST", datacredential));

                    return response;
                }
            }
            catch (Exception ex)
            {
                return "";
            }
        }
    }
}