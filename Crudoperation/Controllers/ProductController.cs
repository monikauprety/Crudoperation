using Microsoft.AspNetCore.Mvc;

namespace Crudoperation.Controllers
{
	public class ProductController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
