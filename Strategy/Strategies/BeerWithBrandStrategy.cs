using DesignPatterns.Models.Data;
using DesignsPatterns.Repository;
using Strategy.Models.ViewModels;
using System;

namespace Strategy.Strategies
{
    public class BeerWithBrandStrategy : IBeerStrategy
    {
        public void Add(BeerFormViewModel beerFormViewModel, IUnitOfWork unitOfWork)
        {
            beerFormViewModel.BrandId = Guid.NewGuid();
            var brand = new Brand()
            {
                Name = beerFormViewModel.NewBrandName,
                Id = (Guid)beerFormViewModel.BrandId
            };


            var beer = new Beer()
            {
                Name = beerFormViewModel.Name,
                Style = beerFormViewModel.Style,
                BrandId = (Guid)beerFormViewModel.BrandId
            };

            unitOfWork.Brands.Add(brand);
            unitOfWork.Beers.Add(beer);
            unitOfWork.Save();
        }
    }
}
