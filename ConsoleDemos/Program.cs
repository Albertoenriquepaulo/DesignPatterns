using ConsoleDemos.DependencyInjection;
using ConsoleDemos.FactoryPattern;
using ConsoleDemos.RepositoryPattern;
using ConsoleDemos.RepositoryPattern.Generic;
using ConsoleDemos.Strategy;
using ConsoleDemos.UnitOfWorkPattern;
using System;
using System.Linq;
using Repository = ConsoleDemos.RepositoryPattern.Model;

namespace ConsoleDemos
{
	 class Program
	 {
		  static void Main(string[] args)
		  {
			//// FACTORY
			//Console.WriteLine("FACTORY");
			//SaleFactory storeSaleFactory = new StoreSaleFactory(10);
			//SaleFactory internetSaleFactory = new InternetSaleFactory(20);

			//var storeSaleObj = storeSaleFactory.GetSale();
			//var internetSaleObj = internetSaleFactory.GetSale();

			//storeSaleObj.Sell(100);
			//internetSaleObj.Sell(1000);


			//// DEPENDENCY INJECTION
			//Console.WriteLine("\nDEPENDENCY INJECTION");
			//var beer = new DependencyInjection.Beer("Polar", "Light");
			//var drinkWithBeer = new DrinkWithBeer(10, 20, beer);
			//drinkWithBeer.Build();


			//// REPOSITORY
			//Console.WriteLine("\nREPOSITORY");
			//using (var context = new Repository.DesignPatternsContext())
			//{
			//	 context.Beers.ToList().ForEach(b =>
			//		  Console.WriteLine($"Name: {b.Name}\nStyle: {b.Style}\n")
			//	 );
			//}

			////Repository is an alias to the using, there is a problem with the beer models
			//using (var context = new Repository.DesignPatternsContext())
			//{
			//	 var beerRepo = new BeerRepository(context);

			//	 beerRepo.Add(new Repository.Beer() { Name = "Zulia", Style = "Green" });
			//	 beerRepo.Save();
			//	 context.Beers.ToList().ForEach(b =>
			//		 Console.WriteLine($"Name: {b.Name}\nStyle: {b.Style}\n")
			//	 );

			//	 var brandRepo = new Repository<Repository.Brand>(context);

			//	 brandRepo.Add(new Repository.Brand() { Name = "Regional" });
			//	 brandRepo.Save();
			//	 context.Brands.ToList().ForEach(b =>
			//		 Console.WriteLine($"Brand Name: {b.Name}\n")
			//	 );
			//}

			//using (var context = new Repository.DesignPatternsContext())
			//{
			//	 var beerRepo = new Repository<Repository.Beer>(context);

			//	 beerRepo.Update(new Repository.Beer() { Id = 3, Name = "Zulia", Style = "Verde" });
			//	 beerRepo.Save();
			//	 context.Beers.ToList().ForEach(b =>
			//		 Console.WriteLine($"Name: {b.Name}\nStyle: {b.Style}\n")
			//	 );
			//}

			////UNIT OF WORK
			//// Implementing the same above (line 45 to 52) but using UnitOfWork
			//// Plese this link is very interesting for unitOfWork https://docs.microsoft.com/en-us/aspnet/mvc/overview/older-versions/getting-started-with-ef-5-using-mvc-4/implementing-the-repository-and-unit-of-work-patterns-in-an-asp-net-mvc-application
			//using (var context = new Repository.DesignPatternsContext())
			//{
			//	 var unitOfWork = new UnitOfWork(context);
			//	 var beerRepo = unitOfWork.Beers;

			//	 beerRepo.Add(new Repository.Beer() { Name = "Heineken", Style = "IPA" });
			//	 beerRepo.Save();
			//	 context.Beers.ToList().ForEach(b =>
			//		 Console.WriteLine($"Name: {b.Name}\nStyle: {b.Style}\n")
			//	 );

			//	 var brandRepo = unitOfWork.Brands;

			//	 brandRepo.Add(new Repository.Brand() { Name = "Volt Damn" });
			//	 brandRepo.Save();
			//	 context.Brands.ToList().ForEach(b =>
			//		 Console.WriteLine($"Brand Name: {b.Name}\n")
			//	 );

			//	 var beerList = beerRepo.Get();
			//	 var brandList = brandRepo.Get();

			//	 unitOfWork.Save();
			//}

			// STRATEGY
			var strategyContext = new Context(new CarStrategy());
			strategyContext.Run();

			// we can change the strategy setting the Strategy of the strategyContext object or creating a new context
			strategyContext.SetStrategy(new MotorcycleStrategy());
			strategyContext.Run();

			strategyContext = new Context(new BicycleStrategy());
			strategyContext.Run();
		}
	 }
}
