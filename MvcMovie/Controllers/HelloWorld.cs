using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorld : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            ViewData["Message"] = "今天天气真不错" ;
        
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome(string name, int numTimes = 1)
        {
            return String.Format ("name is {0} ,numTimes is {1}...",name, numTimes);
        }
    }
}
