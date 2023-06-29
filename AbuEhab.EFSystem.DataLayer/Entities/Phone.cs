namespace AbuEhab.EFSystem.DataLayer.Entities
{
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	[Table("Phone")]
	public partial class Phone
	{
		public int Id { get; set; }

		[StringLength(50)]
		public string Name { get; set; }

		[StringLength(12)]
		public string Jawwal { get; set; }

		[StringLength(12)]
		public string Ooredoo { get; set; }
		public DateTime CreationDate { get; set; } = DateTime.Now;
	}
}
