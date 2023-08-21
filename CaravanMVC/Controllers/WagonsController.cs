using Microsoft.AspNetCore.Mvc;
using CaravanMVC.DataAccess;
using CaravanMVC.Models;


namespace CaravanMVC.Controllers
{
	public class WagonsController : Controller
	{
		private readonly CaravanMvcContext _context;

		public WagonsController(CaravanMvcContext context)
		{
			_context = context;
		}
		public IActionResult Index()
		{
			var wagons = _context.Wagons.ToList();
			return View(wagons);
		}
        [Route("users/{id:int}")]
        public IActionResult Show(int id)
        {
            var wagon = _context.Wagons.Find(id);
               
            return View(wagon);
        }
    }
}
