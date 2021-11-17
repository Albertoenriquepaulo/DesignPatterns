using DesignsPatterns.Repository;
using Strategy.Models.ViewModels;

namespace Strategy.Strategies
{
    public class Context
    {
        private IBeerStrategy beerStrategy;

        public IBeerStrategy BeerStrategy { 
            set => beerStrategy = value; 
        }

        public Context(IBeerStrategy beerStrategy)
        {
            this.beerStrategy = beerStrategy;
        }

        public void Add(BeerFormViewModel beerFormViewModel, IUnitOfWork unitOfWork)
        {
            beerStrategy.Add(beerFormViewModel, unitOfWork);
        }
    }
}
