using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloMVC.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            /*
            string html = "<form method='post' action='/Hello/Display'>" +
                "<input type='text' name='name' />" +
                "<input type='submit' value='Greet me!' />" +
                "</form>";

            return Content(html, "text/html");
            */

            /*
             * string html = "<form method='post' /> " +
                "<input type='text' name='name' />" +
                "<input type='submit' value='Greet me!' />" +
                "</form>";

            return Content(html, "text/html");
            */

            return Redirect("/Hello/Goodbye");
        }

        //  /Hello?name=NAME (query parameter)
        [Route("/Hello")]
        [HttpPost]
        public IActionResult Display(string name = "World")
        {
            return Content(string.Format("<h1>Hello MVC World - {0}</h1>", name), "text/html");
        }

        //  Handle requests to /Hello/NAME (URL segment)  -- /Hello/Mary
        [Route("/Hello/{name}")]
        public IActionResult Index2(string name)
        {
            return Content(string.Format("<h1>Hello MVC World - {0}</h1>", name), "text/html");
        }


        public IActionResult Goodbye()
        {
            return Content("Goodbye MVC World");
        }
    }
}
