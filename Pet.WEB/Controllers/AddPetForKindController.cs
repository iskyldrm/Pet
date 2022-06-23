using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pet.BL.Abstract;

namespace Pet.WEB.Controllers
{
    [Route("api/[controller]/[action]/{id?}")]
    [ApiController]
    public class AddPetForKindController : ControllerBase
    {
        private readonly IGenusManager manager;

        public AddPetForKindController(IGenusManager manager)
        {
            this.manager = manager;
        }


        [HttpGet]
        public IActionResult GetPetWithName(string input)
        {
            if (input == "Kedi")
            {
                var result = manager.GetAll(p => p.GenusType == true).Select(p => new { p.Id,p.GenusName });
                return Ok(result.ToList());
            }
            else
            {
                var result = manager.GetAll(p => p.GenusType == false);
                return Ok(result.ToList());
            }
                
           
        }
    }
}
