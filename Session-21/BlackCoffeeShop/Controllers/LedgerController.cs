using Microsoft.AspNetCore.Mvc;

namespace BlackCoffeeShop.Web.Controllers {
    public class LedgerController : Controller {
        public IActionResult Index() {
            return View();
        }
    }
}
