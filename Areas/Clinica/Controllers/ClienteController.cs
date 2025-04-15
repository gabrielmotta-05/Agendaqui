using Microsoft.AspNetCore.Mvc;

namespace Agendaqui.Areas.Clinica.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
