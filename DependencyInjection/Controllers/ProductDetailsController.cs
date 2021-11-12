using LibraryTools.Earn;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
	 public class ProductDetailsController : Controller
	 {
		  private readonly LocalEarnFactory _localEarnFactory;
		  private readonly ForeignEarnFactory _foreignEarnFactory;

		  public ProductDetailsController(LocalEarnFactory localEarnFactory, ForeignEarnFactory foreignEarnFactory)
		  {
				_foreignEarnFactory = foreignEarnFactory;
				_localEarnFactory = localEarnFactory;
		  }

		  public IActionResult Index(decimal total)
		  {
				// products
				var localEarn = _localEarnFactory.GetEarn();
				var foreignEarn = _foreignEarnFactory.GetEarn();

				// calculating earns
				ViewBag.totalLocal = total + localEarn.Earn(total);
				ViewBag.totalForeign = total + foreignEarn.Earn(total);

				return View();
		  }
	 }
}
