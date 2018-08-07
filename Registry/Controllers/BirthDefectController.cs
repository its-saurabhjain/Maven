using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Registry.Controllers
{
    public class BirthDefectController : Controller
    {
        // GET: /<controller>/
        public IActionResult GetRegistryList()
        {
            System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();
            var result = client.GetAsync("http://birthdefectregistry/api/Birthdefect").Result;
            string text = result.Content.ReadAsStringAsync().Result;

            return View("BirthDefectRegistry", text);
        }
    }
}
