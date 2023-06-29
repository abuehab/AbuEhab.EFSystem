using AbuEhab.EFSystem.DataLayer.Entities;
using System.Linq.Expressions;

namespace AbuEhab.EFSystem.DataLayer.Repositories
{
	// Abu Ehab Mizyed
	public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
	{

		public dbContext context = new dbContext();

		public Repository()
		{
			context = new dbContext();
		}

		public void Add(TEntity entity)
		{
			try
			{
				context.Set<TEntity>().Add(entity);
				context.SaveChanges();

			}
			catch (Exception)
			{
				throw;
			}
		}

		public void Delete(int id)
		{
			TEntity entity = FindById(id);
			context.Set<TEntity>().Remove(entity);
			context.SaveChanges();
		}

		public void Update(int id)
		{
			TEntity entity = FindById(id);
			context.SaveChanges();
		}

		public IEnumerable<TEntity> GetAll()
		{
			try
			{
				return context.Set<TEntity>().ToList();
			}
			catch (Exception)
			{
				return null;
			}
		}

		public TEntity FindById(int Id) => context.Set<TEntity>().Find(Id);


		public IEnumerable<TEntity> First(Expression<Func<TEntity, bool>> predicate)
			=> context.Set<TEntity>().Where(predicate);


		public IEnumerable<TEntity> GetBy(Expression<Func<TEntity, bool>> predicate)
		 => context.Set<TEntity>().Where(predicate);

		public TEntity GetFirst(Expression<Func<TEntity, bool>> predicate)
			=> context.Set<TEntity>().FirstOrDefault(predicate);



	}
}
