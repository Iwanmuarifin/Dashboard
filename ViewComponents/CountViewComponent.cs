using Microsoft.AspNetCore.Mvc;

namespace Dashboard.ViewComponents
{
    public class CountViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
