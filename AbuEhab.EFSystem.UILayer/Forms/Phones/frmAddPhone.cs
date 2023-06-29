using AbuEhab.EFSystem.DataLayer.Entities;
using AbuEhab.EFSystem.DataLayer.Repositories;
using AbuEhab.EFSystem.UILayer.Interfaces;
using AbuEhab.EFSystem.UILayer.Services;

namespace AbuEhab.EFSystem.UILayer.Forms.Phones
{
	public partial class frmAddPhone : Form
	{
		public frmAddPhone()
		{
			InitializeComponent();
		}
		private IRepository<Phone> repository = new Repository<Phone>();
		private IHelper helper = new Helper();
		private void frmAddPhone_Load(object sender, EventArgs e)
		{

		}

		private void btnOkay_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtName.Text))
			{
				txtName.Focus();
				return;
			}
			var q = this.repository.GetBy(c => c.Name == txtName.Text).FirstOrDefault();
			if (q != null) { Clear(); Messages.Warning(); return; }
			else
			{

				Phone phone = new Phone()
				{
					Name = txtName.Text,
					Jawwal = txtJawwal.Text,
					Ooredoo = txtOoredoo.Text
				};

				this.repository.Add(phone);
				Messages.Save();
				Clear();
			}

		}

		void Clear()
		{
			txtName.Clear();
			txtJawwal.Clear();
			txtOoredoo.Clear();
			txtName.Focus();
		}

		#region  "  Events  "
		private void txtJawwal_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtJawwal.Text)) { txtJawwal.Text = "0"; txtJawwal.SelectAll(); }
		}

		private void txtOoredoo_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtOoredoo.Text)) { txtOoredoo.Text = "0"; txtOoredoo.SelectAll(); }
		}

		private void txtOoredoo_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.helper.TextKeyPress(this.txtJawwal, sender, e);
		}

		private void txtJawwal_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.helper.TextKeyPress(this.txtOoredoo, sender, e);
		}

		#endregion
	}
}
