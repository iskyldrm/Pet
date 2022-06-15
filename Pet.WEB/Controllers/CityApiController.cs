using Microsoft.AspNetCore.Mvc;
using Pet.BL.Abstract;

namespace Pet.WEB.Controllers
{

    [ApiController]
    [Route("api/[controller]/[action]/{id?}")]
    public class CityApiController:ControllerBase
    {
        private readonly ICityManager cityManager;
        private readonly IDistrictManager districtManager;

        public CityApiController(ICityManager cityManager,IDistrictManager districtManager)
        {
            this.cityManager = cityManager;
            this.districtManager = districtManager;
        }


        [HttpGet]
        public IActionResult GetCities()
        {
            return Ok(cityManager.GetAll());
        }

        public IActionResult GetDistrict(int CityId)
        {
            var result = districtManager.GetAll(p => p.CityId == CityId);

            return Ok(result);
        }
    }
}
