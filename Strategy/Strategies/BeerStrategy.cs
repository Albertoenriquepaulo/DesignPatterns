using DesignPatterns.Models.Data;
using DesignsPatterns.Repository;
using Strategy.Models.ViewModels;
using System;

namespace Strategy.Strategies
{
    public class BeerStrategy : IBeerStrategy
    {
        public void Add(BeerFormViewModel beerFormViewModel, IUnitOfWork unitOfWork)
        {
            unitOfWork.Beers.Add(new Beer()
            {
                Name = beerFormViewModel.Name,
                Style = beerFormViewModel.Style,
                BrandId = (Guid)beerFormViewModel.BrandId,
            });
            unitOfWork.Save();
        }
    }
}
