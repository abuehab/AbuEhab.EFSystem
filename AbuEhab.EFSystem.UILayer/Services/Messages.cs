namespace AbuEhab.EFSystem.UILayer.Services
{
	// Abu Ehab Mizyed
	public class Messages
	{
		public static void Save()
		{
			MessageBox.Show("Saved Successfull", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		public static void Error()
		{
			MessageBox.Show("\r\nSomething is wrong ...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		public static void Warning()
		{
			MessageBox.Show("Warning , already existed...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}
	}
}
