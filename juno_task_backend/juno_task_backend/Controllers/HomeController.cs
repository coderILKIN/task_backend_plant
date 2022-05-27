using Microsoft.AspNetCore.Mvc;

namespace juno_task_backend.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
