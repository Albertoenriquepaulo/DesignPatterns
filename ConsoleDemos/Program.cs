using ConsoleDemos.FactoryPattern;

namespace ConsoleDemos
{
	 class Program
	 {
		  static void Main(string[] args)
		  {
				SaleFactory storeSaleFactory = new StoreSaleFactory(10);
				SaleFactory internetSaleFactory = new InternetSaleFactory(20);

				var storeSaleObj = storeSaleFactory.GetSale();
				var internetSaleObj = internetSaleFactory.GetSale();

				storeSaleObj.Sell(100);
				internetSaleObj.Sell(1000);
		  }
	 }
}
