using Microsoft.AspNetCore.Mvc;

namespace msl_asp_dotnet_core_mvc_mvcmovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "Hello World";
        }

        public string Welcome() 
        {
            return "This is welcome action method";
        }

    }
}
