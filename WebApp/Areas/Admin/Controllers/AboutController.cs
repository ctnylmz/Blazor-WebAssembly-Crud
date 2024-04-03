using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Text;
using WebApp.Areas.Admin.Models;

namespace WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutController : Controller
    {

        private readonly IHttpClientFactory _httpClientFactory;

        public AboutController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }


        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();

            var responseMessage = await client.GetAsync("https://localhost:44380/api/About/GetList");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<AboutViewModel>>(JObject.Parse(jsonData)["data"].ToString());

                var about = values.FirstOrDefault();

                if (about == null)
                {
                    var aboutModel = new AboutViewModel
                    {
                        title = "empty",
                        imageUrl = "empty",
                        description = "empty"
                    };

                    var aboutData = JsonConvert.SerializeObject(aboutModel);
                    StringContent stringContent = new StringContent(aboutData, Encoding.UTF8, "application/json");
                    var responseAdd = await client.PostAsync("https://localhost:44380/api/About/Add", stringContent);

                    if (responseAdd.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        return View("Error");
                    }
                }

                return View(about);
            }
            else
            {
                return View("Error");
            }
        }


        [HttpPost]
        public async Task<IActionResult> Index(AboutViewModel service)
        {

            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(service);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:44380/api/About/Update", stringContent);

            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}
