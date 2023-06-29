using System.Linq.Expressions;

namespace AbuEhab.EFSystem.DataLayer.Repositories
{
	// Abu Ehab Mizyed
	public interface IRepository<TEntity> where TEntity : class
	{
		void Add(TEntity entity);
		void Update(int id);
		void Delete(int id);
		TEntity FindById(int id);
		IEnumerable<TEntity> GetAll();
		IEnumerable<TEntity> GetBy(Expression<Func<TEntity, bool>> predicate);
	}
}
