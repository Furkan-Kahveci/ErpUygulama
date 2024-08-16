using Microsoft.AspNetCore.Mvc;

namespace ErpUygulama.Web.Controllers
{
    public class ErpUygulamaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
