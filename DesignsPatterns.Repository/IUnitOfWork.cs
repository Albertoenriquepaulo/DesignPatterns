using DesignPatterns.Models.Data;

namespace DesignsPatterns.Repository
{
	 public interface IUnitOfWork
	 {
		  public IRepository<Beer> Beers { get; }
		  public IRepository<Brand> Brands { get; }

		  void Save();
	 }
}
