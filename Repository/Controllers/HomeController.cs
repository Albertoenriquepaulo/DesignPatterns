using DesignPatterns.Models.Data;
using DesignsPatterns.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Repository.Models;
using System.Diagnostics;

namespace Repository.Controllers
{
	 public class HomeController : Controller
	 {
		  private readonly ILogger<HomeController> _logger;
		  private readonly IRepository<Beer> _beerRepo;

		  public HomeController(ILogger<HomeController> logger, IRepository<Beer> beerRepo)
		  {
				_logger = logger;
				_beerRepo = beerRepo;
		  }

		  public IActionResult Index()
		  {
				var beerList = _beerRepo.Get();
				return View("Index", beerList);
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
	 }
}
