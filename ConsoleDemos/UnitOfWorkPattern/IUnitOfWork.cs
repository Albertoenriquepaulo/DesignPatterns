using ConsoleDemos.RepositoryPattern.Generic;
using ConsoleDemos.RepositoryPattern.Model;

namespace ConsoleDemos.UnitOfWorkPattern
{
	 public interface IUnitOfWork
	 {
		  public IRepository<Beer> Beers { get; }
		  public IRepository<Brand> Brands { get; }

		  void Save();
	 }
}
