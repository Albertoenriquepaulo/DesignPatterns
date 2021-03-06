using DesignPatterns.Models.Data;

namespace DesignsPatterns.Repository
{
	 public class UnitOfWork : IUnitOfWork
	 {
		  private DesignPatternsContext _context;
		  private IRepository<Beer> _beers;
		  private IRepository<Brand> _brands;
		  public IRepository<Beer> Beers
		  {
				get => _beers ??= new Repository<Beer>(_context);  //This is the same than the line for brands
		  }
		  public IRepository<Brand> Brands
		  {
				get => _brands == null ? new Repository<Brand>(_context) : _brands;
		  }

		  public UnitOfWork(DesignPatternsContext context)
		  {
				_context = context;
		  }

		public void Save() => _context.SaveChanges();
	 }
}

