using Microsoft.AspNetCore.Mvc;

namespace NorthwindApp.Areas.ManagementPanel.Controllers {
    public class DashboardController : Controller {
        public IActionResult Index() {
            return View();
        }
    }
}
