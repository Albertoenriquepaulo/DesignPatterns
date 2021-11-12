using DesignPatterns.Models.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DesignsPatterns.Repository
{
	 public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
	 {

		  private DesignPatternsContext _context;
		  private DbSet<TEntity> _dbSet;

		  public Repository(DesignPatternsContext context)
		  {
				_context = context;
				_dbSet = context.Set<TEntity>();
		  }

		  public void Add(TEntity data) => _dbSet.Add(data);

		  public void Delete(int id) => _dbSet.Remove(Get(id));

		  public IEnumerable<TEntity> Get() => _dbSet.ToList();

		  public TEntity Get(int id) => _dbSet.Find(id);

		  public void Update(TEntity data)
		  {
				_dbSet.Attach(data); //This could work without this line, but it is supposed this is to avoid concurrent access
				_context.Entry(data).State = EntityState.Modified;
		  }

		  public void Save() => _context.SaveChanges();
	 }
}
