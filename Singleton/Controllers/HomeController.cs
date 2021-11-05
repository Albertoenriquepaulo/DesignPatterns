using LibraryTools;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Singleton.Config;
using Singleton.Models;
using System;
using System.Diagnostics;

namespace Singleton.Controllers
{
	 public class HomeController : Controller
	 {
		  private readonly IOptions<MyConfig> _config;
		  public HomeController(IOptions<MyConfig> config)
		  {
				_config = config;
		  }

		  public IActionResult Index()
		  {
				Log.GetInstance(_config.Value.PathLog).Save($"Index was queried on {DateTime.Now}");
				return View();
		  }

		  public IActionResult Privacy()
		  {
				Log.GetInstance(_config.Value.PathLog).Save($"Privacy was queried on {DateTime.Now}");
				return View();
		  }

		  [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		  public IActionResult Error() => View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
	 }
}
