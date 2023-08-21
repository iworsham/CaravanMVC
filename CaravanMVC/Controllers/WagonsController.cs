using Microsoft.AspNetCore.Mvc;
using CaravanMVC.DataAccess;

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
	}
}
