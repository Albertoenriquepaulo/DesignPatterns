using ConsoleDemos.DependencyInjection;
using ConsoleDemos.FactoryPattern;

namespace ConsoleDemos
{
	 class Program
	 {
		  static void Main(string[] args)
		  {
				// FACTORY
				SaleFactory storeSaleFactory = new StoreSaleFactory(10);
				SaleFactory internetSaleFactory = new InternetSaleFactory(20);

				var storeSaleObj = storeSaleFactory.GetSale();
				var internetSaleObj = internetSaleFactory.GetSale();

				storeSaleObj.Sell(100);
				internetSaleObj.Sell(1000);

				// DEPENDENCY INJECTION
				var beer = new Beer("Polar", "Light");
				var drinkWithBeer = new DrinkWithBeer(10, 20, beer);
				drinkWithBeer.Build();

		  }
	 }
}
