using System;

namespace ConsoleDemos.DependencyInjection
{
	 public class DrinkWithBeer
	 {
		  private readonly Beer _beer;
		  private readonly decimal _water;
		  private readonly decimal _sugar;

		  public DrinkWithBeer(decimal water, decimal sugar, Beer beer)
		  {
				_water = water;
				_sugar = sugar;
				_beer = beer;
		  }

		  public void Build()
		  {
				Console.WriteLine($"{_beer.Name} have {_water} water + {_sugar} sugar");
		  }


	 }
}
