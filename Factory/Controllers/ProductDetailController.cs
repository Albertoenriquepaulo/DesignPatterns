using LibraryTools.Earn;
using Microsoft.AspNetCore.Mvc;

namespace Factory.Controllers
{
	 public class ProductDetailController : Controller
	 {
		  public IActionResult Index(decimal total)
		  {
			  // factories
			  var localEarnFactory = new LocalEarnFactory(0.20m);
			  var foreignEarnFactory = new ForeignEarnFactory(0.30m, 20m);
			  
			  // products
			  var localEarn = localEarnFactory.GetEarn();
			  var foreignEarn = foreignEarnFactory.GetEarn();
			  
			  // calculating earns
			  ViewBag.totalLocal = total + localEarn.Earn(total);
			  ViewBag.totalForeign = total + foreignEarn.Earn(total);
			  
			  return View();
		  }
	 }
}
