using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    public class AjaxExampleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public JsonResult GetNames()
        {
            var names = new string[3]
            {
                "Lojain","Evan","Shahed"
            };
            return new JsonResult(names);
        }


        [HttpPost]
        public JsonResult PostName(string name)
        {
           

            return new JsonResult(Ok());

        }



    }
}
