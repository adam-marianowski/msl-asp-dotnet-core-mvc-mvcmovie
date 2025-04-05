using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;

namespace msl_asp_dotnet_core_mvc_mvcmovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "Hello World";
        }

        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }

    }
}
