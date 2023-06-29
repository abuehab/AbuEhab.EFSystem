using AbuEhab.EFSystem.UILayer.Forms.Phones;
using AbuEhab.EFSystem.UILayer.Services;

namespace AbuEhab.EFSystem.UILayer
{
	internal static class Program
	{

		[STAThread]
		static void Main()
		{
			ApplicationConfiguration.Initialize();
			//==========================================
			StartUp startUp = new StartUp();
			startUp.Seed();
			//==========================================
			Application.Run(new frmPhones());
		}
	}
}