using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;

namespace msl_asp_dotnet_core_mvc_mvcmovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index() => View();

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
    }
}
