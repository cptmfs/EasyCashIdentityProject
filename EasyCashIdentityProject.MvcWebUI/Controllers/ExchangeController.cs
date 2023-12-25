using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace EasyCashIdentityProject.MvcWebUI.Controllers
{
    public class ExchangeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-exchange.p.rapidapi.com/exchange?from=USD&to=TRY&q=1.0"),
                Headers =
                        {
                            { "X-RapidAPI-Key", "ca4edd0e38msh491633a601ce494p17d7d1jsn72cf9c36514e" },
                            { "X-RapidAPI-Host", "currency-exchange.p.rapidapi.com" },
                        },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var bodyTRY = Double.Parse(body,CultureInfo.InvariantCulture);
                bodyTRY=Math.Round(bodyTRY,4);
                ViewBag.USDtoTRY = bodyTRY.ToString(new CultureInfo("tr-TR"));
            }


            var requestEURtoTRY = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-exchange.p.rapidapi.com/exchange?from=EUR&to=TRY&q=1.0"),
                Headers =
    {
        { "X-RapidAPI-Key", "ca4edd0e38msh491633a601ce494p17d7d1jsn72cf9c36514e" },
        { "X-RapidAPI-Host", "currency-exchange.p.rapidapi.com" },
    },
            };
            using (var responseEURtoTRY = await client.SendAsync(requestEURtoTRY))
            {
                responseEURtoTRY.EnsureSuccessStatusCode();
                var bodyEURtoTRY = await responseEURtoTRY.Content.ReadAsStringAsync();

                double number = Double.Parse(bodyEURtoTRY, CultureInfo.InvariantCulture);
                number = Math.Round(number, 4);
                ViewBag.EURtoTRY = number.ToString(new CultureInfo("tr-TR"));
                //ViewBag.EURtoTRY = bodyEURtoTRY;
            }

            var requestEURtoUSD = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-exchange.p.rapidapi.com/exchange?from=EUR&to=USD&q=1.0"),
                Headers =
    {
        { "X-RapidAPI-Key", "ca4edd0e38msh491633a601ce494p17d7d1jsn72cf9c36514e" },
        { "X-RapidAPI-Host", "currency-exchange.p.rapidapi.com" },
    },
            };
            using (var responseEURtoUSD = await client.SendAsync(requestEURtoUSD))
            {
                responseEURtoUSD.EnsureSuccessStatusCode();
                var bodyEURtoUSD = await responseEURtoUSD.Content.ReadAsStringAsync();
                double bodyEURtoUSDDouble = Double.Parse(bodyEURtoUSD, CultureInfo.InvariantCulture); // Kültür bağımsız olarak dönüştürme
                bodyEURtoUSDDouble = Math.Round(bodyEURtoUSDDouble, 4);
                ViewBag.EURtoUSD = bodyEURtoUSDDouble.ToString(new CultureInfo("tr-TR"));
            }

            return View();
        }
    }
}
