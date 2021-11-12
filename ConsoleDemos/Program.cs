using ConsoleDemos.DependencyInjection;
using ConsoleDemos.FactoryPattern;
using ConsoleDemos.RepositoryPattern;
using ConsoleDemos.RepositoryPattern.Generic;
using System;
using System.Linq;
using Repository = ConsoleDemos.RepositoryPattern.Model;

namespace ConsoleDemos
{
	 class Program
	 {
		  static void Main(string[] args)
		  {
				// FACTORY
				Console.WriteLine("FACTORY");
				SaleFactory storeSaleFactory = new StoreSaleFactory(10);
				SaleFactory internetSaleFactory = new InternetSaleFactory(20);

				var storeSaleObj = storeSaleFactory.GetSale();
				var internetSaleObj = internetSaleFactory.GetSale();

				storeSaleObj.Sell(100);
				internetSaleObj.Sell(1000);


				// DEPENDENCY INJECTION
				Console.WriteLine("\nDEPENDENCY INJECTION");
				var beer = new DependencyInjection.Beer("Polar", "Light");
				var drinkWithBeer = new DrinkWithBeer(10, 20, beer);
				drinkWithBeer.Build();


				// REPOSITORY
				Console.WriteLine("\nREPOSITORY");
				using (var context = new Repository.DesignPatternsContext())
				{
					 context.Beers.ToList().ForEach(b =>
						  Console.WriteLine($"Name: {b.Name}\nStyle: {b.Style}\n")
					 );
				}

				//Repository is an alias to the using, there is a problem with the beer models
				using (var context = new Repository.DesignPatternsContext())
				{
					 var beerRepo = new BeerRepository(context);

					 beerRepo.Add(new Repository.Beer() { Name = "Zulia", Style = "Green" });
					 beerRepo.Save();
					 context.Beers.ToList().ForEach(b =>
						 Console.WriteLine($"Name: {b.Name}\nStyle: {b.Style}\n")
					 );
				}

				using (var context = new Repository.DesignPatternsContext())
				{
					 var beerRepo = new Repository<Repository.Beer>(context);

					 beerRepo.Update(new Repository.Beer() { Id = 3, Name = "Zulia", Style = "Verde" });
					 beerRepo.Save();
					 context.Beers.ToList().ForEach(b =>
						 Console.WriteLine($"Name: {b.Name}\nStyle: {b.Style}\n")
					 );
				}
		  }
	 }
}
