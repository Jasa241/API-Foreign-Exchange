using Foreign_Exchange.Models;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Globalization;

namespace Foreign_Exchange.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Flag = "0";
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Index(Money money)
        {
            HttpClient client = new HttpClient();

            var Json = await client.GetStringAsync("https://api.exchangeratesapi.io/latest?symbols=USD,CAD,GBP,CNY");
            var Content = JsonConvert.DeserializeObject<API>(Json);

            money.CAD = money.Euro * Content.money.CAD;
            money.CNY = money.Euro * Content.money.CNY;
            money.USD = money.Euro * Content.money.USD;
            money.GBP = money.Euro * Content.money.GBP;
            ViewBag.Flag = "1";
            return View(money);
        }
    }
}