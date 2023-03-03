using Microsoft.AspNetCore.Mvc;

namespace AgricultureUI.ViewComponents
{
    public class _DashboardChartPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = 88;
            ViewBag.v2 = 93;
            return View();
        }
    }
}
