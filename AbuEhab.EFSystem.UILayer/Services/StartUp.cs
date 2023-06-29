using AbuEhab.EFSystem.DataLayer.Entities;
using AbuEhab.EFSystem.DataLayer.Repositories;

namespace AbuEhab.EFSystem.UILayer.Services
{
	internal class StartUp
	{
		public IRepository<Phone> repository = new Repository<Phone>();
		public void Seed()
		{

			var q = this.repository.GetAll().Count();
			if (q == 0)
			{
				Phone phone = new Phone()
				{
					Name = "Abu Ehab",
					Jawwal = "0590000000",
					Ooredoo = "056000000"

				};

				this.repository.Add(phone);
		
			}
		}


	}
}
