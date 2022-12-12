using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAdver.Web.Controllers
{
    public class Accounts : Controller
    {
        // GET: Accounts
        public IActionResult Index()
        {
            return View();
        }

    }
}
