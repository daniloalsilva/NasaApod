using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace RazorProject.Pages
{
    public partial class IndexModel : PageModel
    {
        private readonly NasaConfiguration _nasa;
        private readonly ILogger<IndexModel> _logger;
        public IndexModel(ILogger<IndexModel> logger, IConfiguration config)
        {
            _nasa = config.GetSection("NasaConfiguration").Get<NasaConfiguration>();
            _logger = logger;
        }

        public void OnGet()
        {
            string endPoint = _nasa.Endpoint;
            string apiKey = _nasa.ApiKey;

            var uri = new Uri(
                QueryHelpers.AddQueryString(endPoint,
                    new Dictionary<string, string>(){
                        {"api_key", apiKey},
                        {"date", DateTime.Now.AddDays(-new Random().Next(365)).ToString("yyyy-MM-dd")}
                    }
                )
            );

            using (var client = new HttpClient())
            {
                var response = client.GetAsync(uri).Result;
                response.EnsureSuccessStatusCode();
                TempData["NasaData"] = JsonConvert.DeserializeObject(
                    response.Content.ReadAsStringAsync().Result
                );
            }
        }
    }
}
