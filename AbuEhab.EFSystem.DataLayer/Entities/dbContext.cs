using System.Data.Entity;

namespace AbuEhab.EFSystem.DataLayer.Entities
{
	// Abu Ehab Mizyed
	public class dbContext : DbContext
	{
		public dbContext()
		  : base(ConnectionString())
		{
		}
		public virtual DbSet<Phone> Phones { get; set; }

		private static string ConnectionString()
		{
			// Note : You can change server name and database name ...
			return $"Data Source=localhost;Initial Catalog=dbEF;Integrated Security=True";

		}
	}
}
