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
			  
			  // products
			  var localEarn = localEarnFactory.GetEarn();
			  
			  // calculating earns
			  ViewBag.totalLocal = total + localEarn.Earn(total);
			  
			  return View();
		  }
	 }
}
