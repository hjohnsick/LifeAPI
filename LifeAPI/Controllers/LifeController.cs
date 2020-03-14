using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LifeAPI.Controllers
{

   
    public class LifeController : Controller
    {
      public async Task<IActionResult> Index()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44302/");

            var response = await client.GetAsync("api/life");
            var result = await response.Content.ReadAsStringAsync();

            return View();
        }
    }
}