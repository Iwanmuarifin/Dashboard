using Microsoft.AspNetCore.Mvc;

namespace Dashboard.ViewComponents
{
    public class ViewModelViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
