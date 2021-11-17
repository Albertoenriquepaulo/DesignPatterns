using DesignPatterns.Models.Data;
using DesignsPatterns.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Strategy.Models.ViewModels;
using Strategy.Strategies;
using System;
using System.Linq;

namespace Strategy.Controllers
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
            ViewBag.Brands = GetBrandsData();

            return View();

        }

        [HttpPost]
        public IActionResult Add(BeerFormViewModel beerFormViewModel)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Brands = GetBrandsData();
                return View("Add", beerFormViewModel);
            }

            var context = beerFormViewModel.BrandId == null
                            ? new Context(new BeerWithBrandStrategy())
                            : new Context(new BeerStrategy());

            context.Add(beerFormViewModel, _unitOfWork);

            return RedirectToAction("Index");
        }

        #region HELPER
        public SelectList GetBrandsData()
        {
            var brands = _unitOfWork.Brands.Get();
            return new SelectList(brands, "Id", "Name");
        }
        #endregion
    }
}
