using DesignPatterns.Models.Data;
using DesignsPatterns.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
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

		[HttpGet]
		public IActionResult Add()
        {
			var brands = _unitOfWork.Brands.Get();
			ViewBag.Brands = new SelectList(brands,"Id", "Name");

			return View();

        }
		
		[HttpPost]
        public IActionResult Add(BeerFormViewModel beerFormViewModel)
        {
            if (!ModelState.IsValid)
            {
                var brands = _unitOfWork.Brands.Get();
                ViewBag.Brands = new SelectList(brands, "BrandId", "Name");

                return View("Add", beerFormViewModel);
            }

            if (new Brand() is var brand && beerFormViewModel.BrandId == null)
            {
				beerFormViewModel.BrandId = Guid.NewGuid();
                brand = new Brand()
                {
                    Name = beerFormViewModel.NewBrandName,
                    Id = (Guid)beerFormViewModel.BrandId
                };

                _unitOfWork.Brands.Add(brand);

            }

            var beer = new Beer()
            {
                Name = beerFormViewModel.Name,
                Style = beerFormViewModel.Style,
                BrandId = (Guid)beerFormViewModel.BrandId
            };

            _unitOfWork.Beers.Add(beer);
            _unitOfWork.Save();

            return RedirectToAction("Index");
        }
	}
}
