using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace cruddemo.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //public string Index()
        //{
        //    return "this is index";
        //}

        public string Cliente()
        {
            return "this is cliente";
        }


    }
}
