using Microsoft.AspNetCore.Mvc;

namespace Pet.WEB.ViewComponents
{
    public class Image: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
