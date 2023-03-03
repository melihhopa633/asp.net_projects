using Microsoft.AspNetCore.Mvc;

namespace AgricultureUI.Controllers
{
    public class _DashboardHeaderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
