using System.Collections.Generic;

namespace ConsoleDemos.RepositoryPattern.Generic
{
	 public interface IRepository<TEntity> //TEntity is to allow works with DbSet, see DbSet code in the file of the context, DbSet use TEntity as well
	 {
		  IEnumerable<TEntity> Get();
		  TEntity Get(int id);
		  void Add(TEntity data);
		  void Delete(int id);
		  void Update(TEntity data);
		  void Save();
	 }
}
