using Microsoft.AspNetCore.Mvc;
using Pet.BL.Abstract;


namespace Pet.WEB.Controllers
{
    public class CityController: Controller
    {
        private readonly ICityManager cityManager;

        public CityController(ICityManager cityManager)
        {
            this.cityManager = cityManager;
        }

       public IActionResult GetCities()
        {
            
            
            return Ok(cityManager.GetAll());
        }
    }
}
