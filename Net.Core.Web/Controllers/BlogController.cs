using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Net.Core.Web.Controllers
{
    [Route("blog")]
    public class BlogController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [Route("{year:min(2000)}/{month:range(1,12)}/{key}")]
        public IActionResult Post(int year, int month, string key)
        {
            return new ContentResult
            {
                Content = $"Year: {year} - Month: {month} - Key {key}"
            };
        }
    }
}
