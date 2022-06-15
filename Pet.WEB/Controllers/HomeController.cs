using Microsoft.AspNetCore.Mvc;
using Pet.Entities.Context;
using Pet.WEB.Models;
using System.Diagnostics;
using System.Web.Mvc;
using Controller = Microsoft.AspNetCore.Mvc.Controller;
using JsonResult = Microsoft.AspNetCore.Mvc.JsonResult;

namespace Pet.WEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        SqlDbContext sqlDb;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            sqlDb = new SqlDbContext();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public JsonResult IlceGetir(int p)
        {
            var ilceler = (from x in sqlDb.Districts
                           join y in sqlDb.Cities on x.City.Id equals y.Id
                           where x.City.Id == p
                           select new
                           {
                               Text = x.DistrictName,
                               Value = x.Id.ToString()
                           }).ToList();
            return Json(ilceler, JsonRequestBehavior.AllowGet);
        }
    }
}