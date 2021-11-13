using DesignsPatterns.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using UnitOfWork.Models.ViewModels;

namespace UnitOfWork.Controllers
{
	 public class BeerController : Controller
	 {
		  private readonly IUnitOfWork _unitOfWork;

		  public BeerController(IUnitOfWork unitOfWork)
		  {
				_unitOfWork = unitOfWork;
		  }

		  public IActionResult Index()
		  {
				var beerList = from d in _unitOfWork.Beers.Get()
									select new BeerViewModel
									{
										 Id = d.Id,
										 Name = d.Name,
										 Style = d.Style
									};

				return View("Index", beerList);
		  }
	 }
}
