using DesignsPatterns.Repository;
using Strategy.Models.ViewModels;

namespace Strategy.Strategies
{
    public interface IBeerStrategy
    {
        public void Add(BeerFormViewModel beerFormViewModel, IUnitOfWork unitOfWork);
    }
}
