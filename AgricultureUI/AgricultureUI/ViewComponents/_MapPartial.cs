using DataAccessLayer.Contexts;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AgricultureUI.ViewComponents
{
    public class _MapPartial : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            AgricultureContext context = new AgricultureContext();
            var values = context.Addresses.Select(x => x.MapInfo).FirstOrDefault();
            ViewBag.MapInfo = values;
            return View();
        }

    }
}
