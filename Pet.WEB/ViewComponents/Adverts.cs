using Microsoft.AspNetCore.Mvc;

namespace Pet.WEB.ViewComponets
{
    public class Adverts:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
