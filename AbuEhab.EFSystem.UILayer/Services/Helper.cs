using AbuEhab.EFSystem.UILayer.Interfaces;

namespace AbuEhab.EFSystem.UILayer.Services
{
	// Abu Ehab Mizyed
	public class Helper : IHelper
	{



		/// <summary>
		///  Use It at TextBox_KeyPress Event
		///  Process : TextBox Accept numaric values only
		/// </summary>
		/// <param name="TargetTextBox">TextBox Name </param>
		/// <param name="e">Insert e Only</param>
		public void TextKeyPress(TextBox TargetTextBox, object sender, KeyPressEventArgs e)
		{


			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
			 (e.KeyChar != '.'))
			{
				e.Handled = true;
			}

			// only allow one decimal point
			if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
			{
				e.Handled = true;
			}

		}
	}
}
