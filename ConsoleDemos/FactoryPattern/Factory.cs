using System;

namespace ConsoleDemos.FactoryPattern
{
	 //Creator
	 public abstract class SaleFactory
	 {
		  public abstract ISale GetSale();
	 }

	 //Concrete Creator for Store Sale
	 public class StoreSaleFactory : SaleFactory
	 {
		  private readonly decimal _bonus;

		  public StoreSaleFactory(decimal bonus)
		  {
				_bonus = bonus;
		  }
		  public override ISale GetSale()
		  {
				return new StoreSale(_bonus);
		  }

		  //Concrete Product
		  private class StoreSale : ISale
		  {
				private readonly decimal _bonus;

				public StoreSale(decimal bonus)
				{
					 _bonus = bonus;
				}
				public void Sell(decimal total)
				{
					 Console.WriteLine($"Store sale: {total + _bonus}");
				}
		  }
	 }

	 //Product Interface - Contract
	 public interface ISale
	 {
		  public void Sell(decimal total);
	 }

	 //Concrete Creator for Internet Sale
	 public class InternetSaleFactory : SaleFactory
	 {
		  private readonly decimal _discount;

		  public InternetSaleFactory(decimal discount)
		  {
				_discount = discount;
		  }
		  public override ISale GetSale()
		  {
				return new InternetSale(_discount);
		  }

		  // Concrete Internet Product
		  private class InternetSale : ISale
		  {
				private readonly decimal _discount;

				public InternetSale(decimal discount)
				{
					 _discount = discount;
				}
				public void Sell(decimal total)
				{
					 Console.WriteLine($"Internet sale: {total - _discount}");
				}
		  }
	 }
}
